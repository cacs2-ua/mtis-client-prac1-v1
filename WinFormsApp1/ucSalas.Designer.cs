namespace WinFormsApp1
{
    partial class ucSalas
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
            idModificarSalaTextBox = new TextBox();
            label5 = new Label();
            modificarSalaButton = new Button();
            crearSalaButton = new Button();
            label4 = new Label();
            codigoSalaModificarTextBox = new TextBox();
            label24 = new Label();
            consultarSalasDataGridView = new DataGridView();
            consultarSalaButton = new Button();
            codigoSalaConsultarSalaTextBox = new TextBox();
            label22 = new Label();
            label23 = new Label();
            eliminarSalaButton = new Button();
            codigoSalaEliminarSalaTextBox = new TextBox();
            label21 = new Label();
            label20 = new Label();
            nivelModificarSalaTextBox = new TextBox();
            label14 = new Label();
            nombreModificarSalaTextBox = new TextBox();
            label15 = new Label();
            label10 = new Label();
            nivelRegistrarSalaTextBox = new TextBox();
            label3 = new Label();
            nombreRegistrarSalaTextBox = new TextBox();
            label2 = new Label();
            codigoSalaCrearSalaTextBox = new TextBox();
            nifNieLabel = new Label();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)consultarSalasDataGridView).BeginInit();
            SuspendLayout();
            // 
            // idModificarSalaTextBox
            // 
            idModificarSalaTextBox.Location = new Point(724, 452);
            idModificarSalaTextBox.Name = "idModificarSalaTextBox";
            idModificarSalaTextBox.Size = new Size(370, 27);
            idModificarSalaTextBox.TabIndex = 107;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(682, 455);
            label5.Name = "label5";
            label5.Size = new Size(22, 20);
            label5.TabIndex = 106;
            label5.Text = "id";
            // 
            // modificarSalaButton
            // 
            modificarSalaButton.BackColor = SystemColors.ControlDark;
            modificarSalaButton.Location = new Point(1001, 657);
            modificarSalaButton.Name = "modificarSalaButton";
            modificarSalaButton.Size = new Size(94, 29);
            modificarSalaButton.TabIndex = 105;
            modificarSalaButton.Text = "Modificar";
            modificarSalaButton.UseVisualStyleBackColor = false;
            // 
            // crearSalaButton
            // 
            crearSalaButton.BackColor = SystemColors.ControlDark;
            crearSalaButton.Location = new Point(425, 605);
            crearSalaButton.Name = "crearSalaButton";
            crearSalaButton.Size = new Size(94, 29);
            crearSalaButton.TabIndex = 104;
            crearSalaButton.Text = "Crear";
            crearSalaButton.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(643, 63);
            label4.Name = "label4";
            label4.Size = new Size(332, 48);
            label4.TabIndex = 103;
            label4.Text = "Servicio \"Salas\"";
            // 
            // codigoSalaModificarTextBox
            // 
            codigoSalaModificarTextBox.Location = new Point(724, 505);
            codigoSalaModificarTextBox.Name = "codigoSalaModificarTextBox";
            codigoSalaModificarTextBox.Size = new Size(370, 27);
            codigoSalaModificarTextBox.TabIndex = 102;
            // 
            // label24
            // 
            label24.AutoSize = true;
            label24.Location = new Point(620, 507);
            label24.Name = "label24";
            label24.Size = new Size(84, 20);
            label24.TabIndex = 101;
            label24.Text = "codigoSala";
            // 
            // consultarSalasDataGridView
            // 
            consultarSalasDataGridView.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            consultarSalasDataGridView.Location = new Point(547, 192);
            consultarSalasDataGridView.Name = "consultarSalasDataGridView";
            consultarSalasDataGridView.RowHeadersWidth = 51;
            consultarSalasDataGridView.Size = new Size(1313, 105);
            consultarSalasDataGridView.TabIndex = 100;
            // 
            // consultarSalaButton
            // 
            consultarSalaButton.BackColor = SystemColors.ControlDark;
            consultarSalaButton.Location = new Point(417, 268);
            consultarSalaButton.Name = "consultarSalaButton";
            consultarSalaButton.Size = new Size(94, 29);
            consultarSalaButton.TabIndex = 99;
            consultarSalaButton.Text = "Consultar";
            consultarSalaButton.UseVisualStyleBackColor = false;
            consultarSalaButton.Click += consultarSalaButton_Click;
            // 
            // codigoSalaConsultarSalaTextBox
            // 
            codigoSalaConsultarSalaTextBox.Location = new Point(141, 214);
            codigoSalaConsultarSalaTextBox.Name = "codigoSalaConsultarSalaTextBox";
            codigoSalaConsultarSalaTextBox.Size = new Size(370, 27);
            codigoSalaConsultarSalaTextBox.TabIndex = 98;
            // 
            // label22
            // 
            label22.AutoSize = true;
            label22.Location = new Point(51, 214);
            label22.Name = "label22";
            label22.Size = new Size(84, 20);
            label22.TabIndex = 97;
            label22.Text = "codigoSala";
            // 
            // label23
            // 
            label23.AutoSize = true;
            label23.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label23.ForeColor = Color.FromArgb(128, 128, 255);
            label23.Location = new Point(177, 134);
            label23.Name = "label23";
            label23.Size = new Size(313, 46);
            label23.TabIndex = 96;
            label23.Text = "Consultar una sala";
            // 
            // eliminarSalaButton
            // 
            eliminarSalaButton.BackColor = SystemColors.ControlDark;
            eliminarSalaButton.Location = new Point(1554, 503);
            eliminarSalaButton.Name = "eliminarSalaButton";
            eliminarSalaButton.Size = new Size(94, 29);
            eliminarSalaButton.TabIndex = 95;
            eliminarSalaButton.Text = "Eliminar";
            eliminarSalaButton.UseVisualStyleBackColor = false;
            // 
            // codigoSalaEliminarSalaTextBox
            // 
            codigoSalaEliminarSalaTextBox.Location = new Point(1278, 452);
            codigoSalaEliminarSalaTextBox.Name = "codigoSalaEliminarSalaTextBox";
            codigoSalaEliminarSalaTextBox.Size = new Size(370, 27);
            codigoSalaEliminarSalaTextBox.TabIndex = 94;
            // 
            // label21
            // 
            label21.AutoSize = true;
            label21.Location = new Point(1168, 456);
            label21.Name = "label21";
            label21.Size = new Size(84, 20);
            label21.TabIndex = 93;
            label21.Text = "codigoSala";
            // 
            // label20
            // 
            label20.AutoSize = true;
            label20.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label20.ForeColor = Color.FromArgb(128, 128, 255);
            label20.Location = new Point(1322, 364);
            label20.Name = "label20";
            label20.Size = new Size(291, 46);
            label20.TabIndex = 92;
            label20.Text = "Eliminar una sala";
            // 
            // nivelModificarSalaTextBox
            // 
            nivelModificarSalaTextBox.Location = new Point(725, 615);
            nivelModificarSalaTextBox.Name = "nivelModificarSalaTextBox";
            nivelModificarSalaTextBox.Size = new Size(370, 27);
            nivelModificarSalaTextBox.TabIndex = 91;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(664, 618);
            label14.Name = "label14";
            label14.Size = new Size(40, 20);
            label14.TabIndex = 90;
            label14.Text = "nivel";
            // 
            // nombreModificarSalaTextBox
            // 
            nombreModificarSalaTextBox.Location = new Point(725, 559);
            nombreModificarSalaTextBox.Name = "nombreModificarSalaTextBox";
            nombreModificarSalaTextBox.Size = new Size(370, 27);
            nombreModificarSalaTextBox.TabIndex = 89;
            // 
            // label15
            // 
            label15.AutoSize = true;
            label15.Location = new Point(643, 564);
            label15.Name = "label15";
            label15.Size = new Size(61, 20);
            label15.TabIndex = 88;
            label15.Text = "nombre";
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label10.ForeColor = Color.FromArgb(128, 128, 255);
            label10.Location = new Point(763, 364);
            label10.Name = "label10";
            label10.Size = new Size(315, 46);
            label10.TabIndex = 87;
            label10.Text = "Modificar una sala";
            // 
            // nivelRegistrarSalaTextBox
            // 
            nivelRegistrarSalaTextBox.Location = new Point(149, 559);
            nivelRegistrarSalaTextBox.Name = "nivelRegistrarSalaTextBox";
            nivelRegistrarSalaTextBox.Size = new Size(370, 27);
            nivelRegistrarSalaTextBox.TabIndex = 86;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(95, 562);
            label3.Name = "label3";
            label3.Size = new Size(40, 20);
            label3.TabIndex = 85;
            label3.Text = "nivel";
            // 
            // nombreRegistrarSalaTextBox
            // 
            nombreRegistrarSalaTextBox.Location = new Point(149, 505);
            nombreRegistrarSalaTextBox.Name = "nombreRegistrarSalaTextBox";
            nombreRegistrarSalaTextBox.Size = new Size(370, 27);
            nombreRegistrarSalaTextBox.TabIndex = 84;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(74, 507);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 83;
            label2.Text = "nombre";
            // 
            // codigoSalaCrearSalaTextBox
            // 
            codigoSalaCrearSalaTextBox.Location = new Point(149, 449);
            codigoSalaCrearSalaTextBox.Name = "codigoSalaCrearSalaTextBox";
            codigoSalaCrearSalaTextBox.Size = new Size(370, 27);
            codigoSalaCrearSalaTextBox.TabIndex = 82;
            // 
            // nifNieLabel
            // 
            nifNieLabel.AutoSize = true;
            nifNieLabel.Location = new Point(51, 452);
            nifNieLabel.Name = "nifNieLabel";
            nifNieLabel.Size = new Size(84, 20);
            nifNieLabel.TabIndex = 81;
            nifNieLabel.Text = "codigoSala";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(163, 364);
            label1.Name = "label1";
            label1.Size = new Size(348, 46);
            label1.TabIndex = 80;
            label1.Text = "Crear una nueva sala";
            // 
            // ucSalas
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(idModificarSalaTextBox);
            Controls.Add(label5);
            Controls.Add(modificarSalaButton);
            Controls.Add(crearSalaButton);
            Controls.Add(label4);
            Controls.Add(codigoSalaModificarTextBox);
            Controls.Add(label24);
            Controls.Add(consultarSalasDataGridView);
            Controls.Add(consultarSalaButton);
            Controls.Add(codigoSalaConsultarSalaTextBox);
            Controls.Add(label22);
            Controls.Add(label23);
            Controls.Add(eliminarSalaButton);
            Controls.Add(codigoSalaEliminarSalaTextBox);
            Controls.Add(label21);
            Controls.Add(label20);
            Controls.Add(nivelModificarSalaTextBox);
            Controls.Add(label14);
            Controls.Add(nombreModificarSalaTextBox);
            Controls.Add(label15);
            Controls.Add(label10);
            Controls.Add(nivelRegistrarSalaTextBox);
            Controls.Add(label3);
            Controls.Add(nombreRegistrarSalaTextBox);
            Controls.Add(label2);
            Controls.Add(codigoSalaCrearSalaTextBox);
            Controls.Add(nifNieLabel);
            Controls.Add(label1);
            Name = "ucSalas";
            Size = new Size(1902, 1002);
            ((System.ComponentModel.ISupportInitialize)consultarSalasDataGridView).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox idModificarSalaTextBox;
        private Label label5;
        private Button modificarSalaButton;
        private Button crearSalaButton;
        private Label label4;
        private TextBox codigoSalaModificarTextBox;
        private Label label24;
        private DataGridView consultarSalasDataGridView;
        private Button consultarSalaButton;
        private TextBox codigoSalaConsultarSalaTextBox;
        private Label label22;
        private Label label23;
        private Button eliminarSalaButton;
        private TextBox codigoSalaEliminarSalaTextBox;
        private Label label21;
        private Label label20;
        private TextBox nivelModificarSalaTextBox;
        private Label label14;
        private TextBox nombreModificarSalaTextBox;
        private Label label15;
        private Label label10;
        private TextBox nivelRegistrarSalaTextBox;
        private Label label3;
        private TextBox nombreRegistrarSalaTextBox;
        private Label label2;
        private TextBox codigoSalaCrearSalaTextBox;
        private Label nifNieLabel;
        private Label label1;
    }
}
