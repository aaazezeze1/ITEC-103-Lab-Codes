/******************************************************************************

Instance Methods WORKS IN VISUAL STUDIO BUT NOT IN ONLINEGDB DUE TO DOTNET VERSION BEING OLD

*******************************************************************************/
using System;

using System.Collections;
class InstanceMethod
{
    // STRING
    public class Name
    {
        string name = "Amazing";

        public Name(string name)
        {
            this.name = name;
        }

        public void Greeting()
        {
            Console.WriteLine(String.Format("Hello {0}!", name));
        }
    }
    // MATH
    public class Root
    {
        int num = 64;

        public void RootNum()
        {
            Console.WriteLine(Math.Sqrt(num));
        }
    }
    // ARRAY
    public class ArrayEx
    {
        string[] cars = { "Volvo", "BMW", "Ford", "Mazda" };

        public void PrintCars()
        {
            foreach (string car in cars)
            {
                Console.WriteLine(car);
            }
        }
    }
    // LIST
    public class PrintList
    {
        List<string> subjects = new List<string>() { "English", "Math" };

        public void ListItems()
        {
            Console.WriteLine("The first element of the list is " + subjects[0]);
            Console.WriteLine("The second element of the list is " + subjects[1]);
        }
    }
    // QUEUE
    public class FruitQ
    {
        public static string[] FruitsArr = { "Apple", "Orange", "Kiwi", "Banana" };
        Queue<string> fruitsQueue = new Queue<string>(FruitsArr);

        public void PrintFruit()
        {
            foreach (string item in fruitsQueue)
            {
                Console.WriteLine(item);
            }
        }
    }
    // STACK
    public class MyStacks()
    {
        public static string[] stockNames = { "Jollibee", "Ayala", "SM" };
        Stack<string> MyStocks = new Stack<string>(stockNames);

        public void PrintStock()
        {
            foreach (string stocks in MyStocks)
            {
                Console.WriteLine(stocks);
            }
        }
    }

    static void Main()
    {
        // String, Math, Array, List, Queue, and Stack

        // Output: Hello Amaze!
        Name myName = new Name("Amaze");
        myName.Greeting();

        // Output: 8
        Root rNum = new Root();
        rNum.RootNum();

        // Output:
        // Volvo
        // BMW
        // Ford
        // Mazda
        ArrayEx displayArr = new ArrayEx();
        displayArr.PrintCars();

        // Output:
        // The first element of the list is English
        // The second element of the list is Math
        PrintList listSubs = new PrintList();
        listSubs.ListItems();

        // Output:
        // Apple
        // Orange
        // Kiwi
        // Banana
        FruitQ displayFruit = new FruitQ();
        displayFruit.PrintFruit();

        // Output:
        // SM
        // Ayala
        // Jollibee
        MyStacks PrintMyStocks = new MyStacks();
        PrintMyStocks.PrintStock();
    }
}
