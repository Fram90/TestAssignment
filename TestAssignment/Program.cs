using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;

namespace TestAssignment
{
    class Program
    {
        static void Main(string[] args)
        {
            List<TravelCard> cardSet = new List<TravelCard>()
            {
                new TravelCard("Test7", "Test8"),
                new TravelCard("Test6", "Test7"),
                new TravelCard("Test5", "Test6"),
                new TravelCard("Test4", "Test5"),
                new TravelCard("Test3", "Test4"),
                new TravelCard("Test2", "Test3"),
                new TravelCard("Test1", "Test2")
            };

            Console.WriteLine(TravelCardExtensions.SortCards(cardSet).Print());
            Console.ReadLine();
        }
    }
}
