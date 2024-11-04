using System;

class Atendente
{
      public override void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto Atendente do vale alimentação R$"+(salario * 0.12));
    }
}