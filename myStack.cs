using IndexOutOfRangeException = System.IndexOutOfRangeException;
using Object = System.Object;

namespace myStack{
    class myStack<T>{
        int num;
        int maxSize;
        T[] stack;

        public myStack(){
        	num = 0;
        	maxSize = 8;
            stack = new T[maxSize];
        }

        public void push(T value){
            if (num < maxSize)
                stack[num++] = value;
            else{
                maxSize *= 2;
                T[] temp = new T[maxSize];
                for (int i = 0; i < stack.Length; ++i)
                    temp[i] = stack[i];
                temp[num++] = value;
                stack = temp;    
            }
        }

        public Object pop(){
            T temp;

            try{
                temp =  stack[--num];
                return temp;
            }
            catch(IndexOutOfRangeException e){
                return e;
            }
            
        }

        public int number(){
            return num;
        }
    }
}
