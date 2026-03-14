using GradeBook.Enums;
using GradeBook.GradeBooks;

namespace GradeBook.UserInterfaces
{
    public class StandardGradeBook : BaseGradeBook
    {
        public StandardGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}