
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