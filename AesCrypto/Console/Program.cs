
﻿namespace Console
{
    class Program
    {
        static void Main(string[] args)
        {
            string data = System.Console.ReadLine();
            string encrypted = data.Encrypt();
            System.Console.WriteLine("Encrypted: " + encrypted);
            System.Console.WriteLine("Decrypted: " + encrypted.Decrypt());
            System.Console.ReadKey();
        }
    }
}