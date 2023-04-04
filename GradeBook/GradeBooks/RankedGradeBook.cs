using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(String name,bool isWeighted):base(name,isWeighted)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {  
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            List<Student> v = new List<Student>(Students);
            v.Sort((student1, student2) => student1.AverageGrade.CompareTo(student2.AverageGrade));
            
            

           if(averageGrade >= v[(int)(v.Count * 0.8)].AverageGrade)
            {
                return 'A';
            }
            else if (averageGrade >= v[(int)(v.Count * 0.6)].AverageGrade)
            {
                return 'B';
            }
            else if (averageGrade >= v[(int)(v.Count * 0.4)].AverageGrade)
            {
                return 'C';
            }
            else if (averageGrade >= v[(int)(v.Count * 0.2)].AverageGrade)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }
       
        }
        public override void CalculateStatistics()
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");

            }
            else
            {
                base.CalculateStatistics();
            }

        }
        public override void CalculateStudentStatistics(string name)
        {
            if (Students.Count < 5)
            {
                Console.WriteLine("Ranked grading requires at least 5 students.");

            }
            else
            {
                base.CalculateStudentStatistics(name);

            }
        }
    }
}
