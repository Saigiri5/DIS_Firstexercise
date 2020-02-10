using System;
using System.Collections.Generic;
using System.Linq;

namespace Assignment1_Spring2020
{
    class Program
    {
        private const int Seconds = 0;
        
        static void Main(string[] args)
        {
            int n = 5;
            PrintPattern(n);

            int n2 = 6;
            PrintSeries(n2);

            string s = "09:15:35PM";
            string t = UsfTime(s);
            Console.WriteLine(t);

            int n3 = 110;
            int k = 11;
            UsfNumbers(n3, k);

            string[] words = new string[] { "abcd", "dcba", "lls", "s", "sssll" };
            PalindromePairs(words);

            int n4 = 5;
            Stones(n4);
        }

        // Defining the private printpattern method with return type Void 
        private static void PrintPattern(int n)
        {
            /*
             * This method prints number pattern of integers using recursion
             */

            try
            {
                //defining variable a and initilizing with empty value
                string a = "";

                // Check whether given input is greater than zero or not
                if (n >= 0)  
                {
                    // Loop to print the numbers from given value to 1
                    for (int i = n; i > 0; i--) 
                    {
                        //Appends all the numbers which are coming from loop
                        a += i; 
                    }

                    //prints the output in one line
                    Console.WriteLine(a); 
                    // Calls printpattern method recursively by passing the decremented value as input

                    PrintPattern(n - 1);
                }
            }
            //Below exception message will be displayed in output If any expections are caught during program execution.
            catch
            {
                Console.WriteLine("Exception Occured while computing printPattern");
            }
        }

        // Defining the private PrintSeries method with return type Void 
        private static void PrintSeries(int n2)
        {
            /*
             * The method prints the sequence of numbers which are sum of integers preceding that number
             */

            try
            {
                Console.WriteLine("****************************  2nd program  *****************************");

                // For loop to print the sequence in given limit
                for (int e = 1; e <= n2; e++)  
                {
                    //defining variable a and initializing it to 0 value
                    int a = 0;

                    // for loop to print the sequence numbers
                    for (int i = 1; i <= e; i++) 
                    {
                        // adds the i value to existing a variable value
                        a += i; 
                    }
                    //prints the a variable value with ,
                    Console.Write(a+","); 
                }
                //prints new line
                Console.WriteLine();
            }
            //If any exception below code will be executed.
            catch
            {
                //Prints exception message,If any expections are caught during program execution.
                Console.WriteLine("Exception Occured while computing printSeries");
            }
        }

        // Defining the private PrintSeries method with return type string
        public static string UsfTime(string s)
        {
            try
            {
                /*
                 * This method prints coverted time in USF clock format(i.e. UU:SS:FF )where 01<= UU<=36, 00<=SS<=59,00<=FF<=45
                 */

                Console.WriteLine("****************************  3rd program  *****************************");

                /* converting the string to datetime format, extracting the time of day
                 and assiging it to timespan data type varaible "tsTime"*/
                TimeSpan tsTime = DateTime.Parse(s).TimeOfDay;
                // Coverts the time to total seconds and assign it to secs variable
                int Secs  = Convert.ToInt32(tsTime.TotalSeconds);
                //Calculation for seconds and assigning it to variable
                int seconds = Secs % 45;
                //Calculation for minutes and assigning it to variable
                int mins = (Secs / 45) % 60;
                //Calculation for hours and assigning it to variable
                int hours = (Secs / 45)/60;

                //prints the ouput in hours:mins:seconds format 
                Console.Write(hours+":");
                Console.Write(mins+":");
                Console.WriteLine(seconds);
            }
            //If any exception below code will be executed.
            catch
            {
                //Prints exception message,If any expections are caught during program execution.
                Console.WriteLine("Exception Occured while computing UsfTime");
            }
            return null;
        }

        //Defines the UsfNumbers method with Void return type
        public static void UsfNumbers(int n3, int k)
        {
            try
            {
                /*
                 * This method prints the numbers 1 to 110, 11 numbers per line.
                 * The method shall print 'U' in place of numbers which are multiple of 3,"S" for multiples of 5,"F" for multiples of 7,
                 * 'US' in place of numbers which are multiple of 3 and 5,'SF' in place of numbers which are multiple of 5 and 7 and so on. 
                 */

                Console.WriteLine("****************************  4th program  *****************************");

                //Declaring and initializing the variable
                int a = 0;

                //for loop to print 10 rows of numbers
                for (int i=0; i < (n3/k); i++)
                {
                    //adds the i variable value to a variable value
                    a = a + i;

                    //for loop to print 11 elements for each row 
                    for (int e = (a * k)+1; e <= (a+1) * k; e++)
                    {
                        //Checks whether number is divisble by 3 or not
                        if (e % 3 == 0)
                        {
                            //Checks whether number is divisble by 5 or not
                            if (e % 5 == 0)
                            {
                                //If number is divisble by 3 and 5, it prints "US" in output
                                Console.Write("US" + " ");
                            }
                            //If number is divisble by only 3, it prints "U" in output
                            Console.Write("U" + " ");
                        }
                        //Checks whether number is divisble by 5 or not
                        else if (e % 5 == 0)
                        {
                            //Checks whether number is divisble by 7 or not
                            if (e % 7 == 0)
                            {
                                //If number is divisble by 5 and 7, it prints "SF" with space in output
                                Console.Write("SF" + " ");
                            }
                            //If number is divisble by only 5, it prints "S" with space in output
                            Console.Write("S" + " ");
                        }
                        //Checks whether number is divisble by 7 or not
                        else if (e % 7 == 0)
                        {
                            //If number is divisble by only 7, it prints "F" with space in output
                            Console.Write("F" + " ");
                        }
                        // If any of above conditions fails, below code will be executed 
                        else
                        {
                            //Prints the number in output with space
                            Console.Write(e + " ");
                        }
                    }
                    //Prints new line in ouptput
                    Console.WriteLine();
                    
                }
            }
            //If any exception below code will be executed.
            catch
            {
                Console.WriteLine("Exception occured while computing UsfNumbers()");
            }
        }


        //Defines the PalindromePairs method with Void return type
        public static void PalindromePairs(string[] words)
        {
            try
            {
                /*
                 * This method print distinct indices of words given in the list which two can be palindrome pairs by concatenating the both the words.
                 */

                Console.WriteLine("****************************  5th program  *****************************");

                //defining the variable lw and assigning the value as length of words list
                int lw = words.Length;

                //for loop which traverse through words list
                for (int i =0;i<lw;i++)
                {
                    for (int j = 0;j<lw;j++)
                    {
                        if (words[i] != words[j])
                        {
                            //concatenates the two strings 
                            string newstring = words[i] + words[j];
                            //Defining character array and initializing with newstring characters
                            char[] reversestring = newstring.ToCharArray();
                            //Reversed the characters in reversestring character array
                            Array.Reverse(reversestring);
                            //converting the character array to string and assiging it to variable
                            string newstring1 = new string(reversestring);

                            //Checks the whether string is equal to it's reverse string or not
                            if (newstring == newstring1)
                            {
                                //prints the indexs of words which can be palindrome pairs
                                Console.Write("[" + i + "," + j + "]");
                            }
                        }
                    }
                }
                
            }
            //If any exception below code will be executed.
            catch
            {
                //Prints exception message,If any expections are caught during program execution.
                Console.WriteLine("Exception occured while computing     PalindromePairs()");
            }
        }
        /*
         * This program assumes that both players are smart enough
         * The logic behind this program is the first person always fails If the given no of stones are multiples of 4
         * If no of stones are not multiples of 4, first person will make a move as 4 multiples of stones will be left over to second person
         */

        public static void Stones(int n4)
        {
            try
            {
                //prints new line and 6th program in output
                Console.WriteLine();
                Console.WriteLine("****************************  6th program  *****************************");

                //Declaring the list variable out
                List<int> output = new List<int>(); 
                int player; //Declaring an integer variable named player

                //Checks if the input value is less than 4 or not
                if (n4 < 4 || n4 % 4 == 0) 
                {
                    //Prints False in output which means first player wins
                    Console.WriteLine("FALSE");
                }

                else
                {
                    //adds remainder to array as first player first pick out of the stones 
                    output.Add(n4 % 4);        
                    Console.WriteLine("Player 1:" + (n4 % 4));
                    // assigns the 2 to player variable
                    player = 2;

                    //Checks if the sum of the values in the array is not equal to 4.
                    while (output.Sum() != n4) 
                    {
                        
                        Console.Write("Player " + player + ":");
                        //Converts the input to integer value
                        int input = Convert.ToInt32(Console.ReadLine());

                        //Check if the input value doesn't fall in range (0,3) and if it exceeds the stone limit while adding input to already picked stones
                        if (input < 0 || input > 3 || (output.Sum()+ input) > n4 )
                        {
                            Console.WriteLine("Try again as you picked wrong no of stones");
                        }
                        else
                        {
                            //Adds the input value to output array
                            output.Add(input);
                            //Switches between players
                            player = (player == 1 ? 2 : 1); 
                        }
                    }
                    //Prints all the picks by players
                    Console.WriteLine("[" + String.Join(", ", output) + "]");  
                }
            }
            catch
            {
                //Prints exception message,If any expections are caught during program execution.
                Console.WriteLine("Exception occurred while computing Stones()");
            }

        }
    }
}
