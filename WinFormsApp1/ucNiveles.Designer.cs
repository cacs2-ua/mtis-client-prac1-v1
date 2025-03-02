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
            label1 = new Label();
            consultarNivelTextBox = new TextBox();
            label2 = new Label();
            consultarNivelDataGridView = new DataGridView();
            consultarNivelbutton = new Button();
            ((System.ComponentModel.ISupportInitialize)consultarNivelDataGridView).BeginInit();
            SuspendLayout();
            // 
            // crearNuevoNivelLabel
            // 
            crearNuevoNivelLabel.AutoSize = true;
            crearNuevoNivelLabel.Font = new Font("Segoe UI", 20F);
            crearNuevoNivelLabel.ForeColor = Color.FromArgb(128, 128, 255);
            crearNuevoNivelLabel.Location = new Point(788, 91);
            crearNuevoNivelLabel.Name = "crearNuevoNivelLabel";
            crearNuevoNivelLabel.Size = new Size(326, 46);
            crearNuevoNivelLabel.TabIndex = 0;
            crearNuevoNivelLabel.Text = "Crear un nuevo nivel";
            // 
            // descripcionNivelTextBox
            // 
            descripcionNivelTextBox.Location = new Point(773, 186);
            descripcionNivelTextBox.Name = "descripcionNivelTextBox";
            descripcionNivelTextBox.Size = new Size(370, 27);
            descripcionNivelTextBox.TabIndex = 1;
            // 
            // nivelTextBox
            // 
            nivelTextBox.Location = new Point(773, 250);
            nivelTextBox.Name = "nivelTextBox";
            nivelTextBox.Size = new Size(370, 27);
            nivelTextBox.TabIndex = 2;
            nivelTextBox.TextChanged += nivelTextBox_TextChanged;
            // 
            // descripcionNivelLabel
            // 
            descripcionNivelLabel.AutoSize = true;
            descripcionNivelLabel.Location = new Point(664, 189);
            descripcionNivelLabel.Name = "descripcionNivelLabel";
            descripcionNivelLabel.Size = new Size(85, 20);
            descripcionNivelLabel.TabIndex = 3;
            descripcionNivelLabel.Text = "descripcion";
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new Point(709, 253);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new Size(40, 20);
            nivelLabel.TabIndex = 4;
            nivelLabel.Text = "nivel";
            // 
            // registrarNivelButton
            // 
            registrarNivelButton.BackColor = SystemColors.ControlDark;
            registrarNivelButton.Location = new Point(1049, 305);
            registrarNivelButton.Name = "registrarNivelButton";
            registrarNivelButton.Size = new Size(94, 29);
            registrarNivelButton.TabIndex = 5;
            registrarNivelButton.Text = "Registrar";
            registrarNivelButton.UseVisualStyleBackColor = false;
            registrarNivelButton.Click += registrarNivelButton_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(67, 189);
            label1.Name = "label1";
            label1.Size = new Size(85, 20);
            label1.TabIndex = 8;
            label1.Text = "descripcion";
            // 
            // consultarNivelTextBox
            // 
            consultarNivelTextBox.Location = new Point(176, 186);
            consultarNivelTextBox.Name = "consultarNivelTextBox";
            consultarNivelTextBox.Size = new Size(370, 27);
            consultarNivelTextBox.TabIndex = 7;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 20F);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(191, 91);
            label2.Name = "label2";
            label2.Size = new Size(287, 46);
            label2.TabIndex = 6;
            label2.Text = "Consultar un nivel";
            // 
            // consultarNivelDataGridView
            // 
            consultarNivelDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consultarNivelDataGridView.Location = new Point(67, 333);
            consultarNivelDataGridView.Name = "consultarNivelDataGridView";
            consultarNivelDataGridView.RowHeadersWidth = 51;
            consultarNivelDataGridView.Size = new Size(479, 155);
            consultarNivelDataGridView.TabIndex = 9;
            // 
            // consultarNivelbutton
            // 
            consultarNivelbutton.BackColor = SystemColors.ControlDark;
            consultarNivelbutton.Location = new Point(452, 232);
            consultarNivelbutton.Name = "consultarNivelbutton";
            consultarNivelbutton.Size = new Size(94, 29);
            consultarNivelbutton.TabIndex = 10;
            consultarNivelbutton.Text = "Consultar";
            consultarNivelbutton.UseVisualStyleBackColor = false;
            consultarNivelbutton.Click += consultarNivelbutton_Click;
            // 
            // ucNiveles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(consultarNivelbutton);
            Controls.Add(consultarNivelDataGridView);
            Controls.Add(label1);
            Controls.Add(consultarNivelTextBox);
            Controls.Add(label2);
            Controls.Add(registrarNivelButton);
            Controls.Add(nivelLabel);
            Controls.Add(descripcionNivelLabel);
            Controls.Add(nivelTextBox);
            Controls.Add(descripcionNivelTextBox);
            Controls.Add(crearNuevoNivelLabel);
            Name = "ucNiveles";
            Size = new Size(1902, 1002);
            Load += ucNiveles_Load;
            ((System.ComponentModel.ISupportInitialize)consultarNivelDataGridView).EndInit();
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
        private Label label1;
        private TextBox consultarNivelTextBox;
        private Label label2;
        private DataGridView consultarNivelDataGridView;
        private Button consultarNivelbutton;
    }
}
