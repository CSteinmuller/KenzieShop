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
            decimal pop;
            decimal candy;
            decimal pen;
            decimal disk;
            decimal movie;
            decimal anime;
            decimal gum;
            decimal wax;
            decimal total = 0;
            string[] inputs = new string[8];
            Console.WriteLine("*********************************************");
            Console.WriteLine("**          Welcome to the eStore!         **");
            Console.WriteLine("*********************************************");
            Console.WriteLine("**Current Prices:                          **");
            Console.WriteLine("* *Super Pepsi   $ 7.50 | Candy     $ 9.79 **");
            Console.WriteLine("* *Fancy Pen     $ 1.99 | Harddrive $89.99 **");
            Console.WriteLine("* *Cool Movie    $19.99 | Animes    $27.49 **");
            Console.WriteLine("* *Fruity Gum    $ 0.69 | Wax(3oz)  $ 5.99 **");
            Console.WriteLine("* ********************************************");
            Console.WriteLine("");
            Console.WriteLine("What would you like to purchase today ?");
            Console.WriteLine("");
            Console.WriteLine("Super Pepsi?");
            Console.Write(">>");
            inputs[0] = Console.ReadLine();
            pop = Convert.ToDecimal(inputs[0]);
            Console.WriteLine("Fancy Pen?");
            Console.Write(">>");
            inputs[1] = Console.ReadLine();
            pen = Convert.ToDecimal(inputs[1]);
            Console.WriteLine("Cool Movie?");
            Console.Write(">>");
            inputs[2] = Console.ReadLine();
            movie = Convert.ToDecimal(inputs[2]);
            Console.WriteLine("Fruity Gum?");
            Console.Write(">>");
            inputs[3] = Console.ReadLine();
            gum = Convert.ToDecimal(inputs[3]);
            Console.WriteLine("Candy?");
            Console.Write(">>");
            inputs[4] = Console.ReadLine();
            candy = Convert.ToDecimal(inputs[4]);
            Console.WriteLine("Harddrive?");
            Console.Write(">>");
            inputs[5] = Console.ReadLine();
            disk = Convert.ToDecimal(inputs[5]);
            Console.WriteLine("Animes?");
            Console.Write(">>");
            inputs[6] = Console.ReadLine();
            anime = Convert.ToDecimal(inputs[6]);
            Console.WriteLine("Wax (3oz)?");
            Console.Write(">>");
            inputs[7] = Console.ReadLine();
            wax = Convert.ToDecimal(inputs[7]);
            Console.WriteLine("****************************************");
            Console.WriteLine("**              Receipt               **");
            Console.WriteLine("****************************************");
            Console.WriteLine("**    Item Name   | Count |   Total   **");
            Console.WriteLine("**------------------------------------**");
            Console.WriteLine("{0,10}{1,12}{2,8}{3,1}{4,1}", "** Super Pepsi", pop, "$", Decimal.Round(pop * 7.5m, 3), "**" );
            total = total + pop * 7.5m;
            Console.WriteLine("{0,10}{1,14}{2,8}{3,-1}{4,-1}", "** Fancy Pen", pen, "$", Decimal.Round(pen * 1.99m, 3), "**");
            total = total + pen * 1.99m;
            Console.WriteLine("{0,10}{1,13}{2,8}{3,-1}{4,-1}", "** Cool Movie", movie, "$", Decimal.Round(movie * 19.99m, 3), "**");
            total = total + (movie * 19.99m);
            Console.WriteLine("{0,10}{1,13}{2,8}{3,1}{4,1}", "** Fruity Gum", gum, "$", Decimal.Round(gum * 0.69m, 3), "**");
            total = total + (gum * 0.69m);
            Console.WriteLine("{0,8}{1,18}{2,8}{3,1}{4,1}", "** Candy", candy, "$", Decimal.Round(candy * 9.79m, 3), "**");
            total = total + (candy * 9.79m);
            Console.WriteLine("{0,10}{1,14}{2,8}{3,1}{4,1}", "** Harddrive", disk, "$", Decimal.Round(disk * 89.99m, 3), "**");
            total = total + (disk * 89.99m);
            Console.WriteLine("{0,8}{1,18}{2,8}{3,1}{4,1}", "** Anime", anime, "$", Decimal.Round(anime * 27.49m, 3), "**");
            total = total + (anime * 27.49m);
            Console.WriteLine("{0,10}{1,14}{2,8}{3,1}{4,1}", "** Wax (3oz)", wax, "$", Decimal.Round(wax * 5.99m, 3), "**");
            total = total + (wax * 5.99m);
            Console.WriteLine("**----------------------------------**");
            Console.WriteLine("{0,0}{1,1}{2,1}", "**                SUBTOTAL:   $ ", total," **");
            Console.WriteLine("{0,0}{1,1}{2,1}", "**               TAX (11%):   $ ", Decimal.Round(total * 0.11m, 2), " **");
            Console.WriteLine("**                           -------- **");
            Console.WriteLine("{0,0}{1,1}{2,1}", " **                   TOTAL:  $", Decimal.Round(total * 1.11m, 2)," **");
            Console.WriteLine("****************************************");
            Console.Read();
        }
    }
}
