using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework7
{
    class Seed
    {
        public string VillainsSeed()
        {
            return "INSERT INTO villains(name) VALUES('Joker'); " +
                    "INSERT INTO villains(name) VALUES('Darth Vader'); " +
                    "INSERT INTO villains(name) VALUES('Evil Person'); ";
        }

        public string TeamsSeed()
        {
            return "INSERT INTO teams(name) VALUES('Team Dream Team'); " +
                "INSERT INTO teams(name) VALUES('Team Awesome Sauce'); " +
                "INSERT INTO teams(name) VALUES('Theme Team'); ";
        }

        public string PowersSeed()
        {
            return "INSERT INTO powers(name) VALUES('Speed'); " +
                "INSERT INTO powers(name) VALUES('Invisability'); " +
                "INSERT INTO powers(name) VALUES('Music'); " +
                "INSERT INTO powers(name) VALUES('Flight'); " +
                "INSERT INTO powers(name) VALUES('Mind Control'); " +
                "INSERT INTO powers(name) VALUES('Writing Code'); " +
                "INSERT INTO powers(name) VALUES('Typing'); ";
        }

        public string ColorsSeed()
        {
            return "INSERT INTO colors(name) VALUES('Red'); " +
                "INSERT INTO colors(name) VALUES('Blue'); " +
                "INSERT INTO colors(name) VALUES('Green'); " +
                "INSERT INTO colors(name) VALUES('White'); " +
                "INSERT INTO colors(name) VALUES('Black'); " +
                "INSERT INTO colors(name) VALUES('Purple'); " +
                "INSERT INTO colors(name) VALUES('Tan'); ";
        }

        public string SuperheroesSeed()
        {
            return "INSERT INTO superheroes(name,villain_id,team_id) VALUES('Luke Skywalker',2,1); " +
                "INSERT INTO superheroes(name,villain_id,team_id) VALUES ('Super Taco Eater',1,3); " +
                "INSERT INTO superheroes(name,villain_id,team_id) VALUES ('Ryan Kojan',3,2); ";
        }
    }
}
