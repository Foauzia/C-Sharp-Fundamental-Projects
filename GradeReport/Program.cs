using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeReport
{
    public class StudentReport
    {
        public int[] CreditHr { get; set; }
        public int[] Marks { get; set; }

        public decimal calculateGPA()
        {
            decimal[] gpa = new decimal[CreditHr.Length];
            char [] grades  = new char[CreditHr.Length];
            decimal gpaSum = 0.0M;
            int CreditHrSum = 0;
            for (int i= 0; i  < Marks.Length; i++)
            {
                grades[i] = this.calculateGrade(Marks[i]);
                gpa[i]= this.calculateGradePoint(grades[i]) * CreditHr[i];
                gpaSum += gpa[i];
                CreditHrSum += CreditHr[i];
            }
            return gpaSum / CreditHrSum;

        }
        private decimal calculateGradePoint(char grade)
        {
            if (grade== 'A')
            {
                return 4.0M;
            }
            if(grade == 'B')
            {
                return 3.0M;
            }
            if(grade== 'C')
            {
                return 2.0M;
            }
            if(grade== 'D')
            {
                return 1.0M;
            }
            else
            {
                return 0.0M;
            }
        }
        private char calculateGrade( int mark)
        {
            char result = ' ';
            if(mark > 90)
            {
                result = 'A';
            }
            else if(mark > 70)
            {
                result = 'B';
            }
            else if(mark > 50)
            {
                result = 'C';
            }
            else if (mark > 40)
            {
                result = 'D';
            }
            else
            {
                result = 'F';
            }
            return result;

        }
        public static void Main()
        {
            StudentReport sr = new StudentReport();
            sr.CreditHr = new int[6];
            sr.CreditHr = [5, 1, 4, 1, 2, 2];
            sr.Marks = [100, 100, 100, 100, 100, 100];
           var studReport = sr.calculateGPA();
            //var sReport = sr.calculateGrade();
            Console.WriteLine(studReport);
            //Console.WriteLine(sReport);
            Console.ReadLine();
           
        }
    }

}