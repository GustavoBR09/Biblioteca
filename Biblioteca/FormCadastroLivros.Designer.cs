namespace Biblioteca
{
    partial class FormCadastroLivros
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
            panel1 = new Panel();
            numericUpDownQuantidade = new NumericUpDown();
            numericUpDownNumeroPaginas = new NumericUpDown();
            buttonCadastrarNovo = new Button();
            buttonCadastrar = new Button();
            labelAnoPublicacao = new Label();
            labelQuantidade = new Label();
            textBoxAnoPublicacao = new TextBox();
            labelNumeroPaginas = new Label();
            labelGenero = new Label();
            labelAutor = new Label();
            labelTitulo = new Label();
            textBoxAutor = new TextBox();
            textBoxTitulo = new TextBox();
            labelCadastroLivros = new Label();
            comboBoxGeneroLiterario = new ComboBox();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeroPaginas).BeginInit();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(numericUpDownQuantidade);
            panel1.Controls.Add(numericUpDownNumeroPaginas);
            panel1.Controls.Add(buttonCadastrarNovo);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(labelAnoPublicacao);
            panel1.Controls.Add(labelQuantidade);
            panel1.Controls.Add(textBoxAnoPublicacao);
            panel1.Controls.Add(labelNumeroPaginas);
            panel1.Location = new Point(406, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(393, 451);
            panel1.TabIndex = 19;
            // 
            // numericUpDownQuantidade
            // 
            numericUpDownQuantidade.Location = new Point(82, 313);
            numericUpDownQuantidade.Name = "numericUpDownQuantidade";
            numericUpDownQuantidade.Size = new Size(235, 27);
            numericUpDownQuantidade.TabIndex = 41;
            // 
            // numericUpDownNumeroPaginas
            // 
            numericUpDownNumeroPaginas.Location = new Point(82, 230);
            numericUpDownNumeroPaginas.Name = "numericUpDownNumeroPaginas";
            numericUpDownNumeroPaginas.Size = new Size(235, 27);
            numericUpDownNumeroPaginas.TabIndex = 40;
            // 
            // buttonCadastrarNovo
            // 
            buttonCadastrarNovo.ForeColor = SystemColors.ActiveCaptionText;
            buttonCadastrarNovo.Location = new Point(164, 402);
            buttonCadastrarNovo.Name = "buttonCadastrarNovo";
            buttonCadastrarNovo.Size = new Size(222, 27);
            buttonCadastrarNovo.TabIndex = 39;
            buttonCadastrarNovo.Text = "Enviar e cadastrar novo livro";
            buttonCadastrarNovo.UseVisualStyleBackColor = true;
            buttonCadastrarNovo.Click += buttonCadastrarNovo_Click;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCadastrar.Location = new Point(13, 402);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(121, 27);
            buttonCadastrar.TabIndex = 38;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // labelAnoPublicacao
            // 
            labelAnoPublicacao.AutoSize = true;
            labelAnoPublicacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAnoPublicacao.ForeColor = SystemColors.ControlText;
            labelAnoPublicacao.Location = new Point(85, 120);
            labelAnoPublicacao.Name = "labelAnoPublicacao";
            labelAnoPublicacao.Size = new Size(194, 20);
            labelAnoPublicacao.TabIndex = 31;
            labelAnoPublicacao.Text = "Insira o ano de publicação:";
            // 
            // labelQuantidade
            // 
            labelQuantidade.AutoSize = true;
            labelQuantidade.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelQuantidade.ForeColor = SystemColors.ControlText;
            labelQuantidade.Location = new Point(85, 280);
            labelQuantidade.Name = "labelQuantidade";
            labelQuantidade.Size = new Size(222, 20);
            labelQuantidade.TabIndex = 33;
            labelQuantidade.Text = "Insira a quantidade disponível:";
            // 
            // textBoxAnoPublicacao
            // 
            textBoxAnoPublicacao.Location = new Point(82, 148);
            textBoxAnoPublicacao.Name = "textBoxAnoPublicacao";
            textBoxAnoPublicacao.Size = new Size(235, 27);
            textBoxAnoPublicacao.TabIndex = 29;
            // 
            // labelNumeroPaginas
            // 
            labelNumeroPaginas.AutoSize = true;
            labelNumeroPaginas.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNumeroPaginas.ForeColor = SystemColors.ControlText;
            labelNumeroPaginas.Location = new Point(85, 197);
            labelNumeroPaginas.Name = "labelNumeroPaginas";
            labelNumeroPaginas.Size = new Size(206, 20);
            labelNumeroPaginas.TabIndex = 32;
            labelNumeroPaginas.Text = "Digite o número de paginas:";
            // 
            // labelGenero
            // 
            labelGenero.AutoSize = true;
            labelGenero.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelGenero.ForeColor = SystemColors.ControlText;
            labelGenero.Location = new Point(72, 280);
            labelGenero.Name = "labelGenero";
            labelGenero.Size = new Size(177, 20);
            labelGenero.TabIndex = 24;
            labelGenero.Text = "Insira o gênero literário:";
            // 
            // labelAutor
            // 
            labelAutor.AutoSize = true;
            labelAutor.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelAutor.ForeColor = SystemColors.ControlText;
            labelAutor.Location = new Point(72, 197);
            labelAutor.Name = "labelAutor";
            labelAutor.Size = new Size(111, 20);
            labelAutor.TabIndex = 23;
            labelAutor.Text = "Digite o autor:";
            // 
            // labelTitulo
            // 
            labelTitulo.AutoSize = true;
            labelTitulo.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTitulo.ForeColor = SystemColors.ControlText;
            labelTitulo.Location = new Point(72, 120);
            labelTitulo.Name = "labelTitulo";
            labelTitulo.Size = new Size(107, 20);
            labelTitulo.TabIndex = 22;
            labelTitulo.Text = "Insira o título:";
            // 
            // textBoxAutor
            // 
            textBoxAutor.Location = new Point(72, 229);
            textBoxAutor.Name = "textBoxAutor";
            textBoxAutor.Size = new Size(235, 27);
            textBoxAutor.TabIndex = 21;
            // 
            // textBoxTitulo
            // 
            textBoxTitulo.Location = new Point(69, 148);
            textBoxTitulo.Name = "textBoxTitulo";
            textBoxTitulo.Size = new Size(235, 27);
            textBoxTitulo.TabIndex = 20;
            // 
            // labelCadastroLivros
            // 
            labelCadastroLivros.AutoSize = true;
            labelCadastroLivros.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelCadastroLivros.ForeColor = SystemColors.ControlText;
            labelCadastroLivros.Location = new Point(54, 38);
            labelCadastroLivros.Name = "labelCadastroLivros";
            labelCadastroLivros.Size = new Size(277, 41);
            labelCadastroLivros.TabIndex = 28;
            labelCadastroLivros.Text = "Cadastro de Livros";
            // 
            // comboBoxGeneroLiterario
            // 
            comboBoxGeneroLiterario.FormattingEnabled = true;
            comboBoxGeneroLiterario.Location = new Point(69, 312);
            comboBoxGeneroLiterario.Name = "comboBoxGeneroLiterario";
            comboBoxGeneroLiterario.Size = new Size(238, 28);
            comboBoxGeneroLiterario.TabIndex = 29;
            // 
            // FormCadastroLivros
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(comboBoxGeneroLiterario);
            Controls.Add(labelCadastroLivros);
            Controls.Add(labelGenero);
            Controls.Add(labelAutor);
            Controls.Add(labelTitulo);
            Controls.Add(textBoxAutor);
            Controls.Add(textBoxTitulo);
            Controls.Add(panel1);
            ForeColor = SystemColors.AppWorkspace;
            Name = "FormCadastroLivros";
            Text = "Cadastro de Livros";
            Load += FormCadastroLivros_Load;
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)numericUpDownQuantidade).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDownNumeroPaginas).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private Label labelGenero;
        private Label labelAutor;
        private Label labelTitulo;
        private TextBox textBoxAutor;
        private TextBox textBoxTitulo;
        private Label labelCadastroLivros;
        private Label labelAnoPublicacao;
        private Label labelQuantidade;
        private TextBox textBoxAnoPublicacao;
        private Label labelNumeroPaginas;
        private Button buttonCadastrarNovo;
        private Button buttonCadastrar;
        private NumericUpDown numericUpDownQuantidade;
        private NumericUpDown numericUpDownNumeroPaginas;
        private ComboBox comboBoxGeneroLiterario;
    }
}