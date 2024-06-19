/*
1. You are a student who has recently taken an exam with your classmates. However, the professor has not yet provided the students with a sorted list of exam scores. 
To make things easier, you write a program to sort exam scores in ascending order using the selection sort algorithm. 
This way, you can obtain the sorted list of scores and see how you performed compared to your classmates. Also, you choose selection sort since that is an easy way of implementation.
*/

using System.Data;

namespace Assignment_7._1._1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] grades = { 80, 90, 75, 85, 62, 98, 92 };
            //int[] grades = { 80, 60, 75 };
            //int[] grades = { 60, 65, 70, 80, 75, 63, 59 };

            SortedGrades sortedGrades = new SortedGrades();


            int[] sortedArray = sortedGrades.SortGrades(grades);

            sortedGrades.PrintArray(sortedArray);


        }

        public class SortedGrades
        {
            public int[] SortGrades(int[] grades) 
            {
                // outer loop points to the diviing line between the sorted and unsorted
                for (int i = 0; i < grades.Length-1; i++)// iterates through the array except the last element
                {
                    // tracks the index of the minimum value to swap later. initializing the minimum element to the current index
                    int minIndex = i;
                    for (int j = i + 1; j < grades.Length; j++) // iterates through all of the unsorted array
                    {
                        if (grades[j] < grades[minIndex]) // compares elements to find the minimum value in the unsorted array 
                        {
                            minIndex = j; //updates the index of the minimum element
                        }
                    }

                    int temp = grades[minIndex]; //temporarily stores the minimum element
                    grades[minIndex] = grades[i]; //places the element at 'i' in the position of the minimum element
                    grades[i] = temp; // Places the miniumelement in the position 'i'
                }
                return grades;
            }

            public void PrintArray(int[] sortedArray)
            {
                foreach (var item in sortedArray)
                {
                    Console.WriteLine(item + " ");
                }

            }
        }
    }
}
