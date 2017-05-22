using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Homework7_GUI
{
    class Program
    {
        static void Main(string[] args)
        {
            DBConnection db = new DBConnection();
            string userInput;

            Console.WriteLine(" Select option from list  1. Colors 2. Teams 3. Superheroes 4. Villains 5. Powers");
            userInput = Console.ReadLine();

            switch (Int32.Parse(userInput))
            {

                case 1:
                    db.ExecuteSelectQuery("SELECT * FROM colors", "colors");
                    Console.WriteLine("(1) Add new color (2) Delete color");
                    string colorUserInput = Console.ReadLine();

                    if (colorUserInput == "1")
                    {

                        Console.WriteLine("Enter the color you would like to be added: ");
                        colorUserInput = Console.ReadLine();
                        db.ExecuteInsertQuery("colors", colorUserInput, "name");
                    }
                    else
                    {
                        Console.WriteLine("Enter the color id to be deleted: ");
                        colorUserInput = Console.ReadLine();
                        db.DeleteEntry(colorUserInput, "colors");
                    }

                    break;

                case 2:
                    db.ExecuteSelectQuery("SELECT * FROM teams", "teams");
                    Console.WriteLine("(1) Add new team (2) Delete Team");
                    string teamsUserInput = Console.ReadLine();

                    if (teamsUserInput == "1")
                    {
                        Console.WriteLine("Enter the name of the team to be added");
                        teamsUserInput = Console.ReadLine();
                        db.ExecuteInsertQuery("teams", teamsUserInput, "name");
                    }
                    else {
                        Console.WriteLine("Enter the team id to be deleted");
                        teamsUserInput = Console.ReadLine();
                        db.DeleteEntry(teamsUserInput, "teams");
                    }
                    break;
                    
                case 3:
                    break;

                case 4:
                    db.ExecuteSelectQuery("SELECT * FROM villains", "villains");
                    Console.WriteLine("(1) Add new villain (2) Delete villain");
                    string villainUserInput = Console.ReadLine();

                    if (villainUserInput == "1")
                    {
                        Console.WriteLine("Enter villain name to be added: ");
                        villainUserInput = Console.ReadLine();
                        db.ExecuteInsertQuery("villains", villainUserInput, "name");
                    }
                    else {
                        Console.WriteLine("Enter the villain id to be deleted: ");
                        villainUserInput = Console.ReadLine();
                        db.DeleteEntry(villainUserInput, "villains");
                    }
                    break;

                case 5:
                    db.ExecuteSelectQuery("SELECT * FROM powers", "powers");
                    Console.WriteLine("(1) Add new power (2) Delete power");
                    string powersUserInput = Console.ReadLine();

                    if (powersUserInput == "1")
                    {
                        Console.WriteLine("Enter power to be added");
                        powersUserInput = Console.ReadLine();
                        db.ExecuteInsertQuery("powers", powersUserInput, "powers");
                    }
                    else {

                    }

                    break;
            }

        }
    }
}
