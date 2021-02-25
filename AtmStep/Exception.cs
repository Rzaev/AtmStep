using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AtmStep
{
    class WrongPinLengthException : ApplicationException
    {
        public WrongPinLengthException(string message, DateTime timeException,
            int errorLine, string source)
        {
            Message = message;
            TimeException = timeException;
            ErrorLine = errorLine;
            Source = source;
        }

        public string Message { get; set; }
        public DateTime TimeException { get; set; }
        public int ErrorLine { get; set; }
        public string Source { get; set; }

        public void Show()
        {
            Console.WriteLine(Message);
            Console.WriteLine(TimeException);
            Console.WriteLine("Error Line:" + ErrorLine);
            Console.WriteLine("Source" + Source);
        }
    }

    class NegativeBalanceException : ApplicationException
    {
        public NegativeBalanceException(string message, DateTime timeException,
            int errorLine, string source)
        {
            Message = message;
            TimeException = timeException;
            ErrorLine = errorLine;
            Source = source;
        }

        public string Message { get; set; }
        public DateTime TimeException { get; set; }
        public int ErrorLine { get; set; }
        public string Source { get; set; }

        public void Show()
        {
            Console.WriteLine(Message);
            Console.WriteLine(TimeException);
            Console.WriteLine("Error Line:" + ErrorLine);
            Console.WriteLine("Source" + Source);
        }
    }


    class NotNumberException : ApplicationException
    {
        public NotNumberException(string message, DateTime timeException,
            int errorLine, string source)
        {
            Message = message;
            TimeException = timeException;
            ErrorLine = errorLine;
            Source = source;
        }

        public string Message { get; set; }
        public DateTime TimeException { get; set; }
        public int ErrorLine { get; set; }
        public string Source { get; set; }

        public void Show()
        {
            Console.WriteLine(Message);
            Console.WriteLine(TimeException);
            Console.WriteLine("Error Line:" + ErrorLine);
            Console.WriteLine("Source" + Source);
        }
    }



}






