use BIBLIOTECA;
go


CREATE PROC dbo.CreatePessoa (@firstName varchar(100), @lastName varchar(100), @nasData date, @tele decimal(9,0), @id int OUT)
as
	insert into BIBLIOTECA.Pessoa (first_name,last_name,data_nascimento,telefone) values (@firstName,@lastName,@nasData,@tele);
	set @id = SCOPE_IDENTITY()
go

--drop PROC dbo.CreateCliente;

CREATE PROC dbo.CreateCliente (@first_Name varchar(100), @last_Name varchar(100), @nas_Data date = null, @telemovel decimal(9,0) = null, @morada varchar(255), @mail varchar(100), @nif decimal(9,0), @id int out)
as
	begin Transaction
	declare @pessoaId as int;
	exec dbo.CreatePessoa @firstName = @first_Name,@lastName=@last_Name,@nasData=@nas_Data,@tele=@telemovel,@id=@pessoaId out;
	insert into BIBLIOTECA.Cliente (id_cliente,mail,morada,nif) values (@pessoaId,@mail,@morada,@nif)
	set @id = @pessoaId;
	if @@ERROR !=0
		rollback tran
	else
		commit tran
go

--drop proc dbo.CreateAutor
CREATE PROC dbo.CreateAutor (@first_Name varchar(100), @last_Name varchar(100), @nas_Data date = null, @telemovel decimal(9,0) = null)
as
	begin Transaction
	declare @pessoaId as int;
	exec dbo.CreatePessoa @firstName = @first_Name,@lastName=@last_Name,@nasData=@nas_Data,@tele=@telemovel,@id=@pessoaId out;
	insert into BIBLIOTECA.Autor values (@pessoaId)
	if @@ERROR !=0
		rollback tran
	else
		commit tran
go

create proc dbo.CreateEditora (@nome varchar(50), @morada varchar(255)=null,@telefone decimal(9,0)=null)
as
	insert into BIBLIOTECA.Editora(nome_editora,endereco,telefone) values (@nome,@morada,@telefone)

--exec dbo.CreateAutor 'oi', 'tanto'

CREATE PROC BIBLIOTECA.EditCliente (@pessoaId int, @first_Name varchar(100), @last_Name varchar(100), @nas_Data date = null, @telemovel decimal(9,0) = null, @morada varchar(255), @mail varchar(100), @nif decimal(9,0))
as
	begin Transaction
	update BIBLIOTECA.Pessoa SET first_name=@first_Name, last_name=@last_Name, data_nascimento=@nas_Data, telefone=@telemovel
							 WHERE id=@pessoaId;
	update BIBLIOTECA.Cliente SET mail=@mail, morada=@morada, nif= @nif
							  WHERE id_cliente=@pessoaId;
	if @@ERROR !=0
	begin
		rollback tran
		return 0
	end
	else
	begin
		commit tran
		return 1
	end
go

--EXECUTE Biblioteca.EditCliente '1', 'Rina2', 'Cruz2', '2003-09-08', '988247615', '0162 Valley Edge Drive', 'fmumford0@parallels.com', '339451477';
--go


--drop proc BIBLIOTECA.CreateEmprestimo
--drop PROC BIBLIOTECA.FazerEmprestimo

CREATE PROC BIBLIOTECA.CreateEmprestimo (@n_emprestimo int out, @funcionario int, @cliente int)
as
	insert into BIBLIOTECA.Emprestimo(data_saida,data_entrega,data_chegada,funcionario,cliente) values (GETDATE(),GETDATE(),null,@funcionario,@cliente);
	set @n_emprestimo = SCOPE_IDENTITY()
go

CREATE PROC BIBLIOTECA.FazerEmprestimo (@numeros_exemplares varchar(20), @id_funcionario int, @id_cliente int)
as
	begin Transaction
	declare @nu_emprestimo as int;
	declare @numero_exemplar as int;

	exec BIBLIOTECA.CreateEmprestimo @n_emprestimo=@nu_emprestimo out, @funcionario=@id_funcionario , @cliente=@id_cliente;

	declare C cursor
	for select value from string_split(@numeros_exemplares,';') where RTRIM(value) <> '';
	open C;
	fetch C into @numero_exemplar;

	while @@FETCH_STATUS = 0
		begin
			update BIBLIOTECA.Livros_Exemplares SET n_emprestimo=@nu_emprestimo
								WHERE numero_exemplar=@numero_exemplar;
			fetch next from  C into @numero_exemplar;
		end;
	close C;
	Deallocate C;

	if @@ERROR !=0
		rollback tran
	else
		commit tran
go

--EXECUTE BIBLIOTECA.FazerEmprestimo '1;4;10', '101', '1';
--go

