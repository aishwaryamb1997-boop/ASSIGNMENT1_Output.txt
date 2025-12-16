using System;
using System.IO;  // Needed for File and Directory operations

namespace FileWriteReadDemo
{
    class Program
    {
        static void Main()
        {
            try
            {
                // Step 1: Define the folder path and file name
                string folderPath = Path.Combine(
                    Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments),
                    "MyFiles"); // Custom folder inside Documents

                string filePath = Path.Combine(folderPath, "output.txt");

                // Step 2: Check if folder exists, else create it
                if (!Directory.Exists(folderPath))
                {
                    Directory.CreateDirectory(folderPath);
                    Console.WriteLine($"📁 Created new folder: {folderPath}");
                }

                Console.WriteLine("Enter multiple lines of text (type 'STOP' to finish):");

                // Step 3: Write user input into the file
                using (StreamWriter writer = new StreamWriter(filePath))
                {
                    while (true)
                    {
                        string inputLine = Console.ReadLine();

                        if (inputLine.ToUpper() == "STOP")
                            break;

                        writer.WriteLine(inputLine);
                    }
                }

                Console.WriteLine($"\n✅ Text has been saved to: {filePath}\n");

                // Step 4: Read back and display file contents
                Console.WriteLine("Contents of the file:");
                using (StreamReader reader = new StreamReader(filePath))
                {
                    string fileContent = reader.ReadToEnd();
                    Console.WriteLine("---------------------------------");
                    Console.WriteLine(fileContent);
                    Console.WriteLine("---------------------------------");
                }
            }
            catch (IOException ioEx)
            {
                Console.WriteLine("⚠️ File error: " + ioEx.Message);
            }
            catch (Exception ex)
            {
                Console.WriteLine("⚠️ Unexpected error: " + ex.Message);
            }

            Console.WriteLine("\nProgram ended. Press any key to exit.");
            Console.ReadKey();
        }
    }
}
