using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BSUIR_Lab_7_Tasks_3
{
    public class CompareUserAge : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            if (x is null || y is null) throw new ArgumentException("Не допустимый тип ");

            return x.Age - y.Age;
        }
    }

    public class ComparerUserId : IComparer<User>
    {
        public int Compare(User? x, User? y)
        {
            if (x is null || y is null) throw new ArgumentException("Не допустимый тип ");

            return x.id - y.id;
        }
    }
}
