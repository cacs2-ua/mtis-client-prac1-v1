﻿namespace WinFormsApp1
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
            EmpleadosToolStripMenuItem = new ToolStripMenuItem();
            ControlAccesosToolStripMenuItem = new ToolStripMenuItem();
            ControlPresenciaToolStripMenuItem = new ToolStripMenuItem();
            panelContenedor = new Panel();
            label1 = new Label();
            contextMenuStrip2.SuspendLayout();
            menuStrip1.SuspendLayout();
            panelContenedor.SuspendLayout();
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
            menuStrip1.Items.AddRange(new ToolStripItem[] { EmpleadosToolStripMenuItem, ControlAccesosToolStripMenuItem, ControlPresenciaToolStripMenuItem });
            menuStrip1.Location = new Point(0, 0);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1902, 28);
            menuStrip1.TabIndex = 4;
            menuStrip1.Text = "menuStrip1";
            // 
            // EmpleadosToolStripMenuItem
            // 
            EmpleadosToolStripMenuItem.Name = "EmpleadosToolStripMenuItem";
            EmpleadosToolStripMenuItem.Size = new Size(97, 24);
            EmpleadosToolStripMenuItem.Text = "Empleados";
            EmpleadosToolStripMenuItem.Click += EmpleadosToolStripMenuItem_Click;
            // 
            // ControlAccesosToolStripMenuItem
            // 
            ControlAccesosToolStripMenuItem.Name = "ControlAccesosToolStripMenuItem";
            ControlAccesosToolStripMenuItem.Size = new Size(125, 24);
            ControlAccesosToolStripMenuItem.Text = "ControlAccesos";
            ControlAccesosToolStripMenuItem.Click += ControlAccesosToolStripMenuItem_Click;
            // 
            // ControlPresenciaToolStripMenuItem
            // 
            ControlPresenciaToolStripMenuItem.Name = "ControlPresenciaToolStripMenuItem";
            ControlPresenciaToolStripMenuItem.Size = new Size(134, 24);
            ControlPresenciaToolStripMenuItem.Text = "ControlPresencia";
            ControlPresenciaToolStripMenuItem.Click += ControlPresenciaToolStripMenuItem_Click;
            // 
            // panelContenedor
            // 
            panelContenedor.Controls.Add(label1);
            panelContenedor.Location = new Point(0, 31);
            panelContenedor.Name = "panelContenedor";
            panelContenedor.Size = new Size(1902, 1002);
            panelContenedor.TabIndex = 46;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 20F);
            label1.ForeColor = Color.FromArgb(128, 128, 255);
            label1.Location = new Point(695, 45);
            label1.Name = "label1";
            label1.Size = new Size(312, 46);
            label1.TabIndex = 0;
            label1.Text = "MTIS-Cliente-SOAP";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1902, 1033);
            Controls.Add(panelContenedor);
            Controls.Add(menuStrip1);
            MainMenuStrip = menuStrip1;
            Name = "Form1";
            Text = "MTIS-Prac1-Cliente-SOAP";
            Load += Form1_Load;
            contextMenuStrip2.ResumeLayout(false);
            menuStrip1.ResumeLayout(false);
            menuStrip1.PerformLayout();
            panelContenedor.ResumeLayout(false);
            panelContenedor.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private ContextMenuStrip contextMenuStrip1;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem aaToolStripMenuItem;
        private MenuStrip menuStrip1;
        private ToolStripMenuItem EmpleadosToolStripMenuItem;
        private ToolStripMenuItem ControlAccesosToolStripMenuItem;
        private ToolStripMenuItem ControlPresenciaToolStripMenuItem;
        private Panel panelContenedor;
        private Label label1;
    }
}
