using System;

class Pessoa
{
    //Metodos 01
    public void apresentar()
    {
        Console.WriteLine("Olá!!!");

    }


    //Metodos 02
    public void apresentar(string nome)
    {
        Console.WriteLine("Olá " +nome);
    }

    //Metodos 03
        public void apresentar(string nome, int idade)
    {
        Console.WriteLine("Olá "  +nome+  " voce tem " +idade+ " anos ");
    }
}