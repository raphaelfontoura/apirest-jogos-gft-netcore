USE master;
GO

IF DB_ID (N'CatalogoJogos') IS NULL
CREATE DATABASE CatalogoJogos;
GO

-- IF NOT EXISTS(SELECT * FROM sys.databases WHERE name = 'CatalogoJogos')
--     begin
--         CREATE DATABASE CatalogoJogos
--     end;
-- GO
