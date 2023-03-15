using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class RankedGradeBook: BaseGradeBook
    {
        public RankedGradeBook(String name):base(name)
        {
            Type = Enums.GradeBookType.Ranked;
        }
        public override char GetLetterGrade(double averageGrade)
        {
            if (Students.Count < 5)
            {
                throw new InvalidOperationException();
            }
            Students.Sort((emp1, emp2) => emp1.AverageGrade.CompareTo(emp2.AverageGrade));
            
            

           if(averageGrade >= Students[(int)(Students.Count * 0.8)].AverageGrade)
            {
                return 'A';
            }
            else if (averageGrade >= Students[(int)(Students.Count * 0.6)].AverageGrade)
            {
                return 'B';
            }
            else if (averageGrade >= Students[(int)(Students.Count * 0.4)].AverageGrade)
            {
                return 'C';
            }
            else if (averageGrade >= Students[(int)(Students.Count * 0.2)].AverageGrade)
            {
                return 'D';
            }
            else
            {
                return 'F';
            }

        }
    }
}
