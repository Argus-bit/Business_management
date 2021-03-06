/*
   terça-feira, 6 de abril de 202123:31:16
   Usuário: FELIPEFARIAS
   Servidor: LAPTOP-4J79D6GV\SQLEXPRESS
   Banco de Dados: dbPegadasOrtopedica
   Aplicativo: 
*/

/* Para impedir possíveis problemas de perda de dados, analise este script detalhadamente antes de executá-lo fora do contexto do designer de banco de dados.*/
BEGIN TRANSACTION
SET QUOTED_IDENTIFIER ON
SET ARITHABORT ON
SET NUMERIC_ROUNDABORT OFF
SET CONCAT_NULL_YIELDS_NULL ON
SET ANSI_NULLS ON
SET ANSI_PADDING ON
SET ANSI_WARNINGS ON
COMMIT
BEGIN TRANSACTION
GO
CREATE TABLE dbo.Table_1
	(
	key_Cliente int NOT NULL IDENTITY (1, 1),
	ccli_Paciente varchar(100) NULL,
	ccli_DataNascimento datetime NULL,
	ccli_Cpf varchar(25) NULL,
	ccli_Responsavel varchar(100) NULL,
	ccli_Telefone1 varchar(11) NULL,
	ccli_TexTelefone1 varchar(20) NULL,
	ccli_Telefone2 varchar(11) NULL,
	ccli_TexTelefone2 varchar(20) NULL,
	ccli_Telefone3 varchar(11) NULL,
	ccli_TexTelefone3 varchar(20) NULL,
	ccli_Telefone4 varchar(11) NULL,
	ccli_TexTelefone4 varchar(50) NULL
	)  ON [PRIMARY]
GO
ALTER TABLE dbo.Table_1 ADD CONSTRAINT
	PK_Table_1 PRIMARY KEY CLUSTERED 
	(
	key_Cliente
	) WITH( STATISTICS_NORECOMPUTE = OFF, IGNORE_DUP_KEY = OFF, ALLOW_ROW_LOCKS = ON, ALLOW_PAGE_LOCKS = ON) ON [PRIMARY]

GO
ALTER TABLE dbo.Table_1 SET (LOCK_ESCALATION = TABLE)
GO
COMMIT
