using System;
using System.IO;

namespace DocumentApplication
{
    class Document
    {
        static void Main(string[] args)
        {
            try
            {
                Console.WriteLine("Document");
                Console.WriteLine("");
                Console.WriteLine("Document Name:");

                string DocFile = Console.ReadLine();

                Console.WriteLine("Document Content:");

                string character = Console.ReadLine();
                string filename = DocFile + ".txt";
                string savedata = Environment.CurrentDirectory  + filename;
                if (!File.Exists(savedata))

                {

                    File.WriteAllText(savedata, character);

                }

                Console.WriteLine(filename + " was successfully saved. The document contains " + character.Length + " characters");
                Console.ReadKey();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);

            }

        }

    }

}