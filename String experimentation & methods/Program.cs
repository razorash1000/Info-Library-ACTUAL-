using System;
using System.Diagnostics;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Xml.Serialization;

namespace strings
{
    public class STR
    {
        
        public static void Main()
        {
      

            Console.Write("string phrase = ");
            
            string phrase = "|This is a test string| ";                                     
            Console.WriteLine(phrase);
            Console.WriteLine("                0123456789.123456789.12");

            Console.Write("string phrase2 = ");
            string phrase2 = "|This is also a test string|";
            Console.WriteLine(phrase2);
            Console.WriteLine("                 0123456789.123456789.1234567");
            Console.WriteLine("Press esc to exit");
         
            

            STR str = new STR();
            

            Console.WriteLine("Welcome to the Console!");
            Console.ReadKey();
            Console.WriteLine("If you are back here again then I am making the assumption that you are in need of reference to something yes? \nperhaps maybe even a string method..");
            Console.ReadKey();
            Console.WriteLine("If that is so, you are in luck! this pre-made repository has most of the existing methods for strings as of (2023/07/27)");
            Console.ReadKey();
            Console.WriteLine("Bear in mind before you start, the variables \"phrase\" and \"phrase2\" are pre-defined, and the process of how to make them is something I'm anticipating you already know..");
            Console.ReadKey();
            Console.WriteLine("Finally, type and enter the number of the options below to be presented with a definition of said method.");
            STR.num(phrase, phrase2);    
        }
    
        
        static void printvar(string phrase, string phrase2)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase + phrase2);");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase + phrase2);
            Console.ReadKey();
            Console.WriteLine("EXPLANATION: PRINTS OUT THE STRING INSIDE THE VARIABLE");
        }

        static void varlen(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.Length);");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Length);
            Console.ReadKey();
            Console.WriteLine("LENGTH RETURNS THE # OF CHARACTERS IN THE SPECIFIED STRING");
        }

        static void varsub(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.Substring(10));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Substring(10));
            Console.ReadKey();
            Console.WriteLine("SUBSTRING RETURNS WHATEVER PART OF THE STRING IS AFTER THE ZERO BASED INDEX NUMBER YOU INPUT 0-STRING.LENGTH. THIS METHOD ALSO CONTAINS 1 OVERLOAD.THE OVERLOAD IS IF YOU INPUT \"10\" LIKE ABOVE YOU CAN INPUT , # AFTER. THE # AFTER IN THE SECOND PARAMETER IS THE TOTAL # OF CHARACTERS (INCLUDING \"10\" THAT WILL BE PRINTED OUT INSTEAD OF PRINTING OUT THE REST OF THE STRING");
        }

        static void varlasind(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.LastIndexOf('i'));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.LastIndexOf('i'));
            Console.ReadKey();
            Console.WriteLine("PRINTS OUT THE INDEX NUMBER FOR THE LAST OCCURANCE OF THE SPECIFIED CHARACTER FOR INSTANCE THE LAST TIME THE CHARACTER 'i' IS SEEN IN string phrase IS AT INDEX NUMBER 18. THIS LINE WILL OUTPUT 18");
           
        }

        static void uplow(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.ToUpper());");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.ToUpper());
            Console.ReadKey();
            Console.WriteLine("CONVERTS EVERY CHARACTER IN THE STRING TO A UPPER CASE CHARACTER");
            Console.WriteLine("Console.WriteLine(phrase.ToLower());");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.ToLower());
            Console.ReadKey();
            Console.WriteLine("CONVERTS EVERY CHARACTER IN A STRING TO A LOWER CHASE CHARACTER");
        }

        static void comp(string phrase, string phrase2)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.CompareTo(phrase2));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.CompareTo(phrase2));
            Console.ReadKey();
            Console.WriteLine("COMPARES THE SELECTED STRING TO ANOTHER STRING IN ALPHEBETICAL ORDER. IF STRING A(THE FIRST ONE) COMES BEFORE STRING B(THE ONE IN THE PARENTHESIS) THEN IT WILL OUTPUT -1, IF IT COMES AFTER THEN 1, IT THEY ARE COME AT THE SAME TIME THEN 0*/");
        }

        static void conc(string phrase, string phrase2)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(string.Concat(phrase, phrase2));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(string.Concat(phrase, phrase2));
            Console.ReadKey();
            Console.WriteLine("JOINS 2 STRINGS TOGETHER OF YOUR CHOICE! PARAMETER 1 + PARAMETER 2!");
        }

        static void cont(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.Contains(\"test string\"));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Contains("test string"));
            Console.ReadKey();
            Console.WriteLine("THIS METHOD CHECKS TO SEE IF THE SPECIFIED STRING CONTAINS A CHARACTER OR LIST OF CHARACTERS YOU SPECIFY");
        }
        static void ends(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.EndsWith('a'));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.EndsWith('a'));
            Console.ReadKey();
            Console.WriteLine("THIS METHOD TESTS IF THE END OF YOUR STRING ENDS WITH THE SPECIFIED CHARACTER WITH BOOLEAN EXPRESSION");
        }
        
        static void equals(string phrase, string phrase2)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("Console.WriteLine(phrase.Equals(phrase2));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Equals(phrase2));
            Console.ReadKey();
            Console.WriteLine("THIS LINE TESTS IF YOUR 2 STRINGS ARE THE SAME OR NOT. IF YES, TRUE, IF NO, FALSE");
        }
        
        static void format(string phrase)
        {
            Console.Write("Your Input: ");
            Console.WriteLine("double pricePerOunce = 17.36;\r\nString s = String.Format(\"The current price is {0} per ounce.\", pricePerOunce); \nConsole.WriteLine(s);");
            Console.ReadKey();  
            double pricePerOunce = 17.36;
            Console.Write("Output: ");
            String s = String.Format("The current price is {0} per ounce.", pricePerOunce);
            Console.WriteLine(s);
            Console.ReadKey();
            Console.WriteLine("WHAT IS HAPPENING HERE LOOKS COMPLICATED BUT. IS NOT... .FORMAT HAS 2 PARAMETERS RIGHT HERE^. A STRING, AND A VARIABLE. YOU TYPE OUT THE STRING WITH THE {0} AT WHERE YOU WANT THE VARIABLE TO BE INSERTED WITH A STRING FORMAT. THEN YOU , + THE VARIABLE IN QUESTION. THIS AUTOMATICALLTY CONVERTS THE VARIABLE IN QUESTION INTO A STRING!");
        }
        static void indexof(string phrase)
        {
            Console.Write("Input: ");
            Console.WriteLine("Console.WriteLine(phrase.IndexOf(\"i\"));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.IndexOf("i"));
            Console.ReadKey();
            Console.WriteLine("THE OUTPUT IS THE INDEX NUMBER FOR THE FIRST OCCURENCE OF THE SPECIFIED CHARACTER"); 
        }
        static void join()
        {
            Console.Write("Input: ");
            Console.WriteLine("Console.WriteLine(string.Join(\"I am \", String.Empty, \"gay\"));");
            Console.ReadKey();
            Console.WriteLine("Output: ");
            Console.WriteLine(string.Join("I am ",String.Empty,  "gay"));
            Console.ReadKey();
            Console.WriteLine("AT THE TIME OF WRITING THIS, THIS IS BASICALLY LIKE STRING.CONCAT. THE ONLY DIFFERENCE SEEMS TO BE THAT YOU CANNOT COMBINE VARIABLES, ONLY INDIVIDUAL STRINGS. AND YES, STRING.EMPTY IS NECESSARY, OTHERWISE IT WILL ONLY OUTPUT THE 2ND STRING. NOT SURE WHY AT THE MOMENT.");
        }
        static void pad(string phrase, string phrase2)
        {
            Console.Write("Input");
            Console.WriteLine("Console.WriteLine(phrase.PadLeft(50));");
            Console.ReadKey();
            Console.WriteLine("Output(top) vs original (bottom): ");
            Console.WriteLine(phrase.PadLeft(50));
            Console.WriteLine(phrase);
            Console.ReadKey();
            Console.WriteLine("BASICALLY THIS ADDS SPACES ON THE LEFT SIDE OF YOUR STRING, THIS IS CALLED \"PADDING\". .PADRIGHT DOES THE SAME THING TO THE RIGHT SIDE");
        }
        static void rem(string phrase, string phrase2)
        {
            Console.Write("Input: ");
            Console.WriteLine("Console.WriteLine(phrase.Remove(4, 10));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Remove(4, 10));
            Console.ReadKey();
            Console.WriteLine("REMOVES EVERY CHARACTER AFTER THE INDEX NUMBER SPECIFIED. PARAMETER IS INDEX NUMBER, 2ND IS COUNT. 2ND = HOW MANY AFTER INDEX NUMBER WILL BE REMOVED(INCLUDING INDEX#)");
        }
        static void rep(string phrase, string phrase2)
        {
            Console.Write("Input: ");
            Console.WriteLine("Console.WriteLine(phrase.Replace(phrase[5], 'A'));");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Replace(phrase[5], 'A'));
            Console.ReadKey();
            Console.WriteLine("ANY CHARACTER THAT IS THE SAME AS THE SPECIFIED INDEX CHARACTER WILL BE CHANGED TO THE NEW CHARACTER");
        }

        static void split(string phrase)
        {        
            Console.Write("Input: ");
            Console.WriteLine("string[] words = phrase.Split(' '); \nforeach (string word in words)\r\n            {\r\n                Console.WriteLine(word);\r\n            }");
            Console.ReadKey();
            Console.Write("Output: ");
            string[] words = phrase.Split(' ');
            foreach (string word in words)
            {
                Console.WriteLine(word);
            }
            Console.ReadKey();
            Console.WriteLine("LONG EXPLANATION INCOMMING! BASICALLY WHAT THIS IS DOING IS JUST USING A LOOP TO SPLIT YOUR STRING INTO AN ARRAY. THE CODE WILL \"SPLIT\" YOUR ARRAY ON EVERY ITERATION OF THE SPECIFIED CHARACTER, THEN IT WILL EXECUTE THE CODE IN THE BRACKETS. WILL GO OVER LOOPS IN DETAIL IN ANOTHER PROGRAM!");
        }
        static void start(string phrase)
        {
            Console.Write("Input: ");
            Console.WriteLine("Console.WriteLine(phrase.StartsWith('T'))");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.StartsWith('T'));
            Console.ReadKey();
            Console.WriteLine(" GENERATES A BOOLEAN TO DETERMINE WHETHER THE FIRST CHARACTER IN YOUR STRING IS OR IS NOT THE SPECIFIED CHARACTER");

        }
        static void arry(string phrase)
        {
            Console.Write("Input: ");
            Console.WriteLine("char[] characters = phrase.ToCharArray();\r\n            foreach (char c in characters)\r\n            {\r\n                Console.WriteLine(c);\r\n            }");
            Console.ReadKey();
            Console.Write("Output: ");
            char[] characters = phrase.ToCharArray();
            foreach (char c in characters)
            {
                Console.WriteLine(c);
            }
            Console.WriteLine("THIS FUNCTION TAKES EVERY SINGLE CHARACTER AND PUTS IT INTO AN ARRAY.");    
        }
         static void trim(string phrase)
        {
            string strtrim = phrase.Trim();
            Console.Write("Input: ");
            Console.WriteLine("string strtrim = phrase.Trim(); \n Console.WriteLine(phrase.Trim());");
            Console.ReadKey();
            Console.Write("Output: ");
            Console.WriteLine(phrase.Trim());
            Console.ReadKey();
            Console.WriteLine("FOR THIS METHOD YOU HAVE TO CREATE AN OBJECT FOR THE VARIABLE TO GO INSIDE. THAT IS WHAT THE \"string strtrim = phrase.Trim();\" IS FOR. THIS METHOD JUST REMOVES ALL UNNECCECARY SPACES FROM THE STRING");
        }
        static void yn(string phrase,  string phrase2)
        {
            Console.WriteLine("continue? (y/n)");
            string choice = Console.ReadLine(); 
            if (choice == "y")
            {
                STR.num(phrase, phrase2);
            }
            else
            {
                Console.WriteLine("I hope this was helpful, it took a while to make!");
                Environment.ExitCode = 0;
            }
            
        }
       

        static void num(string phrase, string phrase2)
        {
            Console.WriteLine("Here are your options: \n 1. Printing a variable by name \n 2. String.Length \n 3. String.Substring \n 4. String.LastIndexof \n 5. String.ToUpper & String.ToLower");
            Console.WriteLine(" 6. String.CompareTo \n 7. String.Concat \n 8. String.Contains \n 9. String.EndsWith \n 10. String.Equals \n 11. String.Format \n 12. String.IndexOf \n 13. String.Join");
            Console.WriteLine(" 14. String.PadLeft & StringPadRight \n 15. String.Remove \n 16. String.Replace \n 17. String.Split \n 18. String.StartsWith \n 19. String.ToCharArray \n 20. String.Trim");
            string choice = Console.ReadLine();
            
            if (choice == "1")
            {
                STR.printvar(phrase, phrase2);
                STR.yn(phrase, phrase2);
            }
            if (choice == "2")
            {
                STR.varlen(phrase);
                STR.yn(phrase, phrase2);
            }
            if(choice == "3")
            {
                STR.varsub(phrase);
                STR.yn(phrase, phrase2);
            }
            if( choice == "4")
            {
                STR.varlasind(phrase);
                STR.yn(phrase, phrase2);
            }
            if( choice == "5") 
            {
                STR.uplow(phrase);
                STR.yn(phrase, phrase2);
            }
            if( choice=="6")
            {
                STR.comp(phrase, phrase2);
                STR.yn(phrase, phrase2);
            }
            if (choice == "7")
            {
                STR.conc(phrase, phrase2);
                STR.yn(phrase, phrase2);
            }
            if(choice == "8")
            {
                STR.cont(phrase);
                STR.yn(phrase, phrase2);
            }
            if(choice == "9")
            {
                STR.ends(phrase);
                STR.yn(phrase, phrase2);
            }
            if (choice == "10")
            {
                STR.equals(phrase, phrase2);
                STR.yn(phrase, phrase2);
            }
            if (choice == "11")
            {
                STR.format(phrase);
                STR.yn(phrase, phrase2);
            }
            if(choice == "12")
            {
                STR.indexof(phrase);
                STR.yn(phrase, phrase2);
            }
            if (choice == "13")
            {
                STR.join();
                STR.yn(phrase, phrase2);
            }
            if (choice == "14")
            {
                STR.pad(phrase, phrase2);
                STR.yn(phrase, phrase2);
            }
            if (choice == "15")
            {
                STR.rem(phrase, phrase2);
                STR.yn(phrase, phrase2);

            }
            if( choice == "16")
            {
                STR.rep(phrase, phrase2);
                STR.yn(phrase, phrase2);
            }
            if(choice == "17")
            {
                STR.split(phrase);
                STR.yn(phrase, phrase2);    
            }
            if (choice == "18")
            {
                STR.start(phrase);
                STR.yn(phrase, phrase2);
            }
            if (choice == "19")
            {
                STR.arry(phrase);
                STR.yn(phrase, phrase2);
            }
            if (choice == "20")
            {
                STR.trim(phrase);
                STR.yn(phrase, phrase2);  
            }

        }


    }
}