using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GradeBook.GradeBooks
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(String name,bool isWeighted):base(name,isWeighted) 
        {
            base.Type = Enums.GradeBookType.Standard;
        }
    }
}
