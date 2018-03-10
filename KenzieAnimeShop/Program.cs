using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using static System.Console;

namespace KenzieAnimeShop
{
    class KenzieShop
    {
        static void Main(string[] args)
        {
            int popCount;
            int candyCount;
            int penCount;
            int diskCount;
            int movieCount;
            int animeCount;
            int gumCount;
            int waxCount;
            decimal total = 0;
            //these could be one WriteLine but I'm trying to keep it all without side scrolling for now
            Console.WriteLine("********************************************* \n**          Welcome to the eStore!         ** \n*********************************************");
            Console.WriteLine("* Current Prices:                          ** \n* *Super Pepsi   $ 7.50 | candy     $ 9.79 ** \n* *Fancy Pen     $ 1.99 | Harddrive $89.99 **");
            //skip an extra line here
            Console.WriteLine("* *Cool Movie    $19.99 | Animes    $27.49 ** \n* *Fruity Gum    $ 0.69 | Wax(3oz)  $ 5.99 ** \n* ******************************************** \n");
            Console.WriteLine("What would you like to purchase today ? \n");
            Console.WriteLine("Super Pepsi?");
            Console.Write(">>");
            popCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fancy Pen?");
            Console.Write(">>");
            penCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Cool Movie?");
            Console.Write(">>");
            movieCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Fruity Gum?");
            Console.Write(">>");
            gumCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("candyCount?");
            Console.Write(">>");
            candyCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Harddrive?");
            Console.Write(">>");
            diskCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Animes?");
            Console.Write(">>");
            animeCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("Wax (3oz)?");
            Console.Write(">>");
            waxCount = Int32.Parse(Console.ReadLine());
            Console.WriteLine("****************************************");
            Console.WriteLine("**              Receipt               **");
            Console.WriteLine("****************************************");
            Console.WriteLine("**    Item Name   | Count |   Total   **");
            Console.WriteLine("** ---------------------------------- **");
            Console.WriteLine("{0,10}{1,12}{2,8}{3,1}{4,1}", "** Super Pepsi", popCount, "$", Decimal.Round(popCount * 7.5m, 3), "**" );
            total += (decimal)popCount * 7.5m;
            Console.WriteLine("{0,10}{1,14}{2,8}{3,-1}{4,-1}", "** Fancy Pen", penCount, "$", Decimal.Round(penCount * 1.99m, 3), "**");
            total += (decimal)penCount * 1.99m;
            Console.WriteLine("{0,10}{1,13}{2,8}{3,-1}{4,-1}", "** Cool Movie", movieCount, "$", Decimal.Round(movieCount * 19.99m, 3), "**");
            total += (decimal)movieCount * 19.99m;
            Console.WriteLine("{0,10}{1,13}{2,8}{3,1}{4,1}", "** Fruity Gum", gumCount, "$", Decimal.Round(gumCount * 0.69m, 3), "**");
            total += (decimal)gumCount * 0.69m;
            Console.WriteLine("{0,8}{1,18}{2,8}{3,1}{4,1}", "** candy", candyCount, "$", Decimal.Round(candyCount * 9.79m, 3), "**");
            total += (decimal)candyCount * 9.79m;
            Console.WriteLine("{0,10}{1,14}{2,8}{3,1}{4,1}", "** Harddrive", diskCount, "$", Decimal.Round(diskCount * 89.99m, 3), "**");
            total += (decimal)diskCount * 89.99m;
            Console.WriteLine("{0,8}{1,18}{2,8}{3,1}{4,1}", "** Anime", animeCount, "$", Decimal.Round(animeCount * 27.49m, 3), "**");
            total += (decimal)animeCount * 27.49m;
            Console.WriteLine("{0,10}{1,14}{2,8}{3,1}{4,1}", "** Wax (3oz)", waxCount, "$", Decimal.Round(waxCount * 5.99m, 3), "**");
            total += (decimal)waxCount * 5.99m;
            Console.WriteLine("** -------------------------------- **");
            Console.WriteLine("{0,0}{1,1}{2,1}", "**                SUBTOTAL:   $ ", total," **");
            Console.WriteLine("{0,0}{1,1}{2,1}", "**               TAX (11%):   $ ", Decimal.Round(total * 0.11m, 2), " **");
            Console.WriteLine("**                           -------- **");
            Console.WriteLine("{0,0}{1,1}{2,1}", " **                   TOTAL:  $", Decimal.Round(total * 1.11m, 2)," **");
            Console.WriteLine("****************************************");
            Console.Read();
        }
    }
}
