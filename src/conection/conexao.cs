using System;
using MySql.Data.MySqlClient;

//classe de conexao com o banco
public class Conectar{
    MySqlConnection con = new MySqlConnection();
    //construtor q ira possuir a string de conexão ou seja o endereço
    public Conectar(){
        con.ConnectionString = "datasource = localhost; username = root; password = sirlei231; database = testando";
    }
    //metodo que conecta ao banco
    public MySqlConnection conexao(){
        if(con.State == System.Data.ConnectionState.Closed){
            con.Open();
            
        }
        return con;
    }
    //Metodo que desconecta do banco
    public void desconexao(){
        if (con.State == System.Data.ConnectionState.Open){
            con.Close();
           
        }
    }
}
