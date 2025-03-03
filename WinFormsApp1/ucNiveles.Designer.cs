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
            consultarNivelButton = new Button();
            label4 = new Label();
            idModificarNivelTextBox = new TextBox();
            label5 = new Label();
            modificarNivelButton = new Button();
            nivelModificarNivelTextBox = new TextBox();
            label24 = new Label();
            eliminarNivelButton = new Button();
            eliminarNivelTextBox = new TextBox();
            label21 = new Label();
            label20 = new Label();
            descripcionModificarNivelTextBox = new TextBox();
            label15 = new Label();
            label10 = new Label();
            ((System.ComponentModel.ISupportInitialize)consultarNivelDataGridView).BeginInit();
            SuspendLayout();
            // 
            // crearNuevoNivelLabel
            // 
            crearNuevoNivelLabel.AutoSize = true;
            crearNuevoNivelLabel.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            crearNuevoNivelLabel.ForeColor = Color.FromArgb(128, 128, 255);
            crearNuevoNivelLabel.Location = new Point(191, 372);
            crearNuevoNivelLabel.Name = "crearNuevoNivelLabel";
            crearNuevoNivelLabel.Size = new Size(350, 46);
            crearNuevoNivelLabel.TabIndex = 0;
            crearNuevoNivelLabel.Text = "Crear un nuevo nivel";
            // 
            // descripcionNivelTextBox
            // 
            descripcionNivelTextBox.Location = new Point(176, 519);
            descripcionNivelTextBox.Name = "descripcionNivelTextBox";
            descripcionNivelTextBox.Size = new Size(370, 27);
            descripcionNivelTextBox.TabIndex = 1;
            // 
            // nivelTextBox
            // 
            nivelTextBox.Location = new Point(176, 467);
            nivelTextBox.Name = "nivelTextBox";
            nivelTextBox.Size = new Size(370, 27);
            nivelTextBox.TabIndex = 2;
            nivelTextBox.TextChanged += nivelTextBox_TextChanged;
            // 
            // descripcionNivelLabel
            // 
            descripcionNivelLabel.AutoSize = true;
            descripcionNivelLabel.Location = new Point(67, 522);
            descripcionNivelLabel.Name = "descripcionNivelLabel";
            descripcionNivelLabel.Size = new Size(85, 20);
            descripcionNivelLabel.TabIndex = 3;
            descripcionNivelLabel.Text = "descripcion";
            // 
            // nivelLabel
            // 
            nivelLabel.AutoSize = true;
            nivelLabel.Location = new Point(112, 470);
            nivelLabel.Name = "nivelLabel";
            nivelLabel.Size = new Size(40, 20);
            nivelLabel.TabIndex = 4;
            nivelLabel.Text = "nivel";
            // 
            // registrarNivelButton
            // 
            registrarNivelButton.BackColor = SystemColors.ControlDark;
            registrarNivelButton.Location = new Point(452, 586);
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
            label1.Location = new Point(112, 189);
            label1.Name = "label1";
            label1.Size = new Size(40, 20);
            label1.TabIndex = 8;
            label1.Text = "nivel";
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
            label2.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(128, 128, 255);
            label2.Location = new Point(191, 91);
            label2.Name = "label2";
            label2.Size = new Size(311, 46);
            label2.TabIndex = 6;
            label2.Text = "Consultar un nivel";
            // 
            // consultarNivelDataGridView
            // 
            consultarNivelDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consultarNivelDataGridView.Location = new Point(664, 144);
            consultarNivelDataGridView.Name = "consultarNivelDataGridView";
            consultarNivelDataGridView.RowHeadersWidth = 51;
            consultarNivelDataGridView.Size = new Size(550, 106);
            consultarNivelDataGridView.TabIndex = 9;
            // 
            // consultarNivelButton
            // 
            consultarNivelButton.BackColor = SystemColors.ControlDark;
            consultarNivelButton.Location = new Point(452, 232);
            consultarNivelButton.Name = "consultarNivelButton";
            consultarNivelButton.Size = new Size(94, 29);
            consultarNivelButton.TabIndex = 10;
            consultarNivelButton.Text = "Consultar";
            consultarNivelButton.UseVisualStyleBackColor = false;
            consultarNivelButton.Click += consultarNivelButton_Click;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(664, 26);
            label4.Name = "label4";
            label4.Size = new Size(367, 48);
            label4.TabIndex = 104;
            label4.Text = "Servicio \"Niveles\"";
            // 
            // idModificarNivelTextBox
            // 
            idModificarNivelTextBox.Location = new Point(709, 467);
            idModificarNivelTextBox.Name = "idModificarNivelTextBox";
            idModificarNivelTextBox.Size = new Size(370, 27);
            idModificarNivelTextBox.TabIndex = 121;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(667, 470);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 120;
            label5.Text = "id";
            // 
            // modificarNivelButton
            // 
            modificarNivelButton.BackColor = SystemColors.ControlDark;
            modificarNivelButton.Location = new Point(985, 637);
            modificarNivelButton.Name = "modificarNivelButton";
            modificarNivelButton.Size = new Size(94, 29);
            modificarNivelButton.TabIndex = 119;
            modificarNivelButton.Text = "Modificar";
            modificarNivelButton.UseVisualStyleBackColor = false;
            modificarNivelButton.Click += modificarNivelButton_Click;
            // 
            // nivelModificarNivelTextBox
            // 
            nivelModificarNivelTextBox.Location = new Point(709, 520);
            nivelModificarNivelTextBox.Name = "nivelModificarNivelTextBox";
            nivelModificarNivelTextBox.Size = new Size(370, 27);
            nivelModificarNivelTextBox.TabIndex = 118;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(649, 522);
            label24.Name = "label24";
            label24.Size = new Size(40, 20);
            label24.TabIndex = 117;
            label24.Text = "nivel";
            // 
            // eliminarNivelButton
            // 
            eliminarNivelButton.BackColor = SystemColors.ControlDark;
            eliminarNivelButton.Location = new Point(1532, 518);
            eliminarNivelButton.Name = "eliminarNivelButton";
            eliminarNivelButton.Size = new Size(94, 29);
            eliminarNivelButton.TabIndex = 116;
            eliminarNivelButton.Text = "Eliminar";
            eliminarNivelButton.UseVisualStyleBackColor = false;
            // 
            // eliminarNivelTextBox
            // 
            eliminarNivelTextBox.Location = new Point(1256, 467);
            eliminarNivelTextBox.Name = "eliminarNivelTextBox";
            eliminarNivelTextBox.Size = new Size(370, 27);
            eliminarNivelTextBox.TabIndex = 115;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1191, 470);
            label21.Name = "label21";
            label21.Size = new Size(40, 20);
            label21.TabIndex = 114;
            label21.Text = "nivel";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(128, 128, 255);
            label20.Location = new Point(1300, 372);
            label20.Name = "label20";
            label20.Size = new Size(289, 46);
            label20.TabIndex = 113;
            label20.Text = "Eliminar un nivel";
            // 
            // descripcionModificarNivelTextBox
            // 
            descripcionModificarNivelTextBox.Location = new Point(710, 574);
            descripcionModificarNivelTextBox.Name = "descripcionModificarNivelTextBox";
            descripcionModificarNivelTextBox.Size = new Size(370, 27);
            descripcionModificarNivelTextBox.TabIndex = 110;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(604, 577);
            label15.Name = "label15";
            label15.Size = new Size(85, 20);
            label15.TabIndex = 109;
            label15.Text = "descripcion";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(128, 128, 255);
            label10.Location = new Point(741, 372);
            label10.Name = "label10";
            label10.Size = new Size(313, 46);
            label10.TabIndex = 108;
            label10.Text = "Modificar un nivel";
            // 
            // ucNiveles
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(idModificarNivelTextBox);
            Controls.Add(label5);
            Controls.Add(modificarNivelButton);
            Controls.Add(nivelModificarNivelTextBox);
            Controls.Add(label24);
            Controls.Add(eliminarNivelButton);
            Controls.Add(eliminarNivelTextBox);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(descripcionModificarNivelTextBox);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(label4);
            Controls.Add(consultarNivelButton);
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
        private Button consultarNivelButton;
        private Label label4;
        private TextBox idModificarNivelTextBox;
        private Label label5;
        private Button modificarNivelButton;
        private TextBox nivelModificarNivelTextBox;
        private Label label24;
        private Button eliminarNivelButton;
        private TextBox eliminarNivelTextBox;
        private Label label21;
        private Label label20;
        private TextBox descripcionModificarNivelTextBox;
        private Label label15;
        private Label label10;
    }
}
