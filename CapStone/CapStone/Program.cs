using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapStone
{
    class Program
    {
        //
        // Burton, David
        // Capstone Project
        //
        static void Main(string[] args)
        {
            string name;

            name = DisplayOpeningScreen();
            DisplayBeginning(name);
        }

        static void DisplayBeginning(string name)
        {
            bool loopRunning = true;
            string userResponse;

            Console.Clear();
            Console.WriteLine("The dame was dangerous. But dames always are.");
            Console.WriteLine("She stood their in my office, her coat dripping rain water.");
            Console.WriteLine("Her lips were red and her hair was long, and I could tell right away she was trouble.");
            Console.WriteLine("She hung up her coat and took one of the old leather chairs in front of my desk.");
            Console.WriteLine("She picked up the carton of cigarettes of my desk and helped herself.");
            Console.WriteLine("\"Hello detective "+name+", Got a light?\" ");
            Console.WriteLine("I grabbed a cigartte for myself and pulled the lighter from my front pocket.");
            Console.WriteLine("With one motion I lit both our cigarettes.");
            Console.WriteLine("She sat back took a drag then she looked at me expectantly");
            Console.WriteLine();
            Console.WriteLine();

            while (loopRunning)
            {
                Console.WriteLine("What do you want to say? [A, B, C] ");
                Console.WriteLine("A) What seems to be the issue Miss?");
                Console.WriteLine("B) What's the big idea barging in here!?");
                Console.WriteLine("C) *Stay silent*");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = false;
                    Console.WriteLine("\"I need your help detective!\" ");
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = false;
                    Console.WriteLine("\"Whatever happened to chivalry? I need your help detective.\" ");
                }
                else if (userResponse == "C")
                {
                    Console.Clear();
                    loopRunning = false;
                    Console.WriteLine("\"The strong silent type huh? Well I need your help detective.\" ");
                }
                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("What do you want to say? [A, B, C] ");
                    Console.WriteLine("A) What seems to be the issue Miss?");
                    Console.WriteLine("B) What's the big idea barging in here!?");
                    Console.WriteLine("C) *Stay silent*");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }

            DisplayInitialStory(name);
        }

        static void DisplayInitialStory(string name)
        {
            bool loopRunning = true;
            string userResponse;

            Console.WriteLine("\"My life is in danger "+name+"!\"");
            Console.WriteLine("\"They've ransacked my house...\"");
            Console.WriteLine("\"...and they've threated my life.\"");
            Console.WriteLine("A tear rolled down her cheek.");
            Console.WriteLine();
            Console.WriteLine();

            while (loopRunning)
            {
                Console.WriteLine("What do you want to say? [A, B] ");
                Console.WriteLine("A) What happened?");
                Console.WriteLine("B) *Stay silent*");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = false;
                    Console.WriteLine("She cleared her throat and thought for a moment ");
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = false;
                    Console.WriteLine("She shifted uncomfortably, then began with the details ");

                }

                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("What do you want to say? [A, B] ");
                    Console.WriteLine("A) What happened?");
                    Console.WriteLine("B) *Stay silent*");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }

            Console.WriteLine("\"I came home yesterday to find my apartment trashed.\"");
            Console.WriteLine("\"I walked through the house to see what had been stolen,\"");
            Console.WriteLine("\"but when I got to the kitchen a man burst out of my pantry and grabbed me.\"");
            Console.WriteLine("\"We wrestled for a moment but I got ahold of a kitchen knife and stabbed him in the leg.\"");
            Console.WriteLine("\"Then I ran out of there. You have to catch this man I'm afraid to go home!\"");
            Console.WriteLine("\"Unfortunately the man grabbed me from behind so I didn't get a good look at his face.\"");
            Console.WriteLine("\"He did have a birthmark on the right side of his face though\"");
            Console.WriteLine("She scribbled on a sheet of paper");
            Console.WriteLine("\"This is my address if you want to check my apartment. My name is Valerie by the way.\"");
            Console.WriteLine("I nodded to her and told her I would take the case. I knew where I had to begin");
            Console.WriteLine();
            Console.WriteLine();

            while (!loopRunning)
            {
                Console.WriteLine("Where do you want to investigate? [A, B] ");
                Console.WriteLine("A) Investigate her apartment");
                Console.WriteLine("B) Check hospital records");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = true;
                    DisplayCheckApartment(name);
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = true;
                    DisplayCheckHospital(name);

                }

                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("Where do you want to investigate? [A, B] ");
                    Console.WriteLine("A) Investigate her apartment");
                    Console.WriteLine("B) Check hospital records");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }
        }

        static void DisplayCheckApartment(string name)
        {
            bool loopRunning = false;
            string userResponse;

            Console.Clear();
            Console.WriteLine("I decided to check her apartment.");
            Console.WriteLine("First I put out a feeler to my resource down at the cop shop.");
            Console.WriteLine("His name was Jimmy and he owed me one.");
            Console.WriteLine("I told him to keep an eye out for any riff-raff with a birthmark on their mug.");
            Console.WriteLine("Then I headed out. The apartment was on the other side of town.");
            Console.WriteLine("The nice side of town.");
            Console.WriteLine("Or atleast as nice as any side of this town got.");
            Console.WriteLine("Her apartment was on the top floor.");
            Console.WriteLine("And by apartment I meant penthouse.");
            Console.WriteLine("It was sprawling. Who in the hell was this broad?");
            Console.WriteLine("The place was a mess. Whoever robbed this place tore it apart.");
            Console.WriteLine("I started with the kitchen. There was a trail of blood leading to the bathroom.");
            Console.WriteLine("He must have bound his leg with a towel.");
            Console.WriteLine("But why did he attack her at all?");
            Console.WriteLine("Next I checked the bedroom.");
            Console.WriteLine("It was trashed. The mattress was overturned, the closet torn apart, the dresser drawers pulled out, and...");
            Console.WriteLine("... the jewelery box scattered.");
            Console.WriteLine("I picked up a necklace from the ground. It was genuine gold");
            Console.WriteLine("What kind of robber doesn't steal the jewelery?");
            Console.WriteLine("Something didn't smell right here.");
            Console.WriteLine("That's when the front door opened and closed");
            Console.WriteLine("I knew I had two options");
            Console.WriteLine();
            Console.WriteLine();

            while (!loopRunning)
            {
                Console.WriteLine("What do you want to do? [A, B] ");
                Console.WriteLine("A) Confront the suspect");
                Console.WriteLine("B) Hide");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = true;
                    DisplayBadEnd();
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = true;
                    DisplayHide(name);

                }

                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("What do you want to do? [A, B] ");
                    Console.WriteLine("A) Confront the suspect");
                    Console.WriteLine("B) Hide");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }

        }

        static void DisplayHide(string name)
        {
            Console.WriteLine("I hid in the closet.");
            Console.WriteLine("Often the indirect method is the best.");
            Console.WriteLine("He fumbled around for while. He was obviously a large man.");
            Console.WriteLine("I kept my gun in hand just incase.");
            Console.WriteLine("After sifting through wreckage of the apartment for 10 minutes he lost it.");
            Console.WriteLine("He threw a dresser drawer into a mirror.");
            Console.WriteLine("Both smashed.");
            Console.WriteLine("\"Where is it you floozy!\"");
            Console.WriteLine("\"Thinks she can steal from me. When I find her she's dead\"");
            Console.WriteLine("He stomped to the door of the apartment and left");
            Console.WriteLine("When I was sure he was gone I stepped out.");
            Console.WriteLine("Valerie isn't who she appears to be.");
            Console.WriteLine("I headed back to the office to reconsider.");

            DisplayContinuePrompt();
            DisplayOffice(name);
        }

        static void DisplayCheckHospital(string name)
        {
            Console.Clear();
            Console.WriteLine("I decided to check the local hospital records.");
            Console.WriteLine("First I put out a feeler to my resource down at the cop shop");
            Console.WriteLine("His name was Jimmy and he owed me one.");
            Console.WriteLine("I told him to keep an eye out for any riff-raff with a birthmark on their mug.");
            Console.WriteLine("Then I headed to the hospital closest to her apartment.");
            Console.WriteLine("I knew the suspect had a stab wound in his leg and a birthmark on his face.");
            Console.WriteLine("I made it to the Hospital and went inside.");
            Console.WriteLine("Then I walked over to the gal at the information desk.");
            Console.WriteLine("Her name was Ester and I'd worked closely with her before.");
            Console.WriteLine("Very closely.");
            Console.WriteLine("\'I need information on a suspect dollface.\' I said.");
            Console.WriteLine("She rolled her eyes");
            Console.WriteLine("\"Oh "+name+" you always say the sweetest things\"");
            Console.WriteLine("The sarcasm was palpable but she opened the records drawer.");
            Console.WriteLine("\'I'm looking for a man who would have come in yesterday\'");
            Console.WriteLine("\'He would have had a laceration on his leg and a birthmark on his face\'");
            Console.WriteLine("She nodded.");
            Console.WriteLine("\"Yeah I remember him.\"");
            Console.WriteLine("She grabbed the file and handed it to me.");
            Console.WriteLine("I looked at his name.");
            Console.WriteLine("John Smith.");
            Console.WriteLine("Obviously fake.");
            Console.WriteLine("The address was definitly bogus too.");
            Console.WriteLine("Discharged yesterday.");
            Console.WriteLine("Damn.");
            Console.WriteLine("Brusing around neck suggests attempted strangulation.");
            Console.WriteLine("Thats odd. Valerie hadn't mentioned choking him.");
            Console.WriteLine("The rest of the file was useless. I handed it back.");
            Console.WriteLine("With a few sweet words to Ester I took my leave.");
            Console.WriteLine("I headed back to the office to reconsider.");

            DisplayContinuePrompt();
            DisplayOffice(name);
        }

        static void DisplayOffice(string name)
        {
            bool loopRunning = true;
            string userResponse;

            Console.Clear();
            Console.WriteLine("This case wasn't adding up.");
            Console.WriteLine("When I walked in to the office the phone was ringing.");
            Console.WriteLine("I scooped it up and answered.");
            Console.WriteLine("It was Jimmy with the Fuzz.");
            Console.WriteLine("\""+name+" we got him in custody.\"");
            Console.WriteLine("\"Fool robbed the museum and dropped his drivers liscense at the scene.\"");
            Console.WriteLine("How convient.");
            Console.WriteLine("\'Thanks for the tip Jimmy\'");
            Console.WriteLine("After I hung up I made up my mind.");
            Console.WriteLine();
            Console.WriteLine();

            while (loopRunning)
            {
                Console.WriteLine("Where do you want to go? [A, B] ");
                Console.WriteLine("A) Question suspect");
                Console.WriteLine("B) Check museum");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = false;
                    DisplaySuspect(name);
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = false;
                    DisplayMuseum(name);

                }

                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("Where do you want to go? [A, B] ");
                    Console.WriteLine("A) Question suspect");
                    Console.WriteLine("B) Check museum");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }

        }

        static void DisplaySuspect(string name)
        {
            bool loopRunning = true;
            string userResponse; 

            Console.Clear();
            Console.WriteLine("I headed to the Cop Shop.");
            Console.WriteLine("He was in a interogation room, handcuffed to a table.");
            Console.WriteLine("I walked into the room, sat down, and lit a cigarette.");
            Console.WriteLine("The man eyed me suspiciously. He had a large birthmark on the right side of his face.");
            Console.WriteLine("\'So Paul...\'");
            Console.WriteLine("His real name was Paul.");
            Console.WriteLine("\'... thought you could steal the Wish Diamond.\'");
            Console.WriteLine("He said nothing.");
            Console.WriteLine("\'Looking at a long prison sentance here Paul.\'");
            Console.WriteLine("Still nothing.");
            Console.WriteLine("\'Give me something here Paul. If you had a partner you could testify against them for a reduced sentance.\'");
            Console.WriteLine("He spat on the table.");
            Console.WriteLine("This was going nowhere fast.");
            Console.WriteLine("They hadn't found the Diamond yet.");
            Console.WriteLine("Maybe they never would.");
            Console.WriteLine();
            Console.WriteLine();

            while (loopRunning)
            {
                Console.WriteLine("What do you want to do? [A, B] ");
                Console.WriteLine("A) Close Case");
                Console.WriteLine("B) Find Valerie");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = false;
                    DisplayFalseEnd();
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = false;
                    DisplayQuestionVal(name);

                }

                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("What do you want to do? [A, B] ");
                    Console.WriteLine("A) Close Case");
                    Console.WriteLine("B) Find Valerie");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }
        }

        static void DisplayMuseum(string name)
        {
            Console.Clear();
            Console.WriteLine("I headed to the Museum.");
            Console.WriteLine("After flashing the badge about three times I made it to the curator.");
            Console.WriteLine("He was a beady eyed old man.");
            Console.WriteLine("\'I understand you had an item stolen?\'");
            Console.WriteLine("He grimaced");
            Console.WriteLine("\"I told you people already! Yes the Wish Diamond.\"");
            Console.WriteLine("\"The Diamond is priceless. It belongs to the public.\"");
            Console.WriteLine("I looked around. Dinosaur bones and stuffed animals were everywhere.");
            Console.WriteLine("\"I believe they have a subject in custody.\"");
            Console.WriteLine("He grimaced deeper.");
            Console.WriteLine("\'Yet no diamond. He doesn't seem to have they tell me.\'");
            Console.WriteLine("Now that was interesting.");
            Console.WriteLine("Then it dawned on me. I knew where I had to go.");

            DisplayContinuePrompt();
            DisplayQuestionVal(name);
        }

        static void DisplayQuestionVal(string name)
        {
            bool loopRunning = true;
            string userResponse;

            Console.WriteLine("I headed to where I would go if I had stolen a massive diamond.");
            Console.WriteLine("I milled around the airport for most of the day.");
            Console.WriteLine("It seemed hopeless in some ways, but I had a gut feeling I should stick it out.");
            Console.WriteLine("And then there she was.");
            Console.WriteLine("She had dyed hair, sunglasses and a boarding pass, but I knew her.");
            Console.WriteLine("I walked up to her.");
            Console.WriteLine("Her mouth feel open.");
            Console.WriteLine("\'We caught him Val. He shouldn't bother you anymore.\'");
            Console.WriteLine("She seemed taken aback.");
            Console.WriteLine("\"G-Good. Glad to hear.\"");
            Console.WriteLine("Time for the heart of this.");
            Console.WriteLine("\'Let's talk about the Wish Diamond.\'");
            Console.WriteLine("Her eyes narrowed.");
            Console.WriteLine("\"I don't know what you're talking about.\"");
            Console.WriteLine("I lit a cigarette.");
            Console.WriteLine("\'Give it up Val.\'");
            Console.WriteLine("She took off her sunglasses.");
            Console.WriteLine("\""+name+" come with me.\"");
            Console.WriteLine("\'What?\'");
            Console.WriteLine("\"Come With me. I'm headed to Mexico. I have fence set up. With the money we will live like kings.\"");
            Console.WriteLine("To me it wasn't even a choice.");
            Console.WriteLine();
            Console.WriteLine();

            while (loopRunning)
            {
                Console.WriteLine("What do you want to do? [A, B] ");
                Console.WriteLine("A) Arrest Val");
                Console.WriteLine("B) Head to Mexico");
                userResponse = Console.ReadLine().ToUpper();

                if (userResponse == "A")
                {
                    Console.Clear();
                    loopRunning = false;
                    DisplayTrueEndGood();
                }
                else if (userResponse == "B")
                {
                    Console.Clear();
                    loopRunning = false;
                    DisplayTrueEndBad();

                }

                else
                {
                    Console.WriteLine("No valid response detected");
                    Console.WriteLine("What do you want to do? [A, B] ");
                    Console.WriteLine("A) Arrest Val");
                    Console.WriteLine("B) Head to Mexico");
                    userResponse = Console.ReadLine().ToUpper();
                }
            }
        }

        static void DisplayFalseEnd()
        {
            Console.Clear();
            Console.WriteLine("I left the interogation room, and wlked out onto the street.");
            Console.WriteLine("The suspect was in custody, my job was done.");
            Console.WriteLine("I headed back to the office for a another case.");
            Console.WriteLine("And a smoke.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("ENDING 2 OF 4");
            Console.WriteLine("CASE CLOSED ENDING");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }

        static void DisplayTrueEndGood()
        {
            Console.WriteLine("She didn't come easily. But she came.");
            Console.WriteLine("The diamond was in her bag like I thought it would be.");
            Console.WriteLine("I was hailed as a local hero.");
            Console.WriteLine("Name in the paper, handshake from the mayor, the whole nine yards.");
            Console.WriteLine("But eventually things settled down.");
            Console.WriteLine("Until the next case.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("ENDING 4 OF 4");
            Console.WriteLine("GOOD ENDING");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }

        static void DisplayTrueEndBad()
        {
            Console.WriteLine("I boarded the plane without a second thought.");
            Console.WriteLine("By this time tomorrow I'd be sipping margaritas in Mexico.");
            Console.WriteLine("Who says crime doesn't pay?");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("ENDING 3 OF 4");
            Console.WriteLine("PERMANENT VACATION ENDING");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();
        }

        static void DisplayBadEnd()
        {
            Console.Clear();
            Console.WriteLine("\'FREEZE!\' I yelled.");
            Console.WriteLine("I pointed my gun at the man in the entrance way.");
            Console.WriteLine("He big and gruff and had a birthmark on his face.");
            Console.WriteLine("Slowly he put his hands in the air.");
            Console.WriteLine("Then he dove into a side room.");
            Console.WriteLine("I chased after him.");
            Console.WriteLine("The window was open and looking out he was scambling down the rickety fire escape");
            Console.WriteLine("I went after him, chasing him out onto the metal structure.");
            Console.WriteLine("I reached the bottom breathless, and looked around.");
            Console.WriteLine("I was in an alley, the were a couple dumpsters to my left and the street to my right.");
            Console.WriteLine("There was a noise from the dumpsters.");
            Console.WriteLine("I walked over to the dumpster, gun in hand.");
            Console.WriteLine("With a motion I threw open the lid.");
            Console.WriteLine("Only trash was inside.");
            Console.WriteLine("I sighed and holstered my gun.");
            Console.WriteLine("Then a wire went over my head and arond my neck.");
            Console.WriteLine("I reached for my gun but he jerked my head and slammed it into the dumpster.");
            Console.WriteLine("Stars dotted my vision, and then everything went black.");
            Console.WriteLine();
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine("GAME OVER");
            Console.WriteLine("ENDING 1 OF 4");
            Console.WriteLine("BAD ENDING");
            Console.WriteLine("PRESS ANY KEY TO EXIT");
            Console.ReadKey();

    
        }

        static string DisplayOpeningScreen()

        {
            string name;

            Console.Clear();



            Console.WriteLine();

            Console.WriteLine("\t\tCapStone");

            Console.WriteLine();

            Console.Write("Please enter your name:");
            name = Console.ReadLine();


            DisplayContinuePrompt();

            return name;

        }

        static void DisplayContinuePrompt()

        {

            Console.WriteLine();

            Console.WriteLine("Press any key to continue.");

            Console.ReadKey();

        }


        static void DisplayEndingOne()

        {

            Console.Clear();



            Console.WriteLine();

            Console.WriteLine("");

            Console.WriteLine();



            Console.WriteLine("Press any key to exit.");

            Console.ReadKey();

        }
    }
}
