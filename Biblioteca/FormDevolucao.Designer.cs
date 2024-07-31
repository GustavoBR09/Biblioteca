namespace Biblioteca
{
    partial class FormDevolucao
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            comboBoxClienteDevolucao = new ComboBox();
            buttonDevolver = new Button();
            comboBoxLivroDevolucao = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            labelCadastro = new Label();
            SuspendLayout();
            // 
            // comboBoxClienteDevolucao
            // 
            comboBoxClienteDevolucao.DisplayMember = "Nome";
            comboBoxClienteDevolucao.FormattingEnabled = true;
            comboBoxClienteDevolucao.Location = new Point(46, 85);
            comboBoxClienteDevolucao.Name = "comboBoxClienteDevolucao";
            comboBoxClienteDevolucao.Size = new Size(211, 28);
            comboBoxClienteDevolucao.TabIndex = 0;
            comboBoxClienteDevolucao.ValueMember = "Id";
            comboBoxClienteDevolucao.SelectedIndexChanged += comboBoxClienteDevolucao_SelectedIndexChanged;
            // 
            // buttonDevolver
            // 
            buttonDevolver.Location = new Point(46, 230);
            buttonDevolver.Name = "buttonDevolver";
            buttonDevolver.Size = new Size(94, 29);
            buttonDevolver.TabIndex = 1;
            buttonDevolver.Text = "Devolver";
            buttonDevolver.UseVisualStyleBackColor = true;
            buttonDevolver.Click += buttonDevolver_Click;
            // 
            // comboBoxLivroDevolucao
            // 
            comboBoxLivroDevolucao.DisplayMember = "Titulo";
            comboBoxLivroDevolucao.FormattingEnabled = true;
            comboBoxLivroDevolucao.Location = new Point(46, 166);
            comboBoxLivroDevolucao.Name = "comboBoxLivroDevolucao";
            comboBoxLivroDevolucao.Size = new Size(211, 28);
            comboBoxLivroDevolucao.TabIndex = 2;
            comboBoxLivroDevolucao.ValueMember = "Id";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(46, 62);
            label1.Name = "label1";
            label1.Size = new Size(61, 20);
            label1.TabIndex = 3;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(46, 143);
            label2.Name = "label2";
            label2.Size = new Size(125, 20);
            label2.TabIndex = 4;
            label2.Text = "Livro a devolver:";
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelCadastro.ForeColor = SystemColors.ControlText;
            labelCadastro.Location = new Point(104, 9);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(295, 41);
            labelCadastro.TabIndex = 20;
            labelCadastro.Text = "Devolução de livros";
            // 
            // FormDevolucao
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.AppWorkspace;
            ClientSize = new Size(494, 299);
            Controls.Add(labelCadastro);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(comboBoxLivroDevolucao);
            Controls.Add(buttonDevolver);
            Controls.Add(comboBoxClienteDevolucao);
            ForeColor = SystemColors.ActiveCaptionText;
            Name = "FormDevolucao";
            Text = "FormDevolucao";
            Load += FormDevolucao_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBoxClienteDevolucao;
        private Button buttonDevolver;
        private ComboBox comboBoxLivroDevolucao;
        private Label label1;
        private Label label2;
        private Label labelCadastro;
    }
}