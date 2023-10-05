namespace diagnostico_OC
{
    partial class s
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btn_generar = new System.Windows.Forms.Button();
            this.lbl_id = new System.Windows.Forms.Label();
            this.gb_estado = new System.Windows.Forms.GroupBox();
            this.rb_pendiente = new System.Windows.Forms.RadioButton();
            this.rb_completado = new System.Windows.Forms.RadioButton();
            this.tb_id = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.dtp_fechaCrea = new System.Windows.Forms.DateTimePicker();
            this.lbl_fechaC = new System.Windows.Forms.Label();
            this.lbl_fechaRes = new System.Windows.Forms.Label();
            this.dtp_fechaRes = new System.Windows.Forms.DateTimePicker();
            this.gb_prioridad = new System.Windows.Forms.GroupBox();
            this.rb_baja = new System.Windows.Forms.RadioButton();
            this.rb_media = new System.Windows.Forms.RadioButton();
            this.rb_alta = new System.Windows.Forms.RadioButton();
            this.tb_informador = new System.Windows.Forms.TextBox();
            this.lbl_informador = new System.Windows.Forms.Label();
            this.tb_responsable = new System.Windows.Forms.TextBox();
            this.lbl_responsable = new System.Windows.Forms.Label();
            this.tb_descripcion = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.gb_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.gb_prioridad.SuspendLayout();
            this.SuspendLayout();
            // 
            // btn_generar
            // 
            this.btn_generar.Location = new System.Drawing.Point(592, 194);
            this.btn_generar.Name = "btn_generar";
            this.btn_generar.Size = new System.Drawing.Size(75, 23);
            this.btn_generar.TabIndex = 0;
            this.btn_generar.Text = "Generar OC";
            this.btn_generar.UseVisualStyleBackColor = true;
            this.btn_generar.Click += new System.EventHandler(this.btn_generar_Click);
            // 
            // lbl_id
            // 
            this.lbl_id.AutoSize = true;
            this.lbl_id.Location = new System.Drawing.Point(43, 23);
            this.lbl_id.Name = "lbl_id";
            this.lbl_id.Size = new System.Drawing.Size(20, 15);
            this.lbl_id.TabIndex = 1;
            this.lbl_id.Text = "Id:";
            // 
            // gb_estado
            // 
            this.gb_estado.Controls.Add(this.rb_pendiente);
            this.gb_estado.Controls.Add(this.rb_completado);
            this.gb_estado.Location = new System.Drawing.Point(43, 91);
            this.gb_estado.Name = "gb_estado";
            this.gb_estado.Size = new System.Drawing.Size(126, 99);
            this.gb_estado.TabIndex = 2;
            this.gb_estado.TabStop = false;
            this.gb_estado.Text = "Estado";
            // 
            // rb_pendiente
            // 
            this.rb_pendiente.AutoSize = true;
            this.rb_pendiente.Checked = true;
            this.rb_pendiente.Location = new System.Drawing.Point(22, 32);
            this.rb_pendiente.Name = "rb_pendiente";
            this.rb_pendiente.Size = new System.Drawing.Size(78, 19);
            this.rb_pendiente.TabIndex = 1;
            this.rb_pendiente.TabStop = true;
            this.rb_pendiente.Text = "Pendiente";
            this.rb_pendiente.UseVisualStyleBackColor = true;
            // 
            // rb_completado
            // 
            this.rb_completado.AutoSize = true;
            this.rb_completado.Location = new System.Drawing.Point(22, 57);
            this.rb_completado.Name = "rb_completado";
            this.rb_completado.Size = new System.Drawing.Size(91, 19);
            this.rb_completado.TabIndex = 0;
            this.rb_completado.Text = "Completado";
            this.rb_completado.UseVisualStyleBackColor = true;
            this.rb_completado.CheckedChanged += new System.EventHandler(this.rb_completado_CheckedChanged);
            // 
            // tb_id
            // 
            this.tb_id.Enabled = false;
            this.tb_id.Location = new System.Drawing.Point(69, 20);
            this.tb_id.Name = "tb_id";
            this.tb_id.Size = new System.Drawing.Size(100, 23);
            this.tb_id.TabIndex = 3;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(43, 261);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(624, 150);
            this.dataGridView1.TabIndex = 4;
            // 
            // dtp_fechaCrea
            // 
            this.dtp_fechaCrea.Enabled = false;
            this.dtp_fechaCrea.Location = new System.Drawing.Point(138, 53);
            this.dtp_fechaCrea.Name = "dtp_fechaCrea";
            this.dtp_fechaCrea.Size = new System.Drawing.Size(200, 23);
            this.dtp_fechaCrea.TabIndex = 5;
            // 
            // lbl_fechaC
            // 
            this.lbl_fechaC.AutoSize = true;
            this.lbl_fechaC.Location = new System.Drawing.Point(43, 57);
            this.lbl_fechaC.Name = "lbl_fechaC";
            this.lbl_fechaC.Size = new System.Drawing.Size(92, 15);
            this.lbl_fechaC.TabIndex = 6;
            this.lbl_fechaC.Text = "Fecha creacion: ";
            // 
            // lbl_fechaRes
            // 
            this.lbl_fechaRes.AutoSize = true;
            this.lbl_fechaRes.Location = new System.Drawing.Point(362, 57);
            this.lbl_fechaRes.Name = "lbl_fechaRes";
            this.lbl_fechaRes.Size = new System.Drawing.Size(102, 15);
            this.lbl_fechaRes.TabIndex = 7;
            this.lbl_fechaRes.Text = "Fecha resolución: ";
            // 
            // dtp_fechaRes
            // 
            this.dtp_fechaRes.Enabled = false;
            this.dtp_fechaRes.Location = new System.Drawing.Point(470, 53);
            this.dtp_fechaRes.Name = "dtp_fechaRes";
            this.dtp_fechaRes.Size = new System.Drawing.Size(197, 23);
            this.dtp_fechaRes.TabIndex = 8;
            // 
            // gb_prioridad
            // 
            this.gb_prioridad.Controls.Add(this.rb_baja);
            this.gb_prioridad.Controls.Add(this.rb_media);
            this.gb_prioridad.Controls.Add(this.rb_alta);
            this.gb_prioridad.Location = new System.Drawing.Point(196, 91);
            this.gb_prioridad.Name = "gb_prioridad";
            this.gb_prioridad.Size = new System.Drawing.Size(126, 99);
            this.gb_prioridad.TabIndex = 3;
            this.gb_prioridad.TabStop = false;
            this.gb_prioridad.Text = "Prioridad";
            // 
            // rb_baja
            // 
            this.rb_baja.AutoSize = true;
            this.rb_baja.Location = new System.Drawing.Point(22, 69);
            this.rb_baja.Name = "rb_baja";
            this.rb_baja.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.rb_baja.Size = new System.Drawing.Size(47, 19);
            this.rb_baja.TabIndex = 2;
            this.rb_baja.Text = "Baja";
            this.rb_baja.UseVisualStyleBackColor = true;
            // 
            // rb_media
            // 
            this.rb_media.AutoSize = true;
            this.rb_media.Checked = true;
            this.rb_media.Location = new System.Drawing.Point(22, 45);
            this.rb_media.Name = "rb_media";
            this.rb_media.Size = new System.Drawing.Size(58, 19);
            this.rb_media.TabIndex = 1;
            this.rb_media.TabStop = true;
            this.rb_media.Text = "Media";
            this.rb_media.UseVisualStyleBackColor = true;
            // 
            // rb_alta
            // 
            this.rb_alta.AutoSize = true;
            this.rb_alta.Location = new System.Drawing.Point(22, 20);
            this.rb_alta.Name = "rb_alta";
            this.rb_alta.Size = new System.Drawing.Size(46, 19);
            this.rb_alta.TabIndex = 0;
            this.rb_alta.Text = "Alta";
            this.rb_alta.UseVisualStyleBackColor = true;
            // 
            // tb_informador
            // 
            this.tb_informador.Location = new System.Drawing.Point(433, 108);
            this.tb_informador.Name = "tb_informador";
            this.tb_informador.Size = new System.Drawing.Size(234, 23);
            this.tb_informador.TabIndex = 10;
            // 
            // lbl_informador
            // 
            this.lbl_informador.AutoSize = true;
            this.lbl_informador.Location = new System.Drawing.Point(362, 111);
            this.lbl_informador.Name = "lbl_informador";
            this.lbl_informador.Size = new System.Drawing.Size(70, 15);
            this.lbl_informador.TabIndex = 9;
            this.lbl_informador.Text = "Informador:";
            // 
            // tb_responsable
            // 
            this.tb_responsable.Enabled = false;
            this.tb_responsable.Location = new System.Drawing.Point(433, 144);
            this.tb_responsable.Name = "tb_responsable";
            this.tb_responsable.Size = new System.Drawing.Size(234, 23);
            this.tb_responsable.TabIndex = 12;
            // 
            // lbl_responsable
            // 
            this.lbl_responsable.AutoSize = true;
            this.lbl_responsable.Location = new System.Drawing.Point(359, 147);
            this.lbl_responsable.Name = "lbl_responsable";
            this.lbl_responsable.Size = new System.Drawing.Size(79, 15);
            this.lbl_responsable.TabIndex = 11;
            this.lbl_responsable.Text = "Responsable: ";
            // 
            // tb_descripcion
            // 
            this.tb_descripcion.Location = new System.Drawing.Point(258, 20);
            this.tb_descripcion.Name = "tb_descripcion";
            this.tb_descripcion.Size = new System.Drawing.Size(409, 23);
            this.tb_descripcion.TabIndex = 14;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(188, 23);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(72, 15);
            this.label1.TabIndex = 13;
            this.label1.Text = "Descripcion:";
            // 
            // s
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(712, 450);
            this.Controls.Add(this.tb_descripcion);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tb_responsable);
            this.Controls.Add(this.lbl_responsable);
            this.Controls.Add(this.tb_informador);
            this.Controls.Add(this.lbl_informador);
            this.Controls.Add(this.gb_prioridad);
            this.Controls.Add(this.dtp_fechaRes);
            this.Controls.Add(this.lbl_fechaRes);
            this.Controls.Add(this.lbl_fechaC);
            this.Controls.Add(this.dtp_fechaCrea);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.tb_id);
            this.Controls.Add(this.gb_estado);
            this.Controls.Add(this.lbl_id);
            this.Controls.Add(this.btn_generar);
            this.Name = "s";
            this.Text = "Ordenes de Trabajo";
            this.gb_estado.ResumeLayout(false);
            this.gb_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.gb_prioridad.ResumeLayout(false);
            this.gb_prioridad.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btn_generar;
        private Label lbl_id;
        private GroupBox gb_estado;
        private RadioButton rb_pendiente;
        private RadioButton rb_completado;
        private TextBox tb_id;
        private DataGridView dataGridView1;
        private DateTimePicker dtp_fechaCrea;
        private Label lbl_fechaC;
        private Label lbl_fechaRes;
        private DateTimePicker dtp_fechaRes;
        private GroupBox gb_prioridad;
        private RadioButton rb_baja;
        private RadioButton rb_media;
        private RadioButton rb_alta;
        private TextBox tb_informador;
        private Label lbl_informador;
        private TextBox tb_responsable;
        private Label lbl_responsable;
        private TextBox tb_descripcion;
        private Label label1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
    }
}