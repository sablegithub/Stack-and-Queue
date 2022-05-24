// See https://aka.ms/new-console-template for more information
using StackExp;


public class Program
{
    public static void Main(String[] args)
    {
        Console.WriteLine("\nList of Option");
        Console.WriteLine("1.Push Element into Stack");
        Console.WriteLine("2.Pop Element into Stack");
        Console.WriteLine("3.Peek Element of the Stack");
        Console.WriteLine("Enter Your Choice:");
        int Choice = Convert.ToInt32(Console.ReadLine());
        switch (Choice)
        {
           case 1:
                Stack obj1 = new Stack();
                obj1.push(56);
                obj1.push(30);
                obj1.push(70);
                obj1.Display();
                break;
           case 2:
                Stack obj2 = new Stack();
                obj2.push(56);
                obj2.push(30);
                obj2.push(70);
                obj2.Display();
                obj2.pop();
                obj2.Display();
                break;
            case 3:
                Stack obj3 = new Stack();
                obj3.push(56);
                obj3.push(30);
                obj3.push(70);
                obj3.Display();
                obj3.peek();
                break;
            default:
                Console.WriteLine("Enter Correct Choice");
                break;
        }

        //Stack objstack = new Stack();
        //objstack.push(10);
        //objstack.push(20);
        //objstack.push(30);
        //objstack.push(40);
        //objstack.push(50);
        //objstack.Display();
        //objstack.pop();
        //objstack.Display();
        //objstack.peek();
     }
}