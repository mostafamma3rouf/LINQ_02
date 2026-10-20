using LINQ_02.DataSource;
using LINQ_02.Models;
using System.Diagnostics.Metrics;
using System.Drawing;

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
            //var result = Source.ProductList.GroupBy(P => P.Category);

            //foreach (var item in result)
            //    Console.WriteLine($"{item.Key} - Product Count: {item.Count()}");

            #endregion

            #region 7. Group products by Category and project only product names per group
            //var result = Source.ProductList.GroupBy(P => P.Category);

            //foreach (var item in result)
            //{
            //    Console.WriteLine($"{item.Key}: ");
            //    foreach (var product in item)
            //        Console.WriteLine($"    {product.ProductName}");
            //}
            #endregion

            #region 8. Find all categories that have MORE THAN 3 products
            //var result = Source.ProductList.GroupBy(P => P.Category)
            //                               .Where(M => M.Count() > 3)
            //                               .Select(M => M.Key);

            #endregion

            #region 9. Using QUERY SYNTAX, group customers by Country, and for each group select { Country, Count, TotalOrderValue }.
            //var result = from P in Source.CustomerList
            //             group P by P.Country
            //             into G
            //             select new
            //             {
            //                 Country = G.Key,
            //                 Count = G.Count(),
            //                 TotalOrderValue = G.Sum(T => T.Orders.Sum(O => O.Total))
            //             };

            #endregion

            #region 10. Calculate the total number of units in stock across all products
            //var result = Source.ProductList.Sum(P => P.UnitsInStock);
            //Console.WriteLine(result);

            #endregion

            #region 11. Find the CHEAPEST and MOST EXPENSIVE product prices
            //var Cheapest = Source.ProductList.MinBy(P => P.UnitPrice);
            //Console.WriteLine($"Cheapest: {Cheapest}");

            //Console.WriteLine();

            //var MostExpensive = Source.ProductList.MaxBy(P => P.UnitPrice);
            //Console.WriteLine($"Most Expensive: {MostExpensive}");

            #endregion

            #region 12. Get a distinct list of all product categories
            //var result = Source.ProductList.Select(P => P.Category)
            //                               .Distinct()
            //                               .ToList();

            #endregion

            #region 13. find product IDs that are in setA but NOT in setB
            //int[] setA = { 1, 3, 5, 7, 9, 11, 13 };
            //int[] setB = { 3, 6, 9, 12, 15, 13 };

            //var result = setA.Except(setB).ToList();

            #endregion

            #region 14. Find countries that appear in list1 but NOT in list2 (case -insensitive).
            //string[] list1 = { "Germany", "France", "UK", "Spain" };
            //string[] list2 = { "france", "SPAIN", "Italy" };

            //var result = list1.Except(list2, StringComparer.OrdinalIgnoreCase).ToList();

            #endregion

            #region 15. Build a Dictionary<int, Product> keyed by ProductID. Then retrieve and print the product with ID = 18.
            //Dictionary<int, Product> productDictionary = Source.ProductList.ToDictionary(P => P.ProductID);

            //if (productDictionary.TryGetValue(18, out Product product))
            //    Console.WriteLine($"Product with ID 18: {product.ProductName}");

            //else
            //    Console.WriteLine("Product with ID 18 was not found.");

            #endregion

            #region 16. Get the first product whose price is greater than $50.
            //var result = Source.ProductList.First(P => P.UnitPrice > 50);
            //Console.WriteLine(result);

            #endregion

            #region 17. Try to get the first product with a price > $500. it returns null instead of throwing.
            //var result = Source.ProductList.FirstOrDefault(P => P.UnitPrice > 500);

            //if (result == null)
            //    Console.WriteLine("No product costs more than $500.");
            //else
            //    Console.WriteLine(result);

            #endregion

            #region 18. Generate a multiplication table row for 7
            var result = Enumerable.Range(1, 10).Select(i => $"7 x {i} = {7 * i}");

            foreach (var line in result)
                Console.WriteLine(line);
            #endregion


            //foreach (var item in result)
            //    Console.WriteLine(item);
        }
    }
}
