using System;


class Users{
    private string Nome;
    private int Idade;

    public string getNome (){
        return Nome;
    }
    public void setNome(string nome){
        Nome = nome;
    }
    public int getIdade(){
        return Idade;
    }
    public void sertIdade(int idade){
        Idade = idade;
    }
   public Users(string nome, int idade){
        Nome = nome;
        Idade = idade;
   }
}