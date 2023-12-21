using System;
using System.ComponentModel.Design;
using System.Linq;

class Program
{
    static void Main(string[] args)
    {
        string ord = Console.ReadLine().ToLower();

        int countk = 0;
        char tocount = 'k';
        foreach (char c in ord.ToCharArray())
        {
            if (c == tocount)
            {
                countk++;
            }
        }
        

        int countb = 0;
        char tofind = 'b';
        foreach (char d in ord.ToCharArray()) 
        { 
            if (d == tofind) 
            {
                countb++;
            }
        }
        
        if (countb > countk)
        {
            Console.WriteLine("Boba");
        }
        else if (countb < countk)
        {
            Console.WriteLine("Kiki");
        }

        else if (countb == 0 && countk == 0)
        {
            Console.WriteLine("None");
        }

        else if (countb == countk)
        {
            Console.WriteLine("Boki");
        }



    }
}