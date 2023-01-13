//Jovann Contreras
//Date 10/25/2022
//Getting all challenges and adding them to one controller with different endpoints for eachone.
//Peer reviewed by: Marcel R - Program ran well. Every endpoint accepts an input and displays properly. I like how the restraurant picker has random for all choices! :D
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Threading.Tasks;
using ContrerasJAllforOne.Models;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;


namespace ContrerasJAllforOne.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class AllForOneController : ControllerBase
    {

        [HttpGet]
        [Route("MiniCh1/{name}")]

        public string MiniCH1(string name)
        {
            return $"Hello {name} how are you?";
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

        public string MiniCH4(int num1, int num2)
        {
            string answer = "";
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

        public string MiniCH5(string adj, string fictionalCreature, string specialEvent, string adjTwo, string heOrShe, string adverb, string location, string noun, string color, string food)
        {
            return $"The {adj} day was a hard day for {fictionalCreature}, {heOrShe} got up to go to a {specialEvent} at the {location} but {heOrShe} had to go and get {food}. Walking down the side walk {heOrShe} had seen their favorite {noun} in their favorite {color}. Continuing on {heOrShe} made it down to the {adjTwo} resturant they ran inside and grabbed the food. {heOrShe} made it to the {specialEvent} and was happy The End.";
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




        public List<studentListModel> studentLists = new List<studentListModel>(){
            new studentListModel(){
                firstName = "Harrison",
                lastName = "Busby",
                slackName = "Harrison Busby",
                email = "hbusby@codestack.co",
                hobbies = "Piano"
            },
            new studentListModel(){
                firstName = "Brandon",
                lastName = "Le",
                slackName = "Brandon Le",
                email = "ble@codestack.co",
                hobbies = "Eating and Sleeping"
            },
            new studentListModel(){
                firstName = "Jessie",
                lastName = "Lamzon",
                slackName = "Jessie Lamzon",
                email = "jlamzon@codestack.co",
                hobbies = "Eating and traveling"
            },
            new studentListModel(){
                firstName = "Andrea",
                lastName = "Burr",
                slackName = "Andrea Burr",
                email = "aburr@codestack.co",
                hobbies = "Horse riding"
            },
            new studentListModel(){
                firstName = "Daniel",
                lastName = "Decoito",
                slackName = "Daniel Decoito",
                email = "ddecoito@codestack.co",
                hobbies = "bears, beets, battlestar galactica"
            },
            new studentListModel(){
                firstName = "Pedro",
                lastName = "Castaneda",
                slackName = "Pedro Castaneda",
                email = "pcastaneda@codestack.co",
                hobbies = "Hikin and traveling"
            },
            new studentListModel(){
                firstName = "Jeremy",
                lastName = "Lapham",
                slackName = "Jeremy Lapham",
                email = "jlapham@codestack.co",
                hobbies = "Bodybuilding, powerlifting, wrestling"
            },
            new studentListModel(){
                firstName = "Jacob",
                lastName = "Dekok",
                slackName = "Jacob Dekok",
                email = "jdekok@codestack.co",
                hobbies = "Copying Jeremy, body building, powerlifting, wrestling"
            },
            new studentListModel(){
                firstName = "Kenneth",
                lastName = "Fujimura",
                slackName = "Kenneth Fujimura",
                email = "kfujimura@codestack.co",
                hobbies = "Games, sports, model kits, anime, naps, culinary tourism"
            },
            new studentListModel(){
                firstName = "Fernando",
                lastName = "Aguilar",
                slackName = "Fernado Aguilar",
                email = "faguilar@codestack.co",
                hobbies = "Playing videogames, reading and writing"
            },
            new studentListModel(){
                firstName = "Jovann",
                lastName = "Contreras",
                slackName = "Jovann Contreras",
                email = "jcontreras@codestack.co",
                hobbies = "Like collecting comics"
            },
            new studentListModel(){
                firstName = "Andrew",
                lastName = "Nilsson",
                slackName = "Andrew Nilsson",
                email = "anilsson@codestack.co",
                hobbies = "Playing video games"
            },
            new studentListModel(){
                firstName = "Lerissa",
                lastName = "Lazar",
                slackName = "Lerissa Lazar",
                email = "llazar@codestack.co",
                hobbies = "Drawing and watching anime"
            },
            new studentListModel(){
                firstName = "N.Harrinson",
                lastName = "Wilkins",
                slackName = "Harrison Wilkins",
                email = "nwilkins@codestack.co",
                hobbies = ""
            },
            new studentListModel(){
                firstName = "Madeline",
                lastName = "Gowan",
                slackName = "Madeline Gowan",
                email = "mgowan@codestack.co",
                hobbies = "Rodents"
            },
            new studentListModel(){
                firstName = "Manuel",
                lastName = "Levya",
                slackName = "Manuel Levya",
                email = "mlevya@codestack.co",
                 hobbies = "Photography"
            },
            new studentListModel(){
                firstName = "Elizar",
                lastName = "Garcia",
                slackName = "Elizar Garcia",
                email = "egarcia@codestack.co",
                hobbies = "Bowling and sleeping"
            },
            new studentListModel(){
                firstName = "Mark",
                lastName = "Ramirez",
                slackName = "Mark Ramirez",
                email = "mramirez@codestack.co",
                hobbies = "Game and drinking way to much water"
            },
            new studentListModel(){
                firstName = "Chris",
                lastName = "Martinez",
                slackName = "Chris Martinez",
                email = "cmartinez@codestack.co",
                hobbies = "Playing ping pong"
            },
            new studentListModel(){
                firstName = "Samuel",
                lastName = "Laguna",
                slackName = "Samuel Laguna",
                email = "slaguna@codestack.co",
                hobbies = ""
            },
            new studentListModel(){
                firstName = "Isaiah",
                lastName = "Ferguson",
                slackName = "Isaiah Ferguson",
                email = "iferguson@codestack.co",
                hobbies = "Martial arts, tricking, hiking, and watching slice of life anime"
            },
            new studentListModel(){
                firstName = "John",
                lastName = "Magpantay",
                slackName = "John Magpantay",
                email = "jmagpantay@codestack.co",
                hobbies = "FPS Games"
            },
            new studentListModel(){
                firstName = "Reed",
                lastName = "Goodwin",
                slackName = "Reed Goodwin",
                email = "rgoodwin@codestack.co",
                hobbies = ""
            },
            new studentListModel(){
                firstName = "Amar",
                lastName = "Mann",
                slackName = "Amar Mann",
                email = "amann@codestack.co",
                hobbies = "Kicking rocks"
            },
            new studentListModel(){
                firstName = "Marcel",
                lastName = "Rodriguez",
                slackName = "Marcel Rodriguez",
                email = "mrodriguez@codestack.co",
                hobbies = ""
            },
            new studentListModel(){
                firstName = "Richard",
                lastName = "Johnson",
                slackName = "Richard Johnson",
                email = "rjohnson@codestack.co",
                hobbies = "Watching youtube videos, sketching, playing video games"
            },
            new studentListModel(){
                firstName = "Ulises",
                lastName = "Ortega",
                slackName = "Ulises Ortega",
                email = "uortega@codestack.co",
                hobbies = "Video games, roller blading, board games"
            },
            new studentListModel(){
                firstName = "Caroline",
                lastName = "Hana",
                slackName = "Caroline Hana",
                email = "chana@codestack.co",
                hobbies = "video games, anime, hanging out with friends"
            },
            new studentListModel(){
                firstName = "Aisha",
                lastName = "Mashrah",
                slackName = "Aisha Mashrah",
                email = "amashrah@codestack.co",
                hobbies = "painting"
            },
            new studentListModel(){
                firstName = "Shaun",
                lastName = "Aguirre Reyes",
                slackName = "Aguirre Reyes",
                email = "areyes@codestack.co",
                hobbies = "writing, listening to music"
            }
        };




        [HttpGet]
        [Route("studentInfoFirst/{studentFirstName}")]
        public studentListModel getStudentInfobyName(string studentFirstName)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentLists.Count; i++){
                if(studentLists[i].firstName == studentFirstName)
                {
                    result = studentLists[i];
                    break;
                }
            }
            return result;
        }

        [HttpGet]
        [Route("studentInfoLast/{studentLastName}")]
        public studentListModel getStudentInfobyLastName(string studentLastName)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentLists.Count; i++){
                if(studentLists[i].lastName == studentLastName)
                {
                    result = studentLists[i];
                    break;
                }
            }
            return result;
        }

        [HttpGet]
        [Route("studentInfoSlack/{studentSlackName}")]
        public studentListModel getStudentInfobySlackName(string studentSlackName)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentLists.Count; i++){
                if(studentLists[i].slackName == studentSlackName)
                {
                    result = studentLists[i];
                    break;
                }
            }
            return result;
        }

        [HttpGet]
        [Route("studentInfoEmail/{studentEmail}")]
        public studentListModel getStudentInfobyEmailName(string studentEmail)
        {
            studentListModel result = new studentListModel(){
                firstName = "N/A",
                lastName  = "N/A",
                slackName = "N/A",
                email = "N/A",
                hobbies = "N/A"
            };

            for(int i = 0; i < studentLists.Count; i++){
                if(studentLists[i].email == studentEmail)
                {
                    result = studentLists[i];
                    break;
                }
            }
            return result;
        }
        

        // [HttpGet]
        // [Route("MiniCh8/{response}")]
        // public string MiniCH8(string response)
        // {
        //     int rannum = 0;
        //     Random r = new Random();
        //     rannum = r.Next(1, 20);

        //     switch (rannum)
        //     {
        //         case 1:
        //             response = "Maybe";
        //             return response;
        //         case 2:
        //             response = "Yes";
        //             return response;
        //         case 3:
        //             response = "Most likely";
        //             return response;
        //         case 4:
        //             response = "Uncertain";
        //             return response;
        //         case 5:
        //             response = "No";
        //             return response;
        //         case 6:
        //             response = "Could happen";
        //             return response;
        //         case 7:
        //             response = "Chances are low";
        //             return response;
        //         case 8:
        //             response = "Don't count on it";
        //             return response;
        //         case 9:
        //             response = "Definitley";
        //             return response;
        //         case 10:
        //             response = "Ask again later";
        //             return response;
        //         case 11:
        //             response = "Do not know right now";
        //             return response;
        //         case 12:
        //             response = "Answer is still no";
        //             return response;
        //         case 14:
        //             response = "As I see it yes";
        //             return response;
        //         case 15:
        //             response = "Don't ask again";
        //             return response;
        //         case 16:
        //             response = "Outlook not so good";
        //             return response;
        //         case 17:
        //             response = "My reply is no";
        //             return response;
        //         case 18:
        //             response = "Doubtful";
        //             return response;
        //         case 19:
        //             response = "Without a doubt";
        //             return response;
        //         case 20:
        //             response = "Dont get your hopes up";
        //             return response;
        //     }
        //     return response;
        // }


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