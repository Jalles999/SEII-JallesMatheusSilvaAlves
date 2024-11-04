using System;

class Gerente
{
    // Metodo
    public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto gerente do vale alimentação R$"+(salario * 0.15));
    }
}