using System;
using System.Collections.Generic;
using System.Text;

namespace EventDelegationDemo
{

    //Multicast Delegate
    public delegate void GreetMessage(string msg);

    //UniCast Delegate
    public delegate int Calculation(int num1, int num2);

    class Hindi
    {
        public void WelcomeMessage(string userName)
        {
            Console.WriteLine("शुभ प्रभात: " + userName);
        }

    }


    class Tamil
    {
        public void WelcomeMessage(string userName)
        {
            Console.WriteLine("காலை வணக்கம்: (Tamil) " + userName);
        }

    }


    class Telugu
    {
        public void WelcomeMessage(string userName)
        {
            Console.WriteLine("శుభోదయం: (Telugu) " + userName);
        }

    }

    class Marathi
    {
        public void WelcomeMessage(string userName)
        {
            Console.WriteLine("शुभ प्रभात: " + userName);
        }
    }


    public class DelegateDemo
    {
        public static void DelegateDemoMain()
        {
            
            Tamil tm = new Tamil();
            GreetMessage GreetInTamil = new GreetMessage(tm.WelcomeMessage);

            GreetInTamil("Parth");

        }
    }
}
