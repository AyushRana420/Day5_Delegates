using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Demo_Delegates
{
    //Create a delegate type
    public delegate void NotifyUser(string message);
    internal class Notifer
    {
        public void SendEmail(string message)
        {
            Console.WriteLine($"Email sent with message: {message}");
        }
        
        public void SendSMS(string message)
        {
            Console.WriteLine($"SMS sent with message: {message}");
        }
    }
}
