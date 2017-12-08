using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rock_Paper_Scissors_CS
{
    public class Program
    {
        public static void Main(string[] args)
        {
            Console.WriteLine("Somewhere in a Mos Eisley cantina. . . \n" +
                "RULES:\n" + "- Han vs. Greedo\n" + "- Best 2/3 wins\n" + "- (Hint: Using the scissors backwards has unexpected results . . .)\n\n");

            Player pl = new Player();
            Console.WriteLine("==========GAME START==========\n");
            pl.GameStart(pl);
        }
    }

    public class Player
    {
        public Random rnd;
        public string[] moves;
        public int pPnts;
        public int cPnts;
        public string pm;
        public string cm;
        public bool done;
        public string cp { get; set; }
        public string hum { get; set; }

        public void GameStart(Player pl)
        {
            moves = new string[] { "rock", "paper", "scissors" };
            rnd = new Random();
            hum = "Han Solo ";
            cp = "Greedo ";
            pPnts = 0;
            cPnts = 0;

            done = false;
            while (true)
            {
                if (pl.pPnts >= 3 || pl.cPnts >= 3)
                    break;
                Console.WriteLine("\nEnter your choice:\n");
                pl.pm = Console.ReadLine().ToLower();
                pl.cm = moves.ElementAt(pl.rnd.Next(moves.Length)).ToLower();

                if (pl.pm == moves[0] || pl.pm == moves[1] || pl.pm == moves[2])
                {
                    Console.WriteLine(hum + "chose " + pl.pm + "\n");
                    Console.WriteLine(cp + "chose " + pl.cm + "\n");
                }

                if (pl.pm == pl.cm)
                {
                    Console.WriteLine("\n-= It's a draw! =- \n\n" + "Han: {0} - CP: {1}", pl.pPnts.ToString(), pl.cPnts.ToString());
                }

                if (pl.cm == moves[0] && pl.pm == moves[1])
                {
                    pl.pPnts = pl.pPnts + 1;
                    Console.WriteLine("\n -= {0}won =-\n\nHan: {1} - CP: {2}", pl.hum, pl.pPnts.ToString(), pl.cPnts.ToString());
                }

                if (pl.cm == moves[0] && pl.pm == moves[2])
                {
                    pl.cPnts = pl.cPnts + 1;
                    Console.WriteLine("\n -= {0}won =-\n\nHan: {1} - CP: {2}", pl.cp, pl.pPnts.ToString(), pl.cPnts.ToString());
                }

                if (pl.cm == moves[1] && pl.pm == moves[0])
                {
                    pl.cPnts = pl.cPnts + 1;
                    Console.WriteLine("\n -= {0}won =-\n\nHan: {1} - CP: {2}", pl.cp, pl.pPnts.ToString(), pl.cPnts.ToString());
                }

                if (pl.cm == moves[1] && pl.pm == moves[2])
                {
                    pl.pPnts = pl.pPnts + 1;
                    Console.WriteLine("\n -= {0}won =-\n\nHan: {1} - CP: {2}", pl.hum, pl.pPnts.ToString(), pl.cPnts.ToString());
                }

                if (pl.cm == moves[2] && pl.pm == moves[1])
                {
                    pl.cPnts = pl.cPnts + 1;
                    Console.WriteLine("\n -= {0}won =-\n\nHan: {1} - CP: {2}", pl.cp, pl.pPnts.ToString(), pl.cPnts.ToString());
                }

                if (pl.cm == moves[2] && pl.pm == moves[0])
                {
                    pl.pPnts = pl.pPnts + 1;
                    Console.WriteLine("\n -= {0}won =-\n\nHan: {1} - CP: {2}", pl.hum, pl.pPnts.ToString(), pl.cPnts.ToString());
                }
                if (pl.pm == "srossics")
                {
                    Console.WriteLine("*CHEAT DETECTED*");
                    pl.pPnts = pl.pPnts + 574885045;
                }
            }

            if (pl.cPnts > pl.pPnts)
            {
                Console.WriteLine("{0}won with {1} points.\n", pl.cp, pl.cPnts.ToString());
                Console.WriteLine(pl.hum + "is Arrested and sent to Jabba's Palace in \na carbon freezing chamber!\n" + "You lose!");
                Console.WriteLine("==========GAME OVER==========");
                Console.ReadLine();
            }
            else
            {
                Console.WriteLine("{0}won with {1} points.\n", pl.hum, pl.pPnts.ToString());
                Console.WriteLine(pl.hum + "shoots " + pl.cp +  "at point blank range; killing him instantly...\n" + "You Are victorious!\n");
                Console.WriteLine("==========GAME OVER==========");
                Console.ReadLine();
            }

        }
    }
}
