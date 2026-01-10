using System;
using System.Collections.Generic;
using System.Text;
using System.Transactions;

namespace EventDelegationDemo
{

    interface IBank
    {

        bool OpenAct(string details);
        List<String> GenStatement();

    }

    interface iRBI
    {



    }

    class Axis : IBank
    {
        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAct(string details)
        {
            throw new NotImplementedException();
        }
    }

    class HDFC : IBank
    {

        public delegate void Transaction(int actNo, string date, int amount);

        public event Transaction Debit;
        public event Transaction Credit;

        public List<string> GenStatement()
        {
            throw new NotImplementedException();
        }

        public bool OpenAct(string details)
        {
            throw new NotImplementedException();
        }
    }


    class HDFCJalandhar: HDFC
    {

    }



    internal class EventDemo
    {

        public static void EventDemoMain()
        {
            HDFCJalandhar hDFCJalandhar = new HDFCJalandhar();
            hDFCJalandhar.Credit += HDFCJalandhar_Credit;
        }

        private static void HDFCJalandhar_Credit(int actNo, string date, int amount)
        {
            throw new NotImplementedException();
        }
    }
}
