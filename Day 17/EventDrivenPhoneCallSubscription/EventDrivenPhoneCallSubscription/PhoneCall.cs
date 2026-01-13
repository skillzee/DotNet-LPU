using System;
using System.Collections.Generic;
using System.Text;

namespace EventDrivenPhoneCallSubscription
{

    public delegate void Notify();
    public class PhoneCall
    {
        public string? Message { get; private set;  }
        public event Notify PhoneCallevent;
        

        private void OnSubscribe()
        {
            Message = "Subscribed to call";
        }

        private void OnUnsubscribe()
        {
            Message = "UnSubscribed to call";
        }

        public void MakeAPhoneCall(bool notify)
        {
            //Console.WriteLine("Make a phone Call Called");
            if (notify)
            {
                PhoneCallevent = OnSubscribe;
            }
            else
            {
                PhoneCallevent = OnUnsubscribe;
            }

            PhoneCallevent();

        }

        public void DisplayMessage()
        {
            //Console.WriteLine("Display MEssage CAlled");
            Console.WriteLine(Message);
        }
    }

    
}
