

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

CREATE PROC BIBLIOTECA.EditCliente (@pessoaId int, @first_Name varchar(100), @last_Name varchar(100), @nas_Data date = null, @telemovel decimal(9,0) = null, @morada varchar(255), @mail varchar(100), @nif decimal(9,0))
as
	begin Transaction
	update BIBLIOTECA.Pessoa SET first_name=@first_Name, last_name=@last_Name, data_nascimento=@nas_Data, telefone=@telemovel
							 WHERE id=@pessoaId;
	update BIBLIOTECA.Cliente SET mail=@mail, morada=@morada, nif= @nif
							  WHERE id_cliente=@pessoaId;
	if @@ERROR !=0
		rollback tran
	else
		commit tran
go

--EXECUTE Biblioteca.EditCliente '1', 'Rina2', 'Cruz2', '2003-09-08', '988247615', '0162 Valley Edge Drive', 'fmumford0@parallels.com', '339451477';
--go



CREATE PROC BIBLIOTECA.CreateEmprestimo (@data_saida date, @data_entrega date, @data_chegada date, @funcionario int, @cliente int)
as


go


CREATE PROC BIBLIOTECA.FazerEmprestimo (@numero_exemplar int, @n_emprestimo int, @ISBN varchar(50), @data_de_aquisicao date, @estado varchar(50)=null, @cota decimal(18,0) = null, @id_funcionario int, @id_cliente int)
as
	begin Transaction
	--Criar PROC BIBLIOTECA.CreateEmprestimo
	--exec BIBLIOTECA.CreateEmprestimo @firstName = @first_Name,@lastName=@last_Name,@nasData=@nas_Data,@tele=@telemovel,@id=@pessoaId out;
	select * from BIBLIOTECA.Livro as empretadar where @n_emprestimo=@numero_exemplar;
	update BIBLIOTECA.Emprestimo set data_saida=GETDATE(), data_entrega=GETDATE(), funcionario=@id_funcionario, cliente=@id_cliente; --falta meter as datas bem
	
	if @@ERROR !=0
		rollback tran
	else
		commit tran

	declare @pessoaId as int;
	--exec  @firstName = @first_Name,@lastName=@last_Name,@nasData=@nas_Data,@tele=@telemovel,@id=@pessoaId out;
	insert into BIBLIOTECA.Cliente (id_cliente,mail,morada,nif) values (@pessoaId,@mail,@morada,@nif)
	if @@ERROR !=0
		rollback tran
	else
		commit tran
go
