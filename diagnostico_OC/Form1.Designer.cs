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
            btn_generar = new Button();
            lbl_id = new Label();
            gb_estado = new GroupBox();
            rb_pendiente = new RadioButton();
            rb_completado = new RadioButton();
            tb_id = new TextBox();
            dgv_OCs = new DataGridView();
            dtp_fechaCrea = new DateTimePicker();
            lbl_fechaC = new Label();
            lbl_fechaRes = new Label();
            dtp_fechaRes = new DateTimePicker();
            gb_prioridad = new GroupBox();
            rb_baja = new RadioButton();
            rb_media = new RadioButton();
            rb_alta = new RadioButton();
            tb_informador = new TextBox();
            lbl_informador = new Label();
            tb_responsable = new TextBox();
            lbl_responsable = new Label();
            tb_descripcion = new TextBox();
            label1 = new Label();
            backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            gb_estado.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_OCs).BeginInit();
            gb_prioridad.SuspendLayout();
            SuspendLayout();
            // 
            // btn_generar
            // 
            btn_generar.Location = new Point(569, 194);
            btn_generar.Name = "btn_generar";
            btn_generar.Size = new Size(98, 23);
            btn_generar.TabIndex = 0;
            btn_generar.Text = "Generar OC";
            btn_generar.UseVisualStyleBackColor = true;
            btn_generar.Click += Btn_generar_Click;
            // 
            // lbl_id
            // 
            lbl_id.AutoSize = true;
            lbl_id.Location = new Point(43, 23);
            lbl_id.Name = "lbl_id";
            lbl_id.Size = new Size(20, 15);
            lbl_id.TabIndex = 1;
            lbl_id.Text = "Id:";
            // 
            // gb_estado
            // 
            gb_estado.Controls.Add(rb_pendiente);
            gb_estado.Controls.Add(rb_completado);
            gb_estado.Location = new Point(43, 91);
            gb_estado.Name = "gb_estado";
            gb_estado.Size = new Size(126, 99);
            gb_estado.TabIndex = 2;
            gb_estado.TabStop = false;
            gb_estado.Text = "Estado";
            // 
            // rb_pendiente
            // 
            rb_pendiente.AutoSize = true;
            rb_pendiente.Checked = true;
            rb_pendiente.Location = new Point(22, 32);
            rb_pendiente.Name = "rb_pendiente";
            rb_pendiente.Size = new Size(78, 19);
            rb_pendiente.TabIndex = 1;
            rb_pendiente.TabStop = true;
            rb_pendiente.Text = "Pendiente";
            rb_pendiente.UseVisualStyleBackColor = true;
            // 
            // rb_completado
            // 
            rb_completado.AutoSize = true;
            rb_completado.Location = new Point(22, 57);
            rb_completado.Name = "rb_completado";
            rb_completado.Size = new Size(91, 19);
            rb_completado.TabIndex = 0;
            rb_completado.Text = "Completado";
            rb_completado.UseVisualStyleBackColor = true;
            rb_completado.CheckedChanged += Rb_completado_CheckedChanged;
            // 
            // tb_id
            // 
            tb_id.Enabled = false;
            tb_id.Location = new Point(69, 20);
            tb_id.Name = "tb_id";
            tb_id.Size = new Size(100, 23);
            tb_id.TabIndex = 3;
            // 
            // dgv_OCs
            // 
            dgv_OCs.AllowUserToAddRows = false;
            dgv_OCs.AllowUserToDeleteRows = false;
            dgv_OCs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dgv_OCs.Location = new Point(43, 236);
            dgv_OCs.Name = "dgv_OCs";
            dgv_OCs.ReadOnly = true;
            dgv_OCs.RowTemplate.Height = 25;
            dgv_OCs.Size = new Size(624, 175);
            dgv_OCs.TabIndex = 4;
            // 
            // dtp_fechaCrea
            // 
            dtp_fechaCrea.Enabled = false;
            dtp_fechaCrea.Location = new Point(138, 53);
            dtp_fechaCrea.Name = "dtp_fechaCrea";
            dtp_fechaCrea.Size = new Size(200, 23);
            dtp_fechaCrea.TabIndex = 5;
            // 
            // lbl_fechaC
            // 
            lbl_fechaC.AutoSize = true;
            lbl_fechaC.Location = new Point(43, 57);
            lbl_fechaC.Name = "lbl_fechaC";
            lbl_fechaC.Size = new Size(92, 15);
            lbl_fechaC.TabIndex = 6;
            lbl_fechaC.Text = "Fecha creacion: ";
            // 
            // lbl_fechaRes
            // 
            lbl_fechaRes.AutoSize = true;
            lbl_fechaRes.Location = new Point(362, 57);
            lbl_fechaRes.Name = "lbl_fechaRes";
            lbl_fechaRes.Size = new Size(102, 15);
            lbl_fechaRes.TabIndex = 7;
            lbl_fechaRes.Text = "Fecha resolución: ";
            // 
            // dtp_fechaRes
            // 
            dtp_fechaRes.Enabled = false;
            dtp_fechaRes.Location = new Point(470, 53);
            dtp_fechaRes.Name = "dtp_fechaRes";
            dtp_fechaRes.Size = new Size(197, 23);
            dtp_fechaRes.TabIndex = 8;
            // 
            // gb_prioridad
            // 
            gb_prioridad.Controls.Add(rb_baja);
            gb_prioridad.Controls.Add(rb_media);
            gb_prioridad.Controls.Add(rb_alta);
            gb_prioridad.Location = new Point(196, 91);
            gb_prioridad.Name = "gb_prioridad";
            gb_prioridad.Size = new Size(126, 99);
            gb_prioridad.TabIndex = 3;
            gb_prioridad.TabStop = false;
            gb_prioridad.Text = "Prioridad";
            // 
            // rb_baja
            // 
            rb_baja.AutoSize = true;
            rb_baja.Location = new Point(22, 20);
            rb_baja.Name = "rb_baja";
            rb_baja.RightToLeft = RightToLeft.No;
            rb_baja.Size = new Size(47, 19);
            rb_baja.TabIndex = 2;
            rb_baja.Text = "Baja";
            rb_baja.UseVisualStyleBackColor = true;
            // 
            // rb_media
            // 
            rb_media.AutoSize = true;
            rb_media.Checked = true;
            rb_media.Location = new Point(22, 45);
            rb_media.Name = "rb_media";
            rb_media.Size = new Size(58, 19);
            rb_media.TabIndex = 1;
            rb_media.TabStop = true;
            rb_media.Text = "Media";
            rb_media.UseVisualStyleBackColor = true;
            // 
            // rb_alta
            // 
            rb_alta.AutoSize = true;
            rb_alta.Location = new Point(22, 70);
            rb_alta.Name = "rb_alta";
            rb_alta.Size = new Size(46, 19);
            rb_alta.TabIndex = 0;
            rb_alta.Text = "Alta";
            rb_alta.UseVisualStyleBackColor = true;
            // 
            // tb_informador
            // 
            tb_informador.Location = new Point(433, 108);
            tb_informador.Name = "tb_informador";
            tb_informador.Size = new Size(234, 23);
            tb_informador.TabIndex = 10;
            // 
            // lbl_informador
            // 
            lbl_informador.AutoSize = true;
            lbl_informador.Location = new Point(362, 111);
            lbl_informador.Name = "lbl_informador";
            lbl_informador.Size = new Size(70, 15);
            lbl_informador.TabIndex = 9;
            lbl_informador.Text = "Informador:";
            // 
            // tb_responsable
            // 
            tb_responsable.Enabled = false;
            tb_responsable.Location = new Point(433, 144);
            tb_responsable.Name = "tb_responsable";
            tb_responsable.Size = new Size(234, 23);
            tb_responsable.TabIndex = 12;
            // 
            // lbl_responsable
            // 
            lbl_responsable.AutoSize = true;
            lbl_responsable.Location = new Point(359, 147);
            lbl_responsable.Name = "lbl_responsable";
            lbl_responsable.Size = new Size(79, 15);
            lbl_responsable.TabIndex = 11;
            lbl_responsable.Text = "Responsable: ";
            // 
            // tb_descripcion
            // 
            tb_descripcion.Location = new Point(258, 20);
            tb_descripcion.Name = "tb_descripcion";
            tb_descripcion.Size = new Size(409, 23);
            tb_descripcion.TabIndex = 14;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 23);
            label1.Name = "label1";
            label1.Size = new Size(72, 15);
            label1.TabIndex = 13;
            label1.Text = "Descripcion:";
            // 
            // s
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(712, 450);
            Controls.Add(tb_descripcion);
            Controls.Add(label1);
            Controls.Add(tb_responsable);
            Controls.Add(lbl_responsable);
            Controls.Add(tb_informador);
            Controls.Add(lbl_informador);
            Controls.Add(gb_prioridad);
            Controls.Add(dtp_fechaRes);
            Controls.Add(lbl_fechaRes);
            Controls.Add(lbl_fechaC);
            Controls.Add(dtp_fechaCrea);
            Controls.Add(dgv_OCs);
            Controls.Add(tb_id);
            Controls.Add(gb_estado);
            Controls.Add(lbl_id);
            Controls.Add(btn_generar);
            Name = "s";
            Text = "Ordenes de Trabajo";
            gb_estado.ResumeLayout(false);
            gb_estado.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dgv_OCs).EndInit();
            gb_prioridad.ResumeLayout(false);
            gb_prioridad.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button btn_generar;
        private Label lbl_id;
        private GroupBox gb_estado;
        private RadioButton rb_pendiente;
        private RadioButton rb_completado;
        private TextBox tb_id;
        private DataGridView dgv_OCs;
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