//Jovann Contreras
//Date 10/25/2022
//Getting all challenges and adding them to one controller with different endpoints for eachone.
//Peer reviewed by: Marcel R - Program ran well. Every endpoint accepts an input and displays properly. I like how the restraurant picker has random for all choices! :D
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;

namespace ContrerasJAllforOne.Controllers
{
    [Route("[controller]")]
    public class AllForOneController : Controller
    {

        [HttpGet]
        [Route("MiniCh1/{name}")]

        public string MiniCH1(string name)
        {
            return $"Hello {name}how are you?";
        }

        [HttpGet]
        [Route("MiniCh2/{num1}/{num2}")]

        public int MiniCH2(int num1, int num2)
        {
            return num1 + num2;
        }

        [HttpGet]
        [Route("MiniCh3/{Name}/{time}/{AmOrPM}")]

        public string MiniCH3(string Name, int time, string AmOrPm)
        {
            return $"Hello {Name} you woke up at {time}{AmOrPm}";
        }

        [HttpGet]
        [Route("MiniCh4/{num1}/{num2}")]

        public string MiniCH4(string answer, int num1, int num2)
        {

            if (num1 > num2)
            {
                answer = $"{num1} is greater than {num2}";
            }
            else if (num1 < num2)
            {
                answer = $"{num1} is less than {num2}";
            }
            else if (num1 == num2)
            {
                answer = $"{num1} is equal to {num2}";
            }

            return answer;
        }

        [HttpGet]
        [Route("MiniCh5")]

        public string MiniCH5()
        {
            return $"The bright day was a hard day for Dragon, he got up to go to a party at the Dave and Busters but he had to go and get pizza. Walking down the side walk he had seen their favorite car in their favorite red. Continuing on he made it down to the good resturant they ran inside and grabbed the food. he made it to the party and was happy The End.";
        }

        [HttpGet]
        [Route("MiniCh6/{num1}")]

        public string MiniCH6(int num1)
        {
            if (num1 % 2 == 0)
            {
                return $"{num1} is even";
            }
            else
            {
                return $"{num1} is odd";
            }
        }



        [HttpGet]
        [Route("MiniCh7/{wrd}")]

        public string MiniCH7(string wrd)
        {
            string reverseString = "";
            for (int i = wrd.Length - 1; i >= 0; i--)
            {
                reverseString = reverseString + wrd.Substring(i, 1);
            }

            return reverseString;
        }


        [HttpGet]
        [Route("MiniCh8/{response}")]
        public string MiniCH8(string response)
        {
            int rannum = 0;
            Random r = new Random();
            rannum = r.Next(1, 20);

            switch (rannum)
            {
                case 1:
                    response = "Maybe";
                    return response;
                case 2:
                    response = "Yes";
                    return response;
                case 3:
                    response = "Most likely";
                    return response;
                case 4:
                    response = "Uncertain";
                    return response;
                case 5:
                    response = "No";
                    return response;
                case 6:
                    response = "Could happen";
                    return response;
                case 7:
                    response = "Chances are low";
                    return response;
                case 8:
                    response = "Don't count on it";
                    return response;
                case 9:
                    response = "Definitley";
                    return response;
                case 10:
                    response = "Ask again later";
                    return response;
                case 11:
                    response = "Do not know right now";
                    return response;
                case 12:
                    response = "Answer is still no";
                    return response;
                case 14:
                    response = "As I see it yes";
                    return response;
                case 15:
                    response = "Don't ask again";
                    return response;
                case 16:
                    response = "Outlook not so good";
                    return response;
                case 17:
                    response = "My reply is no";
                    return response;
                case 18:
                    response = "Doubtful";
                    return response;
                case 19:
                    response = "Without a doubt";
                    return response;
                case 20:
                    response = "Dont get your hopes up";
                    return response;
            }
            return response;
        }


        [HttpGet]
        [Route("MiniCh9")]

        public string MiniCH9()
        {
            string[] Res = { "Burger King", "MCdonald", "Chicfila", "Wendys", "Shirisoni", "Carls Jr.", "Jack in the box", "Payters" };

            string rndFood;

            Random randomplace = new Random();
            int res = randomplace.Next(0, Res.Length);
            rndFood = Res[res];
            return rndFood;
        }

    }
}