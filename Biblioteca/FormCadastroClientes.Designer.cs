namespace Biblioteca
{
    partial class FormCadastroClientes
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
            textBoxNome = new TextBox();
            textBoxEmail = new TextBox();
            maskedTextBoxCPF = new MaskedTextBox();
            labelNome = new Label();
            labelEmail = new Label();
            labelCPF = new Label();
            panel1 = new Panel();
            button1 = new Button();
            comboBoxEstado = new ComboBox();
            labelComplemento = new Label();
            labelNumero = new Label();
            labelEstado = new Label();
            labelBairro = new Label();
            labelCidade = new Label();
            labelRua = new Label();
            textBoxComplemento = new TextBox();
            textBoxBairro = new TextBox();
            textBoxNumero = new TextBox();
            textBoxCidade = new TextBox();
            textBoxRua = new TextBox();
            labelEndereco = new Label();
            buttonCadastrar = new Button();
            labelCadastro = new Label();
            maskedTextBox1 = new MaskedTextBox();
            labelTelefone = new Label();
            panel1.SuspendLayout();
            SuspendLayout();
            // 
            // textBoxNome
            // 
            textBoxNome.Location = new Point(40, 115);
            textBoxNome.Name = "textBoxNome";
            textBoxNome.Size = new Size(296, 27);
            textBoxNome.TabIndex = 0;
            // 
            // textBoxEmail
            // 
            textBoxEmail.Location = new Point(40, 208);
            textBoxEmail.Name = "textBoxEmail";
            textBoxEmail.Size = new Size(296, 27);
            textBoxEmail.TabIndex = 1;
            // 
            // maskedTextBoxCPF
            // 
            maskedTextBoxCPF.Location = new Point(40, 387);
            maskedTextBoxCPF.Mask = "000.000.000-00";
            maskedTextBoxCPF.Name = "maskedTextBoxCPF";
            maskedTextBoxCPF.Size = new Size(296, 27);
            maskedTextBoxCPF.TabIndex = 2;
            // 
            // labelNome
            // 
            labelNome.AutoSize = true;
            labelNome.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNome.ForeColor = SystemColors.ControlText;
            labelNome.Location = new Point(43, 87);
            labelNome.Name = "labelNome";
            labelNome.Size = new Size(105, 20);
            labelNome.TabIndex = 3;
            labelNome.Text = "Insira o nome";
            // 
            // labelEmail
            // 
            labelEmail.AutoSize = true;
            labelEmail.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEmail.Location = new Point(40, 176);
            labelEmail.Name = "labelEmail";
            labelEmail.Size = new Size(106, 20);
            labelEmail.TabIndex = 4;
            labelEmail.Text = "Digite o email";
            // 
            // labelCPF
            // 
            labelCPF.AutoSize = true;
            labelCPF.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCPF.Location = new Point(40, 355);
            labelCPF.Name = "labelCPF";
            labelCPF.Size = new Size(91, 20);
            labelCPF.TabIndex = 5;
            labelCPF.Text = "Insira o CPF";
            // 
            // panel1
            // 
            panel1.BackColor = Color.Gray;
            panel1.Controls.Add(button1);
            panel1.Controls.Add(textBoxComplemento);
            panel1.Controls.Add(comboBoxEstado);
            panel1.Controls.Add(buttonCadastrar);
            panel1.Controls.Add(labelComplemento);
            panel1.Controls.Add(labelEndereco);
            panel1.Controls.Add(labelNumero);
            panel1.Controls.Add(textBoxRua);
            panel1.Controls.Add(labelEstado);
            panel1.Controls.Add(textBoxCidade);
            panel1.Controls.Add(labelBairro);
            panel1.Controls.Add(textBoxNumero);
            panel1.Controls.Add(labelCidade);
            panel1.Controls.Add(textBoxBairro);
            panel1.Controls.Add(labelRua);
            panel1.Location = new Point(390, -2);
            panel1.Name = "panel1";
            panel1.Size = new Size(416, 460);
            panel1.TabIndex = 6;
            // 
            // button1
            // 
            button1.Location = new Point(176, 402);
            button1.Name = "button1";
            button1.Size = new Size(222, 27);
            button1.TabIndex = 37;
            button1.Text = "Enviar e cadastrar novo cliente";
            button1.UseVisualStyleBackColor = true;
            // 
            // comboBoxEstado
            // 
            comboBoxEstado.FormattingEnabled = true;
            comboBoxEstado.Items.AddRange(new object[] { "AC", "", "AL", "", "AP", "", "AM", "", "BA", "", "CE", "", "DF", "", "ES", "", "GO", "", "MA", "", "MT", "", "MS", "", "MG", "", "PA", "", "PB", "", "PR", "", "PE", "", "PI", "", "RR", "", "RO", "", "RJ", "", "RN", "", "RS", "", "SC", "", "SP", "", "SE", "", "TO" });
            comboBoxEstado.Location = new Point(225, 350);
            comboBoxEstado.Name = "comboBoxEstado";
            comboBoxEstado.Size = new Size(157, 28);
            comboBoxEstado.TabIndex = 36;
            // 
            // labelComplemento
            // 
            labelComplemento.AutoSize = true;
            labelComplemento.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelComplemento.ForeColor = SystemColors.ControlText;
            labelComplemento.Location = new Point(225, 88);
            labelComplemento.Name = "labelComplemento";
            labelComplemento.Size = new Size(109, 20);
            labelComplemento.TabIndex = 35;
            labelComplemento.Text = "Complemento:";
            // 
            // labelNumero
            // 
            labelNumero.AutoSize = true;
            labelNumero.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelNumero.ForeColor = SystemColors.ControlText;
            labelNumero.Location = new Point(33, 198);
            labelNumero.Name = "labelNumero";
            labelNumero.Size = new Size(70, 20);
            labelNumero.TabIndex = 34;
            labelNumero.Text = "Número:";
            // 
            // labelEstado
            // 
            labelEstado.AutoSize = true;
            labelEstado.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEstado.ForeColor = SystemColors.ControlText;
            labelEstado.Location = new Point(225, 319);
            labelEstado.Name = "labelEstado";
            labelEstado.Size = new Size(58, 20);
            labelEstado.TabIndex = 33;
            labelEstado.Text = "Estado:";
            // 
            // labelBairro
            // 
            labelBairro.AutoSize = true;
            labelBairro.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelBairro.ForeColor = SystemColors.ControlText;
            labelBairro.Location = new Point(225, 198);
            labelBairro.Name = "labelBairro";
            labelBairro.Size = new Size(55, 20);
            labelBairro.TabIndex = 32;
            labelBairro.Text = "Bairro:";
            // 
            // labelCidade
            // 
            labelCidade.AutoSize = true;
            labelCidade.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelCidade.ForeColor = SystemColors.ControlText;
            labelCidade.Location = new Point(33, 319);
            labelCidade.Name = "labelCidade";
            labelCidade.Size = new Size(60, 20);
            labelCidade.TabIndex = 31;
            labelCidade.Text = "Cidade:";
            // 
            // labelRua
            // 
            labelRua.AutoSize = true;
            labelRua.Font = new Font("Segoe UI Semibold", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelRua.ForeColor = SystemColors.ControlText;
            labelRua.Location = new Point(33, 88);
            labelRua.Name = "labelRua";
            labelRua.Size = new Size(39, 20);
            labelRua.TabIndex = 30;
            labelRua.Text = "Rua:";
            // 
            // textBoxComplemento
            // 
            textBoxComplemento.Location = new Point(225, 116);
            textBoxComplemento.Name = "textBoxComplemento";
            textBoxComplemento.Size = new Size(157, 27);
            textBoxComplemento.TabIndex = 29;
            // 
            // textBoxBairro
            // 
            textBoxBairro.Location = new Point(225, 230);
            textBoxBairro.Name = "textBoxBairro";
            textBoxBairro.Size = new Size(157, 27);
            textBoxBairro.TabIndex = 28;
            // 
            // textBoxNumero
            // 
            textBoxNumero.Location = new Point(33, 230);
            textBoxNumero.Name = "textBoxNumero";
            textBoxNumero.Size = new Size(157, 27);
            textBoxNumero.TabIndex = 27;
            // 
            // textBoxCidade
            // 
            textBoxCidade.Location = new Point(33, 350);
            textBoxCidade.Name = "textBoxCidade";
            textBoxCidade.Size = new Size(157, 27);
            textBoxCidade.TabIndex = 26;
            // 
            // textBoxRua
            // 
            textBoxRua.Location = new Point(33, 116);
            textBoxRua.Name = "textBoxRua";
            textBoxRua.Size = new Size(157, 27);
            textBoxRua.TabIndex = 25;
            // 
            // labelEndereco
            // 
            labelEndereco.AutoSize = true;
            labelEndereco.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelEndereco.ForeColor = SystemColors.ControlText;
            labelEndereco.Location = new Point(134, 50);
            labelEndereco.Name = "labelEndereco";
            labelEndereco.Size = new Size(132, 20);
            labelEndereco.TabIndex = 24;
            labelEndereco.Text = "Digite o Endereço";
            // 
            // buttonCadastrar
            // 
            buttonCadastrar.Location = new Point(25, 402);
            buttonCadastrar.Name = "buttonCadastrar";
            buttonCadastrar.Size = new Size(121, 27);
            buttonCadastrar.TabIndex = 23;
            buttonCadastrar.Text = "Cadastrar";
            buttonCadastrar.UseVisualStyleBackColor = true;
            // 
            // labelCadastro
            // 
            labelCadastro.AutoSize = true;
            labelCadastro.Font = new Font("Segoe UI", 18F, FontStyle.Bold | FontStyle.Italic, GraphicsUnit.Point);
            labelCadastro.ForeColor = SystemColors.ControlText;
            labelCadastro.Location = new Point(43, 27);
            labelCadastro.Name = "labelCadastro";
            labelCadastro.Size = new Size(301, 41);
            labelCadastro.TabIndex = 7;
            labelCadastro.Text = "Cadastro do usuário";
            // 
            // maskedTextBox1
            // 
            maskedTextBox1.Location = new Point(40, 299);
            maskedTextBox1.Mask = "000.000.000-00";
            maskedTextBox1.Name = "maskedTextBox1";
            maskedTextBox1.Size = new Size(296, 27);
            maskedTextBox1.TabIndex = 8;
            // 
            // labelTelefone
            // 
            labelTelefone.AutoSize = true;
            labelTelefone.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point);
            labelTelefone.Location = new Point(40, 265);
            labelTelefone.Name = "labelTelefone";
            labelTelefone.Size = new Size(126, 20);
            labelTelefone.TabIndex = 9;
            labelTelefone.Text = "Digite o telefone";
            // 
            // FormCadastroClientes
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.Silver;
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(800, 450);
            Controls.Add(labelTelefone);
            Controls.Add(maskedTextBox1);
            Controls.Add(labelCadastro);
            Controls.Add(panel1);
            Controls.Add(labelCPF);
            Controls.Add(labelEmail);
            Controls.Add(labelNome);
            Controls.Add(maskedTextBoxCPF);
            Controls.Add(textBoxEmail);
            Controls.Add(textBoxNome);
            DoubleBuffered = true;
            Name = "FormCadastroClientes";
            Text = "Cadastro de Clientes";
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox textBoxNome;
        private TextBox textBoxEmail;
        private MaskedTextBox maskedTextBoxCPF;
        private Label labelNome;
        private Label labelEmail;
        private Label labelCPF;
        private Panel panel1;
        private Button button1;
        private TextBox textBoxComplemento;
        private ComboBox comboBoxEstado;
        private Button buttonCadastrar;
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
        private Label labelCadastro;
        private MaskedTextBox maskedTextBox1;
        private Label labelTelefone;
    }
}