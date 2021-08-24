using System;
using System.Collections.Generic;

namespace Six_part_assignment
{
    class Program
    {
        static void Main()
        {
            //Part 1
            //Creating a string array.
            string[] passwords = { "123456", "123456789", "picture1", "password", "12345678", "111111", "123123", "12345", "1234567890", "senha", "1234567", "1234567", "qwerty", "abc123"};

            //Creating a variable to use as the array index throughout this program.
            ushort i;

            //Writing text to the console.
            Console.WriteLine("Please enter a string value:");

            //Creating a string variable from user input.
            string salt = Console.ReadLine();

            //Loop through all passwords and add the salt to each.
            for (i = 0; i < passwords.Length; i++)
            {
                passwords[i] += salt;
            }

            //Loop through all passwords and write it to the console.
            foreach (string password in passwords)
            {
                Console.WriteLine(password);
            }

            //Part 2
            //Reset the index.
            i = 0;

            //Infinite loop
            while (true)
            {
                //Print the index and the password at that index.
                Console.WriteLine(i + ": " + passwords[i]);

                //Break out of the loop if i is greater than the length of the array.
                if (++i >= passwords.Length)
                {
                    break;
                }
            }

            //Part 3

            //Reset the index.
            i = 0;

            //Loop through all the passwords and print the index and value of each one to the screen.
            while (i < passwords.Length)
            {
                Console.WriteLine(i + ": " + passwords[i++]);
            }

            //Reset the index and loop through all the passwords, printing the index and value of each one to the screen.
            i = 0;
            while (i <= passwords.Length - 1)
            {
                Console.WriteLine(i + ": " + passwords[i++]);
            }

            //Part 4
            //Assign a new list of unique strings to a variable.
            List<string> lyrics = new List<string> {
                "Hand me down my walkin' cane",
                "Hand me down my hat",
                "Hurry now and don't be late",
                "'Cause we ain't got time to chat",
                "You and me, we're goin' out",
                "To catch the latest sound",
                "Guaranteed to blow your mind",
                "So high you won't come down",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound",
                "Like the rubberband man",
                "You're bound to lose control",
                "When the rubberband starts to jam",
                "Oh, this dude is outta sight",
                "Everything he does",
                "Seems to come out right",
                "Once I went to hear him play",
                "At a club outside of town",
                "I was so surprised, I was hypnotized",
                "By the sound these cats put down",
                "When I saw this short, fat guy",
                "Stretch a band between his toes",
                "Hey, I laughed so hard",
                "'Cause the man got down",
                "When it finally reached his nose"
            };

            //Assigning the value false to a new boolean variable.
            bool foundMatch = false;

            //Print some text to the console.
            Console.WriteLine("Please enter some text to search for in the list.");

            //Assign the user entered text to a variable.
            string search = Console.ReadLine();

            //Loop through all the elements in the list.
            for (i = 0; i < lyrics.Count; i++)
            {
                //If the search value is found in the element
                if (lyrics[i].Contains(search))
                {
                    //Print the index and value of the element to the console.
                    Console.WriteLine(i + ": " + lyrics[i]);

                    //Remember a match was found and break out of the for loop.
                    foundMatch = true;
                    break;
                }

            }

            //If no match was found, tell the user.
            if (foundMatch == false)
            {
                Console.WriteLine(search + " was not found in the list.");
            }

            //Part 5

            //Add all the lyrics, including duplicate lines, to the list.
            lyrics = new List<string> {
                "Hand me down my walkin' cane",
                "Hand me down my hat",
                "Hurry now and don't be late",
                "'Cause we ain't got time to chat",
                "You and me, we're goin' out",
                "To catch the latest sound",
                "Guaranteed to blow your mind",
                "So high you won't come down",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound",
                "Like the rubberband man",
                "You're bound to lose control",
                "When the rubberband starts to jam",
                "Oh, this dude is outta sight",
                "Everything he does",
                "Seems to come out right",
                "Once I went to hear him play",
                "At a club outside of town",
                "I was so surprised, I was hypnotized",
                "By the sound these cats put down",
                "When I saw this short, fat guy",
                "Stretch a band between his toes",
                "Hey, I laughed so hard",
                "'Cause the man got down",
                "When it finally reached his nose",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound",
                "Like the rubberband man",
                "You're bound to lose control",
                "When the rubberband starts to jam",
                "Got that rubber band, uh",
                "Up on his toes",
                "And then he wriggled it up",
                "All around his nose",
                "(Du du du du du du du du)",
                "Guaranteed to blow your mind",
                "(Du du du du du du du du)",
                "Playin' all that music, yet keepin' time",
                "(Du du du du du du du du)",
                "Where in the world did he learn that, oh, Lord",
                "(Du du du du du)",
                "Lord, help him get away",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound",
                "Like the rubberband man",
                "You're bound to lose control",
                "When the rubberband starts to jam",
                "Choo, choo, choo, choo, choo, uh",
                "Choo, choo, choo, choo, choo, choo",
                "Choo, choo, choo, choo, choo, uh",
                "Rubberband man, rubberband man, uh",
                "(Du du du du du du du du)",
                "Du du du du",
                "(Du du du du du du du du)",
                "Watch him, keep movin', just movin'",
                "Got em groovin' on the corner, it's burnin' up, y'all",
                "(Du du du du du du du du)",
                "Ohooohooohhh",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound",
                "Like the rubberband man",
                "You're bound to lose control",
                "When the rubberband starts to jam",
                "Ay, ay, ay, ay",
                "Rubberband man's a doozy",
                "Move so quick, uh, he make me woozy",
                "(Du du du du du du du du)",
                "And then he stopped to show down",
                "He wiggle it up, he wiggle it down, uh",
                "(Du du du du du du du du)",
                "Got speed to move it",
                "Get rubberband off the ground, uh",
                "(Du du du du du du du du)",
                "He lifted it well high",
                "In the sky, y'all",
                "And then he",
                "Du du du du du",
                "Oh, get with it, y'all",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound",
                "Like the rubberband man",
                "You're bound to lose control",
                "When the rubberband starts to jam",
                "Choo, choo, choo, choo, choo, uh",
                "Turn it up, turn it up",
                "Choo, choo, choo, choo, choo, uh",
                "Rubberband man, rubberband man, uh",
                "(Du du du du du du du du)",
                "How much of this stuff do he think we can stand, uh, huh?",
                "(Du du du du du du du du)",
                "So much rhythm, grace, and debonair for one man, Lord",
                "(Du du du du du du du du)",
                "And then he had the nerve to twiggle his left toe",
                "Slip it through his knee, got the feeling in his head, y'all",
                "(Du du du du du)",
                "Aw, come on, baby",
                "Hey, y'all, prepare yourself (won't you prepare yourself, hear me) for the rubberband man",
                "You've never heard a sound (never heard a sound)",
                "Like the rubberband man(Aw, he's the man)",
                "You're bound to lose control (and he likes to jam)",
                "When the rubberband starts to jam",
                "Rubberband man starts to jam",
                "Moving up and down cross the land",
                "Got the people all in his wake",
                "Everything probably seems outta place",
                "Just move it, just move it",
                "(Du du du du du du du du)",
                "Just move, move, move it",
                "Just, rubberband, rubberband man",
                "Just move it, just move it",
                "(Du du du du du du du du)",
                "Just move, move, move it",
                "Just, rubberband, rubberband man",
                "Get down",
                "(Du du du du du du du du)",
                "Oh, get down low",
                "Ah ha",
                "(Du du du du du du du du)",
                "Oh, he can jam, y'all",
                "Hey, y'all, prepare yourself for the rubberband man",
                "You've never heard a sound (never heard a sound)",
                "Like the rubberband man(never felt the groove)",
                "You're bound to lose control (take a seat and move)",
                "When the rubberband starts to jam",
                "Ohwee",
                "What's he doin' to me ?",
                "Rhythms I ain't felt before",
                "Just groovin' up loudly",
                "Gotta move, I gotta groove",
                "Rubberband man",
                "(Du du du du du du du du)",
                "Achoo, achoo, achoo",
                "(Du du du du du du du du)",
                "The way he twiddles his toes with the band[?]",
                "Hey, y'all, (I don't know) prepare yourself for the rubberband man(Aw, prepare yourself, y'all)",
                "You've never heard a sound (Can see his show)",
                "Like the rubberband man",
                "You're bound to lose control (Throwing his hat)",
                "When the rubberband starts to jam",
                "Ready to jam",
                "Do my Rubberband",
                "Ready to jam",
                "I gotta do my Rubberband",
                "(Du du du du du du du du)",
                "A - twang, a - twang, a - twang, a - twang",
                "Lord, have mercy",
                "(Du du du du du du du du)",
                "A - twang, a - twang, a - twang, a - twang",
                "Just strike me in my bones",
                "A - twang, a - twang, a - twang, a - twang",
                "Maked a move, y'all",
                "I kinda groove when I did",
                "Hey, y'all, prepare yourself for the rubberband man (ya gotta believe me)",
                "You've never heard a sound (He's a[?] cat )",
                "Like the rubberband man(he moves and grooves)",
                "You're bound to lose control ([?])",
                "When the rubberband starts to jam",
                "He's a big fat man that moves me good",
                "Everybody oughta knock on wood",
                "When you see the man do his stuff",
                "I done see enough",
                "(Du du du du du du du du)",
                "Movin' his shoulders",
                "Got his head movin' side to side",
                "(Du du du du du du du du)",
                "Dig him crimpin' with a [?]",
                "(Du du du du du du du du)",
                "Oh, he's the man, rubberband man",
                "(Du du du du du)"
            };

            //Reset the variable to false.
            foundMatch = false;

            //Write some text to the console.
            Console.WriteLine("Please enter some text to search for in the list.");

            //Assign the user entered value to the variable.
            search = Console.ReadLine();

            //Loop through all the elements in the array
            for (i = 0; i < lyrics.Count; i++)
            {
                //If the line contains the search string
                if (lyrics[i].Contains(search))
                {
                    //Write the index and value of the line to the console.
                    Console.WriteLine(i + ": " + lyrics[i]);

                    //Remember that the match was found.
                    foundMatch = true;
                }

            }

            //If no match was found, tell the user.
            if (foundMatch == false)
            {
                Console.WriteLine(search + " was not found in the list.");
            }

            //Part 6

            //Create a new count variable as type ushort.
            ushort count;

            //Loop through all the elements in the array
            for (i = 0; i < lyrics.Count; i++)
            {
                //Set count to 0
                count = 0;

                //Go through all previous elements in the array
                for (ushort j = 0; j < i; j++)
                {
                    //Count the number of lines that are the same as the current one
                    if (lyrics[i] == lyrics[j])
                    {
                        count++;
                    }
                }

                //Display the line and the count.
                Console.WriteLine(lyrics[i] + " is repeated " + count + " times.");
            }
        }
    }
}
