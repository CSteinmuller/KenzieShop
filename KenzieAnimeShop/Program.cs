using System;

namespace KenzieAnimeShop
{
    class KenzieShop
    {
        static void Main()
        {
            // Number of each item to be purchased
            int popCount;
            int candyCount;
            int penCount;
            int diskCount;
            int movieCount;
            int animeCount;
            int gumCount;
            int waxCount;
            decimal total = 0; // Total
            
            // These could be one WriteLine but I'm trying to keep it all without side scrolling for now
            Console.WriteLine("********************************************* \n**          Welcome to the eStore!         ** \n*********************************************");
            Console.WriteLine("* Current Prices:                          ** \n* *Super Pepsi   $ 7.50 | candy     $ 9.79 ** \n* *Fancy Pen     $ 1.99 | Harddrive $89.99 **");
            // Skip an extra line here
            Console.WriteLine("* *Cool Movie    $19.99 | Animes    $27.49 ** \n* *Fruity Gum    $ 0.69 | Wax(3oz)  $ 5.99 ** \n* ******************************************** \n");
            // Read in number of each item to be purchased

            Console.WriteLine("What would you like to purchase today ? \n");
            Console.WriteLine("Super Pepsi?");
            Console.Write(">> ");
            popCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fancy Pen?");
            Console.Write(">> ");
            penCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cool Movie?");
            Console.Write(">> ");
            movieCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fruity Gum?");
            Console.Write(">> ");
            gumCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Candy?");
            Console.Write(">> ");
            candyCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Harddrive?");
            Console.Write(">> ");
            diskCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Animes?");
            Console.Write(">> ");
            animeCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Wax (3oz)?");
            Console.Write(">> ");
            waxCount = Int32.Parse(Console.ReadLine());

            // Printing the recipt
            Console.WriteLine("**************************************** \n**              Receipt               **\n****************************************");
            Console.WriteLine("**    Item Name   | Count |   Total   **\n** ---------------------------------- **");
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Super Pepsi", popCount, "$", Decimal.Round(popCount * 7.5m, 3));
            total += (decimal)popCount * 7.5m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Fancy Pen", penCount, "$", Decimal.Round(penCount * 1.99m, 3));
            total += (decimal)penCount * 1.99m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Cool Movie", movieCount, "$", Decimal.Round(movieCount * 19.99m, 3));
            total += (decimal)movieCount * 19.99m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Fruity Gum", gumCount, "$", Decimal.Round(gumCount * 0.69m, 3));
            total += (decimal)gumCount * 0.69m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Candy", candyCount, "$", Decimal.Round(candyCount * 9.79m, 3));
            total += (decimal)candyCount * 9.79m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Harddrive", diskCount, "$", Decimal.Round(diskCount * 89.99m, 3));
            total += (decimal)diskCount * 89.99m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Anime", animeCount, "$", Decimal.Round(animeCount * 27.49m, 3));
            total += (decimal)animeCount * 27.49m;
            Console.WriteLine("** {0,-15}{1,8}{2,4}{3,7:##0.00} **", "Wax (3oz)", waxCount, "$", Decimal.Round(waxCount * 5.99m, 3));
            total += (decimal)waxCount * 5.99m;

            // Subtotal, tax, and total
            Console.WriteLine("** ---------------------------------- **");
            Console.WriteLine("{0,0}{1,7:##0.00}{2,-4}", "**                SUBTOTAL:  $", total, " **");
            Console.WriteLine("{0,0}{1,7:##0.00}{2,-4}", "**               TAX (11%):  $", Decimal.Round(total * 0.11m, 2), " **");
            Console.WriteLine("**                           -------- **");
            Console.WriteLine("{0,0}{1,7:##0.00}{2,-4}", "**                   TOTAL:  $", Decimal.Round(total * 1.11m, 2)," **");
            Console.WriteLine("****************************************");
            Console.Read(); // Does not read anything, here to prevent console from closing
        }
    }
}
