namespace LinQ01
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var ProductList = ListGenerator.ProductsList;
            var CustomerList = ListGenerator.CustomersList;

            #region Restriction Operators
            //Console.WriteLine("=== Restriction Operators ===");
            //var outOfStockProducts = ProductList.Where(p => p.UnitsInStock == 0);
            //Console.WriteLine("\n1. Out of Stock Products:");
            //foreach (var product in outOfStockProducts)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //var inStockExpensiveProducts = ProductList.Where(p => p.UnitsInStock > 0 && p.UnitPrice > 3.00M);
            //Console.WriteLine("\n2. In-Stock Expensive Products:");
            //foreach (var product in inStockExpensiveProducts)
            //{
            //    Console.WriteLine($"{product.ProductName} - Price: {product.UnitPrice}");
            //}

            //string[] digits = { "zero", "one", "two", "three", "four", "five", "six", "seven", "eight", "nine" };
            //var result = digits.Where((digit, index) => digit.Length < index);
            //Console.WriteLine("\n3. Digits with names shorter than their value:");
            //foreach (var digit in result)
            //{
            //    Console.WriteLine(digit);
            //}
            //Console.WriteLine("\n====================================================================================================================");
            #endregion

            #region Element Operators
            //Console.WriteLine("\n=== Element Operators ===");

            //var firstOutOfStockProduct = ProductList.FirstOrDefault(p => p.UnitsInStock == 0);
            //Console.WriteLine("\n1. First Out of Stock Product:");
            //Console.WriteLine(firstOutOfStockProduct?.ProductName ?? "No out-of-stock products found.");

            //var firstExpensiveProduct = ProductList.FirstOrDefault(p => p.UnitPrice > 1000);
            //Console.WriteLine("\n2. First Product with Price > 1000:");
            //Console.WriteLine(firstExpensiveProduct?.ProductName ?? "No product found with price > 1000.");

            //int[] numbers = { 5, 4, 1, 3, 9, 8, 6, 7, 2, 0 };
            //var secondNumberGreaterThan5 = numbers.Where(n => n > 5).Skip(1).FirstOrDefault();
            //Console.WriteLine("\n3. Second Number Greater Than 5:");
            //Console.WriteLine(secondNumberGreaterThan5);
            //Console.WriteLine("\n====================================================================================================================");
            #endregion

            #region Aggregate Operators
            //Console.WriteLine("\n=== Aggregate Operators ===");

            //var oddNumberCount = numbers.Count(n => n % 2 != 0);
            //Console.WriteLine("\n1. Number of Odd Numbers:");
            //Console.WriteLine(oddNumberCount);

            //var customerOrderCounts = CustomerList.Select(c => new { c.CustomerID, OrderCount = c.Orders.Count() });
            //Console.WriteLine("\n2. Customers and Their Order Counts:");
            //foreach (var customer in customerOrderCounts)
            //{
            //    Console.WriteLine($"{customer.CustomerID}: {customer.OrderCount} orders");
            //}

            //var categoryProductCounts = ProductList.GroupBy(p => p.Category).Select(g => new { Category = g.Key, ProductCount = g.Count() });
            //Console.WriteLine("\n3. Categories and Their Product Counts:");
            //foreach (var category in categoryProductCounts)
            //{
            //    Console.WriteLine($"{category.Category}: {category.ProductCount} products");
            //}

            //var total = numbers.Sum();
            //Console.WriteLine("\n4. Total of Numbers in Array:");
            //Console.WriteLine(total);

            //string dictionaryPath = @"D:\Route\Assignments\C#\LinQ\1\LinQ01\LinQ01\dictionary_english.txt";
            //var words = File.ReadAllLines(dictionaryPath);
            //var totalCharacters = words.Sum(word => word.Length);
            //Console.WriteLine("\n5. Total Number of Characters in Dictionary:");
            //Console.WriteLine(totalCharacters);

            //var shortestWordLength = words.Min(word => word.Length);
            //Console.WriteLine("\n6. Length of the Shortest Word:");
            //Console.WriteLine(shortestWordLength);

            //var longestWordLength = words.Max(word => word.Length);
            //Console.WriteLine("\n7. Length of the Longest Word:");
            //Console.WriteLine(longestWordLength);

            //var averageWordLength = words.Average(word => word.Length);
            //Console.WriteLine("\n8. Average Length of Words:");
            //Console.WriteLine(averageWordLength);
            //Console.WriteLine("\n====================================================================================================================");
            #endregion

            #region Ordering Operators
            //Console.WriteLine("\n=== Ordering Operators ===");

            //var sortedProductsByName = ProductList.OrderBy(p => p.ProductName);
            //Console.WriteLine("\n1. Products Sorted by Name:");
            //foreach (var product in sortedProductsByName)
            //{
            //    Console.WriteLine(product.ProductName);
            //}

            //string[] wordsArray = { "aPPLE", "AbAcUs", "bRaNcH", "BlUeBeRrY", "ClOvEr", "cHeRry" };
            //var sortedWords = wordsArray.OrderBy(w => w, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("\n2. Case-Insensitive Sorted Words:");
            //foreach (var word in sortedWords)
            //{
            //    Console.WriteLine(word);
            //}

            //var sortedProductsByStock = ProductList.OrderByDescending(p => p.UnitsInStock);
            //Console.WriteLine("\n3. Products Sorted by Units in Stock (Descending):");
            //foreach (var product in sortedProductsByStock)
            //{
            //    Console.WriteLine($"{product.ProductName} - Stock: {product.UnitsInStock}");
            //}

            //var sortedDigits = digits.OrderBy(d => d.Length).ThenBy(d => d);
            //Console.WriteLine("\n4. Digits Sorted by Name Length and Alphabetically:");
            //foreach (var digit in sortedDigits)
            //{
            //    Console.WriteLine(digit);
            //}

            //var sortedWordsByLengthAndCase = wordsArray.OrderBy(w => w.Length).ThenBy(w => w, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("\n5. Words Sorted by Length and Case-Insensitive:");
            //foreach (var word in sortedWordsByLengthAndCase)
            //{
            //    Console.WriteLine(word);
            //}

            //var sortedProductsByCategoryAndPrice = ProductList.OrderBy(p => p.Category).ThenByDescending(p => p.UnitPrice);
            //Console.WriteLine("\n6. Products Sorted by Category and Price (Descending):");
            //foreach (var product in sortedProductsByCategoryAndPrice)
            //{
            //    Console.WriteLine($"{product.Category} - {product.ProductName} - Price: {product.UnitPrice}");
            //}

            //var sortedWordsByLengthAndDescendingCase = wordsArray.OrderBy(w => w.Length).ThenByDescending(w => w, StringComparer.OrdinalIgnoreCase);
            //Console.WriteLine("\n7. Words Sorted by Length and Case-Insensitive Descending:");
            //foreach (var word in sortedWordsByLengthAndDescendingCase)
            //{
            //    Console.WriteLine(word);
            //}

            //var reversedDigitsWithSecondLetterI = digits.Where(d => d.Length > 1 && d[1] == 'i').Reverse();
            //Console.WriteLine("\n8. Reversed Digits with Second Letter 'i':");
            //foreach (var digit in reversedDigitsWithSecondLetterI)
            //{
            //    Console.WriteLine(digit);
            //}
            //Console.WriteLine("\n====================================================================================================================");
            #endregion

            #region Transformation Operators
            //Console.WriteLine("\n=== Transformation Operators ===");

            //var productNames = ProductList.Select(p => p.ProductName);
            //Console.WriteLine("\n1. Product Names:");
            //foreach (var name in productNames)
            //{
            //    Console.WriteLine(name);
            //}

            //var upperLowerWords = wordsArray.Select(w => new { Upper = w.ToUpper(), Lower = w.ToLower() });
            //Console.WriteLine("\n2. Uppercase and Lowercase Words:");
            //foreach (var word in upperLowerWords)
            //{
            //    Console.WriteLine($"{word.Upper} / {word.Lower}");
            //}

            //var productDetails = ProductList.Select(p => new { p.ProductName, Price = p.UnitPrice, p.Category });
            //Console.WriteLine("\n3. Product Details:");
            //foreach (var product in productDetails)
            //{
            //    Console.WriteLine($"{product.ProductName} - Price: {product.Price} - Category: {product.Category}");
            //}

            //var matchingNumbers = numbers.Select((num, index) => num == index);
            //Console.WriteLine("\n4. Numbers Matching Their Index:");
            //foreach (var match in matchingNumbers)
            //{
            //    Console.WriteLine(match);
            //}

            //int[] numbersA = { 0, 2, 4, 5, 6, 8, 9 };
            //int[] numbersB = { 1, 3, 5, 7, 8 };
            //var pairs = from a in numbersA from b in numbersB where a < b select new { A = a, B = b };
            //Console.WriteLine("\n5. Pairs of Numbers (A < B):");
            //foreach (var pair in pairs)
            //{
            //    Console.WriteLine($"{pair.A} < {pair.B}");
            //}

            //var ordersLessThan500 = CustomerList.SelectMany(c => c.Orders).Where(o => o.Total < 500.00M);
            //Console.WriteLine("\n6. Orders with Total < 500:");
            //foreach (var order in ordersLessThan500)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Total: {order.Total}");
            //}

            //var ordersFrom1998OrLater = CustomerList.SelectMany(c => c.Orders).Where(o => o.OrderDate.Year >= 1998);
            //Console.WriteLine("\n7. Orders from 1998 or Later:");
            //foreach (var order in ordersFrom1998OrLater)
            //{
            //    Console.WriteLine($"Order ID: {order.OrderID}, Date: {order.OrderDate.ToShortDateString()}");
            //}
            #endregion
        }
    }
}