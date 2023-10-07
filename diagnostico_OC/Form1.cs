using System.ComponentModel;

namespace diagnostico_OC
{
    public partial class s : Form
    {
        private BindingList<OrdenCompra> ordenesCompras;
        int id = 1;
        public s()
        {
            InitializeComponent();
            ordenesCompras = new BindingList<OrdenCompra>();
            dgv_OCs.DataSource = ordenesCompras;
            tb_id.Text = id.ToString();

        }

        private void Btn_generar_Click(object sender, EventArgs e)
        {
            List<string> errores = new();
            if (tb_descripcion.Text == "") errores.Add("- Descripcion");
            if (tb_informador.Text == "") errores.Add("- Informador");
            if ((rb_completado.Checked) && (tb_responsable.Text == "")) errores.Add("- Responsable");
            if (errores.Count > 0)
            {
                string mensajeErrores = "Los siguientes campos son obligatorios:\n" + string.Join("\n", errores);
                MessageBox.Show(mensajeErrores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            OrdenCompra oc = new(
                id,
                tb_informador.Text,
                tb_descripcion.Text,
                dtp_fechaCrea.Value,
                rb_completado.Checked ? "Completado" : "Pendiente",
                rb_baja.Checked ? 1 : rb_media.Checked ? 2 : 3
                );

            if (rb_completado.Checked && tb_responsable.Text != "")
            {
                oc.Responsable = tb_responsable.Text;
                oc.FechaResolucion = dtp_fechaRes.Value;
            }

            ordenesCompras.Add(oc);

            id++;
            tb_id.Text = id.ToString();

            FormatearForm();
            MessageBox.Show("Orden de Compra Creada Exitosamente");


        }

        private void Rb_completado_CheckedChanged(object sender, EventArgs e)
        {
            if (rb_completado.Checked)
            {
                dtp_fechaRes.Enabled = true;
                tb_responsable.Enabled = true;
            }
            else
            {
                dtp_fechaRes.Enabled = false;
                tb_responsable.Enabled = false;
            }
        }

        private void FormatearForm()
        {
            tb_informador.Text = string.Empty;
            tb_descripcion.Text = string.Empty;
            rb_pendiente.Checked = true;
            rb_media.Checked = true;
            dtp_fechaCrea.Value = DateTime.Today;
            dtp_fechaRes.Value = DateTime.Today;
            dtp_fechaRes.Enabled = false;
            tb_responsable.Text = string.Empty;
            tb_responsable.Enabled = false;
        }
    }
}