

CREATE PROC dbo.CreatePessoa (@firstName varchar(100), @lastName varchar(100), @nasData date, @tele decimal(9,0), @id int OUT)
as
	insert into BIBLIOTECA.Pessoa (first_name,last_name,data_nascimento,telefone) values (@firstName,@lastName,@nasData,@tele);
	set @id = SCOPE_IDENTITY()
go

CREATE PROC dbo.CreateCliente (@first_Name varchar(100), @last_Name varchar(100), @nas_Data date = null, @telemovel decimal(9,0) = null, @morada varchar(255), @mail varchar(100), @nif decimal(9,0))
as
	begin Transaction
	declare @pessoaId as int;
	exec dbo.CreatePessoa @firstName = @first_Name,@lastName=@last_Name,@nasData=@nas_Data,@tele=@telemovel,@id=@pessoaId out;
	insert into BIBLIOTECA.Cliente (id_cliente,mail,morada,nif) values (@pessoaId,@mail,@morada,@nif)
	if @@ERROR !=0
		rollback tran
	else
		commit tran
go