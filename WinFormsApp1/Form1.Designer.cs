namespace WinFormsApp1
{
    partial class Form1
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
            components = new System.ComponentModel.Container();
            contextMenuStrip1 = new ContextMenuStrip(components);
            contextMenuStrip2 = new ContextMenuStrip(components);
            aaToolStripMenuItem = new ToolStripMenuItem();
            menuStrip1 = new MenuStrip();
            aaaToolStripMenuItem = new ToolStripMenuItem();
            bbbToolStripMenuItem = new ToolStripMenuItem();
            cccToolStripMenuItem = new ToolStripMenuItem();
            textBox1 = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            label19 = new Label();
            textBox3 = new TextBox();
            label4 = new Label();
            textBox4 = new TextBox();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            SuspendLayout();
            // 
            // contextMenuStrip1
            // 
            contextMenuStrip1.ImageScalingSize = new Size(20, 20);
            contextMenuStrip1.Name = "contextMenuStrip1";
            contextMenuStrip1.Size = new Size(61, 4);
            // 
            // contextMenuStrip2
            // 
            contextMenuStrip2.ImageScalingSize = new Size(20, 20);
            contextMenuStrip2.Items.AddRange(new ToolStripItem[] { aaToolStripMenuItem });
            contextMenuStrip2.Name = "contextMenuStrip2";
            contextMenuStrip2.Size = new Size(95, 28);
            // 
            // aaToolStripMenuItem
            // 
            aaToolStripMenuItem.Name = "aaToolStripMenuItem";
            aaToolStripMenuItem.Size = new Size(94, 24);
            aaToolStripMenuItem.Text = "aa";
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(20, 20);
            menuStrip1.Items.AddRange(new ToolStripItem[] { aaaToolStripMenuItem, bbbToolStripMenuItem, cccToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1001, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // aaaToolStripMenuItem
            // 
            aaaToolStripMenuItem.Name = "aaaToolStripMenuItem";
            aaaToolStripMenuItem.Size = new Size(134, 24);
            aaaToolStripMenuItem.Text = "ControlPresencia";
            aaaToolStripMenuItem.Click += aaaToolStripMenuItem_Click;
            // 
            // bbbToolStripMenuItem
            // 
            bbbToolStripMenuItem.Name = "bbbToolStripMenuItem";
            bbbToolStripMenuItem.Size = new Size(50, 24);
            bbbToolStripMenuItem.Text = "bbb";
            // 
            // cccToolStripMenuItem
            // 
            cccToolStripMenuItem.Name = "cccToolStripMenuItem";
            cccToolStripMenuItem.Size = new Size(44, 24);
            cccToolStripMenuItem.Text = "ccc";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(367, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(303, 27);
            textBox1.TabIndex = 8;
            textBox1.TextChanged += textBox1_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(426, 70);
            label1.Name = "label1";
            label1.Size = new Size(187, 20);
            label1.TabIndex = 9;
            label1.Text = "Registrar Control Presencia";
            label1.Click += label1_Click_1;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(319, 130);
            label2.Name = "label2";
            label2.Size = new Size(31, 20);
            label2.TabIndex = 10;
            label2.Text = "NIF";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(266, 186);
            label3.Name = "label3";
            label3.Size = new Size(84, 20);
            label3.TabIndex = 12;
            label3.Text = "codigoSala";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(367, 183);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(303, 27);
            textBox2.TabIndex = 11;
            textBox2.TextChanged += textBox2_TextChanged;
            // 
            // button1
            // 
            button1.BackColor = SystemColors.ButtonShadow;
            button1.Location = new Point(576, 348);
            button1.Name = "button1";
            button1.Size = new Size(94, 29);
            button1.TabIndex = 13;
            button1.Text = "Registrar";
            button1.UseVisualStyleBackColor = false;
            button1.Click += button1_Click;
            // 
            // label19
            // 
            label19.AutoSize = true;
            label19.Location = new Point(220, 236);
            label19.Name = "label19";
            label19.Size = new Size(130, 20);
            label19.TabIndex = 45;
            label19.Text = "codigoDispositivo";
            label19.Click += label19_Click;
            // 
            // textBox3
            // 
            textBox3.Location = new Point(367, 236);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(303, 27);
            textBox3.TabIndex = 44;
            textBox3.TextChanged += textBox13_TextChanged;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(266, 295);
            label4.Name = "label4";
            label4.Size = new Size(55, 20);
            label4.TabIndex = 47;
            label4.Text = "WSKey";
            // 
            // textBox4
            // 
            textBox4.Location = new Point(367, 292);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(303, 27);
            textBox4.TabIndex = 46;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1001, 408);
            Controls.Add(label4);
            Controls.Add(textBox4);
            Controls.Add(label19);
            Controls.Add(textBox3);
            Controls.Add(button1);
            Controls.Add(label3);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(textBox1);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem aaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem aaaToolStripMenuItem;
        private ToolStripMenuItem bbbToolStripMenuItem;
        private ToolStripMenuItem cccToolStripMenuItem;
        private TextBox textBox1;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox2;
        private Button button1;
        private Label label19;
        private TextBox textBox3;
        private Label label4;
        private TextBox textBox4;
    }
}
