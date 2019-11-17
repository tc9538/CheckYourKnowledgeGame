using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CheckYourKnowledgeGame
{
    class Program
    {
        static void Main(string[] args)
        {
            Rules r = new Rules();
            r.playerOrder();
            for (int i = 0; i < 5; i++)
            {
                r.play(i);
            }
            r.winnerAnnouncement();
            Console.ReadLine(); //prevent console from automatically closing
        }
    }
}
