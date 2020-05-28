
CREATE SCHEMA BIBLIOTECA
GO

CREATE TABLE BIBLIOTECA.Editora(
	id_editora		INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	nome_editora		VARCHAR(50) NOT NULL,
	endereco		VARCHAR(255),
	telefone		DECIMAL(9,0) UNIQUE CHECK(telefone > 0)
);

CREATE TABLE BIBLIOTECA.Livro(
	ISBN			VARCHAR(50) PRIMARY KEY NOT NULL,
	titulo			VARCHAR(100) NOT NULL,
	ano			INT NOT NULL,
	id_editora		INT REFERENCES BIBLIOTECA.Editora(id_editora) NOT NULL,
	categoria		VARCHAR(75)
);

CREATE TABLE BIBLIOTECA.Pessoa(
	id			INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	first_name			VARCHAR(100) NOT NULL,
	last_name			VARCHAR(100) NOT NULL,
	data_nascimento 	DATE,
	telefone		DECIMAL(9,0)
);

CREATE TABLE BIBLIOTECA.Autor(
	id_autor		INT PRIMARY KEY REFERENCES BIBLIOTECA.Pessoa(id) NOT NULL
);

CREATE TABLE BIBLIOTECA.Escreve(
	id_livro		VARCHAR(50) REFERENCES BIBLIOTECA.Livro(ISBN) NOT NULL,
	id_autor		INT REFERENCES BIBLIOTECA.Autor(id_autor) NOT NULL,
	PRIMARY KEY(id_livro, id_autor)
);

CREATE TABLE BIBLIOTECA.Cliente(
	id_cliente		INT PRIMARY KEY REFERENCES BIBLIOTECA.Pessoa(id) NOT NULL,
	morada			VARCHAR(255) NOT NULL,
	mail			VARCHAR(100) NOT NULL,
	nif			DECIMAL(9,0) NOT NULL CHECK(nif > 0)
);

CREATE TABLE BIBLIOTECA.Socio(
	comprovativo	VARCHAR(50),
	id_socio		INT NOT NULL,
	id_cliente		INT REFERENCES BIBLIOTECA.Cliente(id_cliente) NOT NULL,
	PRIMARY KEY(id_socio, id_cliente)
);

CREATE TABLE BIBLIOTECA.Nao_Socio(
	id_cliente		INT PRIMARY KEY REFERENCES BIBLIOTECA.Cliente(id_cliente) NOT NULL,
	forma_pagamento 	VARCHAR(50) NOT NULL
);

CREATE TABLE BIBLIOTECA.Funcionario(
	id_funcionario		INT PRIMARY KEY REFERENCES BIBLIOTECA.Pessoa(id) NOT NULL,
	morada			VARCHAR(100) NOT NULL
);

CREATE TABLE BIBLIOTECA.Emprestimo(
	n_emprestimo		INT IDENTITY(1,1) PRIMARY KEY NOT NULL,
	data_saida		DATE NOT NULL,
	data_entrega		DATE NOT NULL,
	data_chegada		DATE,
	funcionario		INT REFERENCES BIBLIOTECA.Funcionario(id_funcionario) NOT NULL,
	cliente			INT REFERENCES BIBLIOTECA.Cliente(id_cliente)
);

CREATE TABLE BIBLIOTECA.Livros_Exemplares(
	numero_exemplar		INT IDENTITY(1,1) NOT NULL,
	n_emprestimo		INT REFERENCES BIBLIOTECA.Emprestimo(n_emprestimo) NOT NULL,
	ISBN			VARCHAR(50) REFERENCES BIBLIOTECA.Livro(ISBN) NOT NULL,
	data_de_aquisicao 	DATE NOT NULL,
	estado			VARCHAR(50),
	cota			DECIMAL NOT NULL
	PRIMARY KEY(numero_exemplar, n_emprestimo, ISBN)
);



