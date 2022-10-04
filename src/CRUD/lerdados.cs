using System;
using MySql.Data.MySqlClient;

class Ler_dados{
    Conectar con = new Conectar();
    MySqlCommand query = new MySqlCommand();


    public Ler_dados(){
        query.CommandText = "select nome from inserir";
       
        try
        {
            query.Connection = con.conexao();
            MySqlDataReader dados = query.ExecuteReader();
            Console.WriteLine("conexão estabelecida");
            Console.WriteLine("Lista De usuarios Cadastrados:");
            while(dados.Read()){
                for(int i = 0; i < 1; i = i + 1){ // i < 1: vai depender de quantas colunas voce esta retornando no select como eu to retornando so o nome é apenas uma
                    Console.WriteLine(dados[i]);
                }
            }

        }
        catch (MySqlException)
        {
            Console.WriteLine("erro");
            throw;
        }
    }
}