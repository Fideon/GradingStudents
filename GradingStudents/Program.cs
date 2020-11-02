using System;
using System.Collections.Generic;
using System.Reflection.Metadata.Ecma335;

namespace GradingStudents
{
    class Program
    {
        static void Main(string[] args)
        {
            int gradesCount = Convert.ToInt32(Console.ReadLine().Trim());

            List<int> grades = new List<int>();

            for (int i = 0; i < gradesCount; i++)
            {
                int gradesItem = Convert.ToInt32(Console.ReadLine().Trim());
                grades.Add(gradesItem);
            }

            List<int> result = Result.gradingStudents(gradesCount, grades);

            Console.WriteLine(String.Join("\n", result));
        }

        class Result
        {
            public static List<int> gradingStudents(int gradesCount, List<int> grades)
            {
                for(int i = 0; i < gradesCount; i++)
                {
                    if (grades[i] >= 38)
                    {
                        int dif = grades[i] % 5;
                        if (dif >= 3)
                        {
                            grades[i] += (5 - dif);
                        }
                    }
                }

                return grades;
            }
        }
    }
}
