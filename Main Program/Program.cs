using System;
using Wasteland_Adventures.Data;

namespace Wasteland_Adventures
{
    class Program
    {
        static void Main(string[] args)
        {
            //The story

            Console.WriteLine("The story begins with. . . Oh yes, what is your name?");
            string name = Console.ReadLine();
            Console.WriteLine("Awesome! " + name + " it is then");
            Console.WriteLine("This story takes place in 2077. A few years after nuclear annihilation\n" +
                "comes to the human race. Now we have to get you prepared for your survival \n" +
                "in this new wasteland until your doom is inevitably upon you. \n" +
                "By the way what was your profession before the wasteland? \n");

            Console.WriteLine("Each profession has a set of stats that will help you in situations that play to your part! \n" +
                "This will be important to remember! You can gain points to assign to your stats but only over time. \n " +
                "Use your strengths or it's over! XP");

            Console.WriteLine("Please pick from the list: \n" + " 0.Fire Fighter \n 1.Police Officer \n 2.Gymnast \n 3.Actor \n 4.Unemployed");

            int selection;

            int.TryParse(Console.ReadLine(), out selection);

            Trade selectedJob = Trade.PlayerSelection(selection);

            Console.WriteLine($"You chose {selectedJob.name}");

            Console.WriteLine("Cool, let's hope your profession does you well. Who knows what's out there. \n " +
                "Alright, back to reality! The story begins with you on top of your makeshift fallout car shelter \n " +
                "fending off mutants hounds. The green glow of radiation from these 3 foot tall monsters is sickly looking. \n" +
                "You're not sure how much radiation they may be emanating but it doesn't look good, nor does it feel good! You've \n" + 
                "got to get out of here. You look for your rifle. It's on the ground near two of the hounds. \n" +
                "");

            //Loop for listing jobs
        }
    }
}
