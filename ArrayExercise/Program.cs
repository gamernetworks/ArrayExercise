using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ArrayExercise
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ////////////////////////////////////////////////////////////////////////////////////////////
            // 1. Write a program in C# to store elements in an array and print it (ascending order). //
            ////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("1. Write a program in C# to store elements in an array and print it" +
                " (ascending order.)");

            string originalArrayInput = ""; // I will use this to later to check if the string is a Palindrome
            const int ELEMENTS_ARRAY = 5;
            int[] originalArray = new int[ELEMENTS_ARRAY]; // To be used on problem #6
            int[] elements = new int[ELEMENTS_ARRAY];


            Console.WriteLine("> Store up to 5 numbers: ");

            for (int i = 0; i < elements.Length; i++)
            {
                elements[i] = Convert.ToInt32(Console.ReadLine());
                originalArray[i] = elements[i];
                originalArrayInput += elements[i];                
            }

            Array.Sort(elements);
            Console.Write("\n> Result: Elements in the Array in ascending order are: ");
            for (int i = 0; i < elements.Length; i++)
            {
                Console.Write(elements[i]);
                if (i < elements.Length - 1)
                    Console.Write(", ");
            }
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////////////////////////////////
            // 2. Write a program in C# to read n number of values in an array and display it in reverse order. //
            //////////////////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n2. Write a program in C# to read n number of values in an array and display" +
                " it in reverse order.");

            int numberOfElements = 0;
            Console.Write("- How many elements do you want in your Array? ");
            
            numberOfElements = int.Parse(Console.ReadLine());
            int[] array2 = new int[numberOfElements];

            Console.WriteLine("- Store up to {0} numbers: ", numberOfElements);
            for (int i = 0; i < array2.Length; i++)
            {
                array2[i] = Convert.ToInt32(Console.ReadLine());
            }

            Console.Write("\n> Elements in the array in descending order are as follows: ");
            Array.Reverse(array2);
            for (int i = 0; i < array2.Length; i++)
            {
                Console.Write(array2[i]);
                if (i < array2.Length - 1)
                    Console.Write(", ");
            }
            Console.ReadKey();


            ///////////////////////////////////////////////////////////////////////////
            // 3.Write a program in C# to find the sum of all elements of the array. //
            ///////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n3. Write a program in C# to find the sum of all elements of the array.");
            int[] array3 = { 5, 12, 6, 57, 6, 3 };
            int sumElements = 0;

            for (int i = 0; i <= array3.Length - 1; i++)
            {
                sumElements += array3[i];
            }
            Console.WriteLine("> The sum of an array with elements 5, 12, 6, 57, 6, and 3 is: {0}", sumElements);
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////
            // 4.Write a program in C# to find if a string is Palindrome or not. //
            ///////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n4.Write a program in C# to find if a string is Palindrome or not.");

            char[] reversedArray = originalArrayInput.ToCharArray(); // Step 1
            Array.Reverse(reversedArray); // Step 2
            string palindromeTest = new String(reversedArray); // Step 3

            if (originalArrayInput == palindromeTest) // Step 4
            {
                Console.WriteLine("> Exercise #1 Array String is a Palindrome");
            }
            else
                Console.WriteLine("> Exercise #1 Array String is not a Palindrome");
            Console.ReadKey();

            /////////////////////////////////////////////////////////////
            // 4. Ask User for a string to check if it is a Palindrome //
            /////////////////////////////////////////////////////////////

            string userInput = "";
            string reversedUserInput = "";

            Console.Write("\n> Enter a string to check for Palindrome: ");
            userInput = Console.ReadLine();

            int lenght = userInput.Length - 1;
            for(; lenght >= 0; lenght--)
            {
                reversedUserInput += userInput[lenght];
            }
            if (userInput == reversedUserInput)
                Console.WriteLine("\n> The Array String is a Palindrome");
            else
                Console.WriteLine("\n> The Array String is not a Palindrome");
            Console.ReadKey();

            ////////////////////////////////////////////////////////////////////////////////////////
            // 5.Write a program in C# to count a total number of duplicate elements in an array. //
            ////////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n5.Write a program in C# to count a total number of duplicate elements " +
                "in an array.");

            int count = 0;
            int[] array5 = { 2,6,8,4,1,5,9,3,6,1};
            Console.Write("\n> In Array { 1,2,6,8,4,1,5,9,3,6,1 }, the following numbers repeat: ");
            for(int i = 0; i < array5.Length; i++)
            {
                for (int j = (i + 1); j < array5.Length; j++)
                {
                    if (array5[i]== array5[j])
                    {
                        Console.Write(array5[j]);
                        count++;
                        if (j < array5.Length - 1)
                            Console.Write(", ");
                    }
                }
            }
            Console.WriteLine("\n> There are " + count + " duplicates in this array");
            Console.ReadKey();

            ////////////////////////////////////////////////////////////      
            // 6.Write a program in C# to sort the elements in array. //
            ////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n6.Write a program in C# to sort the elements in array.");

            int [] array6 = { 2,6,8,4,12,5,9,3,6,1};
            int selection = 0;

            Console.WriteLine("> The Array elements are 2, 6, 8, 4, 1, 5, 9, 3, 6, and 1.\n> Press 1 to sort it in" +
                " ascending order or Press 2 to sort it in descending order: ");

            do
            {
                switch (selection = int.Parse(Console.ReadLine()))
                {
                    case 1:
                        Array.Sort(array6);
                        Console.Write("> The result is: ");
                        for (int i = 0; i < array6.Length; i++)
                        {
                            Console.Write(array6[i]);
                            if (i < array6.Length - 1)
                                Console.Write(", ");
                        }
                        break;
                    case 2:
                        Array.Sort(array6);
                        Array.Reverse(array6);
                        Console.Write("> The result is: ");
                        for (int i = 0; i < array6.Length; i++)
                        {
                            Console.Write(array6[i]);
                            if (i < array6.Length - 1)
                                Console.Write(", ");
                        }
                        break;
                    default:
                        Console.WriteLine("> You have made an invalid selection. Please try again.");
                        break;
                }
            } while (selection < 1 || selection > 2);
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////////
            // 7.Write a program in C# to separate odd and even integers in separate arrays. //
            ///////////////////////////////////////////////////////////////////////////////////

            int[] array7 = { 32, 29, 8, 4, 11, 5, 9, 3, 64, 45, 53, 22 };
            int arrayLenght = array7.Length;

            double[] array7even = new double[arrayLenght];
            double[] array7odd = new double[arrayLenght];
            //string e;

            int evenCount = 0;
            int oddCount = 0;

            Console.WriteLine("\n\n\n7.Write a program in C# to separate odd and even integers in separate arrays.");
            Console.WriteLine("> The original array elements are: 32, 29, 8, 4, 11, 5, 9, 3, 64, 45, 53, and 22");

            for(int i = 0; i < array7.Length; i++)
            {
                if (array7[i] % 2 == 0)
                {
                    array7even[evenCount] = array7[i];
                    evenCount++;
                }
                else
                {
                    array7odd[oddCount] = array7[i];
                    oddCount++;
                }
            }

            Console.Write("\n> New Array with even numbers: ");
            foreach(var i in array7even)
            {
                Console.Write(i + ", ");
            }

            Console.Write("\n> New Array with odd numbers: ");
            foreach (var i in array7odd)
            {
                Console.Write(i + ", ");
            }
            Console.ReadKey();

            /////////////////////////////////////////////////////////////////////////////////////
            // 8.Write a program in C# to delete an element at desired position from an array. //
            /////////////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n8.Write a program in C# to delete an element at desired position from" +
                " an array.");

            int[] array8 = new int [] { 2, 23, 8, 4, 12, 5 };
            int arrayLength = array8.Length;
            int desiredLocation = 0;

            Console.Write("> The Array elements are 2, 23, 8, 4, 12, and 5.\n> Which element would" +
            " you like to delete? (Use numbers 1 through {0}, from left to right): ", arrayLength);

            desiredLocation = Convert.ToInt32(Console.ReadLine());
            while(desiredLocation != 0 && desiredLocation <= (arrayLength -1))
            {
                array8[desiredLocation-1] = array8[desiredLocation];
                desiredLocation++;
            }

            arrayLength = array8.Length - 1;
            Console.Write("\n> The new array now looks like this: ");
            for (int i = 0; i < arrayLength; i++)
            {
                Console.Write(array8[i]);
                if (i < array8.Length - 1)
                    Console.Write(", ");
            }
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////////
            // 9.Write a program in C# to find the second smallest element in an array. //
            //////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n9.Write a program in C# to find the second smallest element in an array.");

            int[] array9 = { 2, 6, 8, 4, 12, 5, 9, 3, 6, 1 };
            Console.Write("> The Array elements are 2, 6, 8, 4, 1, 5, 9, 3, 6, and 1.");

            Array.Sort(array9);

            if(array9[0] < array9[1] && array9[1] < array9[2])
            {
                Console.WriteLine("\n> The second smallest element in this array is the element with a " +
                "value of {0}", array9[1]);
            }
            else if(array9[0] == array9[1] && array9[1] < array9[2])
            {
                Console.WriteLine("\n> The second smallest element in this array is the element with a " +
                "value of {0}", array9[2]);
            }
            else if(array9[0] < array9[1] && array9[1] == array9[2])
            {
                Console.WriteLine("\n> The second smallest elements in this array are the elements # 1 and 2" +
                    " with value of {0}",array9[1]);
            }
            Console.ReadKey();

            ///////////////////////////////////////////////////////////////////////////////
            // 10.Write a program in C# for a 2D array of size 3x3 and print the matrix. //
            ///////////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n10.Write a program in C# for a 2D array of size 3x3 and print the matrix.");
            Console.Write("> The Array is Matrix format is:\n\n");
            var array10 = new int[3, 3]
            {
                { 1,2,3 },
                { 4,5,6 },
                { 7,8,9 }
            };

            for (int i = 0; i < array10.GetLength(0); i++)
            {
                for (int j = 0; j < array10.GetLength(0); j++)
                {
                    Console.Write(array10[i,j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            /////////////////////////////////////////////////////////////////////////
            // 11.Write a program in C# for addition of two Matrices of same size. //
            /////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n11.Write a program in C# for addition of two Matrices of same size.");

            int[,] array11a = new int[3,3]
            {
                { 3,2,3 },
                { 4,5,6 },
                { 7,3,9 }
            };
            int[,] array11b = new int[3,3]
            {
                { 1,6,3 },
                { 9,2,3 },
                { 1,7,4 }
            };
            int[,] array11c = new int[3, 3];

            Console.WriteLine("\n> First Array:\n");
            for (int i = 0; i < array11a.GetLength(0); i++)
            {
                for (int j = 0; j < array11a.GetLength(0); j++)
                {
                    Console.Write(array11a[i, j] + "\t");
                }
                Console.WriteLine();
            }

            Console.WriteLine("\n> Second Array:\n");
            for (int i = 0; i < array11b.GetLength(0); i++)
            {
                for (int j = 0; j < array11b.GetLength(0); j++)
                {
                    Console.Write(array11b[i, j] + "\t");
                }
                Console.WriteLine();
            }
            
            Console.WriteLine("\n> The sum of both arrays yields:\n");
            for(int i = 0; i < array11a.GetLength(0); i++)
            {
                for(int j = 0; j < array11b.GetLength(0); j++)
                {
                    array11c[i,j] = array11a[i,j] + array11b[i,j];
                    Console.Write(array11c[i, j] + "\t");
                }
                Console.WriteLine();
            }
            Console.ReadKey();

            /////////////////////////////////////////////////////////////////////////////////////////////////
            // 12.Write a program in C# to check if any two elements in array sum to a given input number. //
            /////////////////////////////////////////////////////////////////////////////////////////////////


            Console.WriteLine("\n\n\n12.Write a program in C# to check if any two elements in array sum to" +
                " a given input number.");

            int[] array12 = new int[] { 2, 23, 8, 4, 12, 5 };
            int desiredSumValue = 12;

            for(int i = 0; i < arrayLength -1; i++)
            {
                for(int j = (i+1); j < arrayLength; j++)
                {
                    if (array12[i] + array12[j] == desiredSumValue)
                        Console.WriteLine("> A pair of elements {0} and {1}, when added together, do add up to" +
                            " {2}", array12[i], array12[j], desiredSumValue);
                }
            }
            Console.WriteLine("> No pairs when added together in the array add up to {0}",
                    desiredSumValue);
            Console.ReadKey();

            /////////////////////////////////////////////////////////////////////
            // 13.Write a program in C# to sort the array in descending order. //
            /////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n13.Write a program in C# to sort the array in descending order.");

            int[] array13 = { 2, 6, 8, 4, 12, 5, 9, 3, 6, 1 };

            Console.Write("> The Array elements are 2, 6, 8, 4, 1, 5, 9, 3, 6, and 1." +
            "\n> The Array in in descending order is: ");
            Array.Sort(array13);
            Array.Reverse(array13);
            for (int i = 0; i < array13.Length; i++)
                {
                    Console.Write(array13[i]);
                    if (i < array13.Length - 1)
                        Console.Write(", ");
                }
            Console.ReadKey();

            //////////////////////////////////////////////////////////////////////////
            // 14.Write a C# program to swap minimum and maximum elements in array. //
            //////////////////////////////////////////////////////////////////////////

            Console.WriteLine("\n\n\n14.Write a C# program to swap minimum and maximum elements in array.");

            int[] array14 = { 2, 6, 8, 4, 12, 5, 9, 3, 6, 1 };
            int maxValueIndex = 0;
            int minValueIndex = 0;
            int maxValue = 0;
            int minValue = 0;

            Console.WriteLine("> The Array elements are 2, 6, 8, 4, 12, 5, 9, 3, 6, and 1.");
            for (int i = 1; i < array14.Length; i++)
            {
                if (array14[maxValueIndex] > array14[i])          
                    maxValueIndex = i;
                if (array14[minValueIndex] < array14[i])
                    minValueIndex = i;
            }

            maxValue = array14[maxValueIndex];
            minValue = array14[minValueIndex];
            array14[maxValueIndex] = minValue;
            array14[minValueIndex] = maxValue;

            Console.Write("> Array after swap looks like: ");
            for(int i = 0; i < array14.Length; i++)
            {
                Console.Write(array14[i] + ", ");
            }
            Console.WriteLine();
            Console.ReadKey();
        }
    }
}
