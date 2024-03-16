using System;
using System.Collections.Generic;

namespace PriorityQueueExample
{
    class Priority
    {
        static void Main(string[] args)
        {
            
            LinkedList<string> playerList = new LinkedList<string>();
            playerList.AddLast("Chris");
            playerList.AddLast("James");
            playerList.AddLast("Mark");
            playerList.AddLast("Ethan");
            playerList.AddLast("Brad");

           
            Console.WriteLine($"First player: {playerList.First?.Value}");

            
            Console.WriteLine($"Last player: {playerList.Last?.Value}");

            
            var middleNode = playerList.Find("Mark");
            if (middleNode != null)
            {
                playerList.AddAfter(middleNode, "Todd");
            }

           
            playerList.RemoveFirst();

          
            Console.WriteLine($"Number of players in the list: {playerList.Count}");

            
            Console.WriteLine("Players in the list:");
            foreach (var player in playerList)
            {
                Console.WriteLine(player);
            }
        }
    }
}
