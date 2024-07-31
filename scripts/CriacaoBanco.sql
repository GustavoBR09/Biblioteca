CREATE TABLE Endereco(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Rua VARCHAR(30) NOT NULL,
	Complemento VARCHAR(50),
	Numero VARCHAR(6) NOT NULL,
	Bairro VARCHAR(30) NOT NULL,
	Cidade VARCHAR(30) NOT NULL,
	Estado VARCHAR(2) NOT NULL
);

CREATE TABLE Funcionario(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	EnderecoID INT NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Telefone VARCHAR(17),
	CarteiraTrabalho VARCHAR(14) NOT NULL,
	NomeUsuario VARCHAR(20) NOT NULL,
	Senha VARCHAR(20) NOT NULL,
	CONSTRAINT fk_Funcionario_EnderecoId FOREIGN KEY(EnderecoID) REFERENCES Endereco(Id)
);

CREATE TABLE Cliente(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Nome VARCHAR(50) NOT NULL,
	EnderecoID INT NOT NULL,
	Email VARCHAR(50) NOT NULL,
	Telefone VARCHAR(17),
	Cpf VARCHAR (14) NOT NULL,
	CONSTRAINT fk_Cliente_EnderecoID FOREIGN KEY(EnderecoID) REFERENCES Endereco(Id)
);

CREATE TABLE Livro(
	Id INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	Titulo VARCHAR(50) NOT NULL,
	Autor VARCHAR(50) NOT NULL,
	AnoPublicacao INT NOT NULL,
	NumeroPaginas INT NOT NULL,
	QuantidadeDisponiveis INT NOT NULL,
	GeneroLiterario INT NOT NULL
);

CREATE TABLE Emprestimo(
	ID INT NOT NULL IDENTITY(1, 1) PRIMARY KEY,
	CLienteID INT NOT NULL,
	FuncionarioID INT NOT NULL,
	LivroID INT NOT NULL,
	DataEmprestimo INT NOT NULL,
	DataDevolucaoPrevista INT NOT NULL,
	DataDevolucaoReal INT NOT NULL,
	Multa INT NOT NULL,
	CONSTRAINT fk_Emprestimo_ClienteID FOREIGN KEY(ClienteID) REFERENCES Cliente(Id),
	CONSTRAINT fk_Emprestimo_FuncionarioID FOREIGN KEY(FuncionarioID) REFERENCES Funcionario(Id),
	CONSTRAINT fk_Emprestimo_LivroID FOREIGN KEY(LivroID) REFERENCES Livro(Id)
);