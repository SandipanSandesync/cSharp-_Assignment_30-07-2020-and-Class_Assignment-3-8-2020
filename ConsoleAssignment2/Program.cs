using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleAssignment2
{
    class Game
    {
        public string country;
        public int noOfPlayers;
        public string CountryProperty { get { return  country; }
            set { country = value; }
        }
        public int PlayersProperty
        {
            get { return noOfPlayers; }
            set { noOfPlayers = value; }
        }
        public Game()
        {

        }
        public Game(int _noOfPlayers,string _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
        }
        public int WorldCup()
        {
           return  DateTime.UtcNow.Year;

        }
    }
    class Cricket : Game
    {
        public string coachName;
        public string CoachProperty { 
            get { return coachName; }
            set
            {
                coachName = value;
                
            }
        
                                        }
        public Cricket()
        {

        }
        public Cricket(int _noOfPlayers,String _country,string _coachName):base(_noOfPlayers, _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
            coachName = _coachName;


                
        }
    }
    class Football : Game
    {
        public string leagueName;
        public string LeagueProperty { get { return leagueName; } set { leagueName = value; } }
        public Football()
        {


        }
        public Football(int _noOfPlayers, String _country, string _leagueName) : base(_noOfPlayers, _country)
        {
            noOfPlayers = _noOfPlayers;
            country = _country;
            leagueName = _leagueName;

        }
    }
    class ShowGameDetails
    {
        public void ShowCricketDetails()
        {
            Console.WriteLine("-------CRICKET INFORMATION---------");
            Game g = new Game(11, "INDIA");
            Cricket india = new Cricket(11, "INDIA", "John Wright");
            Console.WriteLine("country :{0} No of Players :{1} Coach name :{2}", g.CountryProperty, g.PlayersProperty, india.CoachProperty);

            Game g1 = new Game(11, "AUSTRALIA");
            Cricket australia = new Cricket(11, "AUSTRALIA", "John Buchanan");
            Console.WriteLine("country :{0} No of Players :{1} Coach name :{2}", g1.CountryProperty, g1.PlayersProperty, australia.CoachProperty);

        }
        public void ShowFootballDetails()
        {
            Console.WriteLine("--------FOOTBALL INFORMATION----------");
            Game g2 = new Game(11, "Spain");
            Football spain = new Football(11, "Spain", "Spanish League");
            Console.WriteLine("country :{0} No of Players :{1} League name :{2}", g2.CountryProperty, g2.PlayersProperty, spain.LeagueProperty);


            Game g3 = new Game(11, "England");
            Football england = new Football(11, "England", "English League");
            Console.WriteLine("country :{0} No of Players :{1} League name :{2}", g3.CountryProperty, g3.PlayersProperty, england.LeagueProperty);

        }
    }
    class Program
    {
        static void Main(string[] args)
        {

            ShowGameDetails cricket = new ShowGameDetails();
            cricket.ShowCricketDetails();
            ShowGameDetails football = new ShowGameDetails();
            football.ShowFootballDetails();

            Game g5 = new Game();
            Console.WriteLine("\n Australia have won cricket world cup in {0} ",g5.WorldCup());
            Console.WriteLine("\n Spain have won football world cup in {0} ", g5.WorldCup());

            Console.Read();















        }
    }
}
