using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace FirstApplication
{

    class MyProgram
    {
        //Creating an Array
        static void Main(string[] args)
        {

            Console.WriteLine("Enter Amount of Students: ");
            int amountofStudents = int.Parse(Console.ReadLine());

            double averageGrade = 0;
            double highestGrade = 0;
            string highestGradeName = "";

            string[] studentNames = new string[amountofStudents];
            double[] grades = new double[amountofStudents];

            for (int i = 0; i < amountofStudents; i++)
            {
                Console.WriteLine("Enter students #{0} name", i + 1);
                string name = Console.ReadLine();
                studentNames[i] = name;

                Console.WriteLine("Enter students #{0} grade", i + 1);
                double grade = double.Parse(Console.ReadLine());
                grades[i] = grade;

                averageGrade += grade;
                if (grade > highestGrade)
                {
                    highestGrade = grade;
                    highestGradeName = name;
                }
            }
            //printing
            averageGrade /= amountofStudents;
            Console.WriteLine("The Average grade of the class is {0}", averageGrade);
            Console.WriteLine("The Highest grade of the class is {0} and thier name was {1}", highestGrade, highestGradeName);
        }
    }
}
