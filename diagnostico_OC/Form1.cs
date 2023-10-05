namespace diagnostico_OC
{
    public partial class s : Form
    {
        List<OrdenCompra> ordenesCompras= new List<OrdenCompra>();
        public s()
        {
            InitializeComponent();
            if (ordenesCompras.Count == 0)
            {
                tb_id.Text = "1";
            }
        }

        private void btn_generar_Click(object sender, EventArgs e)
        {
            List<string> errores = new List<string>();
            if (tb_descripcion.Text == "") errores.Add("- Descripcion");
            if(tb_informador.Text == "")  errores.Add("- Informador");
            if ((rb_completado.Checked) && (tb_responsable.Text == "")) errores.Add("- Responsable");
            if (errores.Count > 0)
            {
                string mensajeErrores = "Los siguientes campos son obligatorios:\n" + string.Join("\n", errores);
                MessageBox.Show(mensajeErrores, "Errores", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            OrdenCompra oc = new OrdenCompra
            {
                Id = int.Parse(tb_id.Text),
                Descripcion = tb_descripcion.Text,
                FechaCreacion = dtp_fechaCrea.Value,
                Estado = rb_pendiente.Checked ? false : true,
                Prioridad = rb_baja.Checked ? 0 : rb_media.Checked ? 1 : 2
            };

            MessageBox.Show("Listo");

           
        }

        private void rb_completado_CheckedChanged(object sender, EventArgs e)
        {
            if(rb_completado.Checked)
            {
                dtp_fechaRes.Enabled= true;
                tb_responsable.Enabled= true;
            } else
            {
                dtp_fechaRes.Enabled = false;
                tb_responsable.Enabled = false;
            }
        }
    }
}