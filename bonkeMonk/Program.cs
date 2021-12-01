using System;
using RestSharp;
using System.Text.Json;

namespace bonkeMonk
{
    class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                RestClient client = new RestClient("https://pokeapi.co/api/v2/");
                string searchAnswer = "";
                Console.WriteLine("Welcome to a Pokemon Database, made to simplify your playthrough\ncreated by: Edvin Forsling");
                Console.WriteLine("\nSearch for desired Pokémon:");
                Console.CursorTop -= 1;
                Console.CursorLeft += 28;
                searchAnswer = Console.ReadLine().Trim().ToLower();
                RestRequest request = new RestRequest($"pokemon/{searchAnswer}");

                IRestResponse response = client.Get(request);

                // System.Console.WriteLine(response.Content);
                if (response.StatusCode == System.Net.HttpStatusCode.NotFound)
                {
                    Console.WriteLine("Error 404: Not Found!\n Press Enter To Continue");
                }
                else
                {

                    Pokemon ditto = JsonSerializer.Deserialize<Pokemon>(response.Content);
                    ditto.PrintStat("speed");
                    ditto.PrintStat("attack");
                    ditto.PrintStat("special-attack");
                    ditto.PrintStat("defense");
                    ditto.PrintStat("special-defense");
                    ditto.PrintStat("hp");
                }






                Console.ReadLine();
                Console.Clear();

            }


        }
    }
}
