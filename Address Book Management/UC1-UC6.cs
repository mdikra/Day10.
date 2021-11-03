using System;
using System.Collections.Generic;
using System.Text;

namespace AddressBookManagement
{
    class UC1_UC6
    {
        public static int input { get; private set; }

        static void Main()
        {
            ArrayList address = new ArrayList { };
            Boolean menu = true;

            do
            {

                Console.WriteLine("Welcome to my address book program");
                Console.WriteLine("***********");
                Console.WriteLine("Press 1 to Add an entry to the address book");
                Console.WriteLine("Press 2 to Remove any entry in the address book");
                Console.WriteLine("Press 3 to Print the book to the screen");
                Console.WriteLine("Press 4 to Edit a record");
                Console.WriteLine("Press 5 to Search for a record");
                Console.ReadLine();


                Console.WriteLine("Please Enter your Lastname");
                string str2 = "Lastname";
                str2 = Console.ReadLine();
                string valueString2 = str2;

                Console.WriteLine("Please Enter your Firstname");
                string str1 = "Firstname";
                str1 = Console.ReadLine();
                string valueString1 = str1;

                Console.WriteLine("Please Enter your Address, house number and town");
                string str3 = "Address";
                str3 = Console.ReadLine();
                string valueString3 = str3;

                Console.WriteLine("Please Enter your County");
                string str5 = "County";
                str5 = Console.ReadLine();
                string valueString5 = str5;

                Console.WriteLine("Please Enter your Postcode");
                string str6 = "Postcode";
                str6 = Console.ReadLine();
                string valueString6 = str6;



                Console.WriteLine("Here is a list of the stored names and addresees that you have entered so far");
                Console.WriteLine("**************************");
                Console.ReadLine();

                Console.WriteLine("Lastname you entered: " + valueString2);
                Console.WriteLine("Firstname you entered: " + valueString1);
                Console.WriteLine("Address and house number and town you entered: " + valueString3);
                Console.WriteLine("County you entered: " + valueString5);
                Console.WriteLine("Postcode you entered: " + valueString6);
                Console.ReadLine();

            }

            while (menu == true);

            switch (input)
            {
                case 1:
                    // add address
                    break;
                case 2:
                    // edit address
                    break;
                case 3:
                    // delete addrerss
                    break;
                case 4:
                    // add multiple person address
                    break;
                case 5:
                    // refactor to add multiple address
                    break;
            }

            do
            {
                Console.WriteLine("Welcome to my address book program");
                Console.WriteLine("***********");
                Console.WriteLine("Press 1 to Add an entry to the address book");
                Console.WriteLine("Press 2 to Remove any entry in the address book");
                Console.WriteLine("Press 3 to Print the book to the screen");
                Console.WriteLine("Press 4 to Edit a record");
                Console.WriteLine("Press 5 to Search for a record");
            
                switch (Console.ReadLine())
                {
                    case "1": // Check if user entered 1.
                        Console.Clear(); // Clear the console screen.
                        Console.WriteLine("Add!"); // Write you add "program" here.
                        break; // Stop the switch loop.
                    case "2":
                        Console.WriteLine("edit");
                        break;
                    case "3":
                        Console.WriteLine("delete");
                        break;
                    case "4":
                        Console.WriteLine(" add multiple person");
                        break;
                    case "5":
                        Console.WriteLine("refactor to add multiple person");
                        break;

                    default: // If user didn't enter 1 or 2 his choice isn't valid. Show a message.
                        Console.WriteLine("The choice you made isn't valid, please try again.");
                        break;
                }

            }
            
        }
    }
}
