using System;

namespace cSharpFun
{
    public class Program
    {
        //start
        public static void Main(string[] args)
        {
            PrintStuff ps = new PrintStuff("PT"); //declaration
            Console.Write("Please enter your name: ");
            string userName = Console.ReadLine();

            

            ps.PrintName(userName);
            
        }

       

    }
}
