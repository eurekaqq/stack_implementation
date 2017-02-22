using Console = System.Console;
using myStack;//using myStack

namespace test{
    class test{
        static void Main(){
            myStack<int> mystack = new myStack<int>();
            for(int i = 0;i<15; i++)
                mystack.push(i);
            for (int i = 0; i < 16; i++)//show over index
                Console.WriteLine(mystack.pop());
        }
    }
}
