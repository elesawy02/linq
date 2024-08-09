using Session01;

namespace linq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Product> products = ListGenerator.ProductList.Where(ListGenerator.ProductList.Contains).ToList();

            #region
            //var outOfStockProducts = from p in products
            //                         where p.UnitsInStock == 0
            //                         select p;

            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} is out of stock.");
            //}
            #endregion

            #region
            //var ProductInStock = from p in products
            //                               where p.UnitsInStock > 0 && p.UnitPrice > 3.00m
            //                               select p;

            //foreach (var product in ProductInStock)
            //{
            //    Console.WriteLine($"{product.ProductName}:: Price {product.UnitPrice} ");
            //}
            #endregion

            #region

            //string[] Arr = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };

            //var result = Arr.Select((name, index) => new { Name = name, Value = index })
            //                .Where(x => x.Name.Length < x.Value)
            //                .Select(x => x.Value);

            //foreach (var item in result)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region
            //var productname = products.Select(p => p.ProductName);
            //foreach (var item in productname)
            //{
            //    Console.WriteLine(item);
            //}
            #endregion

            #region
            //string[] words = { "aPPLE", "BlUeBeRrY", "cHeRry" };

            //var wordVariants = words.Select(word => new
            //{
            //    Uppercase = word.ToUpper(),
            //    Lowercase = word.ToLower()
            //});

            //foreach (var variant in wordVariants)
            //{
            //    Console.WriteLine($"Uppercase: {variant.Uppercase}, Lowercase: {variant.Lowercase}");
            //}
            #endregion

            #region
            //var product = products.Select(p => new
            //{
            //    p.ProductName,
            //    p.UnitPrice
            //});
            //foreach (var item in product)
            //{
            //    Console.WriteLine($" ProductName:: {item.ProductName}  >>>  productPrice  {item.UnitPrice}");


            //}
            #endregion


            #region 
            //int[] Arr = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };

            //var matches = Arr.Select((value, index) => new
            //{
            //    Value = value,
            //    Index = index,
            //    Matches = value == index
            //});

            //foreach (var item in matches)
            //{
            //    Console.WriteLine($" {item.Value}  {item.Matches}");
            //}
            #endregion


            #region 
            //int[] numberA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numberB = { 1, 3, 5, 7, 8 };


            //var pair = from a in numberA
            //           from b in numberB
            //           where a < b
            //           select new { A = a, B = b };
            //foreach (var item in pair)
            //{
            //    Console.WriteLine($"{item.A} is less than {item.B}");
            //}
            #endregion



            #region 
            //var lowValueOrders = Order.Where(o => o.Total < 500.00m);


            //foreach (var order in lowValueOrders)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, Total: {order.Total:C}");
            //}
            #endregion
            #region
            //var recentOrders = orders.Where(o => o.OrderDate.Year >= 1998);

            //foreach (var order in recentOrders)
            //{
            //    Console.WriteLine($"OrderID: {order.OrderID}, OrderDate: {order.OrderDate.ToShortDateString()}, Total: {order.Total:C}");
            //}
            #endregion

        }
    }
}