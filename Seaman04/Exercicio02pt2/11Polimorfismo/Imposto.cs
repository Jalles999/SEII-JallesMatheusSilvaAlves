using System;

class Imposto
{
    //Metodos
    public virtual void valeAlimentação(double salario)
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$"+(salario * 0.1));

    }
    public void valeTransporte(double salario) 
    {
        Console.WriteLine("Desconto padrão do vale alimentação R$"+(salario * 0.06));
    }
}