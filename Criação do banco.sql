Create Database bludata;

Use bludata;

CREATE TABLE empresas (
    id INT PRIMARY KEY IDENTITY (1, 1),
    uf VARCHAR (2) NOT NULL,
    nomeFantasia VARCHAR (50) NOT NULL,
    cnpj VARCHAR(14),
    removido INT    
);

CREATE TABLE fornecedores (
    id INT PRIMARY KEY IDENTITY (1, 1),
	idEmpresa INT NOT NULL,    
    nome VARCHAR (50) NOT NULL,
	isPf BIT,
    cnpj VARCHAR(14),
	cpf VARCHAR(14),
	rg VARCHAR (10),
	dataNascimento DATETIME,
	dataCadastro DATETIME,
	telefone1 VARCHAR (12),
	telefone2 VARCHAR (12),
    removido INT,
	FOREIGN KEY (idEmpresa) REFERENCES empresas (id)
);