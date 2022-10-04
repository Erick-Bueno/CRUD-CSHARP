using System;
using MySql.Data.MySqlClient;

class Atualizar_dados{
    Conectar con = new Conectar();
    MySqlCommand query = new MySqlCommand();

    public Atualizar_dados(string novo_nome, int nova_idade, int id){
        query.CommandText = "update inserir set nome = @novo_nome, idade = @nova_idade where id = @id";
        query.Parameters.AddWithValue("@novo_nome", novo_nome);
        query.Parameters.AddWithValue("@nova_idade", nova_idade);
        query.Parameters.AddWithValue("@id", id);
        try
        {
            query.Connection = con.conexao();
            query.ExecuteNonQuery();
            Console.WriteLine("Conexão estabelecida");
            Console.WriteLine("Registro Atualizado");
            con.desconexao();
        }
        catch (System.Exception)
        {
            Console.WriteLine("error");
            throw;
        }
    }
}