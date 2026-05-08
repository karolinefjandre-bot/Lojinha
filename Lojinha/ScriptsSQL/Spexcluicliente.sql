use dblojinha
go

CREATE PROCEDURE [dbo].[exclui_cliente]
@codigo int
as
delete from CLIENTES WHERE codigo = @codigo

select * from Clientes