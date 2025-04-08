using System;
using System.IO;

namespace File_Handling
{
    class Program
    {
        static void Main(string[] args)
        {
            int choice;

            // Show menu until user chooses to exit
            do
            {
                Console.WriteLine("\n========== File Operations Menu ==========");
                Console.WriteLine("1. Text File: Read, Write, Append");
                Console.WriteLine("2. Binary File: Read and Write");
                Console.WriteLine("3. Exit");
                Console.Write("Enter your choice (1-3): ");
                choice = Convert.ToInt32(Console.ReadLine());

                switch (choice)
                {
                    case 1:
                        TextFileOperations(); // Call method for text file
                        break;
                    case 2:
                        BinaryFileOperations(); // Call method for binary file
                        break;
                    case 3:
                        Console.WriteLine("Exiting program.");
                        break;
                    default:
                        Console.WriteLine("Invalid choice. Try again.");
                        break;
                }

            } while (choice != 3); // Repeat until Exit
        }

        // ------------------ Method 1: TEXT FILE ------------------
        static void TextFileOperations()
        {
            string filePath = "D:\\.net\\File_Handling\\Janardhan.txt";

            // 1. Writing (overwrites if file exists)
            if (!File.Exists(filePath))
            {
                // If file does NOT exist, create it and write initial content
                File.WriteAllText(filePath, "Hello, this is the first line.\n");
                Console.WriteLine("File created and initial content written.");
            }
            else
            {
                // If file exists, append new content
                File.AppendAllText(filePath, "This line was appended later.\n");
                Console.WriteLine("File exists. Appended new content.");
            }

            //// 3. Reading the file
            string content = File.ReadAllText(filePath);

            Console.WriteLine("\n[Text File Content]");
            Console.WriteLine(content);
        }

        // ------------------ Method 2: BINARY FILE ------------------
        static void BinaryFileOperations()
        {
            string filePath = "D:\\.net\\File_Handling\\Janardhan.dat";

            // 1. Writing binary data to file
            using (BinaryWriter writer = new BinaryWriter(File.Open(filePath, FileMode.Create)))
            {
                writer.Write("Janardhan"); // write string
                writer.Write(21);          // write integer
            }

            // 2. Reading binary data from file
            using (BinaryReader reader = new BinaryReader(File.Open(filePath, FileMode.Open)))
            {
                string name = reader.ReadString();  // read string
                int age = reader.ReadInt32();       // read integer

                Console.WriteLine("\n[Binary File Content]");
                Console.WriteLine($"Name: {name}");
                Console.WriteLine($"Age: {age}");
            }
        }
    }
}
