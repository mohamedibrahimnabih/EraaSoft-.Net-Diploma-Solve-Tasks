namespace CSD02_Operations_List
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string selectedChar = "";
            List<int> nums = new List<int>();

            do
            {
                Console.WriteLine("\n---------------------");
                Console.WriteLine("P - Print numbers");
                Console.WriteLine("A - Add a number");
                Console.WriteLine("M - Display mean of the numbers");
                Console.WriteLine("S - Display the smallest number");
                Console.WriteLine("L - Display the largest number");
                Console.WriteLine("F - Search By Number To Find Index");
                Console.WriteLine("C - To Clear A List");
                Console.WriteLine("Q - Quit");
                Console.WriteLine("\n---------------------");
                Console.Write("Enter your selection: ");

                selectedChar = Console.ReadLine();

                switch (selectedChar)
                {
                    // To Print List
                    case "p":
                    case "P":
                        if (nums.Count == 0)
                            Console.WriteLine("[] - the list is empty");
                        else
                        {
                            Console.Write("[ ");
                            for (int i = 0; i < nums.Count; i++)
                            {
                                Console.Write($"{nums[i]} ");
                            }
                            Console.Write("]");
                        }
                        break;

                    // Add Number To List
                    case "a":
                    case "A":
                        Console.Write("Please Enter A Number To Add In List: ");
                        int newNum = int.Parse(Console.ReadLine());
                        nums.Add(newNum);
                        Console.WriteLine($"{newNum} Added");
                        break;

                    // To Calculate The Average (Mean) Of List
                    case "m":
                    case "M":
                        if (nums.Count == 0)
                            Console.WriteLine("Unable to calculate the mean - no data");
                        else
                        {
                            double average = 0;
                            for (int i = 0; i < nums.Count; i++)
                            {
                                average += nums[i];
                            }
                            average /= nums.Count;
                            Console.WriteLine($"The Average Of List's Numbers Is : {average}");
                        }
                        break;

                    // To Find The Minimum Value 
                    case "s":
                    case "S":
                        if (nums.Count == 0)
                            Console.WriteLine("Unable to calculate the minimum - no data");
                        else
                        {
                            int min = nums[0];
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] < min)
                                    min = nums[i];
                            }
                            Console.WriteLine($"The Minimum Value In List Is: {min}");
                        }
                        break;

                    // To Find The Maximum Value 
                    case "l":
                    case "L":
                        if (nums.Count == 0)
                            Console.WriteLine("Unable to calculate the maximum - no data");
                        else
                        {
                            int max = nums[0];
                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (nums[i] > max)
                                    max = nums[i];
                            }
                            Console.WriteLine($"The Maximum Value In List Is: {max}");
                        }
                        break;

                    // Search By Number To Find Index
                    case "f":
                    case "F":
                        if (nums.Count == 0)
                            Console.WriteLine("Unable to find index - no data");
                        else
                        {
                            Console.Write("Please Enter A Number To Search On It: ");
                            int neededNum = int.Parse(Console.ReadLine());
                            int index = -1;

                            for (int i = 0; i < nums.Count; i++)
                            {
                                if (neededNum == nums[i])
                                {
                                    index = i;
                                    break;
                                }
                            }
                            if (index == -1)
                                Console.WriteLine($"The Needed Number Doesn't Exist");
                            else
                                Console.WriteLine($"The Index Of Needed Number IS : \"{index}\"");
                        }
                        break;

                    // Clear The List
                    case "c":
                    case "C":
                        Console.WriteLine("Are You Sure You Want To Clear All Elements Of List [Y - N]");
                        Console.WriteLine("Press Y To Clear");
                        Console.WriteLine("Press N To Quit This Option");

                        char ch = char.ToUpper(char.Parse(Console.ReadLine()));

                        if (ch == 'Y')
                        {
                            nums.Clear();
                            Console.WriteLine("[] - the list is empty");
                        }
                        break;

                    // Quit From List
                    case "q":
                    case "Q":
                        Console.WriteLine("Goodbye...");
                        break;

                    default:
                        Console.WriteLine("Unknown selection, please try again");
                        break;
                }
            } while (selectedChar != "q" && selectedChar != "Q");
        }
    }
}
