using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text.Json;
using System.Text.Json.Serialization;
using Newtonsoft.Json.Linq;
using Newtonsoft.Json.Converters;

namespace hangman_command
{
    class Program
    {
        public string word;

        static async System.Threading.Tasks.Task Main(string[] args)
        {
            apikey apikey = new apikey(); 
            Program program = new Program();
            Console.WriteLine("Hello World!");
            var client = new HttpClient();
            var request = new HttpRequestMessage
            {
                Method = HttpMethod.Get,
                RequestUri = new Uri("https://wordsapiv1.p.rapidapi.com/words/?random=true"),
                Headers =
    {
        { "x-rapidapi-key", apikey.key },
        { "x-rapidapi-host", apikey.host },
    },
            };
            using (var response = await client.SendAsync(request))
            {
                Console.WriteLine("test");
                int n=0;
                while (n <= 5)
                {
                    n++;
                    Console.WriteLine(n);
                    response.EnsureSuccessStatusCode();
                    var body = await response.Content.ReadAsStringAsync();
                    Console.WriteLine(body);
                    Console.WriteLine(body.GetType());
                    JObject json = JObject.Parse(body);
                    Console.WriteLine($"This is Key : {json.ContainsKey("results")}");
                    Console.WriteLine(json["word"].ToString());
                    //if (json["word"].ToString().Split() > )
                    string word_ = json["word"].ToString();
                    string[] WordOneGram = word_.Split(" ");
                    if (WordOneGram.Length == 1 )
                    {
                        Console.WriteLine("Found One-gram ");
                       
                    }
                    else
                    {
                        Console.WriteLine("Not Found One-gram");
                        
                    }
                    Console.WriteLine($"This is word replace : {word_.Replace(word_, "_")}");
                    Console.WriteLine($"This is word : {word_}");
                   
                    Console.WriteLine($"This is leht of word : {WordOneGram.Length}");

                    // JObject result = JObject.Parse(json["results"].ToString());
                    //Console.WriteLine(json["results"][0]);
                    //JObject result = JObject.Parse(json["results"][0].ToString());
                    // Console.WriteLine(result["definition"]);

                    //Console.WriteLine(json["results"].ToString());
                    //program.Hangstring(5);
                    /*foreach (var e in json)
                    {
                        Console.WriteLine(e);
                    }*/
                }
              
            }

            Console.ReadLine();
            
        }
        public void Hangstring(int num)
        {
            string state1 =     "  _______________  " + "\n" +
                                " |               | " + "\n" +
                                " |              ***" + "\n" +
                                " |             *   *" + "\n" +
                                " |              ***" + "\n" +
                                " |" + "\n" +
                                " |" + "\n" +
                                " |" + "\n" +
                                " |" + "\n" +
                                " |" + "\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |__________________\n";

            string state2 =     "  _______________  " + "\n" +
                                " |               | " + "\n" +
                                " |              ***" + "\n" +
                                " |             *   *" + "\n" +
                                " |              ***" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |"+ "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |__________________\n ";

            string state3 =     "  _______________  " + "\n" +
                                " |               | " + "\n" +
                                " |              ***" + "\n" +
                                " |             *   *" + "\n" +
                                " |              ***" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |              /" + "\n"+
                                " |             /"  + "\n" +
                                " |            /"   + "\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |__________________\n";

            string state4 =     "  _______________  " + "\n" +
                                " |               | " + "\n" +
                                " |              ***" + "\n" +
                                " |             *   *" + "\n" +
                                " |              ***" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                                " |               |" + "\n" +
                               @" |              / \" + "\n" +
                               @" |             /   \" + "\n" +
                               @" |            /     \"+ "\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |__________________\n";

            string state5 =     "  _______________  " + "\n" +
                                " |               | " + "\n" +
                                " |              ***" + "\n" +
                                " |             *   *" + "\n" +
                                " |              ***" + "\n" +
                                " |               |" + "\n" +
                                " |              /|" + "\n" +
                                " |             / |" + "\n" +
                                " |            /  |" + "\n" +
                                " |               |" + "\n" +
                               @" |              / \" + "\n" +
                               @" |             /   \" + "\n" +
                               @" |            /     \" + "\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |__________________\n";

            string state6 =     "  _______________  " + "\n" +
                                " |               | " + "\n" +
                                " |              ***" + "\n" +
                                " |             *   *" + "\n" +
                                " |              ***" + "\n" +
                                " |               |" + "\n" +
                               @" |              /|\" + "\n" +
                               @" |             / | \" + "\n" +
                               @" |            /  |  \" + "\n" +
                                " |               |" + "\n" +
                               @" |              / \" + "\n" +
                               @" |             /   \" + "\n" +
                               @" |            /     \" + "\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |\n" +
                                " |__________________\n";


            switch (num)
            {
                case 1:
                    Console.WriteLine(state1);
                    Console.WriteLine("State 1/6");
                    break;
                case 2:
                    Console.WriteLine(state2);
                    Console.WriteLine("State 2/6");
                    break; 
                case 3:
                    Console.WriteLine(state3);
                    Console.WriteLine("State 3/6");
                    break;
                case 4:
                    Console.WriteLine(state4);
                    Console.WriteLine("State 4/6");
                    break;
                case 5:
                    Console.WriteLine(state5);
                    Console.WriteLine("State 5/6");
                    break;
                case 6:
                    Console.WriteLine(state6);
                    Console.WriteLine("State 6/6 \n It's over my friend.");
                    break; 
                default:
                    break;
            }

        }

    }


}
