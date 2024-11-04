//Arrays
//Arrays Insertions & Deletions

// Inserting at the end of an Arry

int[] intArray = new int[6];

//uma variavel para manter o comprimento do ponto e baseado na capacidade

int length = 0;


for (int i = 0; i < 3; i++)
{
    intArray[length] = i;
    length++;
}

//intArray[length] = 0;
//length++;

//Inserting at the start of an arry
//for (int i = 3; i >= 0; i--);
//{
    //intArray(i + 1) = intArray[i];
//}
//intArray[0] = 20;

//int value  = 0;

for (int i = 0;i>=2;i--)
{
    intArray[i + 1] = intArray[i];
}

intArray[2] = 0;

int value = 0;