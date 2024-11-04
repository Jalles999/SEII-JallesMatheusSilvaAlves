using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace video1.Stack
{
    public class Stack
    {
        public int MaxSize { get; set; }
        public string[] StackArray { get; set; }
        public int Top {  get; set; }   
        public Stack(int size)
        { 
            this.MaxSize = size;
            //creat array with size
            this.StackArray = new string[Maxsize];
            // we give the top -1 because array is zero index
            this.Top = -1;
        }
        public void Push(string item)
        {
            Top++;
            StackArray[Top] = item;
        }  
        
        public string Pop()
        {
            int old_Top = Top;
            Top--;
            return StackArray[old_Top];
        }
        public string Peek()
        {
            return StackArray[Top];
        }
        public bool isEmpty()
        {
            return Top == 0;
        }
        public bool isFull()
        {
            return MaxSize - 2 == Top;
        }
    }
}
