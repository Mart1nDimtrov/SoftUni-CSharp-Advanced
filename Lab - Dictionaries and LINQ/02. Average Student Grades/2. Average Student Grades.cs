using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _02.Average_Student_Grades
{
    class Program
    {
        static void Main(string[] args)
        {

            int count = int.Parse(Console.ReadLine());
            Dictionary<string, List<double>> students = new Dictionary<string, List<double>>();

            for (int i = 0; i < count; i++)
            {
                string[] student = Console.ReadLine()
                                    .Split(new char[] { ' ' }, StringSplitOptions.RemoveEmptyEntries)
                                    .ToArray();
                string studentName = student[0];
                double studentGrade = double.Parse(student[1]);
                if (students.ContainsKey(studentName))
                {
                    students[studentName].Add(studentGrade);
                }
                else
                {
                    students[studentName] = new List<double>();
                    students[studentName].Add(studentGrade);

                }

            }

            foreach (KeyValuePair<string, List<double>> student in students)
            {
                string[] grades = student
                                    .Value
                                    .Select(x => String.Format("{0:F2}", x))
                                    .ToArray();

                Console.WriteLine("{0} -> {1} (avg: {2:F2})", student.Key, string.Join(" ", grades), student.Value.Average());
            }


        }
    }
}
