//Linear Search Array

int[] intArry = new int[] (1,2,3,4,5,6,7,8,9,10);

bool LinearSeach(int[] array,int key)
{
    for (int i = 0; i < array.Length; i++)
    {
        if (arry[i] == key)
        {
            return true;
        }
    }
    return false;
}

Console.WriteLine(LinearSeach(array, 0));