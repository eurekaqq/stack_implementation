using IndexOutOfRangeException = System.IndexOutOfRangeException;
using Object = System.Object;

namespace myStack
{
    class myStack<T>
    {
        int num = 0;
        int maxSize = 8;
        T[] stack;

        public myStack()
        {
            stack = new T[8];
        }

        public void push(T pu)
        {
            if (num < maxSize)
            {
                stack[num++] = pu;
            }
            else
            {
                maxSize *= 2;
                T[] temp = new T[maxSize];
                for (int i = 0; i < stack.Length; ++i)
                    temp[i] = stack[i];
                temp[num] = pu;
                num++;
                stack = temp;
                
            }
        }

        public Object pop()
        {
            T temp;

            try
            {
                temp =  stack[--num];
                return temp;

            }
            catch(IndexOutOfRangeException e)
            {
                return e;
            }


            
        }

        public int number()
        {
            return num;
        }
    }
}
