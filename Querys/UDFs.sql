
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

--UDF to get todos os livros exemplare de um determinado livro
CREATE FUNCTION Biblioteca.listarExemplaresDeUmLivro(@ISBN varchar(50)) returns Table
as
	return(select * from BIBLIOTECA.Livros_Exemplares as le where le.ISBN=@ISBN)

go

--select * from Biblioteca.listarExemplaresDeUmLivro('008813803-8');
--go

