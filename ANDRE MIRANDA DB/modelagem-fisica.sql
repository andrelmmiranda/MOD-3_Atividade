IF NOT EXISTS (
        SELECT *
        FROM sys.databases
        WHERE name = 'ViagemTour'
        )
BEGIN
    CREATE DATABASE ViagemTour;
END
GO

USE ViagemTour;
GO

CREATE TABLE Usuario (
IdUsuario int PRIMARY KEY IDENTITY
)

CREATE TABLE Admin (
IdAdmin int PRIMARY KEY IDENTITY
)

CREATE TABLE Contato (
Id int PRIMARY KEY IDENTITY,
Nome VARCHAR(50),
Email VARCHAR(50),
Mensagem TEXT,
IdAdmin int,
FOREIGN KEY(IdAdmin) REFERENCES Admin (IdAdmin)
)

CREATE TABLE Promocao (
Id int PRIMARY KEY IDENTITY,
Local VARCHAR(50),
QuantidadeDeDias int,
Hospedagem CHAR(3),
CafeDaManha CHAR(3),
PassagemAerea CHAR(3),
Preco float,
IdAdmin int,
FOREIGN KEY(IdAdmin) REFERENCES Admin (IdAdmin)
)

CREATE TABLE Envia (
Id int IDENTITY,
IdUsuario int,
FOREIGN KEY(Id) REFERENCES Contato (Id),
FOREIGN KEY(IdUsuario) REFERENCES Usuario (IdUsuario)
)