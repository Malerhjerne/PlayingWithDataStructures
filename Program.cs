using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlayingWithDataStructures
{
    class Program
    {
        static void Main()
        {
            // Excersize 1
            Console.WriteLine("Hey there stranger, thanks for taking you time to review my code" + "\n" + "excercise 1");
            Console.WriteLine("Using Queue to display number in the right order");
           
            // Using queue to print the numbers as they were entered (FIFO)
            int[] numbers = { 2, 5, 7 };
            Queue<int> numbersInQueue = new Queue <int>();

            // Loop through numbers array and Enqueu the numbers of the array Into the queue
            foreach(int i in numbers)
            {
                numbersInQueue.Enqueue(i);                
            }
            // Print loop
            foreach (int i in numbersInQueue)
            {
                Console.WriteLine(i);
            }

            // Using stack to solve the excercise    (LIFO)
            Console.WriteLine("Using Stack to display in reverse order");
            Stack<int> numbersInStack = new Stack <int>();
            int[] sameNumbers = { 2, 5, 7 };                              

            foreach(int i in sameNumbers)
            {
               numbersInStack.Push(i);
            }

            int[] numbersInStackToArray = numbersInStack.ToArray();     // storing Numbers in an array / just for fun

              // Print loop
            foreach (int i in numbersInStackToArray)
            {
                Console.WriteLine(i);
            }

        }
    }
}


/*
 * 
 * Write a program in C# Sharp to read n number of values and display it in reverse order. 
 * 
 * Try to use one of the structures we discussed in class.



Test Data (user input in bold):

Input the number of elements to store: 3

Input 3 elements:

element - 0 : 2

element - 1 : 5

element - 2 : 7



Expected Output:

The values store are:

2 5 7

The values store in reverse order are :

7 5 2
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * 
 * */



