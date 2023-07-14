using System.Runtime.CompilerServices;

namespace Palindromes
{
    public class Program
    {
        static void Main(string[] args)
        {
            new Program().Start(args);
            //new Program().Start(new string[] { "WordsFile.txt", "ResultFile.txt" });
        }


        /// <summary>
        ///     Start to detect Palindrome
        /// </summary>
        /// <param name="args">input parameters, two parameters, one is source file and another is output file</param>
        private void Start(string[] args)
        {
            if(args.Length > 1)
            {
                try
                {
                    string input = args[0];
                    if (string.IsNullOrEmpty(input))
                    {
                        throw new Exception("The Input File is null and system aborted");
                    }
                    if (File.Exists(input))
                    {
                        StreamReader reader = new StreamReader(args[0]);

                        string output = args[1];

                        if (string.IsNullOrEmpty(output))
                        {
                            throw new Exception("The Output File is null and system aborted");
                        }
                        else
                        {
                            // check if the output file exists
                            if (File.Exists(args[1]))
                            {
                                Console.WriteLine("The Output File exists, replace it [y/n]?");
                                string? result = Console.ReadLine();
                                if ((result?.ToLower() != "y"))
                                {
                                    // throw exception if the user won't replace the existing result file
                                    throw new Exception("The Output File exists and system aborted");
                                }
                            }
                            StreamWriter writer = new StreamWriter(args[1]);

                            string? line = "";
                            while ((line = reader.ReadLine()) != null)
                            {
                                PalindromesCheck palindromesCheck = new PalindromesCheck(line);
                                // detect Palindrome
                                if (palindromesCheck.IsValidate())
                                {
                                    writer.WriteLine(line);
                                    //Console.WriteLine(palindromesCheck.InputString + " is Palindromes");
                                }
                                //else
                                //{
                                //    Console.WriteLine(palindromesCheck.InputString + " is not Palindromes");
                                //}
                            }

                            // release resources
                            writer.Flush();
                            reader.Close();
                            writer.Close();
                            Console.WriteLine("The Output File has been generated in " + ((FileStream)(writer.BaseStream)).Name);
                        }
                    }
                    else
                    {
                        throw new Exception("The Source File does not exist and system aborted");
                    }
                    
                } 
                catch(Exception e)
                {
                    Console.WriteLine(e.Message);
                }

            } 
            else
            {
                PrintHelp();
            }
        }
        /// <summary>
        ///     Print the usage of the program
        /// </summary>
        private void PrintHelp()
        {
            Console.WriteLine("Usage");
            Console.WriteLine("Palindromes {WordsFile} {ResultFile}");
            Console.WriteLine("Parameter:");
            Console.WriteLine("{WordsFile} : source file");
            Console.WriteLine("{ResultFile} : result file");
        }
    }
}