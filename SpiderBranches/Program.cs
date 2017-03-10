using System;
using System.IO;

namespace SpiderBranches
{
    public static class Game
    {
        static int Scenarios = 1;
        static string CharacterName;

        static string[] PartOne = {
            @"You have chosen to watch Charlotte's Web!
            _                           _
            ;`.                       ,'/
            |`.`-.      _____      ,-;,'|
            |  `-.\__,-'     `-.__//'   |
            |     `|               \ ,  |
            `.  ```                 ,  .'
              \_`      .     ,   ,  `_/
                \    ^  `   ,   ^ ` /
                 | '  |  ____  | , |
                 |     ,'    `.    |
                 |    (  O' O  )   |
                 `.    \__,.__/   ,'
                   `-._  `--'  _,'
                       `------' ",
@"You made friends with lots of bugs!
           
              ._q0p_.
              '=(_)='
               / V \
          jgs (_/^\_)
    
Unfortunately, you don't have anything to eat so you starve",
"You drank way too much coffee and were not able to spin a proper web"
    };

    public static void StartGame()
    {
        GameTitle();

        Console.WriteLine("Welcome to Choose Your Web. \nYou are a spider and tyhe action you choose will affect your web.");

        NameCharacter();
        Choice();
    }

        static void LoadText(string file)
        {
            if (File.Exists(file))
            {
                Console.WriteLine(File.ReadAllText(file));
            }
            else
            {
                Console.WriteLine("File not found!");
            }
        }

    public static void Choice()
    {
        for (int section = 1; section <=Scenarios; section++)
        {
            string input = "";

            switch (section)
            {
                case 1: 
                    
                    Console.WriteLine("Would you like to A.) Watch Charlotte's Web B.) Befriend some bugs or C.) Drink an absurd amount of coffee? \nPlease enter A, B, or C");
                    input = Console.ReadLine();
                    input = input.ToUpper();
                    if (input == "A")
                    {
                            LoadText("a.txt");
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine(PartOne[0]);
                    }
                    else if (input == "B")
                    {
                            LoadText("b.txt");
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.WriteLine(PartOne[1]);
                    }
                    else
                    {
                            LoadText("c.txt");
                            Console.ForegroundColor = ConsoleColor.DarkBlue;
                            Console.WriteLine(PartOne[2]);
                    }

                    break;

            }
            Console.ReadKey();
            Console.Clear();
        }
    }
        static void NameCharacter()
        {
            Console.WriteLine("What is your spider name?");
            Console.WriteLine("Enter your name: ");

            CharacterName = Console.ReadLine();

            Console.WriteLine("Welcome " + CharacterName + "!");

        }

        static void GameTitle()
        {
            string Title = @"                                                         
    //   ) )                                             
   //        / __      ___      ___      ___      ___    
  //        //   ) ) //   ) ) //   ) ) ((   ) ) //___) ) 
 //        //   / / //   / / //   / /   \ \    //        
((____/ / //   / / ((___/ / ((___/ / //   ) ) ((____     
                                                                  
                                                                  
\\    / /                           ||   / |  / /                 
 \\  / /  ___               __      ||  /  | / /  ___     / __    
  \\/ / //   ) ) //   / / //  ) )   || / /||/ / //___) ) //   ) ) 
   / / //   / / //   / / //         ||/ / |  / //       //   / /  
  / / ((___/ / ((___( ( //          |  /  | / ((____   ((___/ /   ";
            Console.Title = "Choose your web!";
            Console.WriteLine(Title);
            Console.WriteLine("Choose your web!");
            Console.WriteLine("Press any key to start");
            Console.ReadKey();
            Console.Clear();
        }
    }

    class Program
    {
        static void Main()
        {
            Game.StartGame();
            Console.Read();
        }
    }
}
