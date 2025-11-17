using System;
using System.Collections.Generic;

namespace CSharpStudy.Code.Core
{
    public class ObjectsList
    {
        static void ListOfObjects(string[] args)
        {
            // Creating a list that can store objects of class Player
            List<Player> players = new List<Player>();
        
            // Creating player objects and adding them to the list
            players.Add(new Player("Ken"));
            players.Add(new Player("Steve"));
            players.Add(new Player("Jang"));

            // Using a foreach to iterate on our list of objects to get the players username
            foreach (Player player in players)
            {
                Console.WriteLine(player.username);
            
                // Overwriting the ToString method to access a class method.
                Console.WriteLine(player);
            }
        }
    }

    class Player
    {
        public string username;

        public Player(String username)
        {
            this.username = username;
        }

        public override string ToString()
        {
            return username;
        }
    } 
}

