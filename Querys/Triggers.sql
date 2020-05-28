

create Trigger DeleteCliente on BIBLIOTECA.Pessoa instead of Delete
as
	declare @id as int;
	select @id=id from deleted;
	delete from BIBLIOTECA.Socio where id_cliente=@id;
	delete from BIBLIOTECA.Nao_Socio where id_cliente=@id;
	update BIBLIOTECA.Emprestimo set cliente=null where cliente=@id
	delete from BIBLIOTECA.Cliente where id_cliente=@id
	delete from BIBLIOTECA.Pessoa where id=@id

go