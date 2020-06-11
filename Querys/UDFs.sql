
--UDF to get a lista de livros requesitados por um determinado cliente
create function Biblioteca.GetClientHistorico(@clienteId int) returns Table
 as
	return(select emp.n_emprestimo, data_saida,data_entrega,data_chegada,numero_exemplar,le.ISBN,titulo,ano,categoria,nome_editora,cota 
			from Biblioteca.Emprestimo as emp 
				join BIBLIOTECA.Livros_Exemplares as le on emp.n_emprestimo = le.n_emprestimo
				join BIBLIOTECA.Livro as li on le.ISBN=li.ISBN
				join BIBLIOTECA.Editora as ed on li.id_editora=ed.id_editora
			where cliente = @clienteId )
go

--drop function Biblioteca.listarExemplaresDeUmLivro
CREATE FUNCTION Biblioteca.listarExemplaresDeUmLivro(@ISBN varchar(50)) returns Table
as
	return(select le.ISBN,le.cota,le.estado,le.numero_exemplar,le.n_emprestimo,e.data_chegada
					from BIBLIOTECA.Livros_Exemplares as le join Biblioteca.Emprestimo as e 
					on le.n_emprestimo=e.n_emprestimo
					where le.ISBN=@ISBN
					group by le.ISBN,le.cota,le.estado,le.numero_exemplar,le.n_emprestimo,e.data_chegada)
go

--drop function Biblioteca.ContarLivrosDisponiveis
CREATE FUNCTION BIBLIOTECA.ContarLivrosDisponiveis(@ISBN varchar(50)) returns Table
as
	return(select le.ISBN, count(*) as Disponiveis
					from BIBLIOTECA.Livros_Exemplares as le join Biblioteca.Emprestimo as e 
					on le.n_emprestimo=e.n_emprestimo
					where le.ISBN=@ISBN and e.data_chegada is not null
					Group by le.ISBN)

go

CREATE FUNCTION BIBLIOTECA.ContarLivrosEmFalta(@id_client int) returns Table
as
	return(select count(*) as EmFalta
					from (BIBLIOTECA.Livros_Exemplares as le join Biblioteca.Emprestimo as e 
					on le.n_emprestimo=e.n_emprestimo) join Biblioteca.Cliente as c on e.cliente = c.id_cliente
					where c.id_cliente = @id_client and e.data_chegada is null
			)

go

--Select * from BIBLIOTECA.ContarLivrosEmFalta('1');

--Select * from Biblioteca.listarExemplaresDeUmLivro('008813803-8')
--Select * from Biblioteca.ContarLivrosDisponiveis('008813803-8')

--drop function BIBLIOTECA.CheckRemoveLivro
create Function BIBLIOTECA.CheckRemoveLivro(@isbn varchar(50)) returns bit
as
begin
	declare @date as date;
	declare @remove as bit = 1;

	declare C cursor
	for select e.data_chegada from BIBLIOTECA.Livro as l join BIBLIOTECA.Livros_Exemplares as le on l.ISBN=le.ISBN
				join BIBLIOTECA.Emprestimo as e on le.n_emprestimo=e.n_emprestimo 
				where l.ISBN = @isbn
	open C;
	fetch C into @date;

	while @@FETCH_STATUS = 0
		begin
			if @date is null
			begin
				set @remove = 0;
			end
			fetch next from  C into @date;
		end;
	close C;
	Deallocate C;

	return @remove
end
go

--select Biblioteca.CheckRemoveLivro('036176734-X')