namespace WinFormsApp1
{
    partial class ucControlPresencia
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
            consultarButton = new Button();
            nifConsultarLabel = new Label();
            codigoSalaConsultarTextBox = new TextBox();
            label5 = new Label();
            registrarButton = new Button();
            codigoSalaLabel = new Label();
            NIFLabel = new Label();
            codigoSalaRegistrarTextBox = new TextBox();
            NIFRegistrarTextBox = new TextBox();
            label3 = new Label();
            eliminarButton = new Button();
            label2 = new Label();
            label4 = new Label();
            codigoSalaEliminarTextBox = new TextBox();
            NIFEliminarTextBox = new TextBox();
            label6 = new Label();
            controlPresenciaDataGridView = new DataGridView();
            ((System.ComponentModel.ISupportInitialize)controlPresenciaDataGridView).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.Blue;
            label1.Location = new Point(479, 46);
            label1.Name = "label1";
            label1.Size = new Size(559, 48);
            label1.TabIndex = 0;
            label1.Text = "Servicio \"ControlPresencia\"";
            // 
            // consultarButton
            // 
            consultarButton.BackColor = SystemColors.ControlDark;
            consultarButton.Location = new Point(342, 285);
            consultarButton.Name = "consultarButton";
            consultarButton.Size = new Size(94, 29);
            consultarButton.TabIndex = 39;
            consultarButton.Text = "Consultar";
            consultarButton.UseVisualStyleBackColor = false;
            consultarButton.Click += consultarButton_Click;
            // 
            // nifConsultarLabel
            // 
            nifConsultarLabel.AutoSize = true;
            nifConsultarLabel.Location = new Point(33, 232);
            nifConsultarLabel.Name = "nifConsultarLabel";
            nifConsultarLabel.Size = new Size(84, 20);
            nifConsultarLabel.TabIndex = 36;
            nifConsultarLabel.Text = "codigoSala";
            // 
            // codigoSalaConsultarTextBox
            // 
            codigoSalaConsultarTextBox.Location = new Point(148, 232);
            codigoSalaConsultarTextBox.Name = "codigoSalaConsultarTextBox";
            codigoSalaConsultarTextBox.Size = new Size(288, 27);
            codigoSalaConsultarTextBox.TabIndex = 33;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateBlue;
            label5.Location = new Point(33, 147);
            label5.Name = "label5";
            label5.Size = new Size(478, 46);
            label5.TabIndex = 32;
            label5.Text = "Consultar Empleados en Sala";
            // 
            // registrarButton
            // 
            registrarButton.BackColor = SystemColors.ControlDark;
            registrarButton.Location = new Point(342, 581);
            registrarButton.Name = "registrarButton";
            registrarButton.Size = new Size(94, 29);
            registrarButton.TabIndex = 31;
            registrarButton.Text = "Registrar";
            registrarButton.UseVisualStyleBackColor = false;
            // 
            // codigoSalaLabel
            // 
            codigoSalaLabel.AutoSize = true;
            codigoSalaLabel.Location = new Point(33, 532);
            codigoSalaLabel.Name = "codigoSalaLabel";
            codigoSalaLabel.Size = new Size(84, 20);
            codigoSalaLabel.TabIndex = 29;
            codigoSalaLabel.Text = "codigoSala";
            // 
            // NIFLabel
            // 
            NIFLabel.AutoSize = true;
            NIFLabel.Location = new Point(86, 478);
            NIFLabel.Name = "NIFLabel";
            NIFLabel.Size = new Size(31, 20);
            NIFLabel.TabIndex = 28;
            NIFLabel.Text = "NIF";
            // 
            // codigoSalaRegistrarTextBox
            // 
            codigoSalaRegistrarTextBox.Location = new Point(148, 532);
            codigoSalaRegistrarTextBox.Name = "codigoSalaRegistrarTextBox";
            codigoSalaRegistrarTextBox.Size = new Size(288, 27);
            codigoSalaRegistrarTextBox.TabIndex = 26;
            // 
            // NIFRegistrarTextBox
            // 
            NIFRegistrarTextBox.Location = new Point(148, 478);
            NIFRegistrarTextBox.Name = "NIFRegistrarTextBox";
            NIFRegistrarTextBox.Size = new Size(288, 27);
            NIFRegistrarTextBox.TabIndex = 25;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(33, 379);
            label3.Name = "label3";
            label3.Size = new Size(502, 46);
            label3.TabIndex = 24;
            label3.Text = "Registrar Control de Presencia";
            // 
            // eliminarButton
            // 
            eliminarButton.BackColor = SystemColors.ControlDark;
            eliminarButton.Location = new Point(342, 876);
            eliminarButton.Name = "eliminarButton";
            eliminarButton.Size = new Size(94, 29);
            eliminarButton.TabIndex = 45;
            eliminarButton.Text = "Eliminar";
            eliminarButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(33, 827);
            label2.Name = "label2";
            label2.Size = new Size(84, 20);
            label2.TabIndex = 44;
            label2.Text = "codigoSala";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(86, 773);
            label4.Name = "label4";
            label4.Size = new Size(31, 20);
            label4.TabIndex = 43;
            label4.Text = "NIF";
            // 
            // codigoSalaEliminarTextBox
            // 
            codigoSalaEliminarTextBox.Location = new Point(148, 827);
            codigoSalaEliminarTextBox.Name = "codigoSalaEliminarTextBox";
            codigoSalaEliminarTextBox.Size = new Size(288, 27);
            codigoSalaEliminarTextBox.TabIndex = 42;
            // 
            // NIFEliminarTextBox
            // 
            NIFEliminarTextBox.Location = new Point(148, 773);
            NIFEliminarTextBox.Name = "NIFEliminarTextBox";
            NIFEliminarTextBox.Size = new Size(288, 27);
            NIFEliminarTextBox.TabIndex = 41;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateBlue;
            label6.Location = new Point(23, 673);
            label6.Name = "label6";
            label6.Size = new Size(490, 46);
            label6.TabIndex = 40;
            label6.Text = "Eliminar Control de Presencia";
            // 
            // controlPresenciaDataGridView
            // 
            controlPresenciaDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            controlPresenciaDataGridView.Location = new Point(572, 147);
            controlPresenciaDataGridView.Name = "controlPresenciaDataGridView";
            controlPresenciaDataGridView.RowHeadersWidth = 51;
            controlPresenciaDataGridView.Size = new Size(1309, 838);
            controlPresenciaDataGridView.TabIndex = 46;
            // 
            // ucControlPresencia
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(controlPresenciaDataGridView);
            Controls.Add(eliminarButton);
            Controls.Add(label2);
            Controls.Add(label4);
            Controls.Add(codigoSalaEliminarTextBox);
            Controls.Add(NIFEliminarTextBox);
            Controls.Add(label6);
            Controls.Add(consultarButton);
            Controls.Add(nifConsultarLabel);
            Controls.Add(codigoSalaConsultarTextBox);
            Controls.Add(label5);
            Controls.Add(registrarButton);
            Controls.Add(codigoSalaLabel);
            Controls.Add(NIFLabel);
            Controls.Add(codigoSalaRegistrarTextBox);
            Controls.Add(NIFRegistrarTextBox);
            Controls.Add(label3);
            Controls.Add(label1);
            Name = "ucControlPresencia";
            Size = new Size(1902, 1002);
            ((System.ComponentModel.ISupportInitialize)controlPresenciaDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label7;
        private TextBox fechaHastaConsultarTextBox;
        private Label label6;
        private TextBox fechaDesdeConsultarTextBox;
        private Button consultarButton;
        private Label codigoSalaConsultarLabel;
        private Label nifConsultarLabel;
        private TextBox codigoSalaConsultarTextBox;
        private TextBox nifConsultarTextBox;
        private Label label5;
        private Button registrarRegistroAccesoButton;
        private Label codigoDispositivoLabel;
        private Label codigoSalaLabel;
        private Label NIFLabel;
        private TextBox codigoDispositivoTextBox;
        private TextBox codigoSalaTextBox;
        private TextBox NIFTextBox;
        private Label label3;
        private Button button1;
        private Label label2;
        private Label label4;
        private TextBox textBox1;
        private TextBox textBox2;
        private DataGridView registrosAccesosDataGridView;
        private Button registrarButton;
        private TextBox codigoSalaRegistrarTextBox;
        private TextBox NIFRegistrarTextBox;
        private Button eliminarButton;
        private TextBox codigoSalaEliminarTextBox;
        private TextBox NIFEliminarTextBox;
        private DataGridView controlPresenciaDataGridView;
    }
}
