using System;

class PessoaFisica : Padrao
{
    //Metodo Obrigatorio

    public override void taxaEmprestimo(double valor)
    {
        Console.WriteLine("Taxa de emprestimo para Pessoa Fisica R$ "+(valor*0.1));
    }
}