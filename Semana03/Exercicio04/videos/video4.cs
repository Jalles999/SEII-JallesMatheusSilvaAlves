//Arrays
//Arrays Insertions & Deletions

int[] intArry = new int[9];

int length = 0;
for (int i = 0; i < 6; i++)
{
    intArry[length] = i;
    length++;
}

for(int i = 2; i < length; i++)
{
    intArry[i-1] = intArry[i];
}

length--;

for (int i = 0; 1 < length; i++)
{
    Console.WriteLine(intArry[i]);
}

//length--;
//for(int i =1; i < length; i++)
//{
//intArry(i - 1) = intArry[i] ;
//}

//length--;

