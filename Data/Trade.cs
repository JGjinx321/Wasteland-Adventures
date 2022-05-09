using System;
using System.Collections.Generic;
using System.Text;

namespace Wasteland_Adventures.Data
{
    public class Trade
    {
        public string name { get; set; }

        public int Strength { get; set; }

        public int Intelligence { get; set; }

        public int Agility { get; set; }

        public int Perception { get; set; }

        public int Weaponry { get; set; }

        public int Charisma { get; set; }


        public static Trade PlayerSelection(int selection)
        {
            List<Trade> trades = new List<Trade>();

            if(selection == 0)
            {
                Trade Firefighter = new Trade();

                Firefighter.name = "Fire Fighter";

                Firefighter.Agility = 4;

                Firefighter.Charisma = 3;

                Firefighter.Intelligence = 3;

                Firefighter.Perception = 2;

                Firefighter.Strength = 4;

                Firefighter.Weaponry = 2;


                trades.Add(Firefighter);
            }

            if(selection == 1)
            {
                Trade PoliceOfficer = new Trade();

                PoliceOfficer.name = "Police Officer";

                PoliceOfficer.Agility = 3;

                PoliceOfficer.Charisma = 2;

                PoliceOfficer.Intelligence = 3;

                PoliceOfficer.Perception = 3;

                PoliceOfficer.Strength = 3;

                PoliceOfficer.Weaponry = 4;

                trades.Add(PoliceOfficer);
            }

            if(selection == 2)
            {
                Trade Gymnast = new Trade();

                Gymnast.name = "Gymnast";

                Gymnast.Agility = 5;

                Gymnast.Charisma = 2;

                Gymnast.Intelligence = 3;

                Gymnast.Perception = 3;

                Gymnast.Strength = 2;

                Gymnast.Weaponry = 3;

                trades.Add(Gymnast);
            }

            if(selection == 3)
            {
                Trade Actor = new Trade();

                Actor.name = "Actor";

                Actor.Agility = 3;

                Actor.Charisma = 5;

                Actor.Intelligence = 3;

                Actor.Perception = 3;

                Actor.Strength = 3;

                Actor.Weaponry = 1;

                trades.Add(Actor);
            }

            if (selection == 4)
            {
                Trade Unemployed = new Trade();

                Unemployed.name = "Unemployed";

                Unemployed.Agility = 3;

                Unemployed.Charisma = 3;

                Unemployed.Intelligence = 3;

                Unemployed.Perception = 3;

                Unemployed.Strength = 3;

                Unemployed.Weaponry = 3;

                trades.Add(Unemployed);
            }

            return trades[0];
        }
    }
}