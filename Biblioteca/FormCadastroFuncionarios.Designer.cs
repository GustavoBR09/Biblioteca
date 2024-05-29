namespace Biblioteca
{
    partial class FormCadastroFuncionarios
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
            labelCPF = new Label();
            labelEmail = new Label();
            labelNome = new Label();
            textBoxEmail = new TextBox();
            textBoxNome = new TextBox();
            textBoxCarteiraTrabalho = new TextBox();
            labelTelefone = new Label();
            textBoxTelefone = new TextBox();
            panel1 = new Panel();
            buttonCadastrar = new Button();
            button1 = new Button();
            labelInformacao = new Label();
            labelCadastro = new Label();
            labelFuncionario = new Label();
            label1 = new Label();
            label2 = new Label();
            textBoxSenha = new TextBox();
            textBoxNomeUsuario = new TextBox();
            textBoxComplemento = new TextBox();
            comboBoxEstado = new ComboBox();
            labelComplemento = new Label();
            labelEndereco = new Label();
            labelNumero = new Label();
            textBoxRua = new TextBox();
            labelEstado = new Label();
            textBoxCidade = new TextBox();
            labelBairro = new Label();
            textBoxNumero = new TextBox();
            labelCidade = new Label();
            textBoxBairro = new TextBox();
            labelRua = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelCPF.ForeColor = SystemColors.ControlText;
            labelCPF.Location = new Point(9, 334);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(210, 20);
            labelCPF.TabIndex = 14;
            labelCPF.Text = "Insira a Carteiro de Trabalho:";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEmail.ForeColor = SystemColors.ControlText;
            labelEmail.Location = new Point(12, 171);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(110, 20);
            labelEmail.TabIndex = 13;
            labelEmail.Text = "Digite o email:";
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelNome.ForeColor = SystemColors.ControlText;
            labelNome.Location = new Point(12, 94);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(109, 20);
            labelNome.TabIndex = 12;
            labelNome.Text = "Insira o nome:";
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(12, 203);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(235, 27);
            textBoxEmail.TabIndex = 10;
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(9, 122);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(235, 27);
            textBoxNome.TabIndex = 9;
            // 
            // textBoxCarteiraTrabalho
            // 
            textBoxCarteiraTrabalho.Location = new Point(9, 367);
            textBoxCarteiraTrabalho.Name = "textBoxCarteiraTrabalho";
            textBoxCarteiraTrabalho.Size = new Size(235, 27);
            textBoxCarteiraTrabalho.TabIndex = 15;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelTelefone.ForeColor = SystemColors.ControlText;
            labelTelefone.Location = new Point(9, 254);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(130, 20);
            labelTelefone.TabIndex = 17;
            labelTelefone.Text = "Digite o telefone:";
            // 
            // textBoxTelefone
            // 
            textBoxTelefone.Location = new Point(9, 286);
            textBoxTelefone.Name = "textBoxTelefone";
            textBoxTelefone.Size = new Size(235, 27);
            textBoxTelefone.TabIndex = 16;
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(button1);
            panel1.Controls.Add(labelInformacao);
            panel1.Location = new Point(264, 0);
            panel1.Name = "panel1";
            panel1.Size = new Size(281, 451);
            panel1.TabIndex = 18;
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.ForeColor = SystemColors.ActiveCaptionText;
            buttonCadastrar.Location = new Point(77, 360);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(121, 27);
            buttonCadastrar.TabIndex = 50;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            buttonCadastrar.Click += buttonCadastrar_Click;
            // 
            // button1
            // 
            button1.ForeColor = SystemColors.ActiveCaptionText;
            button1.Location = new Point(17, 399);
            button1.Name = "button1";
            button1.Size = new Size(251, 27);
            button1.TabIndex = 51;
            button1.Text = "Enviar e cadastrar novo funcionário";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // labelInformacao
            // 
            labelInformacao.AutoSize = true;
            labelInformacao.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelInformacao.ForeColor = SystemColors.ControlText;
            labelInformacao.Location = new Point(52, 116);
            labelInformacao.Name = "labelInformacao";
            labelInformacao.Size = new Size(161, 20);
            labelInformacao.TabIndex = 50;
            labelInformacao.Text = "Informações de Login";
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelCadastro.ForeColor = SystemColors.ControlText;
            labelCadastro.Location = new Point(9, 9);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(187, 41);
            labelCadastro.TabIndex = 19;
            labelCadastro.Text = "Cadastro do";
            // 
            // labelFuncionario
            // 
            labelFuncionario.AutoSize = true;
            labelFuncionario.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic);
            labelFuncionario.ForeColor = SystemColors.ControlText;
            labelFuncionario.Location = new Point(9, 50);
            labelFuncionario.Name = "labelFuncionario";
            labelFuncionario.Size = new Size(186, 41);
            labelFuncionario.TabIndex = 20;
            labelFuncionario.Text = "Funcionário";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Gray;
            label1.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label1.ForeColor = SystemColors.ControlText;
            label1.Location = new Point(284, 234);
            label1.Name = "label1";
            label1.Size = new Size(110, 20);
            label1.TabIndex = 24;
            label1.Text = "Digite a senha:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Gray;
            label2.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            label2.ForeColor = SystemColors.ControlText;
            label2.Location = new Point(284, 157);
            label2.Name = "label2";
            label2.Size = new Size(182, 20);
            label2.TabIndex = 23;
            label2.Text = "Insira o nome de usuário:";
            // 
            // textBoxSenha
            // 
            textBoxSenha.Location = new Point(284, 266);
            textBoxSenha.Name = "textBoxSenha";
            textBoxSenha.Size = new Size(235, 27);
            textBoxSenha.TabIndex = 22;
            // 
            // textBoxNomeUsuario
            // 
            textBoxNomeUsuario.Location = new Point(281, 185);
            textBoxNomeUsuario.Name = "textBoxNomeUsuario";
            textBoxNomeUsuario.Size = new Size(235, 27);
            textBoxNomeUsuario.TabIndex = 21;
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(556, 185);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(232, 27);
            textBoxComplemento.TabIndex = 42;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "", "AL", "", "AP", "", "AM", "", "BA", "", "CE", "", "DF", "", "ES", "", "GO", "", "MA", "", "MT", "", "MS", "", "MG", "", "PA", "", "PB", "", "PR", "", "PE", "", "PI", "", "RR", "", "RO", "", "RJ", "", "RN", "", "RS", "", "SC", "", "SP", "", "SE", "", "TO" });
            comboBoxEstado.Location = new Point(686, 398);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(100, 28);
            comboBoxEstado.TabIndex = 49;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelComplemento.ForeColor = SystemColors.ControlText;
            labelComplemento.Location = new Point(556, 157);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(109, 20);
            labelComplemento.TabIndex = 48;
            labelComplemento.Text = "Complemento:";
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold);
            labelEndereco.ForeColor = SystemColors.ControlText;
            labelEndereco.Location = new Point(598, 50);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(132, 20);
            labelEndereco.TabIndex = 37;
            labelEndereco.Text = "Digite o Endereço";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelNumero.ForeColor = SystemColors.ControlText;
            labelNumero.Location = new Point(556, 367);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(70, 20);
            labelNumero.TabIndex = 47;
            labelNumero.Text = "Número:";
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(556, 116);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(232, 27);
            textBoxRua.TabIndex = 38;
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelEstado.ForeColor = SystemColors.ControlText;
            labelEstado.Location = new Point(686, 367);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(58, 20);
            labelEstado.TabIndex = 46;
            labelEstado.Text = "Estado:";
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(556, 328);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(232, 27);
            textBoxCidade.TabIndex = 39;
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelBairro.ForeColor = SystemColors.ControlText;
            labelBairro.Location = new Point(561, 234);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(55, 20);
            labelBairro.TabIndex = 45;
            labelBairro.Text = "Bairro:";
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(556, 399);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(97, 27);
            textBoxNumero.TabIndex = 40;
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelCidade.ForeColor = SystemColors.ControlText;
            labelCidade.Location = new Point(556, 305);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(60, 20);
            labelCidade.TabIndex = 44;
            labelCidade.Text = "Cidade:";
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(556, 257);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(233, 27);
            textBoxBairro.TabIndex = 41;
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold);
            labelRua.ForeColor = SystemColors.ControlText;
            labelRua.Location = new Point(556, 88);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(39, 20);
            labelRua.TabIndex = 43;
            labelRua.Text = "Rua:";
            // 
            // FormCadastroFuncionarios
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            ClientSize = new Size(800, 450);
            Controls.Add(textBoxComplemento);
            Controls.Add(textBoxRua);
            Controls.Add(comboBoxEstado);
            Controls.Add(labelComplemento);
            Controls.Add(labelEndereco);
            Controls.Add(labelNumero);
            Controls.Add(labelEstado);
            Controls.Add(textBoxCidade);
            Controls.Add(labelBairro);
            Controls.Add(textBoxNumero);
            Controls.Add(labelCidade);
            Controls.Add(textBoxBairro);
            Controls.Add(labelRua);
            Controls.Add(label1);
            Controls.Add(label2);
            Controls.Add(textBoxSenha);
            Controls.Add(textBoxNomeUsuario);
            Controls.Add(labelFuncionario);
            Controls.Add(labelCadastro);
            Controls.Add(panel1);
            Controls.Add(labelTelefone);
            Controls.Add(textBoxTelefone);
            Controls.Add(textBoxCarteiraTrabalho);
            Controls.Add(labelCPF);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            ForeColor = SystemColors.AppWorkspace;
            Name = "FormCadastroFuncionarios";
            Text = "Cadastro de Funcionários";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private Label labelCPF;
        private Label labelEmail;
        private Label labelNome;
        private TextBox textBoxEmail;
        private TextBox textBoxNome;
        private TextBox textBoxCarteiraTrabalho;
        private Label labelTelefone;
        private TextBox textBoxTelefone;
        private Panel panel1;
        private Label labelCadastro;
        private Label labelFuncionario;
        private Label label1;
        private Label label2;
        private TextBox textBoxSenha;
        private TextBox textBoxNomeUsuario;
        private Label labelInformacao;
        private TextBox textBoxComplemento;
        private ComboBox comboBoxEstado;
        private Label labelComplemento;
        private Label labelEndereco;
        private Label labelNumero;
        private TextBox textBoxRua;
        private Label labelEstado;
        private TextBox textBoxCidade;
        private Label labelBairro;
        private TextBox textBoxNumero;
        private Label labelCidade;
        private TextBox textBoxBairro;
        private Label labelRua;
        private Button buttonCadastrar;
        private Button button1;
    }
}