using System;
using System.Linq;
using System.Collections.Generic;

namespace MOBA_Challenger
{
    class Program
    {
        static void Main(string[] args)
        {
            //player.Key and Dictionary(position.Key and skill.Value)
            var players = new Dictionary<string, Dictionary<string, int>>();
            //player.Key and total sum of skill.Value
            var playersNames = new Dictionary<string, int>();
            //list of "positions" for first player
            var playerList1 = new List<string>();
            //list of "positions" for second player
            var playerList2 = new List<string>();

            string data = Console.ReadLine();

            while (data.Contains(" -> "))
            {
                string[] delimiters = new string[] { " vs ", " -> " };
              
                string[] input = data.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Season end")
                {
                    break;
                }

                if (!data.Contains("vs"))
                {
                    string player = input[0];
                    string position = input[1];
                    int skill = int.Parse(input[2]);

                    if (!players.ContainsKey(player))
                    {
                        players.Add(player, new Dictionary<string, int>());
                        players[player][position] = skill;
                    }
                    else if (!players[player].ContainsKey(position))
                    {
                        players[player][position] = skill;
                    }
                    else if (players[player].ContainsKey(position))
                    {
                        if (players[player][position] < skill)
                        {
                            players[player][position] = skill;
                        }
                    }
                }
                data = Console.ReadLine();
            }//while loop ends here

            //add player.Key and the sum of skill.Value to playersNames Dictionary
            foreach (var player in players)
            {
                foreach (var position in player.Value)
                {
                    if (!playersNames.ContainsKey(player.Key))
                    {
                        playersNames.Add(player.Key, position.Value);
                    }
                    else
                    {
                        playersNames[player.Key] = playersNames[player.Key] + position.Value;
                    }
                }
            }

            while (data.Contains(" vs "))
            {
                string[] delimiters = new string[] { " vs ", " -> " };
              
                string[] input = data.Split(delimiters, StringSplitOptions.RemoveEmptyEntries).ToArray();

                if (input[0] == "Season end")
                {
                    break;
                }

                if (data.Contains("vs"))
                { 
                    string player1 = input[0];
                    string player2 = input[1];

                    if (players.ContainsKey(player1) && players.ContainsKey(player2))
                    {
                        //add "positions" to first player
                        foreach (var player in players)
                        {
                            foreach (var position in player.Value)
                            {
                                if (player.Key == player1)
                                {
                                    playerList1.Add(position.Key);
                                }
                            }
                        }

                        //add "positions" to second player
                        foreach (var player in players)
                        {
                            foreach (var position in player.Value)
                            {
                                if (player.Key == player2)
                                {
                                    playerList2.Add(position.Key);
                                }
                            }
                        }

                        //compare the 2 lists for equal "positions"
                        bool isTrue = false;
                        for (int i = 0; i < playerList1.Count; i++)
                        {
                            for (int j = 0; j < playerList2.Count; j++)
                            {
                                if (playerList1[i] == playerList2[j])
                                {
                                    isTrue = true;
                                }
                            }
                            
                        }

                        //if true remove player from "players" Dictionary and from "playersNames" Dictionary
                        if (isTrue)
                        {
                            if (playersNames[player1] > playersNames[player2])
                            {
                                players.Remove(player2);
                                playersNames.Remove(player2);
                            }
                            else if (playersNames[player1] < playersNames[player2])
                            {
                                players.Remove(player1);
                                playersNames.Remove(player1);
                            }
                            
                        }

                        //clear the lists. they have to be empty
                        playerList1.Clear();
                        playerList2.Clear();
                    }
                }

                data = Console.ReadLine();

            }//while loop ends here.

            //Print
            foreach (var player in playersNames.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
            {
                Console.WriteLine($"{player.Key}: {player.Value} skill");

                foreach (var play in players)
                {
                    if (player.Key == play.Key)
                    {
                        foreach (var position in play.Value.OrderByDescending(x => x.Value).ThenBy(x => x.Key))
                        {
                            Console.WriteLine($"- {position.Key} <::> {position.Value}");
                        }
                    }
                }
            }
        }
    }
}
