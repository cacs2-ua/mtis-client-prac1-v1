namespace WinFormsApp1
{
    partial class ucControlAccesos
    {
        /// <summary> 
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de componentes

        /// <summary> 
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            NIFTextBox = new TextBox();
            codigoSalaTextBox = new TextBox();
            codigoDispositivoTextBox = new TextBox();
            NIFLabel = new Label();
            codigoSalaLabel = new Label();
            codigoDispositivoLabel = new Label();
            registrarRegistroAccesoButton = new Button();
            consultarButton = new Button();
            label2 = new Label();
            codigoSalaConsultarLabel = new Label();
            nifConsultarLabel = new Label();
            codigoDispositivoConsultarTextBox = new TextBox();
            codigoSalaConsultarTextBox = new TextBox();
            nifConsultarTextBox = new TextBox();
            label5 = new Label();
            label6 = new Label();
            fechaDesdeConsultarTextBox = new TextBox();
            label7 = new Label();
            fechaHastaConsultarTextBox = new TextBox();
            registrosAccesosDataGridView = new DataGridView();
            label3 = new Label();
            ((System.ComponentModel.ISupportInitialize)registrosAccesosDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(331, 672);
            label1.Name = "label1";
            label1.Size = new Size(406, 46);
            label1.TabIndex = 0;
            label1.Text = "Insertar Registro Acceso";
            // 
            // NIFTextBox
            // 
            NIFTextBox.Location = new Point(393, 776);
            NIFTextBox.Name = "NIFTextBox";
            NIFTextBox.Size = new Size(288, 27);
            NIFTextBox.TabIndex = 5;
            // 
            // codigoSalaTextBox
            // 
            codigoSalaTextBox.Location = new Point(393, 830);
            codigoSalaTextBox.Name = "codigoSalaTextBox";
            codigoSalaTextBox.Size = new Size(288, 27);
            codigoSalaTextBox.TabIndex = 6;
            codigoSalaTextBox.TextChanged += codigoSalaTextBox_TextChanged;
            // 
            // codigoDispositivoTextBox
            // 
            codigoDispositivoTextBox.Location = new Point(393, 885);
            codigoDispositivoTextBox.Name = "codigoDispositivoTextBox";
            codigoDispositivoTextBox.Size = new Size(288, 27);
            codigoDispositivoTextBox.TabIndex = 7;
            // 
            // NIFLabel
            // 
            NIFLabel.AutoSize = true;
            NIFLabel.Location = new Point(331, 776);
            NIFLabel.Name = "NIFLabel";
            NIFLabel.Size = new Size(31, 20);
            NIFLabel.TabIndex = 8;
            NIFLabel.Text = "NIF";
            // 
            // codigoSalaLabel
            // 
            codigoSalaLabel.AutoSize = true;
            codigoSalaLabel.Location = new Point(278, 830);
            codigoSalaLabel.Name = "codigoSalaLabel";
            codigoSalaLabel.Size = new Size(84, 20);
            codigoSalaLabel.TabIndex = 9;
            codigoSalaLabel.Text = "codigoSala";
            // 
            // codigoDispositivoLabel
            // 
            codigoDispositivoLabel.AutoSize = true;
            codigoDispositivoLabel.Location = new Point(232, 885);
            codigoDispositivoLabel.Name = "codigoDispositivoLabel";
            codigoDispositivoLabel.Size = new Size(130, 20);
            codigoDispositivoLabel.TabIndex = 10;
            codigoDispositivoLabel.Text = "codigoDispositivo";
            // 
            // registrarRegistroAccesoButton
            // 
            registrarRegistroAccesoButton.BackColor = SystemColors.ControlDark;
            registrarRegistroAccesoButton.Location = new Point(587, 934);
            registrarRegistroAccesoButton.Name = "registrarRegistroAccesoButton";
            registrarRegistroAccesoButton.Size = new Size(94, 29);
            registrarRegistroAccesoButton.TabIndex = 11;
            registrarRegistroAccesoButton.Text = "Registrar";
            registrarRegistroAccesoButton.UseVisualStyleBackColor = false;
            registrarRegistroAccesoButton.Click += registrarRegistroAccesoButton_Click;
            // 
            // consultarButton
            // 
            consultarButton.BackColor = SystemColors.ControlDark;
            consultarButton.Location = new Point(587, 595);
            consultarButton.Name = "consultarButton";
            consultarButton.Size = new Size(94, 29);
            consultarButton.TabIndex = 19;
            consultarButton.Text = "Consultar";
            consultarButton.UseVisualStyleBackColor = false;
            consultarButton.Click += consultarButton_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(232, 429);
            label2.Name = "label2";
            label2.Size = new Size(130, 20);
            label2.TabIndex = 18;
            label2.Text = "codigoDispositivo";
            // 
            // codigoSalaConsultarLabel
            // 
            codigoSalaConsultarLabel.AutoSize = true;
            codigoSalaConsultarLabel.Location = new Point(278, 374);
            codigoSalaConsultarLabel.Name = "codigoSalaConsultarLabel";
            codigoSalaConsultarLabel.Size = new Size(84, 20);
            codigoSalaConsultarLabel.TabIndex = 17;
            codigoSalaConsultarLabel.Text = "codigoSala";
            // 
            // nifConsultarLabel
            // 
            nifConsultarLabel.AutoSize = true;
            nifConsultarLabel.Location = new Point(331, 320);
            nifConsultarLabel.Name = "nifConsultarLabel";
            nifConsultarLabel.Size = new Size(31, 20);
            nifConsultarLabel.TabIndex = 16;
            nifConsultarLabel.Text = "NIF";
            // 
            // codigoDispositivoConsultarTextBox
            // 
            codigoDispositivoConsultarTextBox.Location = new Point(393, 429);
            codigoDispositivoConsultarTextBox.Name = "codigoDispositivoConsultarTextBox";
            codigoDispositivoConsultarTextBox.Size = new Size(288, 27);
            codigoDispositivoConsultarTextBox.TabIndex = 15;
            // 
            // codigoSalaConsultarTextBox
            // 
            codigoSalaConsultarTextBox.Location = new Point(393, 374);
            codigoSalaConsultarTextBox.Name = "codigoSalaConsultarTextBox";
            codigoSalaConsultarTextBox.Size = new Size(288, 27);
            codigoSalaConsultarTextBox.TabIndex = 14;
            // 
            // nifConsultarTextBox
            // 
            nifConsultarTextBox.Location = new Point(393, 320);
            nifConsultarTextBox.Name = "nifConsultarTextBox";
            nifConsultarTextBox.Size = new Size(288, 27);
            nifConsultarTextBox.TabIndex = 13;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateBlue;
            label5.Location = new Point(331, 216);
            label5.Name = "label5";
            label5.Size = new Size(465, 46);
            label5.TabIndex = 12;
            label5.Text = "Consultar Registros Accesos";
            label5.Click += label5_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(275, 478);
            label6.Name = "label6";
            label6.Size = new Size(87, 20);
            label6.TabIndex = 21;
            label6.Text = "fechaDesde";
            // 
            // fechaDesdeConsultarTextBox
            // 
            fechaDesdeConsultarTextBox.Location = new Point(393, 480);
            fechaDesdeConsultarTextBox.Name = "fechaDesdeConsultarTextBox";
            fechaDesdeConsultarTextBox.Size = new Size(288, 27);
            fechaDesdeConsultarTextBox.TabIndex = 20;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(279, 532);
            label7.Name = "label7";
            label7.Size = new Size(83, 20);
            label7.TabIndex = 23;
            label7.Text = "fechaHasta";
            // 
            // fechaHastaConsultarTextBox
            // 
            fechaHastaConsultarTextBox.Location = new Point(393, 532);
            fechaHastaConsultarTextBox.Name = "fechaHastaConsultarTextBox";
            fechaHastaConsultarTextBox.Size = new Size(288, 27);
            fechaHastaConsultarTextBox.TabIndex = 22;
            // 
            // registrosAccesosDataGridView
            // 
            registrosAccesosDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            registrosAccesosDataGridView.Location = new Point(847, 231);
            registrosAccesosDataGridView.Name = "registrosAccesosDataGridView";
            registrosAccesosDataGridView.RowHeadersWidth = 51;
            registrosAccesosDataGridView.Size = new Size(1011, 732);
            registrosAccesosDataGridView.TabIndex = 24;
            registrosAccesosDataGridView.CellContentClick += dataGridView1_CellContentClick;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.Blue;
            label3.Location = new Point(777, 73);
            label3.Name = "label3";
            label3.Size = new Size(529, 48);
            label3.TabIndex = 25;
            label3.Text = "Servicio \"ControlAccesos\"";
            // 
            // ucControlAccesos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(label3);
            Controls.Add(registrosAccesosDataGridView);
            Controls.Add(label7);
            Controls.Add(fechaHastaConsultarTextBox);
            Controls.Add(label6);
            Controls.Add(fechaDesdeConsultarTextBox);
            Controls.Add(consultarButton);
            Controls.Add(label2);
            Controls.Add(codigoSalaConsultarLabel);
            Controls.Add(nifConsultarLabel);
            Controls.Add(codigoDispositivoConsultarTextBox);
            Controls.Add(codigoSalaConsultarTextBox);
            Controls.Add(nifConsultarTextBox);
            Controls.Add(label5);
            Controls.Add(registrarRegistroAccesoButton);
            Controls.Add(codigoDispositivoLabel);
            Controls.Add(codigoSalaLabel);
            Controls.Add(NIFLabel);
            Controls.Add(codigoDispositivoTextBox);
            Controls.Add(codigoSalaTextBox);
            Controls.Add(NIFTextBox);
            Controls.Add(label1);
            Name = "ucControlAccesos";
            Size = new Size(1902, 1002);
            Load += ucControlAccesos_Load;
            ((System.ComponentModel.ISupportInitialize)registrosAccesosDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private TextBox NIFTextBox;
        private TextBox codigoSalaTextBox;
        private TextBox codigoDispositivoTextBox;
        private Label NIFLabel;
        private Label codigoSalaLabel;
        private Label codigoDispositivoLabel;
        private Button registrarRegistroAccesoButton;
        private Button consultarButton;
        private Label label2;
        private Label codigoSalaConsultarLabel;
        private Label nifConsultarLabel;
        private TextBox codigoDispositivoConsultarTextBox;
        private TextBox codigoSalaConsultarTextBox;
        private TextBox nifConsultarTextBox;
        private Label label5;
        private Label label6;
        private TextBox fechaDesdeConsultarTextBox;
        private Label label7;
        private TextBox fechaHastaConsultarTextBox;
        private DataGridView registrosAccesosDataGridView;
        private Label label3;
    }
}
