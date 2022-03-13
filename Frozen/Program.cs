using System;
using System.Collections.Generic;
using System.IO;

namespace Frozen
{
    internal class Program
    {
        class SecretSanta
        {
            string name;
            string gift;

            public SecretSanta(string _name, string _gift)
            {
                name = _name;
                gift = _gift;
            }

            //getters for names and gifts
            public string Name
            {
                get { return name; }
            }

            public string Gift
            {
                get { return gift; }
            }
        }

        static void Main(string[] args)
        {
            // Anna wants new earrings for Christmas

            List<SecretSanta> gifts = new List<SecretSanta>();
            string[] giftsFromFile = GetDataFromFile();

            foreach (string line in giftsFromFile)
            {
                string[] tempArray = line.Split(new char[] { '/' }, StringSplitOptions.RemoveEmptyEntries);
                SecretSanta newGift = new SecretSanta(tempArray[0], tempArray[1]);
                gifts.Add(newGift);
            }

            Console.WriteLine("Wishes for christmas:");
            Console.WriteLine();

            foreach (SecretSanta giftsFromList in gifts)
            {
                Console.WriteLine($"{giftsFromList.Name} wants {giftsFromList.Gift}.");
            }
        }

        public static string[] GetDataFromFile()
        {
            string filePath = @"C:\Users\...\Samples\frozen.txt";
            string[] dataFromFile = File.ReadAllLines(filePath);

            return dataFromFile;
        }
    }
}
