using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegates
{
    public delegate void GreetUser(string name);
    internal class Program
    {
        static void Main(string[] args)
        {
            Greetings newGreetings = new Greetings();
            GreetUser greetDelegate;
            // Assigning the method Greet to the delegate
            newGreetings.Greet("Alice");
            // Assigning the method Greet to the delegate
            greetDelegate = newGreetings.Greet;
            greetDelegate("Bob");
            // Assigning the method Farewell to the delegate
            greetDelegate += newGreetings.Farewell;
            greetDelegate("Charlie");

            Console.WriteLine("Args based on multicasting delegate");
            Notifer notifier = new Notifer();
            NotifyUser notifyDelegate;
            // Assigning the method SendEmail to the delegate
            notifyDelegate = notifier.SendEmail;
            notifyDelegate("Welcome to the system!");
            // Assigning the method SendSMS to the delegate
            notifyDelegate += notifier.SendSMS;
            notifyDelegate("Your verification code is 123456");
        }
    }

    public class Greetings
    {
        public void Greet(string name)
        {
            Console.WriteLine($"Hello, {name}!");
        }
        public void Farewell(string name)
        {
            Console.WriteLine($"Goodbye, {name}!");
        }
    }
}
