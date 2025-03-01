namespace WinFormsApp1
{
    partial class ucNiveles
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
            crearNuevoNivelLabel = new Label();
            descripcionNivelTextBox = new TextBox();
            nivelTextBox = new TextBox();
            descripcionNivelLabel = new Label();
            nivelLabel = new Label();
            registrarNivelButton = new Button();
            SuspendLayout();
            // 
            // crearNuevoNivelLabel
            // 
            crearNuevoNivelLabel.AutoSize = true;
            crearNuevoNivelLabel.Font = new Font("Segoe UI", 20F);
            crearNuevoNivelLabel.ForeColor = Color.FromArgb(128, 128, 255);
            crearNuevoNivelLabel.Location = new Point(538, 88);
            crearNuevoNivelLabel.Name = "crearNuevoNivelLabel";
            crearNuevoNivelLabel.Size = new Size(326, 46);
            crearNuevoNivelLabel.TabIndex = 0;
            crearNuevoNivelLabel.Text = "Crear un nuevo nivel";
            // 
            // descripcionNivelTextBox
            // 
            descripcionNivelTextBox.Location = new Point(523, 183);
            descripcionNivelTextBox.Name = "descripcionNivelTextBox";
            descripcionNivelTextBox.Size = new Size(370, 27);
            descripcionNivelTextBox.TabIndex = 1;
            // 
            // nivelTextBox
            // 
            nivelTextBox.Location = new Point(523, 247);
            nivelTextBox.Name = "nivelTextBox";
            nivelTextBox.Size = new Size(370, 27);
            nivelTextBox.TabIndex = 2;
            nivelTextBox.TextChanged += this.nivelTextBox_TextChanged;
            // 
            // descripcionNivelLabel
            // 
            descripcionNivelLabel.AutoSize = true;
            descripcionNivelLabel.Location = new Point(414, 186);
            descripcionNivelLabel.Name = "descripcionNivelLabel";
            descripcionNivelLabel.Size = new Size(85, 20);
            descripcionNivelLabel.TabIndex = 3;
            descripcionNivelLabel.Text = "descripcion";
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new Point(459, 250);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new Size(40, 20);
            nivelLabel.TabIndex = 4;
            nivelLabel.Text = "nivel";
            // 
            // registrarNivelButton
            // 
            registrarNivelButton.BackColor = SystemColors.ControlDark;
            registrarNivelButton.Location = new Point(799, 310);
            registrarNivelButton.Name = "registrarNivelButton";
            registrarNivelButton.Size = new Size(94, 29);
            registrarNivelButton.TabIndex = 5;
            registrarNivelButton.Text = "Registrar";
            registrarNivelButton.UseVisualStyleBackColor = false;
            registrarNivelButton.Click += this.registrarNivelButton_Click;
            // 
            // ucNiveles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(registrarNivelButton);
            Controls.Add(nivelLabel);
            Controls.Add(descripcionNivelLabel);
            Controls.Add(nivelTextBox);
            Controls.Add(descripcionNivelTextBox);
            Controls.Add(crearNuevoNivelLabel);
            Name = "ucNiveles";
            Size = new Size(1902, 1002);
            Load += this.ucNiveles_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label crearNuevoNivelLabel;
        private TextBox descripcionNivelTextBox;
        private TextBox nivelTextBox;
        private Label descripcionNivelLabel;
        private Label nivelLabel;
        private Button registrarNivelButton;
    }
}
