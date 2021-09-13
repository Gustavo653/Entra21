create table dbo.Dados
(
idDados int Primary Key IDENTITY(1,1) not null,
Nome VARCHAR(50) not null,
Cpf VARCHAR(11) not null,
Rg VARCHAR(8) not null
)
create table dbo.Pessoa(
idPessoa int not null,
Constraint fkDados Foreign Key (idPessoa) REFERENCES dbo.Dados (idDados)
)
create table dbo.Cliente(
idCliente int Primary Key IDENTITY(1,1) not null,
Vip bit not null,
idDados int not null,
Constraint fkDado Foreign Key (idDados) REFERENCES dbo.Dados(idDados)
)
create table dbo.Funcionario(
idFuncionario int Primary Key IDENTITY(1,1) not null,
Salario Money not null,
idDados int not null,
Constraint fkDadoss Foreign Key (idDados) REFERENCES dbo.Dados(idDados)
)