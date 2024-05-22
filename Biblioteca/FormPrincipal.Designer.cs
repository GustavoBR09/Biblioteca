namespace Biblioteca
{
    partial class FormPrincipal
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
            panelBanner = new Panel();
            toolStrip1 = new ToolStrip();
            toolStripLabel1 = new ToolStripLabel();
            tabControl1 = new TabControl();
            tabPage1 = new TabPage();
            tabPage5 = new TabPage();
            tabPage2 = new TabPage();
            tabPage3 = new TabPage();
            tabPage4 = new TabPage();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            SuspendLayout();
            // 
            // panelBanner
            // 
            panelBanner.BackColor = SystemColors.ActiveCaption;
            panelBanner.Dock = DockStyle.Top;
            panelBanner.Location = new Point(0, 0);
            panelBanner.Name = "panelBanner";
            panelBanner.Size = new Size(914, 125);
            panelBanner.TabIndex = 0;
            // 
            // toolStrip1
            // 
            toolStrip1.Dock = DockStyle.Bottom;
            toolStrip1.ImageScalingSize = new Size(20, 20);
            toolStrip1.Items.AddRange(new ToolStripItem[] { toolStripLabel1 });
            toolStrip1.Location = new Point(0, 575);
            toolStrip1.Name = "toolStrip1";
            toolStrip1.Size = new Size(914, 25);
            toolStrip1.TabIndex = 1;
            toolStrip1.Text = "toolStrip1";
            // 
            // toolStripLabel1
            // 
            toolStripLabel1.Name = "toolStripLabel1";
            toolStripLabel1.Size = new Size(124, 22);
            toolStripLabel1.Text = "Data e hora atual";
            // 
            // tabControl1
            // 
            tabControl1.Controls.Add(tabPage1);
            tabControl1.Controls.Add(tabPage5);
            tabControl1.Controls.Add(tabPage2);
            tabControl1.Controls.Add(tabPage3);
            tabControl1.Controls.Add(tabPage4);
            tabControl1.Dock = DockStyle.Fill;
            tabControl1.Location = new Point(0, 125);
            tabControl1.Name = "tabControl1";
            tabControl1.SelectedIndex = 0;
            tabControl1.Size = new Size(914, 450);
            tabControl1.TabIndex = 2;
            // 
            // tabPage1
            // 
            tabPage1.BackColor = Color.LightGray;
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Silver;
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(906, 417);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Empréstimos";
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Livros";
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.DimGray;
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(906, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Clientes";
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.MistyRose;
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(906, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Funcionários";
            // 
            // FormPrincipal
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(914, 600);
            Controls.Add(tabControl1);
            Controls.Add(toolStrip1);
            Controls.Add(panelBanner);
            Margin = new Padding(3, 4, 3, 4);
            Name = "FormPrincipal";
            Text = "FormPrincipal";
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panelBanner;
        private ToolStrip toolStrip1;
        private ToolStripLabel toolStripLabel1;
        private TabControl tabControl1;
        private TabPage tabPage1;
        private TabPage tabPage2;
        private TabPage tabPage5;
        private TabPage tabPage3;
        private TabPage tabPage4;
    }
}