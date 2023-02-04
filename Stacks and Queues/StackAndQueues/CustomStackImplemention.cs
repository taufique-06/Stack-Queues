using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StackAndQueues
{
    public class CustomStackImplemention
    {
        //a stack is a sort of array. Array is the main datastructure where the data is placed
        protected int[] data;
        private static int DEFAULT_SIZE = 10; //giving the array a default size
        private int pointer = -1;

        public CustomStackImplemention()
        {
            this.data = new int[DEFAULT_SIZE];
        }

        public CustomStackImplemention(int size)
        {
            this.data = new int[size];
        }

        public virtual Boolean push(int item) // using virtual because we will override this method in DynamicCustomStackImplementation class
        {
            if (IsFull())
            {
                Console.WriteLine("Stack is Full");
                return false;
            }
            pointer++;
            data[pointer] = item;
            return true;
        }

        public bool IsFull()
        {
            return pointer == data.Length - 1;
        }

        public int pop()
        {
            if (IsEmpty())
            {
                throw new Exception("Can not remove from an empty stack");
            }
            return data[pointer--];
        }

        private bool IsEmpty()
        {
            return pointer ==  -1;
        }

        public int peek()
        {
            return data[pointer];
        }
    }
}
