using System.Linq;
// always add this if need ng arraylist, sorted list and stack
//using System.Collections.Generic;
using System.Collections;

namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // get top element and bottom element
            Stack stkTopBottom = new Stack();
            stkTopBottom.Push("Cabiles");
            stkTopBottom.Push("Gapit");
            stkTopBottom.Push("Mama Mary");

            // Create another stack
            Stack stkBottomTop = new Stack();

            //  Get the topmost element
            Console.WriteLine("The top most element in the stack is: " + stkTopBottom.Peek());

            // while the original stack count is not zero then push to the new stack then pop
            // the only element that will be left in the new stack is Cabiles
            while(stkTopBottom.Count != 0)
            {
                stkBottomTop.Push(stkTopBottom.Pop());
            }
            
            Console.WriteLine("The bottom element in the stack is: " + stkBottomTop.Peek());
        }

    }
}
