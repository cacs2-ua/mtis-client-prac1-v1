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
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.SlateBlue;
            label1.Location = new Point(611, 98);
            label1.Name = "label1";
            label1.Size = new Size(380, 46);
            label1.TabIndex = 0;
            label1.Text = "Insertar Registro Acceso";
            // 
            // NIFTextBox
            // 
            NIFTextBox.Location = new Point(673, 202);
            NIFTextBox.Name = "NIFTextBox";
            NIFTextBox.Size = new Size(288, 27);
            NIFTextBox.TabIndex = 5;
            // 
            // codigoSalaTextBox
            // 
            codigoSalaTextBox.Location = new Point(673, 256);
            codigoSalaTextBox.Name = "codigoSalaTextBox";
            codigoSalaTextBox.Size = new Size(288, 27);
            codigoSalaTextBox.TabIndex = 6;
            // 
            // codigoDispositivoTextBox
            // 
            codigoDispositivoTextBox.Location = new Point(673, 311);
            codigoDispositivoTextBox.Name = "codigoDispositivoTextBox";
            codigoDispositivoTextBox.Size = new Size(288, 27);
            codigoDispositivoTextBox.TabIndex = 7;
            // 
            // NIFLabel
            // 
            NIFLabel.AutoSize = true;
            NIFLabel.Location = new Point(611, 202);
            NIFLabel.Name = "NIFLabel";
            NIFLabel.Size = new Size(31, 20);
            NIFLabel.TabIndex = 8;
            NIFLabel.Text = "NIF";
            // 
            // codigoSalaLabel
            // 
            codigoSalaLabel.AutoSize = true;
            codigoSalaLabel.Location = new Point(558, 256);
            codigoSalaLabel.Name = "codigoSalaLabel";
            codigoSalaLabel.Size = new Size(84, 20);
            codigoSalaLabel.TabIndex = 9;
            codigoSalaLabel.Text = "codigoSala";
            // 
            // codigoDispositivoLabel
            // 
            codigoDispositivoLabel.AutoSize = true;
            codigoDispositivoLabel.Location = new Point(512, 311);
            codigoDispositivoLabel.Name = "codigoDispositivoLabel";
            codigoDispositivoLabel.Size = new Size(130, 20);
            codigoDispositivoLabel.TabIndex = 10;
            codigoDispositivoLabel.Text = "codigoDispositivo";
            // 
            // registrarRegistroAccesoButton
            // 
            registrarRegistroAccesoButton.BackColor = SystemColors.ControlDark;
            registrarRegistroAccesoButton.Location = new Point(867, 360);
            registrarRegistroAccesoButton.Name = "registrarRegistroAccesoButton";
            registrarRegistroAccesoButton.Size = new Size(94, 29);
            registrarRegistroAccesoButton.TabIndex = 11;
            registrarRegistroAccesoButton.Text = "Registrar";
            registrarRegistroAccesoButton.UseVisualStyleBackColor = false;
            registrarRegistroAccesoButton.Click += registrarRegistroAccesoButton_Click;
            // 
            // ucControlAccesos
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
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
    }
}
