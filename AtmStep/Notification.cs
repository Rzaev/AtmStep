using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmStep
{
    abstract class Notification
    {
        public string Text { get; set; }
        public int Id { get; set; }
        public DateTime Time { get; set; }
        public static int Notf_Id { get; set; } = 0;
        public Notification()
        {
            Id = ++Notf_Id;
        }
        public abstract void Print();

    }

    class ShowBalanceNotf : Notification
    {

        public override void Print()
        {
            Console.WriteLine("Notf Info");
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Text:" + Text);
            Console.WriteLine("Operation Time:" + Time);
        }
    }


    class CashNotf : Notification
    {

        public override void Print()
        {
            Console.WriteLine("Notf Info");
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Text:" + Text);
            Console.WriteLine("Operation Time:" + Time);
        }
    }

    class CardtoCardNotf : Notification
    {

        public override void Print()
        {
            Console.WriteLine("Notf Info");
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Text:" + Text);
            Console.WriteLine("Operation Time:" + Time);
        }
    }




}

