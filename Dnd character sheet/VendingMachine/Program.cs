using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine {
    class Program {

        public static void Main(string[] args) {
            string version = "Alpha v1.4";
            Console.WriteLine("                                      Welcome to the DND Character Sheet Program!");
            Console.WriteLine("                                                 Current Version " + version);
            Console.WriteLine("------------------------------------------------------------------------------------------------------------------------");

            string input = "";
            int added = 0;
            float nr = 0;
            int potion = 0;
            string damage = "0";
            string error = "! Function Not Working Currently !";

            int hp = 0;

            int str = 0;
            int dex = 0;
            int con = 0;
            int inte = 0;
            int wis = 0;
            int cha = 0;

            string strS = "!Error!";
            string dexS = "!Error!";
            string conS = "!Error!";
            string inteS = "!Error!";
            string wisS = "!Error!";
            string chaS = "!Error!";

            int platinum = 0;
            int gold = 0;
            int electrum = 0;
            int silver = 0;
            int copper = 0;

            string username = getUser();


            if(username == "dev")
            {
                goto a;
            } 
                hp = getHP();

                str = getstr();
                dex = getdex();
                con = getcon();
                inte = getinte();
                wis = getwis();
                cha = getcha();



            if (str > 0 && str < 4)
            {
                strS = "-4";
            }

            if (str > 3 && str < 6)
            {
                strS = "-3";
            }

            if (str > 5 && str < 8)
            {
                strS = "-2";
            }

            if (str >7 && str < 10)
            {
                strS = "-1";
            }

            if(str > 9 && str < 12)
            {
                strS = "+0";
            }

            if (str > 11 && str < 14)
            {
                strS = "+1";
            }

            if (str > 13 && str < 16)
            {
                strS = "+2";
            }

            if (str > 15 && str < 18)
            {
                strS = "+3";
            }

            if (str > 17 && str < 20)
            {
                strS = "+4";
            }

            if (str == 20)
            {
                strS = "+5";
            }

            if (dex > 0 && dex < 4)
            {
                dexS = "-4";
            }

            if (dex > 3 && dex < 6)
            {
                dexS = "-3";
            }

            if (dex > 5 && dex < 8)
            {
                dexS = "-2";
            }

            if (dex > 7 && dex < 10)
            {
                dexS = "-1";
            }

            if (dex > 9 && dex < 12)
            {
                dexS = "+0";
            }

            if (dex > 11 && dex < 14)
            {
                dexS = "+1";
            }

            if (dex > 13 && dex < 16)
            {
                dexS = "+2";
            }

            if (dex > 15 && dex < 18)
            {
                dexS = "+3";
            }

            if (dex > 17 && dex < 20)
            {
                dexS = "+4";
            }

            if (dex == 20)
            {
                dexS = "+5";
            }

            if (con > 0 && con < 4)
            {
                conS = "-4";
            }

            if (con > 3 && con < 6)
            {
                conS = "-3";
            }

            if (con > 5 && con < 8)
            {
                conS = "-2";
            }

            if (con > 7 && con < 10)
            {
                conS = "-1";
            }

            if (con > 9 && con < 12)
            {
                conS = "+0";
            }

            if (con > 11 && con < 14)
            {
                conS = "+1";
            }

            if (con > 13 && con < 16)
            {
                conS = "+2";
            }

            if (con > 15 && con < 18)
            {
                conS = "+3";
            }

            if (con > 17 && con < 20)
            {
                conS = "+4";
            }

            if (con == 20)
            {
                conS = "+5";
            }

            if (inte > 0 && inte < 4)
            {
                inteS = "-4";
            }

            if (inte > 3 && inte < 6)
            {
                inteS = "-3";
            }

            if (inte > 5 && inte < 8)
            {
                inteS = "-2";
            }

            if (inte > 7 && inte < 10)
            {
                inteS = "-1";
            }

            if (inte > 9 && inte < 12)
            {
                inteS = "+0";
            }

            if (inte > 11 && inte < 14)
            {
                inteS = "+1";
            }

            if (inte > 13 && inte < 16)
            {
                inteS = "+2";
            }

            if (inte > 15 && inte < 18)
            {
                inteS = "+3";
            }

            if (inte > 17 && inte < 20)
            {
                inteS = "+4";
            }

            if (inte == 20)
            {
                inteS = "+5";
            }

            if (wis > 0 && wis < 4)
            {
                wisS = "-4";
            }

            if (wis > 3 && wis < 6)
            {
                wisS = "-3";
            }

            if (wis > 5 && wis < 8)
            {
                wisS = "-2";
            }

            if (wis > 7 && wis < 10)
            {
                wisS = "-1";
            }

            if (wis > 9 && wis < 12)
            {
                wisS = "+0";
            }

            if (wis > 11 && wis < 14)
            {
                wisS = "+1";
            }

            if (wis > 13 && wis < 16)
            {
                wisS = "+2";
            }

            if (wis > 15 && wis < 18)
            {
                wisS = "+3";
            }

            if (wis > 17 && wis < 20)
            {
                wisS = "+4";
            }

            if (wis == 20)
            {
                wisS = "+5";
            }

            if (cha > 0 && cha < 4)
            {
                chaS = "-4";
            }

            if (cha > 3 && cha < 6)
            {
                chaS = "-3";
            }

            if (cha > 5 && cha < 8)
            {
                chaS = "-2";
            }

            if (cha > 7 && cha < 10)
            {
                chaS = "-1";
            }

            if (cha > 9 && cha < 12)
            {
                chaS = "+0";
            }

            if (cha > 11 && cha < 14)
            {
                chaS = "+1";
            }

            if (cha > 13 && cha < 16)
            {
                chaS = "+2";
            }

            if (cha > 15 && cha < 18)
            {
                chaS = "+3";
            }

            if (cha > 17 && cha < 20)
            {
                chaS = "+4";
            }

            if (cha == 20)
            {
                chaS = "+5";
            }




            Console.WriteLine();

            Console.Write("Current Platinum Pieces: ");
                platinum = int.Parse(Console.ReadLine());
            Console.Write("Current Gold Pieces: ");
                gold = int.Parse(Console.ReadLine());
            Console.Write("Current Electrum Pieces: ");
                electrum = int.Parse(Console.ReadLine());
            Console.Write("Current Silver Pieces: ");
                silver = int.Parse(Console.ReadLine());
            Console.Write("Current Copper Pieces: ");
                copper = int.Parse(Console.ReadLine());


            a:

            // ---------------------------------------------------------------//
            //Main Menu

            while (input.ToLower() != "e") {

                Console.Clear();

                Console.WriteLine();
                Console.WriteLine("--------------------------");
                Console.WriteLine("Would you like to: ");
                Console.WriteLine("(A)lter Hit Points/Roll");
                Console.WriteLine("(R)oll Dice");
                Console.WriteLine("(C)heck Stats");
                Console.WriteLine("(U)pdate Coins");
                Console.WriteLine("(P)atch Notes");
                Console.WriteLine("(E)xit");
                Console.Write("Enter selection: ");

                input = Console.ReadLine();

                // ---------------------------------------------------------------//
                // Alter HP/ Roll Dice

                if (input.ToLower() == "a")
                {
                    Console.WriteLine("-------------------------------------------------");
                    Console.WriteLine("Do you want to (S)et Status effects or Alter (H)it Points? ");
                    Console.Write("Enter Selection: ");

                    input = Console.ReadLine();

                    // ---------------------------------------------------------------//
                    // Set Status Effects

                    if (input.ToLower() == "s")
                    {
                        while(input.ToLower() != "l")
                        {
                            Console.Clear();

                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine("Your Current Status Effects are");
                            Console.WriteLine(error);
                            Console.WriteLine();
                            Console.WriteLine("|----------------------------|");
                            Console.WriteLine();
                            Console.WriteLine("What status effects would you like to set?");
                            Console.WriteLine("List Not Implemented");
                            Console.WriteLine("(L)eave");
                            Console.Write("Enter your selection: ");
                            input = Console.ReadLine();
                        }

                    }

                    // ---------------------------------------------------------------//
                    // Alter Hit Points

                    else if (input.ToLower() == "h")
                    {
                        Console.WriteLine("|----------------------------|");
                        Console.WriteLine("Your current HP is: " + hp);
                        Console.WriteLine("Have you taken (D)amage or (H)ealed?");
                        Console.Write("Enter your selection: ");
                        input = Console.ReadLine();

                        // ---------------------------------------------------------------//
                        // Damage

                        if (input.ToLower() == "d")
                        {
                            Console.WriteLine("|----------------------------|");
                            Console.Write("How much damage did you take?: ");
                            damage = Console.ReadLine();

                            hp = hp -= int.Parse(damage);

                            if (hp > 0)
                            {
                                Console.WriteLine("You now have " + hp + " Hit Points Left!");
                            }
                            else if (hp <= 0)
                            {
                                Console.WriteLine("You have " + hp + " Left you are dying!!!");

                            }
                        }

                        // ---------------------------------------------------------------//
                        // Heal

                        else if (input.ToLower() == "h")
                        {
                            Console.WriteLine("|-------------------------------------------------------------------|");
                            Console.WriteLine("Where you healed with a (Po)tion of healing or (O)ther?");
                            Console.Write("Enter your selection: ");

                            input = Console.ReadLine();

                            if (input.ToLower() == "po")
                            {
                                Console.WriteLine("|----------------------------|");
                                Random dice = new Random();
                                potion = dice.Next(1, maxValue: 5) + dice.Next(1, maxValue: 5) + 2;

                                hp = hp += potion;

                                Console.WriteLine("You were healed " + potion + " Hit Points");
                                Console.WriteLine("You now have " + hp + " Hit Points;");

                                Console.ReadKey();
                            }
                            else if (input.ToLower() == "o")
                            {
                                Console.WriteLine("|----------------------------|");
                                Console.Write("How much were you healed?: ");

                                input = Console.ReadLine();

                                added = int.Parse(input);

                                hp = hp += added;

                                Console.WriteLine("You now have " + hp + " Hit Points;");

                                Console.ReadKey();

                            }
                        }


                    }


                }

                // ---------------------------------------------------------------//
                // Roll Dice

                if (input.ToLower() == "r")
                {
                    while (input.ToLower() != "l")
                    {
                        Console.WriteLine("What dice do you want to roll?");
                        Console.WriteLine("D(4)");
                        Console.WriteLine("D(6)");
                        Console.WriteLine("D(8)");
                        Console.WriteLine("D(10)");
                        Console.WriteLine("D(12)");
                        Console.WriteLine("D(20)");
                        Console.WriteLine("D(P)ercentage");
                        Console.WriteLine("(L)eave");
                        Console.Write("Enter your Selection: ");

                        input = Console.ReadLine();

                        if (input.ToLower() == "4")
                        {
                            Console.Clear();
                            nr = D4();
                        }
                        else if (input == "6")
                        {
                            Console.Clear();
                            nr = D6();
                        }
                        else if (input == "8")
                        {
                            Console.Clear();
                            nr = D8();
                        }
                        else if (input == "10")
                        {
                            Console.Clear();
                            nr = D10();
                        }
                        else if (input == "12")
                        {
                            Console.Clear();
                            nr = D12();
                        }
                        else if (input == "20")
                        {
                            Console.Clear();
                            nr = D20();
                        }
                        else if (input.ToLower() == "p")
                        {
                            Console.Clear();
                            nr = DP();
                        }

                    }
                }


                // ---------------------------------------------------------------//
                // Check overall stats

                else if (input.ToLower() == "c")
                {
                    Console.Clear();

                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("////////////////////////////////////////////////");
                    Console.WriteLine();
                    Console.WriteLine("Your Character Name is: " + username);
                    Console.WriteLine("Your current HP is: " + hp);
                    Console.WriteLine("Your last roll was a: " + nr);
                    Console.WriteLine("Your last potion healed your for: " + potion);
                    Console.WriteLine("You last took: " + damage + " Points of damage!");

                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("////////////////////////////////////////////////");
                    Console.WriteLine("");
                    Console.WriteLine("Coins");
                    Console.WriteLine("You Have " + platinum + " Platinum Pieces total");
                    Console.WriteLine("You Have " + gold + " Gold Pieces total");
                    Console.WriteLine("You Have " + electrum + " Electrum Pieces total");
                    Console.WriteLine("You Have " + silver + " Silver Pieces total");
                    Console.WriteLine("You Have " + copper + " Copper Pieces total");
                    Console.WriteLine("////////////////////////////////////////////////");

                    Console.WriteLine("------------------------------------------------");
                    Console.WriteLine("////////////////////////////////////////////////");
                    Console.WriteLine();
                    Console.WriteLine("Stats");
                    Console.WriteLine("Your Strength is " + str + " And has a Score of " + strS);
                    Console.WriteLine("Your Dexterity is " + dex + " And has a Score of " + dexS);
                    Console.WriteLine("Your Constitution is " + con + " And has a Score of " + conS);
                    Console.WriteLine("Your Inteligence is " + inte + " And has a Score of " + inteS);
                    Console.WriteLine("Your Wisdom is " + wis + " And has a Score of " + wisS);
                    Console.WriteLine("Your Charisma is " + cha + " And has a Score of " + chaS);
                    Console.WriteLine("////////////////////////////////////////////////");

                    Console.ReadKey();

                }

                // ---------------------------------------------------------------//
                // Patch Notes

                else if (input.ToLower() == "p")
                {
                    Console.Clear();

                    Console.WriteLine();
                    Console.WriteLine("||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||||");
                    Console.WriteLine();
                    Console.WriteLine("                        Welcome to the Patch notes, you are currently using version " + version);
                    Console.WriteLine();
                    //New Patchnotes here

                    Console.WriteLine("In Aplha v1.4 - Fixed multiple menus from not being accessable, added status menu (Currently not functioning).");
                    Console.WriteLine("In Alpha v1.3 - Fixed patch note not being accessable.");
                    Console.WriteLine("In Alpha v1.2 - Added Patch Notes");
                    Console.WriteLine("In Alpha v1.1 - Updated version name to alpha version and corrected spelling.");
                    Console.WriteLine("In Alpha v1.0 - Added Ability Score modifiers and some other minor fixes.");
                    Console.WriteLine("In Alpha v0.8 - Added Ability Scores and simplified code.");
                    Console.WriteLine("In Alpha v0.5 - Fixed Rolls, allow player to set starting coin values not showing up in stats.");
                    Console.WriteLine("In Alpha v0.2 - Added Coins and ability to track them.");
                    Console.WriteLine("In Alpha v0.1 - Added Name, Hp, and Basic Rolls as well as being able to track some of them.");

                    Console.ReadKey();
                }

                // ---------------------------------------------------------------//
                // Update Coin amounts

                else if (input.ToLower() == "u")
                {
                    while (input.ToLower() != "l")
                    {
                        Console.WriteLine("---------------------------");
                        Console.WriteLine("What currency are you adding/subtracting?");
                        Console.WriteLine("(P)latinum Pieces");
                        Console.WriteLine("(G)old Pieces");
                        Console.WriteLine("(E)lectrum Pieces");
                        Console.WriteLine("(S)ilver Pieces");
                        Console.WriteLine("(C)opper Pieces");
                        Console.WriteLine("(L)eave");
                        Console.Write("Enter your selection: ");

                        input = Console.ReadLine();

                        // ---------------------------------------------------------------//
                        // Update Platinum

                        if (input.ToLower() == "p")
                        {
                            Console.WriteLine("---------------------------");
                            Console.Write("(A)dd or (S)ubtract?: ");

                            input = Console.ReadLine();

                            if (input.ToLower() == "a")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you adding?: ");

                                platinum += int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + platinum + " Platinum Pieces");
                            }

                            else if (input.ToLower() == "s")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you subtracting?: ");

                                platinum -= int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + platinum + " Platinum Pieces");
                            }
                        }

                        // ---------------------------------------------------------------//
                        // Update Gold

                        else if (input.ToLower() == "g")
                        {
                            Console.WriteLine("---------------------------");
                            Console.Write("(A)dd or (S)ubtract?: ");

                            input = Console.ReadLine();

                            if (input.ToLower() == "a")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you adding?: ");

                                gold += int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + gold + " Gold Pieces");
                            }

                            else if (input.ToLower() == "s")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you subtracting?: ");

                                gold -= int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + gold + " Gold Pieces");
                            }
                        }

                        // ---------------------------------------------------------------//
                        // Update Electrum

                        else if (input.ToLower() == "e")
                        {
                            Console.WriteLine("---------------------------");
                            Console.Write("(A)dd or (S)ubtract?: ");

                            input = Console.ReadLine();

                            if (input.ToLower() == "a")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you adding?: ");

                                electrum += int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + electrum + " Electrum Pieces");
                            }

                            else if (input.ToLower() == "s")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you subtracting?: ");

                                electrum -= int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + electrum + " Electrum Pieces");
                            }
                        }

                        // ---------------------------------------------------------------//
                        // Update Silver

                        else if (input.ToLower() == "s")
                        {
                            Console.WriteLine("---------------------------");
                            Console.Write("(A)dd or (S)ubtract?: ");

                            input = Console.ReadLine();

                            if (input.ToLower() == "a")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you adding?: ");

                                silver += int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + silver + " Silver Pieces");
                            }

                            else if (input.ToLower() == "s")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you subtracting?: ");

                                silver -= int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + silver + " Silver Pieces");
                            }
                        }

                        // ---------------------------------------------------------------//
                        // Update Copper

                        else if (input.ToLower() == "c")
                        {
                            Console.WriteLine("---------------------------");
                            Console.Write("(A)dd or (S)ubtract?: ");

                            input = Console.ReadLine();

                            if (input.ToLower() == "a")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you adding?: ");

                                copper += int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + copper + " Copper Pieces");
                            }

                            else if (input.ToLower() == "s")
                            {
                                Console.WriteLine("---------------------------");
                                Console.Write("How much are you subtracting?: ");

                                copper -= int.Parse(Console.ReadLine());

                                Console.WriteLine("You now have " + copper + " Copper Pieces");
                            }
                        }
                    }
                }
            } 

        }

        // ---------------------------------------------------------------//
        // Initial Collection of user data

        static string getUser() {
            string input = "";
            
            Console.Write("Please enter Charcter Name: ");
            input = Console.ReadLine();
            return input;
        }

        public static int getHP()
        {
            int hp = 0;
            
            Console.Write("Please enter your starting Hit Points: ");
            hp = int.Parse(Console.ReadLine());

            return hp;
        }

        public static int getstr()
        {
            int str = 0;

            Console.Write("Please enter your Strength Score: ");
            str = int.Parse(Console.ReadLine());

            return str;
        }

        public static int getdex()
        {
            int dex = 0;

            Console.Write("Please enter your Dexterity Score: ");
            dex = int.Parse(Console.ReadLine());

            return dex;
        }

        public static int getcon()
        {
            int con = 0;

            Console.Write("Please enter your Constitution Score: ");
            con = int.Parse(Console.ReadLine());

            return con;
        }

        public static int getinte()
        {
            int inte = 0;

            Console.Write("Please enter your Inteligence Score: ");
            inte = int.Parse(Console.ReadLine());

            return inte;
        }

        public static int getwis()
        {
            int wis = 0;

            Console.Write("Please enter your Wisdom Score: ");
            wis = int.Parse(Console.ReadLine());

            return wis;
        }

        public static int getcha()
        {
            int cha = 0;

            Console.Write("Please enter your Charisma Score: ");
            cha = int.Parse(Console.ReadLine());

            return cha;
        }




        // ---------------------------------------------------------------//
        // Dice Rollers

        public static float D4()
        {
            Console.WriteLine("!-----------------------!");
            Console.WriteLine("   Rolling a D4");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 5);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!-----------------------!");
            return nr;
        }

        static float D6()
        {
            Console.WriteLine("!-----------------------!");
            Console.WriteLine("   Rolling a D6");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 7);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!-----------------------!");
            return nr;
        }

        static float D8()
        {
            Console.WriteLine("!-----------------------!");
            Console.WriteLine("   Rolling a D8");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 9);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!-----------------------!");
            return nr;
        }

        static float D10()
        {
            Console.WriteLine("!-----------------------!");
            Console.WriteLine("   Rolling a D10");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 11);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!-----------------------!");
            return nr;
        }

        static float D12()
        {
            Console.WriteLine("!-----------------------!");
            Console.WriteLine("   Rolling a D12");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 13);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!-----------------------!");
            return nr;
        }

        static float D20()
        {
            Console.WriteLine("!-----------------------!");
            Console.WriteLine("   Rolling a D20");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 21);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!-----------------------!");
            return nr;
        }

        static float DP()
        {
            Console.WriteLine("!----------------------------!");
            Console.WriteLine("   Rolling a Percentage Die");
            Random dice = new Random();
            int nr = dice.Next(1, maxValue: 101);
            Console.Write("   Your number is: ");
            Console.WriteLine(nr);
            Console.WriteLine("!----------------------------!");
            return nr;
        }
       
    }

   
}
