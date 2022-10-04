using System;
using MySql.Data.MySqlClient;


class inserir_dados{
   MySqlCommand query = new MySqlCommand();
   Conectar conect = new Conectar();
    public inserir_dados(string nome, int idade ){
        //comando sql (CRUD)
        query.CommandText = "Insert into inserir(nome, idade) values(@nome, @idade)";
        //parametros
        query.Parameters.AddWithValue("@nome", nome);
        query.Parameters.AddWithValue("@idade", idade);
        //conectar com o banco
        try
        {
            query.Connection = conect.conexao();
            //executar sql
            query.ExecuteNonQuery();
            Console.Write("usuario adicionado com sucesso");
            Console.Write("conexão feita com sucesso");
            
             //desconectar
             conect.desconexao();
             
        }
        catch (MySqlException)
        {
            Console.Write("conexão falhou");
            throw;
        }
        
       
    }
}