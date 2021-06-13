using System;

namespace lab3
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            Atom atom = new Atom();
            while (true)
            {
                atom.Accept();
                Console.WriteLine("Chon 1 tiep tuc chon 2 de dung");
                int choice = int.Parse(Console.ReadLine());
                if (choice != 1)
                {
                    break;
                }
            }
            atom.Display();
        }
    }
}