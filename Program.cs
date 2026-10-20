using LINQ_02.Models;
using LINQ_02.DataSource;

namespace LINQ_02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            #region 1. Get top 3 most expensive products
            //var result = Source.ProductList.OrderByDescending(P => P.UnitPrice)
            //                               .Take(3);
            #endregion

            #region 2. show page 2 of products, with page size = 5
            //int PageSize = 5;
            //int Page = 2;
            //var result = Source.ProductList.OrderBy(P => P.ProductName)
            //                               .Skip(PageSize * (Page - 1))
            //                               .Take(PageSize);
            #endregion

            #region 3. Take products from the list as long as Their UnitPrice is less than $25(list is ordered by price).
            //var result = Source.ProductList.OrderBy(P => P.UnitPrice)
            //                               .TakeWhile(P => P.UnitPrice < 25);
            #endregion

            #region 4. Check if ALL products in the "Seafood" category are in stock
            //var result = Source.ProductList.All(P => P.Category == "Seafood" && P.UnitsInStock > 0);
            //Console.WriteLine(result);

            #endregion

            #region 5. Check if the ID list contains 9 int[] ids = { 3, 9, 13, 18 };
            //int[] ids = { 3, 9, 13, 18 };
            //Console.WriteLine($"Contains 9: {ids.Contains(9)}");

            #endregion

            #region 6. Group all products by Category and print each group with its product count.
            var result = Source.ProductList.GroupBy(P => P.Category);

            foreach (var item in result)
                Console.WriteLine($"{item.Key} - Product Count: {item.Count()}");
            
            #endregion


            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
