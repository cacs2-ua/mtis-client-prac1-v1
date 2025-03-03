namespace WinFormsApp1
{
    partial class ucNotificaciones
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
            label4 = new Label();
            notificarErrorButton = new Button();
            label1 = new Label();
            emailNotificarErrorTextBox = new TextBox();
            label6 = new Label();
            notificarUsuarioValidoButton = new Button();
            label2 = new Label();
            emailNotificarUsuarioValidoTextBox = new TextBox();
            label3 = new Label();
            notificarPresenciaSalaButton = new Button();
            label5 = new Label();
            SuspendLayout();
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Microsoft Sans Serif", 25.2F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.Blue;
            label4.Location = new Point(730, 53);
            label4.Name = "label4";
            label4.Size = new Size(498, 48);
            label4.TabIndex = 105;
            label4.Text = "Servicio \"Notificaciones\"";
            // 
            // notificarErrorButton
            // 
            notificarErrorButton.BackColor = SystemColors.ControlDark;
            notificarErrorButton.Location = new Point(1488, 293);
            notificarErrorButton.Name = "notificarErrorButton";
            notificarErrorButton.Size = new Size(94, 29);
            notificarErrorButton.TabIndex = 117;
            notificarErrorButton.Text = "Notificar";
            notificarErrorButton.UseVisualStyleBackColor = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(1232, 243);
            label1.Name = "label1";
            label1.Size = new Size(46, 20);
            label1.TabIndex = 116;
            label1.Text = "email";
            // 
            // emailNotificarErrorTextBox
            // 
            emailNotificarErrorTextBox.Location = new Point(1294, 240);
            emailNotificarErrorTextBox.Name = "emailNotificarErrorTextBox";
            emailNotificarErrorTextBox.Size = new Size(288, 27);
            emailNotificarErrorTextBox.TabIndex = 115;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label6.ForeColor = Color.SlateBlue;
            label6.Location = new Point(1312, 153);
            label6.Name = "label6";
            label6.Size = new Size(252, 46);
            label6.TabIndex = 114;
            label6.Text = "Notificar error";
            // 
            // notificarUsuarioValidoButton
            // 
            notificarUsuarioValidoButton.BackColor = SystemColors.ControlDark;
            notificarUsuarioValidoButton.Location = new Point(1013, 293);
            notificarUsuarioValidoButton.Name = "notificarUsuarioValidoButton";
            notificarUsuarioValidoButton.Size = new Size(94, 29);
            notificarUsuarioValidoButton.TabIndex = 113;
            notificarUsuarioValidoButton.Text = "Notificar";
            notificarUsuarioValidoButton.UseVisualStyleBackColor = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(757, 243);
            label2.Name = "label2";
            label2.Size = new Size(46, 20);
            label2.TabIndex = 112;
            label2.Text = "email";
            // 
            // emailNotificarUsuarioValidoTextBox
            // 
            emailNotificarUsuarioValidoTextBox.Location = new Point(819, 240);
            emailNotificarUsuarioValidoTextBox.Name = "emailNotificarUsuarioValidoTextBox";
            emailNotificarUsuarioValidoTextBox.Size = new Size(288, 27);
            emailNotificarUsuarioValidoTextBox.TabIndex = 111;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.SlateBlue;
            label3.Location = new Point(787, 153);
            label3.Name = "label3";
            label3.Size = new Size(397, 46);
            label3.TabIndex = 110;
            label3.Text = "Notificar usuario valido";
            // 
            // notificarPresenciaSalaButton
            // 
            notificarPresenciaSalaButton.BackColor = SystemColors.ControlDark;
            notificarPresenciaSalaButton.Location = new Point(403, 227);
            notificarPresenciaSalaButton.Name = "notificarPresenciaSalaButton";
            notificarPresenciaSalaButton.Size = new Size(148, 53);
            notificarPresenciaSalaButton.TabIndex = 109;
            notificarPresenciaSalaButton.Text = "Notificar";
            notificarPresenciaSalaButton.UseVisualStyleBackColor = false;
            notificarPresenciaSalaButton.Click += notificarPresenciaSalaButton_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Segoe UI", 19.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label5.ForeColor = Color.SlateBlue;
            label5.Location = new Point(263, 153);
            label5.Name = "label5";
            label5.Size = new Size(440, 46);
            label5.TabIndex = 106;
            label5.Text = "Notificar presencia en sala";
            // 
            // ucNotificaciones
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            Controls.Add(notificarErrorButton);
            Controls.Add(label1);
            Controls.Add(emailNotificarErrorTextBox);
            Controls.Add(label6);
            Controls.Add(notificarUsuarioValidoButton);
            Controls.Add(label2);
            Controls.Add(emailNotificarUsuarioValidoTextBox);
            Controls.Add(label3);
            Controls.Add(notificarPresenciaSalaButton);
            Controls.Add(label5);
            Controls.Add(label4);
            Name = "ucNotificaciones";
            Size = new Size(1902, 1002);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label4;
        private Button notificarErrorButton;
        private Label label1;
        private TextBox emailNotificarErrorTextBox;
        private Label label6;
        private Button notificarUsuarioValidoButton;
        private Label label2;
        private TextBox emailNotificarUsuarioValidoTextBox;
        private Label label3;
        private Button notificarPresenciaSalaButton;
        private Label label5;
    }
}
