using System;
using MySql.Data.MySqlClient;


class Deletar_dados{
    Conectar con = new Conectar();
    MySqlCommand query = new MySqlCommand();
    public Deletar_dados(int id){
        query.CommandText = "delete from inserir where id = @id";
        query.Parameters.AddWithValue("@id", id);
        try
        {
            query.Connection = con.conexao();
            query.ExecuteNonQuery();
            Console.WriteLine("conexão estabelecida com sucesso");
            Console.WriteLine("USUARIO DELETADO COM SUCESSO");
            con.desconexao();
            
        }
        catch (MySqlException)
        {
            Console.Write("Conexão falhou");
            throw;
        }
    }
}