using System;

class Pessoa
{

//Atributos 
public double peso, altura;

//Calculo
public double calculo()
{
    return peso/(altura * altura);
}
//Situação
public string Situação()
{
    //variavel
    string retorno;
    //condição
    if(imc < 18.5)
    {
        retorno = "Abaixo do peso";
    }
    else if(imc < 25)
    {
        retorno = "peso normal";
    }
    else if(imc < 30)
    {
        retorno = "Acima do Peso";
    }
    else if(imc < 35)
    {
        retorno = "Obesidade 1";
    }
    else if(imc < 40)
    {
        retorno = "Obesidade 2";

    }
    else 
    {
        retorno = "Obesidade 3";
    }
    //Retorno
    return retorno;
}
//Mensagem
public void mensagem()
{
    //Obter calculo
    double obtercalculo = calculo();
    //Obrter situação 
    string obterSituacao = Situação(obtercalculo);
        //Exibir mensagem
       Console.writeLine("Seu IMC e de " +obtercalculo);
       Console.WriteLine("Sua situação é " +obterSituacao);
}
}