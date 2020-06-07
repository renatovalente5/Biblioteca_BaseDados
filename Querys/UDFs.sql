
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

--SELECT * FROM Biblioteca.GetClientHistorico('1')

CREATE FUNCTION Biblioteca.listarExemplaresDeUmLivro(@ISBN varchar(50)) returns Table
as
	return(select * from BIBLIOTECA.Livros_Exemplares as le where le.ISBN=@ISBN)
go


--UDF to get todos os livros exemplare de um determinado livro
--DROP FUNCTION BIBLIOTECA.GetLivrosEmprestados
--GO

CREATE FUNCTION BIBLIOTECA.GetLivrosEmprestados(@idCliente INT) RETURNS TABLE
AS
	RETURN ( Select *
				FROM  BIBLIOTECA.Emprestimo as e inner join BIBLIOTECA.Livros_Exemplares as le ON e.n_emprestimo=le.n_emprestimo
				--using (n_emprestimo)
				WHERE e.cliente=@idCliente)
GO

--SELECT * FROM BIBLIOTECA.GetLivrosEmprestados(5)
--GO


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