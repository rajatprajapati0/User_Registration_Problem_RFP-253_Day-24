using System;
namespace User_RegistrationByLambda 
{
  public class Program
  {
        public static void Main(string[] args) 
        { 

            Console.WriteLine(" welcome User_Registration Program");
         
            Fillinfo fillinfo = new Fillinfo();
            fillinfo.fill();
        
        }
  }

}