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
            ButtonCadastroLivro = new Button();
            ButtonCadastroFuncionario = new Button();
            ButtonCadastroCliente = new Button();
            tabPage5 = new TabPage();
            buttonDevolver = new Button();
            buttonEmprestar = new Button();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            panel1 = new Panel();
            dataGridViewEmprestimos = new DataGridView();
            comboBoxLivroEmprestimo = new ComboBox();
            comboBoxClienteEmprestimo = new ComboBox();
            dateTimePickerDataDevolução = new DateTimePicker();
            tabPage2 = new TabPage();
            buttonCadastroLivros = new Button();
            textBoxPesquisaLivros = new TextBox();
            buttonPesquisar = new Button();
            dataGridViewLivros = new DataGridView();
            tabPage3 = new TabPage();
            buttonCadastroClientes = new Button();
            textBoxPesquisaClientes = new TextBox();
            buttonPesquisaClientes = new Button();
            dataGridViewClientes = new DataGridView();
            Id = new DataGridViewTextBoxColumn();
            Nome = new DataGridViewTextBoxColumn();
            Endereco = new DataGridViewTextBoxColumn();
            Email = new DataGridViewTextBoxColumn();
            Telefone = new DataGridViewTextBoxColumn();
            CPF = new DataGridViewTextBoxColumn();
            tabPage4 = new TabPage();
            buttonCadastroFuncionarios = new Button();
            textBoxPesquisaFuncionarios = new TextBox();
            buttonPesquisarFuncionario = new Button();
            dataGridViewFuncionarios = new DataGridView();
            IdFuncionario = new DataGridViewTextBoxColumn();
            NomeFuncionario = new DataGridViewTextBoxColumn();
            EmailFuncionario = new DataGridViewTextBoxColumn();
            TelefoneFuncionario = new DataGridViewTextBoxColumn();
            EnderecoFuncionario = new DataGridViewTextBoxColumn();
            CarteiradeTrabalho = new DataGridViewTextBoxColumn();
            NomeUsuario = new DataGridViewTextBoxColumn();
            toolStrip1.SuspendLayout();
            tabControl1.SuspendLayout();
            tabPage1.SuspendLayout();
            tabPage5.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmprestimos).BeginInit();
            tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).BeginInit();
            tabPage3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).BeginInit();
            tabPage4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).BeginInit();
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
            tabPage1.Controls.Add(ButtonCadastroLivro);
            tabPage1.Controls.Add(ButtonCadastroFuncionario);
            tabPage1.Controls.Add(ButtonCadastroCliente);
            tabPage1.Location = new Point(4, 29);
            tabPage1.Name = "tabPage1";
            tabPage1.Padding = new Padding(3);
            tabPage1.Size = new Size(906, 417);
            tabPage1.TabIndex = 0;
            tabPage1.Text = "Principal";
            // 
            // ButtonCadastroLivro
            // 
            ButtonCadastroLivro.Location = new Point(6, 102);
            ButtonCadastroLivro.Name = "ButtonCadastroLivro";
            ButtonCadastroLivro.Size = new Size(193, 29);
            ButtonCadastroLivro.TabIndex = 2;
            ButtonCadastroLivro.Text = "Cadastro de Livros";
            ButtonCadastroLivro.UseVisualStyleBackColor = true;
            ButtonCadastroLivro.Click += ButtonCadastroLivro_Click;
            // 
            // ButtonCadastroFuncionario
            // 
            ButtonCadastroFuncionario.Location = new Point(6, 53);
            ButtonCadastroFuncionario.Name = "ButtonCadastroFuncionario";
            ButtonCadastroFuncionario.Size = new Size(193, 29);
            ButtonCadastroFuncionario.TabIndex = 1;
            ButtonCadastroFuncionario.Text = "Cadastro de Funcionários";
            ButtonCadastroFuncionario.UseVisualStyleBackColor = true;
            ButtonCadastroFuncionario.Click += ButtonCadastroFuncionario_Click;
            // 
            // ButtonCadastroCliente
            // 
            ButtonCadastroCliente.Location = new Point(6, 6);
            ButtonCadastroCliente.Name = "ButtonCadastroCliente";
            ButtonCadastroCliente.Size = new Size(193, 29);
            ButtonCadastroCliente.TabIndex = 0;
            ButtonCadastroCliente.Text = "Cadastro de Clientes";
            ButtonCadastroCliente.UseVisualStyleBackColor = true;
            ButtonCadastroCliente.Click += ButtonCadastroCliente_Click;
            // 
            // tabPage5
            // 
            tabPage5.BackColor = Color.Silver;
            tabPage5.Controls.Add(buttonDevolver);
            tabPage5.Controls.Add(buttonEmprestar);
            tabPage5.Controls.Add(label3);
            tabPage5.Controls.Add(label2);
            tabPage5.Controls.Add(label1);
            tabPage5.Controls.Add(panel1);
            tabPage5.Controls.Add(comboBoxLivroEmprestimo);
            tabPage5.Controls.Add(comboBoxClienteEmprestimo);
            tabPage5.Controls.Add(dateTimePickerDataDevolução);
            tabPage5.Location = new Point(4, 29);
            tabPage5.Name = "tabPage5";
            tabPage5.Padding = new Padding(3);
            tabPage5.Size = new Size(906, 417);
            tabPage5.TabIndex = 4;
            tabPage5.Text = "Empréstimos";
            tabPage5.Enter += tabPage5_Enter;
            // 
            // buttonDevolver
            // 
            buttonDevolver.Location = new Point(747, 100);
            buttonDevolver.Name = "buttonDevolver";
            buttonDevolver.Size = new Size(94, 29);
            buttonDevolver.TabIndex = 8;
            buttonDevolver.Text = "Devolver";
            buttonDevolver.UseVisualStyleBackColor = true;
            buttonDevolver.Click += buttonDevolver_Click;
            // 
            // buttonEmprestar
            // 
            buttonEmprestar.Location = new Point(635, 100);
            buttonEmprestar.Name = "buttonEmprestar";
            buttonEmprestar.Size = new Size(94, 29);
            buttonEmprestar.TabIndex = 7;
            buttonEmprestar.Text = "Emprestar";
            buttonEmprestar.UseVisualStyleBackColor = true;
            buttonEmprestar.Click += buttonEmprestar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label3.Location = new Point(306, 79);
            label3.Name = "label3";
            label3.Size = new Size(121, 20);
            label3.TabIndex = 6;
            label3.Text = "Data devolução:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.Location = new Point(23, 80);
            label2.Name = "label2";
            label2.Size = new Size(61, 20);
            label2.TabIndex = 5;
            label2.Text = "Cliente:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 9F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(23, 26);
            label1.Name = "label1";
            label1.Size = new Size(48, 20);
            label1.TabIndex = 4;
            label1.Text = "Livro:";
            // 
            // panel1
            // 
            panel1.BackColor = Color.WhiteSmoke;
            panel1.Controls.Add(dataGridViewEmprestimos);
            panel1.Location = new Point(23, 137);
            panel1.Name = "panel1";
            panel1.Size = new Size(858, 261);
            panel1.TabIndex = 3;
            // 
            // dataGridViewEmprestimos
            // 
            dataGridViewEmprestimos.BorderStyle = BorderStyle.None;
            dataGridViewEmprestimos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewEmprestimos.Location = new Point(15, 12);
            dataGridViewEmprestimos.Name = "dataGridViewEmprestimos";
            dataGridViewEmprestimos.RowHeadersWidth = 51;
            dataGridViewEmprestimos.Size = new Size(828, 235);
            dataGridViewEmprestimos.TabIndex = 0;
            // 
            // comboBoxLivroEmprestimo
            // 
            comboBoxLivroEmprestimo.DisplayMember = "Titulo";
            comboBoxLivroEmprestimo.FormattingEnabled = true;
            comboBoxLivroEmprestimo.Location = new Point(23, 49);
            comboBoxLivroEmprestimo.Name = "comboBoxLivroEmprestimo";
            comboBoxLivroEmprestimo.Size = new Size(257, 28);
            comboBoxLivroEmprestimo.TabIndex = 2;
            comboBoxLivroEmprestimo.ValueMember = "Id";
            // 
            // comboBoxClienteEmprestimo
            // 
            comboBoxClienteEmprestimo.DisplayMember = "Nome";
            comboBoxClienteEmprestimo.FormattingEnabled = true;
            comboBoxClienteEmprestimo.Location = new Point(23, 103);
            comboBoxClienteEmprestimo.Name = "comboBoxClienteEmprestimo";
            comboBoxClienteEmprestimo.Size = new Size(257, 28);
            comboBoxClienteEmprestimo.TabIndex = 1;
            comboBoxClienteEmprestimo.ValueMember = "Id";
            // 
            // dateTimePickerDataDevolução
            // 
            dateTimePickerDataDevolução.Location = new Point(306, 102);
            dateTimePickerDataDevolução.Name = "dateTimePickerDataDevolução";
            dateTimePickerDataDevolução.Size = new Size(310, 27);
            dateTimePickerDataDevolução.TabIndex = 0;
            // 
            // tabPage2
            // 
            tabPage2.BackColor = Color.WhiteSmoke;
            tabPage2.Controls.Add(buttonCadastroLivros);
            tabPage2.Controls.Add(textBoxPesquisaLivros);
            tabPage2.Controls.Add(buttonPesquisar);
            tabPage2.Controls.Add(dataGridViewLivros);
            tabPage2.Location = new Point(4, 29);
            tabPage2.Name = "tabPage2";
            tabPage2.Padding = new Padding(3);
            tabPage2.Size = new Size(906, 417);
            tabPage2.TabIndex = 1;
            tabPage2.Text = "Livros";
            tabPage2.Enter += tabPage2_Enter;
            // 
            // buttonCadastroLivros
            // 
            buttonCadastroLivros.Location = new Point(705, 6);
            buttonCadastroLivros.Name = "buttonCadastroLivros";
            buttonCadastroLivros.Size = new Size(193, 29);
            buttonCadastroLivros.TabIndex = 3;
            buttonCadastroLivros.Text = "Cadastro de Livros";
            buttonCadastroLivros.UseVisualStyleBackColor = true;
            buttonCadastroLivros.Click += buttonCadastroLivros_Click;
            // 
            // textBoxPesquisaLivros
            // 
            textBoxPesquisaLivros.Location = new Point(6, 6);
            textBoxPesquisaLivros.Name = "textBoxPesquisaLivros";
            textBoxPesquisaLivros.Size = new Size(534, 27);
            textBoxPesquisaLivros.TabIndex = 2;
            textBoxPesquisaLivros.KeyPress += textBoxPesquisaLivros_KeyPress;
            // 
            // buttonPesquisar
            // 
            buttonPesquisar.Location = new Point(546, 6);
            buttonPesquisar.Name = "buttonPesquisar";
            buttonPesquisar.Size = new Size(94, 29);
            buttonPesquisar.TabIndex = 1;
            buttonPesquisar.Text = "Pesquisar";
            buttonPesquisar.UseVisualStyleBackColor = true;
            buttonPesquisar.Click += buttonPesquisar_Click;
            // 
            // dataGridViewLivros
            // 
            dataGridViewLivros.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewLivros.Location = new Point(0, 39);
            dataGridViewLivros.Name = "dataGridViewLivros";
            dataGridViewLivros.RowHeadersWidth = 51;
            dataGridViewLivros.Size = new Size(910, 351);
            dataGridViewLivros.TabIndex = 0;
            // 
            // tabPage3
            // 
            tabPage3.BackColor = Color.Gainsboro;
            tabPage3.Controls.Add(buttonCadastroClientes);
            tabPage3.Controls.Add(textBoxPesquisaClientes);
            tabPage3.Controls.Add(buttonPesquisaClientes);
            tabPage3.Controls.Add(dataGridViewClientes);
            tabPage3.Location = new Point(4, 29);
            tabPage3.Name = "tabPage3";
            tabPage3.Padding = new Padding(3);
            tabPage3.Size = new Size(906, 417);
            tabPage3.TabIndex = 2;
            tabPage3.Text = "Clientes";
            tabPage3.Enter += tabPage3_Enter;
            // 
            // buttonCadastroClientes
            // 
            buttonCadastroClientes.Location = new Point(705, 6);
            buttonCadastroClientes.Name = "buttonCadastroClientes";
            buttonCadastroClientes.Size = new Size(193, 29);
            buttonCadastroClientes.TabIndex = 5;
            buttonCadastroClientes.Text = "Cadastro de Clientes";
            buttonCadastroClientes.UseVisualStyleBackColor = true;
            buttonCadastroClientes.Click += buttonCadastroClientes_Click;
            // 
            // textBoxPesquisaClientes
            // 
            textBoxPesquisaClientes.Location = new Point(6, 6);
            textBoxPesquisaClientes.Name = "textBoxPesquisaClientes";
            textBoxPesquisaClientes.Size = new Size(534, 27);
            textBoxPesquisaClientes.TabIndex = 4;
            textBoxPesquisaClientes.KeyPress += textBoxPesquisaClientes_KeyPress;
            // 
            // buttonPesquisaClientes
            // 
            buttonPesquisaClientes.Location = new Point(546, 6);
            buttonPesquisaClientes.Name = "buttonPesquisaClientes";
            buttonPesquisaClientes.Size = new Size(94, 29);
            buttonPesquisaClientes.TabIndex = 3;
            buttonPesquisaClientes.Text = "Pesquisar";
            buttonPesquisaClientes.UseVisualStyleBackColor = true;
            buttonPesquisaClientes.Click += buttonPesquisaClientes_Click;
            // 
            // dataGridViewClientes
            // 
            dataGridViewClientes.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewClientes.Columns.AddRange(new DataGridViewColumn[] { Id, Nome, Endereco, Email, Telefone, CPF });
            dataGridViewClientes.Location = new Point(0, 39);
            dataGridViewClientes.Name = "dataGridViewClientes";
            dataGridViewClientes.RowHeadersWidth = 51;
            dataGridViewClientes.Size = new Size(906, 317);
            dataGridViewClientes.TabIndex = 0;
            // 
            // Id
            // 
            Id.DataPropertyName = "Id";
            Id.HeaderText = "Id";
            Id.MinimumWidth = 6;
            Id.Name = "Id";
            Id.Visible = false;
            Id.Width = 125;
            // 
            // Nome
            // 
            Nome.DataPropertyName = "Nome";
            Nome.HeaderText = "Nome";
            Nome.MinimumWidth = 6;
            Nome.Name = "Nome";
            Nome.Width = 200;
            // 
            // Endereco
            // 
            Endereco.DataPropertyName = "Endereco";
            Endereco.HeaderText = "Endereço";
            Endereco.MinimumWidth = 6;
            Endereco.Name = "Endereco";
            Endereco.Width = 300;
            // 
            // Email
            // 
            Email.DataPropertyName = "Email";
            Email.HeaderText = "E-mail";
            Email.MinimumWidth = 6;
            Email.Name = "Email";
            Email.Width = 125;
            // 
            // Telefone
            // 
            Telefone.DataPropertyName = "Telefone";
            Telefone.HeaderText = "Telefone";
            Telefone.MinimumWidth = 6;
            Telefone.Name = "Telefone";
            Telefone.Width = 125;
            // 
            // CPF
            // 
            CPF.DataPropertyName = "CPF";
            CPF.HeaderText = "CPF";
            CPF.MinimumWidth = 6;
            CPF.Name = "CPF";
            CPF.Width = 125;
            // 
            // tabPage4
            // 
            tabPage4.BackColor = Color.MistyRose;
            tabPage4.Controls.Add(buttonCadastroFuncionarios);
            tabPage4.Controls.Add(textBoxPesquisaFuncionarios);
            tabPage4.Controls.Add(buttonPesquisarFuncionario);
            tabPage4.Controls.Add(dataGridViewFuncionarios);
            tabPage4.Location = new Point(4, 29);
            tabPage4.Name = "tabPage4";
            tabPage4.Padding = new Padding(3);
            tabPage4.Size = new Size(906, 417);
            tabPage4.TabIndex = 3;
            tabPage4.Text = "Funcionários";
            tabPage4.Enter += tabPage4_Enter;
            // 
            // buttonCadastroFuncionarios
            // 
            buttonCadastroFuncionarios.Location = new Point(705, 8);
            buttonCadastroFuncionarios.Name = "buttonCadastroFuncionarios";
            buttonCadastroFuncionarios.Size = new Size(193, 29);
            buttonCadastroFuncionarios.TabIndex = 6;
            buttonCadastroFuncionarios.Text = "Cadastro de Funcionários";
            buttonCadastroFuncionarios.UseVisualStyleBackColor = true;
            buttonCadastroFuncionarios.Click += buttonCadastroFuncionarios_Click;
            // 
            // textBoxPesquisaFuncionarios
            // 
            textBoxPesquisaFuncionarios.Location = new Point(6, 8);
            textBoxPesquisaFuncionarios.Name = "textBoxPesquisaFuncionarios";
            textBoxPesquisaFuncionarios.Size = new Size(534, 27);
            textBoxPesquisaFuncionarios.TabIndex = 5;
            textBoxPesquisaFuncionarios.KeyPress += textBoxPesquisaFuncionarios_KeyPress;
            // 
            // buttonPesquisarFuncionario
            // 
            buttonPesquisarFuncionario.Location = new Point(546, 7);
            buttonPesquisarFuncionario.Name = "buttonPesquisarFuncionario";
            buttonPesquisarFuncionario.Size = new Size(94, 29);
            buttonPesquisarFuncionario.TabIndex = 4;
            buttonPesquisarFuncionario.Text = "Pesquisar";
            buttonPesquisarFuncionario.UseVisualStyleBackColor = true;
            buttonPesquisarFuncionario.Click += buttonPesquisarFuncionario_Click;
            // 
            // dataGridViewFuncionarios
            // 
            dataGridViewFuncionarios.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewFuncionarios.Columns.AddRange(new DataGridViewColumn[] { IdFuncionario, NomeFuncionario, EmailFuncionario, TelefoneFuncionario, EnderecoFuncionario, CarteiradeTrabalho, NomeUsuario });
            dataGridViewFuncionarios.Location = new Point(-7, 42);
            dataGridViewFuncionarios.Name = "dataGridViewFuncionarios";
            dataGridViewFuncionarios.RowHeadersWidth = 51;
            dataGridViewFuncionarios.Size = new Size(910, 351);
            dataGridViewFuncionarios.TabIndex = 3;
            // 
            // IdFuncionario
            // 
            IdFuncionario.DataPropertyName = "Id";
            IdFuncionario.HeaderText = "Id";
            IdFuncionario.MinimumWidth = 6;
            IdFuncionario.Name = "IdFuncionario";
            IdFuncionario.Visible = false;
            IdFuncionario.Width = 125;
            // 
            // NomeFuncionario
            // 
            NomeFuncionario.DataPropertyName = "Nome";
            NomeFuncionario.HeaderText = "Nome";
            NomeFuncionario.MinimumWidth = 6;
            NomeFuncionario.Name = "NomeFuncionario";
            NomeFuncionario.Width = 125;
            // 
            // EmailFuncionario
            // 
            EmailFuncionario.DataPropertyName = "Email";
            EmailFuncionario.HeaderText = "E-Mail";
            EmailFuncionario.MinimumWidth = 6;
            EmailFuncionario.Name = "EmailFuncionario";
            EmailFuncionario.Width = 125;
            // 
            // TelefoneFuncionario
            // 
            TelefoneFuncionario.DataPropertyName = "Telefone";
            TelefoneFuncionario.HeaderText = "Telefone";
            TelefoneFuncionario.MinimumWidth = 6;
            TelefoneFuncionario.Name = "TelefoneFuncionario";
            TelefoneFuncionario.Width = 125;
            // 
            // EnderecoFuncionario
            // 
            EnderecoFuncionario.DataPropertyName = "Endereco";
            EnderecoFuncionario.HeaderText = "Endereço";
            EnderecoFuncionario.MinimumWidth = 6;
            EnderecoFuncionario.Name = "EnderecoFuncionario";
            EnderecoFuncionario.Width = 125;
            // 
            // CarteiradeTrabalho
            // 
            CarteiradeTrabalho.DataPropertyName = "CarteiraTrabalho";
            CarteiradeTrabalho.HeaderText = "Carteira de Trabalho";
            CarteiradeTrabalho.MinimumWidth = 6;
            CarteiradeTrabalho.Name = "CarteiradeTrabalho";
            CarteiradeTrabalho.Width = 200;
            // 
            // NomeUsuario
            // 
            NomeUsuario.DataPropertyName = "NomeUsuario";
            NomeUsuario.HeaderText = "Nome de Usuário";
            NomeUsuario.MinimumWidth = 6;
            NomeUsuario.Name = "NomeUsuario";
            NomeUsuario.Width = 200;
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
            FormClosing += FormPrincipal_FormClosing;
            Load += FormPrincipal_Load;
            toolStrip1.ResumeLayout(false);
            toolStrip1.PerformLayout();
            tabControl1.ResumeLayout(false);
            tabPage1.ResumeLayout(false);
            tabPage5.ResumeLayout(false);
            tabPage5.PerformLayout();
            panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridViewEmprestimos).EndInit();
            tabPage2.ResumeLayout(false);
            tabPage2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewLivros).EndInit();
            tabPage3.ResumeLayout(false);
            tabPage3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewClientes).EndInit();
            tabPage4.ResumeLayout(false);
            tabPage4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridViewFuncionarios).EndInit();
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
        private Button ButtonCadastroLivro;
        private Button ButtonCadastroFuncionario;
        private Button ButtonCadastroCliente;
        private Button buttonPesquisar;
        private DataGridView dataGridViewLivros;
        private TextBox textBoxPesquisaLivros;
        private TextBox textBoxPesquisaClientes;
        private Button buttonPesquisaClientes;
        private DataGridView dataGridViewClientes;
        private TextBox textBoxPesquisaFuncionarios;
        private Button buttonPesquisarFuncionario;
        private DataGridView dataGridViewFuncionarios;
        private Panel panel2;
        private Panel panel1;
        private ComboBox comboBoxLivroEmprestimo;
        private ComboBox comboBoxClienteEmprestimo;
        private DateTimePicker dateTimePickerDataDevolução;
        private Button buttonEmprestar;
        private Label label3;
        private Label label2;
        private Label label1;
        private DataGridView dataGridViewEmprestimos;
        private Button buttonDevolver;
        private Button buttonCadastroClientes;
        private Button buttonCadastroFuncionarios;
        private Button buttonCadastroLivros;
        private DataGridViewTextBoxColumn Id;
        private DataGridViewTextBoxColumn Nome;
        private DataGridViewTextBoxColumn Endereco;
        private DataGridViewTextBoxColumn Email;
        private DataGridViewTextBoxColumn Telefone;
        private DataGridViewTextBoxColumn CPF;
        private DataGridViewTextBoxColumn IdFuncionario;
        private DataGridViewTextBoxColumn NomeFuncionario;
        private DataGridViewTextBoxColumn EmailFuncionario;
        private DataGridViewTextBoxColumn TelefoneFuncionario;
        private DataGridViewTextBoxColumn EnderecoFuncionario;
        private DataGridViewTextBoxColumn CarteiradeTrabalho;
        private DataGridViewTextBoxColumn NomeUsuario;
    }
}