use dblojinha
go

CREATE PROCEDURE [dbo].[seleciona_cliente]
@filtro varchar(100) = null
as
begin
if @filtro is null
select * from clientes
else
select * from clientes 
where nome like '%' + @filtro + '%'
or email like '%' + @filtro + '%'
or telefone like '%' + @filtro + '%'
end 