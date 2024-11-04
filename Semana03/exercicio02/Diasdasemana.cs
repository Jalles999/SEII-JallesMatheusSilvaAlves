string[] myArray = new string[7]; 

//dias da semana

myArray[0] = "Monday";
myArray[1] = "Tuesday";
myArray[2] = "Wednesday";
myArray[3] = "Thursday";
myArray[4] = "Friday";
myArray[5] = "Saturday";
myArray[6] = "Sunday";


for  (int i = 0; i < myArray.Length; i++)
{
    // Exibe o valor de cada elemento do array no console.
    Console.WriteLine(myArray[i]);
}

// Declaração de uma lista
List<string> list = new List<string>();


list.Add("Monday");
list.Add("Tuesday");
list.Add("Wednesday");
list.Add("Thursday");
list.Add("Friday");
list.Add("Saturday");
list.Add("Sunday");

// Loop 'for' que percorre todos os elementos da lista 'list'.
for (int i = 0; i < list.Count; i++)
{
    //abreviação do dia.
    list[i] = list[i].Substring(0, 3);
    
    Console.WriteLine(list[i]);
}


Dictionary<int, string> dictionary = new Dictionary<int, string>();

// Atribuição de valores ao dicionário usando índices como chaves (0 a 6).

dictionary[0] = "Monday";
dictionary[1] = "Tuesday";
dictionary[2] = "Wednesday";
dictionary[3] = "Thursday";
dictionary[4] = "Friday";
dictionary[5] = "Saturday";

// Adiciona o valor "Sunday" à chave 6 do dicionário, usando o método Add.

dictionary.Add(6, "Sunday");


for (int i = 0; i < dictionary.Count; i++)
{
    
    dictionary[i] = dictionary[i].Substring(0, 3);
    
    // Exibe o valor abreviado do dia no console.
    Console.WriteLine(dictionary[i]);
}
