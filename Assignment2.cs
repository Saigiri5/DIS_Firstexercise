using System;
using System.Collections.Generic;
using System.Linq;


namespace Assignment2_CT_Spring2020
{
    class Program
    {
        private const int V = 1;

        static void Main(string[] args)
        {
            Console.WriteLine("Question 1");
            int[] l1 = new int[] { 5, 6, 6, 9, 9, 12 }; int target = 9;
            int[] r = TargetRange(l1, target);
            Console.WriteLine("[{0}]", string.Join(",", r));

            Console.WriteLine("Question 2");
            string s = "University of South Florida"; string rs = StringReverse(s); Console.WriteLine(rs);

            Console.WriteLine("Question 3");
            int[] l2 = new int[] { 2, 2, 3, 5, 6 }; int sum = MinimumSum(l2); Console.WriteLine(sum);

            Console.WriteLine("Question 4"); string s2 = "Ddell";
            string sortedString = FreqSort(s2); Console.WriteLine(sortedString);

            Console.WriteLine("Question 5-Part 1");
            int[] nums1 = { 3, 6, 2 };
            int[] nums2 = { 6, 3, 6, 7, 3 };
            int[] intersect1 = Intersect1(nums1, nums2); Console.WriteLine("Part 1- Intersection of two arrays is: "); DisplayArray(intersect1);
            Console.WriteLine("\n");

            Console.WriteLine("Question 5-Part 2");
            int[] intersect2 = Intersect2(nums1, nums2); Console.WriteLine("Part 2- Intersection of two arrays is: "); DisplayArray(intersect2);
            Console.WriteLine("\n");

            Console.WriteLine("Question 6");
            char[] arr = new char[] { 'a', 'g', 'h', 'a' }; int k = 3; Console.WriteLine(ContainsDuplicate(arr, k));

            Console.WriteLine("Question 7");
            int rodLength = 5;
            int priceProduct = GoldRod(rodLength); Console.WriteLine(priceProduct);

            Console.WriteLine("Question 8");
            string[] userDict = new string[] { "rocky", "usf", "hello", "apple" }; string keyword = "ucf";

            Console.WriteLine(DictSearch(userDict, keyword));

            Console.WriteLine("Question 8"); SolvePuzzle();
        }
        public static void DisplayArray(int[] a)
        {
            foreach (int n in a)
            {
                Console.Write(n + " ");
            }
        }
        public static int[] TargetRange(int[] l1, int t)
        {
            try
            {
                //Intialising the variables 
                int i, j;
                List<int> output = new List<int>();
                //for loop to traverse through elements of given array to find target element indexes
                for (i = 0, j = 0; i < l1.Length; i++)
                {
                    if (l1[i] == t)
                    {
                        //adding the indexes of target element to output list variable
                        output.Add(i);
                        j++;
                    }

                }
                //checking the condition if target element is not found
                if (output == null)
                {
                    //Adding -1,-1 to list 
                    output.Add(-1);
                    output.Add(-1);
                }
                //returning the list of indexes
                return output.ToArray();
            }
            //Below block will be executed if any exception occurs
            catch (Exception)
            {
                throw;
            }
        }

        public static string StringReverse(string s)
        {
            try
            {
                // Initialising a stack
                Stack<char> Strstack = new Stack<char>();

                // Add a space after String 's' 
                s = s + " ";

                // Output the String
                Console.Write("Reversed String: ");

                // Iteration from i=0 to i is less than length of the string
                for (int i = 0; i < s.Length; ++i)
                {
                    //Check if ith index of s is not ' ' (space)
                    if (s[i] != ' ')
                    {
                        // Pushing ith character of string to stack
                        Strstack.Push(s[i]);
                    }

                    // If there is a space then print the contents of the stack
                    else
                    {
                        // While stack 'st' has more than one character
                        while (Strstack.Count > 0)
                        {
                            // Popping the stack 'Strstack' --> print reverse order
                            Console.Write(Strstack.Pop());
                        }
                        // Print space after a reversed word
                        Console.Write(" ");
                    }
                }
            }
            //below block will be executed if any exception occurs
            catch (Exception)
            {
                throw;
            }

            return null;
        }
        
        public static int MinimumSum(int[] l2)
        {
            try
            {
                // Intialising a integer to store the length of the string
                int n = l2.Length;

                // Intialising two integers named sum and prev with zeroth element of the array.
                int sum = l2[0], prev = l2[0];

                // Iteration from i=1 to i is less than n
                for (int i = 1; i < n; i++)
                {
                    // Checking if the ith element of array is less than previous
                    if (l2[i] <= prev)
                    {
                        prev += 1;
                        sum += prev;
                    }

                    // Else Summing the elements of the array
                    else
                    {
                        sum += l2[i];
                        prev = l2[i];
                    }
                }

                return sum;
            }
            //below block will be executed if any exception occurs
            catch (Exception)
            {
                throw;
            }
        }
        public static string FreqSort(string s2)
        
        {
            try
            {
                //Intialising the fresort dictionary variable
                var fresort = new Dictionary<char, int>();
                //for each loop to traverse through characters of given string
                foreach (char t in s2)
                {
                    //If condition to check dictionary contains the key 
                    if (fresort.ContainsKey(t))
                    {
                        //If key is there incrementing the value 
                        fresort[t]++;
                    }
                    //If key is not there assigning 1 to the value.
                    else
                    {
                        fresort[t] = 1;
                    }
                }
                //intializing the output4 string variable 
                string output4 = "";
                //foreach loop to traverse through sorted dictionary
                foreach (KeyValuePair<char, int> pair in fresort.OrderByDescending(key => key.Value))
                {
                    //for loop to print the characters according to frequency
                    for (int j = 0; j < pair.Value; j++)
                    {
                        output4 += pair.Key;
                    }
                }
                return output4;
            }
            //below block will be executed if any exception occurs
            catch (Exception)
            {
                throw;
            }
            
        }
        //This method is to get common elements from two arrays with time complexity O(nlogn)
        public static int[] Intersect1(int[] nums1, int[] nums2)
        {
            try
            {
                //Intialising the all the variables
                int a = nums1.Length;
                int b = nums2.Length;
                int i = 0;
                int j = 0;
                //Sorting the both the arrays
                Array.Sort(nums1);
                Array.Sort(nums2);
                //Declaring the out1 list object to capture the intersection elements
                List<int> out1 = new List<int>();
                //while lopp to get the intersection elements of both arrays
                while (i < a && j < b)
                {
                    if(nums1[i] == nums2[j])
                    {
                        //adding the common element to out1 list variable
                        out1.Add(nums1[i]);
                        i++;
                        j++;
                    }
                    //if first array element is less than second array element the pointer will move to next element in first array
                    else if(nums1[i] < nums2[j])
                    {
                        i++;
                    }
                    //the pointer will move to next element in second array.
                    else
                    {
                        j++;
                    }
                }
                //returning the array of intersection elements
                return out1.ToArray();
            }
            //Below block will be executed if any exception occurs
            catch
            {
                throw;
            }
        }

        //This method to print the common elements of two arrays with time complexity of O(n)
        
        public static int[] Intersect2(int[] nums1, int[] nums2)
        {
            try
            {
                //getting the lengths of arrays
                int a = nums1.Length;
                int b = nums2.Length;
                //adding the arrays
                List<int> result = new List<int>();
                //intialising the new dictionary variable
                Dictionary<int, int> dict = new Dictionary<int, int>();
                //for loop to traverse through first array
               foreach (int value in nums1)
               {
                //condition to check dictinary contains the first array element or not
                if (dict.ContainsKey(value))
                    {
                        //Incrementing the value if it contains key
                        dict[value]++;
                    }
                else
                    {
                        dict[value] = 1;
                    }
                }
               //for loop to traverse through second array elements
                for (int i = 0; i < b; i++)
                {
                    //intialising the count variable to 0
                    int count = 0;
                    //condition to check dictionary contains second array element or not
                    if (dict.ContainsKey(nums2[i]))
                    {
                        //assiging the value of array element to count variable
                        count = dict[nums2[i]];
                        //condition to check count greater than 1 or not
                        if(count > 1)
                        {
                            //adding the common element to result list variable
                            result.Add(nums2[i]);
                            dict[nums2[i]] = count - 1;
                        }
                        //Checking the value of key, if it is 1 adding that key element to list and removing it from list
                        else if (count == 1)
                        {
                            result.Add(nums2[i]);
                            dict.Remove(nums2[i]);
                        }
                    }
                }
                //returing the common elements array
                return result.ToArray();
            }

            //below block will be executed if any exception occurs
            catch
            {
                throw;
            }

        }
        public static bool ContainsDuplicate(char[] arr, int k)
        {
            try
            {
                // Intialising a dictionary
                Dictionary<char, int> dic = new Dictionary<char, int>();

                // Iteration from i=0 to i is less than count of the array
                for (int i = 0; i < arr.Length; i++)
                {
                    // Checking if the dictionary contains the value of arr[i]
                    if (dic.ContainsKey(arr[i]))

                    {
                        // Checking if the difference is atmost k
                        if (i - dic[arr[i]] <= k)
                        {

                            return true;
                        }
                    }
                    // if not, then assigning the key
                    else
                    {

                        dic[arr[i]] = i;
                    }
                    
                }
                    return false;
                
            }

            //below block will be executed if any exception occurs
            catch (Exception)
            {
                throw;
            }
           
        }
        public static int GoldRod(int rodLength)
        {
            try
            {
                // Checking the length of the rod
                if (rodLength == 2)

                    return 1;

                else if (rodLength == 3)

                    return 2;

                else if (rodLength == 4)

                    return 4;

                else if (rodLength == 5)

                    return 6;

                else if (rodLength == 6)

                    return 9;

                // If not, subtracting 3 from the length of the rod and calling the method again.
                else

                    return 3 * GoldRod(rodLength - 3);
            }

            //below block will be executed if any exception occurs
            catch (Exception)

            {
                throw;
            }

        }

        public static bool DictSearch(string[] userDict, string keyword)
        {
            try
            {
                //Intializing the count variable to 0
                int count = 0;
                //converting the string keyword to character array
                char[] arr1 = keyword.ToCharArray();
                //assigning the length of keyword to len variable
                int len = arr1.Length;
                //for each loop to traverse through userdict
                foreach (string value in userDict)
                {
                    //converting the each word of userdict to character array
                    char[] arr = value.ToCharArray();
                    //assigning the length of each word to len1 variable
                    int len1 = arr.Length;
                    count = 0;
                    // Checking the condition if lengths are equal 
                    if (len == len1)
                    {
                     //for loop to traverse through characters of array   
                        for (int i = 0; i < len; i++)
                        {
                            //condition to check if characters are not equal
                            if (arr[i] != arr1[i])
                            {
                                //If characters are not equal incrementing the count variable
                                count += 1;
                            }
                        }
                    }
                    //checking the condition if count is equal to 1
                    if (count==1)
                    {
                        //breaking the loop
                        break;   
                    }
                }
                //checking the condition if count is equal or not to 1 and returning true or false as output
                    if (count == 1)
                    {
                        return true;
                    }
                    else
                    {
                        return false;
                    }           
            }
            //Below block catches the exceptions if any
            catch (Exception)
            {
                throw;
            }

        }
        /* step1: Getting all the distinct characters of three strings into one array
           step2: sort the distinct character array
           step3: generate the combinations by taking 10^length of array
           step4: Adding the character as keys and combination values as values to dictionary
           step5: adding the values of key characters which belong to first two strings.
           And divide that value by 10 take the coefficient as carry and remainder as thrid string character value.
           step6: Check the third string charater value in dictionary if it exists in dictionary , compare with remainder value.
           If it is equal, repeat the step5 by pointing to next characters towards left of both the strings.
           Step7: print all the valids combination values 
           */
        
        public static void SolvePuzzle()
        {
            try
            {
                string first_word = Console.ReadLine();
                string second_word = Console.ReadLine();
                string result_word = Console.ReadLine();
                char[] arr1 = new char[10];
                int len1 = arr1.Length;
                char[] arr2 = new char[10];
                int len2 = arr2.Length;
                char[] arr3 = new char[10];
                int len3 = arr3.Length;
                arr1 = first_word.ToArray();
                arr2 = second_word.ToArray();
                arr3 = result_word.ToArray();
                var result = arr1.Union(arr2);
                result = result.Union(arr3);
                char [] arr4 = result.ToArray();
                Array.Sort(arr4);
                int len = arr4.Length;
                char[] arr5 = new char[len];
                Dictionary<char, char> dict = new Dictionary<char, char>();
                string s2;
                for (int i = 0; i < Math.Pow(10,len); i++)
                {
                    string s1 = Convert.ToString(i);
                    s2 = s1.PadLeft(len,'0');
                    arr5 = s2.ToCharArray();
                    for (int j = 0; j<len;j++)
                    {
                        dict[arr4[j]] = arr5[j];
                    }
                }
                foreach (KeyValuePair<char,char> value in dict)
                {
                    Console.WriteLine(value.Value);
                }
                
            }
            catch (Exception)
            {
                throw;
            }

        }
    }
}
//Write Your Code Here
//Write Your Code Here