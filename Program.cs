using LINQ_02.Models;
using LINQ_02.DataSource;

namespace LINQ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get top 3 most expensive products
            var result = Source.ProductList.OrderByDescending(P => P.UnitPrice)
                                           .Take(3);
            #endregion

            foreach (var item in result)
                Console.WriteLine(item);
        }
    }
}
