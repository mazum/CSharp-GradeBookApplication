using GradeBook.Enums;

namespace GradeBook.GradeBooks
{
    public class StandarGradeBook : BaseGradeBook
    {
        public StandarGradeBook(string name) : base(name)
        {
            Type = GradeBookType.Standard;
        }
    }
}
