// Bubble sort 

int[] intArray = new int[] {6,5,1,7,2,4};


int[] value = BubbleSort(intArray);
int joker = 0;

int[] BubbleSort(int[] array)
{
    int temp = 0;

    for (int pointer  = 0; pointer < array.Length; pointer++)
    {
        for(int sort  = 0; sort < array.Length; sort++)
        {
            if (array[sort] > array[sort + 1])
            {
                 temp = array[sort + 1];
                array[sort] = temp;
            }
        }
    }
    return array;
}   