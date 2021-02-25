using System;
using System.Collections.Generic;
using System.Data;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;






//class Client
//{
//    public int Id { get; set; }
//    public string Name { get; set; }
//    public string Surname { get; set; }
//    public int Age { get; set; }
//    public int Salary { get; set; }
//    public static int Client_Id { get; set; } = 0;
//    public Bankcard[] Bankcards { get; set; }
//    public int Bankcard_Count { get; set; }


//    public void createBankCard(ref Bankcard bankcard)
//    {
//        Bankcard[] temp = new Bankcard[++Bankcard_Count];
//        if (Bankcards != null)
//        {
//            Bankcards.CopyTo(temp, 0);
//        }
//        temp[temp.Length - 1] = bankcard;
//        Bankcards = temp;
//    }

//    public Client()
//    {
//        Id = ++Client_Id;
//    }

//    public void Show()
//    {
//        Console.WriteLine("ID:" + Id);
//        Console.WriteLine("Name:" + Name);
//        Console.WriteLine("Surname:" + Surname);
//        Console.WriteLine("Age:" + Age);
//        Console.WriteLine("Salary:" + Salary);
//    }

//}


//class Bankcard
//{
//    public string Bankname { get; set; }
//    public string Username { get; set; }
//    public StringBuilder Pan { get; set; } = CreatePan();
//    public string Pin { get; set; }
//    public string Cvc { get; set; } = CreatePin();
//    public DateTime ExpiredYear { get; set; } = CreateExpired();
//    public double Balance { get; set; } = CreateBalance();


//    public static StringBuilder CreatePan()
//    {
//        Random random = new Random();
//        StringBuilder str = new StringBuilder();
//        for (int i = 0; i < 4; i++)
//        {
//            int value = random.Next(1000, 10000);
//            str.Append(string.Concat(value));
//        }
//        return str;
//    }

//    private static string CreatePin()
//    {
//        Random random = new Random();
//        int value = random.Next(100, 1000);
//        string str = value.ToString();
//        return str;
//    }

//    public static DateTime CreateExpired()
//    {
//        DateTime exp = DateTime.Now.AddYears(2);
//        return exp;
//    }

//    public static double CreateBalance()
//    {
//        Random random = new Random();
//        double value = (random.NextDouble() * (9999.99 - 0.99) + 0.99);
//        double b = Math.Round(value, 2, MidpointRounding.ToEven);
//        return b;
//    }

//    public void ShowBankCard()
//    {
//        Console.WriteLine("Bank Name:" + Bankname);
//        Console.WriteLine("Username:" + Username);
//        Console.WriteLine("Pan:" + Pan);
//        Console.WriteLine("Pin:" + Pin);
//        Console.WriteLine("CVC:" + Cvc);
//        Console.WriteLine("Expired Date:" + ExpiredYear.Month + "/" + ExpiredYear.Year);
//        Console.WriteLine("Balance:" + Balance);
//    }
//}


//class Bank
//{
//    public string BankName { get; set; }
//    public Client[] Clients { get; set; }
//    public int Client_Count { get; set; } = 0;

//    public void AddClient(ref Client client)
//    {
//        Client[] temp = new Client[++Client_Count];
//        if (Clients != null)
//        {
//            Clients.CopyTo(temp, 0);
//        }
//        temp[temp.Length - 1] = client;
//        Clients = temp;
//    }



//    public void showCard(/*StringBuilder Pan, string Pin*/)
//    {

//        Console.WriteLine("Input Pan");
//        //pan = Convert.ToString(Console.ReadLine());
//        //pan.Append(value);
//        StringBuilder pan = new StringBuilder();
//        string value = Console.ReadLine();
//        pan.Append(value);
//        // pan.Append(string.Concat(value));

//        Console.WriteLine("Input Pin");
//        string pin = Console.ReadLine();


//        Console.WriteLine("SHOW\n\n\n");
//        for (int i = 0; i < Client_Count; i++)
//        {
//            for (int j = 0; j < Clients[i].Bankcard_Count; j++)
//            {
//                Console.WriteLine("***Pan***" + Clients[i].Bankcards[j].Pan);
//                Console.WriteLine("*Pan" + pan);
//                if (pan.ToString() == Clients[i].Bankcards[j].Pan.ToString() &&
//                    pin == Clients[i].Bankcards[j].Pin)
//                {
//                    if (BankName == Clients[i].Bankcards[j].Bankname)
//                    {
//                        Clients[i].Bankcards[j].ShowBankCard();
//                        //break;
//                    }
//                    else
//                        Console.WriteLine("There is no card here");
//                }


//            }
//        }
//    }
//}

//class Helper
//{
//    // public Bankcard Bankcards { get; set; }
//    public static string GetUsername()
//    {
//        Console.WriteLine("Username:");
//        string user = Console.ReadLine();
//        return user;
//    }

//    public static string GetBankName()
//    {
//        string[] str = new string[] { "Kapital", "Beynelxalq", "Unibank" };
//        foreach (var item in str)
//        {
//            Console.WriteLine(item);
//        }
//        Console.WriteLine("Your choice:");
//        int ch = Convert.ToInt32(Console.ReadLine());
//        if (ch == 1)
//            return str[0];

//        else if (ch == 2)
//            return str[1];
//        else
//            return str[2];

//    }

//    public static string GetPin()
//    {
//        Random random = new Random();
//        int value = random.Next(1000, 10000);
//        string s = value.ToString();
//        return s;
//    }

//    public static string GetName()
//    {
//        Console.WriteLine("Input name:");
//        string name = Console.ReadLine();
//        return name;
//    }

//    public static string GetSurname()
//    {
//        Console.WriteLine("Input surname:");
//        string surname = Console.ReadLine();
//        return surname;
//    }

//    public static int GetAge()
//    {
//        Console.WriteLine("Input age");
//        int age = Convert.ToInt32(Console.ReadLine());
//        return age;
//    }

//    public static int GetSalary()
//    {
//        Console.WriteLine("Input salary");
//        int salary = Convert.ToInt32(Console.ReadLine());
//        return salary;
//    }




//}



//class Program
//{
//    static void Main(string[] args)
//    {
//        Console.WriteLine("Creating Bank");
//        Bank bank = new Bank
//        {
//            BankName = "Kapital"
//        };


//        Console.WriteLine("Creating Bank Card");
//        Bankcard bankcard1 = new Bankcard
//        {
//            Bankname = Helper.GetBankName(),
//            Username = Helper.GetUsername(),
//            Pin = Helper.GetPin()
//        };

//        Console.WriteLine("Pin:" + bankcard1.Pin);
//        Console.WriteLine("Pan:" + bankcard1.Pan);
//        Console.WriteLine("Creating another Bank Card");
//        Bankcard bankcard2 = new Bankcard
//        {
//            Bankname = Helper.GetBankName(),
//            Username = Helper.GetUsername(),
//            Pin = Helper.GetPin()
//        };
//        Console.WriteLine("Pin:" + bankcard2.Pin);
//        Console.WriteLine("Pan:" + bankcard2.Pan);
//        Console.WriteLine("Creating client");
//        Client client1 = new Client
//        {
//            Name = Helper.GetName(),
//            Surname = Helper.GetSurname(),
//            Age = Helper.GetAge(),
//            Salary = Helper.GetSalary()
//        };

//        client1.createBankCard(ref bankcard1);
//        client1.createBankCard(ref bankcard2);

//        bank.AddClient(ref client1);
//        bank.showCard();




//        Console.ReadLine();

//    }
//}










namespace AtmStep
{

    enum Operation
    {
        ShowBalance = 1, Cash, Notification, CardToCard, Exit
    };

    class Card
    {
        public StringBuilder Pan { get; set; } = CreatePan();
        public string Pin { get; set; }
        public string Cvc { get; set; } = CreatePin();
        public DateTime ExpiredYear { get; set; } = CreateExpired();
        public double Balance { get; set; } = CreateBalance();




        public static StringBuilder CreatePan()
        {
            Random random = new Random();
            StringBuilder str = new StringBuilder();
            for (int i = 0; i < 4; i++)
            {
                int value = random.Next(1000, 10000);
                str.Append(string.Concat(value));
            }
            return str;
        }

        private static string CreatePin()
        {
            Random random = new Random();
            int value = random.Next(100, 1000);
            string str = value.ToString();
            return str;
        }

        public static DateTime CreateExpired()
        {
            DateTime exp = DateTime.Now.AddYears(2);
            return exp;
        }

        public static double CreateBalance()
        {
            Random random = new Random();
            Thread.Sleep(100);
            double value = (random.NextDouble() * (9999.99 - 0.99) + 0.99);
            double b = Math.Round(value, 2, MidpointRounding.ToEven);
            return b;
        }

        public void ShowBankCard()
        {
            Console.WriteLine("Pan:" + Pan);
            Console.WriteLine("Pin:" + Pin);
            Console.WriteLine("CVC:" + Cvc);
            Console.WriteLine("Expired Date:" + ExpiredYear.Month + "/" + ExpiredYear.Year);
            Console.WriteLine("Balance:" + Balance);
        }
    }

    class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public static int User_Id { get; set; } = 0;
        public Card[] Cards { get; set; }
        public int Card_Count { get; set; }


        public void createBankCard(ref Card bankcard)
        {
            Card[] temp = new Card[++Card_Count];
            if (Cards != null)
            {
                Cards.CopyTo(temp, 0);
            }
            temp[temp.Length - 1] = bankcard;
            Cards = temp;
        }

        public User()
        {
            Id = ++User_Id;
        }


        public void Show()
        {
            Console.WriteLine("ID:" + Id);
            Console.WriteLine("Name:" + Name);
            Console.WriteLine("Surname:" + Surname);
        }
    }


    class Helper
    {


        Random random = new Random();
        public string GetPin()
        {
            int value = random.Next(1000, 10000);

            string s = value.ToString();
            return s;
        }

        public static string GetName()
        {
            Console.WriteLine("Input name:");
            string name = Console.ReadLine();
            if (!string.IsNullOrEmpty(name))
                return name;
            else
                return "!!!";
        }

        public static string GetSurname()
        {
            Console.WriteLine("Input surname:");
            string surname = Console.ReadLine();
            if (!string.IsNullOrEmpty(surname))
                return surname;
            else
                return "!!!";
        }

        public static int GetErrorLine()
        {
            StackTrace st = new StackTrace(0, true);
            StackFrame sf = new StackFrame();
            sf = st.GetFrame(0);
            int num = sf.GetFileLineNumber();
            return num;

        }

        public static string GetErrorSource()
        {
            StackTrace st = new StackTrace(0, true);
            StackFrame sf = new StackFrame();
            sf = st.GetFrame(0);
            string source = sf.GetFileName();
            return source;
        }

        public static System.Reflection.MethodBase GetErrorMethod()
        {
            StackTrace st = new StackTrace(0, true);
            StackFrame sf = new StackFrame();
            sf = st.GetFrame(0);
            System.Reflection.MethodBase metod = sf.GetMethod();
            return metod;
        }


        public void Start()
        {

            List<Notification> notifications = new List<Notification>();




            Card bankcard1 = new Card
            {
                Pin = GetPin()
            };

            Console.WriteLine(bankcard1.Pin);
            Card bankcard2 = new Card
            {
                Pin = GetPin()
            };
            Console.WriteLine(bankcard2.Pin);

            Card bankcard3 = new Card
            {
                Pin = GetPin()
            };
            Console.WriteLine(bankcard3.Pin);

            User user1 = new User
            {
                Name = Helper.GetName(),
                Surname = Helper.GetSurname(),
            };

            User user2 = new User
            {
                Name = Helper.GetName(),
                Surname = Helper.GetSurname(),
            };

            User user3 = new User
            {
                Name = Helper.GetName(),
                Surname = Helper.GetSurname(),
            };

            user1.createBankCard(ref bankcard1);
            user2.createBankCard(ref bankcard2);
            user3.createBankCard(ref bankcard3);

            const int user_count = 3;
            User[] users = new User[user_count] { user1, user2, user3 };

            Console.WriteLine(user1.Cards[0].Pin);
            Console.WriteLine(user2.Cards[0].Pin);
            Console.WriteLine(user3.Cards[0].Pin);


            int counter = 0;
            while (true)
            {
                Console.WriteLine("Input Pin");
                string pin = Console.ReadLine();
                try
                {
                    if (pin.Length != 4)
                        throw new WrongPinLengthException("Length of pin should be 4", DateTime.Now, 233, "Program.cs");
                    if (!int.TryParse(pin, out int number))
                    {
                        throw new NotNumberException("Pin should be integer type", DateTime.Now, 236, "Program.cs");
                    }

                }
                catch (WrongPinLengthException ex)
                {
                    ex.Show();
                }
                catch (NotNumberException ex)
                {
                    ex.Show();
                }
                for (int i = 0; i < user_count; i++)
                {
                    if (pin == users[i].Cards[0].Pin)
                    {
                        Console.WriteLine($"{users[i].Name} {users[i].Surname} Welcome!!");
                        while (true)
                        {

                            Console.WriteLine("1)Show Balance:" +
                            "2)Chasing money:" +
                            "3)Show Notification:" +
                            "4)Card to card:" +
                            "5)Exit"
                            );
                            int select = Convert.ToInt32(Console.ReadLine());
                            while (select <= 0 || select >= 6)
                            {
                                Console.WriteLine("Select again");
                                select = Convert.ToInt32(Console.ReadLine());
                            }
                            switch (select)
                            {
                                case (int)Operation.ShowBalance:
                                    {

                                        Console.WriteLine("Balance:" + users[i].Cards[0].Balance);
                                        notifications.Add(new ShowBalanceNotf
                                        {
                                            Text = $"{users[i].Name} look at balance",
                                            Time = DateTime.Now
                                        });


                                        break;
                                    }
                                case (int)Operation.Cash:
                                    {
                                        Console.WriteLine(@"                          1. 10 AZN
                                     2. 20 AZN
                                     3. 50 AZN
                                     4. 100 AZN
                                     5. Other ");
                                        int n = Convert.ToInt32(Console.ReadLine());
                                        while (n <= 0 || n >= 6)
                                        {
                                            Console.WriteLine("Select again");
                                            n = Convert.ToInt32(Console.ReadLine());
                                        }
                                        if (n == 1)
                                        {
                                            try
                                            {
                                                if (users[i].Cards[0].Balance - 10 < 0)
                                                {
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cant cash money",
                                                        Time = DateTime.Now
                                                    });
                                                    throw new NegativeBalanceException("Balance is not enought", DateTime.Now, 292, "Program.cs");
                                                }
                                                else
                                                {
                                                    users[i].Cards[0].Balance -= 10;
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cash 10$",
                                                        Time = DateTime.Now
                                                    });
                                                    Console.WriteLine(users[i].Cards[0].Balance);
                                                }

                                            }
                                            catch (NegativeBalanceException ex)
                                            {
                                                ex.Show();

                                            }


                                        }
                                        else if (n == 2)
                                        {
                                            try
                                            {
                                                if (users[i].Cards[0].Balance - 20 < 0)
                                                {
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cant cash money",
                                                        Time = DateTime.Now
                                                    });
                                                    throw new NegativeBalanceException("Balance is not enought", DateTime.Now, 312, "Program.cs");
                                                }
                                                else
                                                {
                                                    users[i].Cards[0].Balance -= 20;
                                                    Console.WriteLine(users[i].Cards[0].Balance);
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cash 20$",
                                                        Time = DateTime.Now
                                                    });
                                                }

                                            }
                                            catch (NegativeBalanceException ex)
                                            {
                                                ex.Show();

                                            }


                                        }
                                        else if (n == 3)
                                        {
                                            try
                                            {
                                                if (users[i].Cards[0].Balance - 50 < 0)
                                                {
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cant cash money",
                                                        Time = DateTime.Now
                                                    });
                                                    throw new NegativeBalanceException("Balance is not enought", DateTime.Now, 333, "Program.cs");
                                                }
                                                else
                                                {
                                                    users[i].Cards[0].Balance -= 50;
                                                    Console.WriteLine(users[i].Cards[0].Balance);
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cash 50$",
                                                        Time = DateTime.Now
                                                    });
                                                }

                                            }
                                            catch (NegativeBalanceException ex)
                                            {
                                                ex.Show();

                                            }


                                        }
                                        else if (n == 4)
                                        {
                                            try
                                            {
                                                if (users[i].Cards[0].Balance - 100 < 0)
                                                {
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cant cash money",
                                                        Time = DateTime.Now
                                                    });
                                                    throw new NegativeBalanceException("Balance is not enought", DateTime.Now, 354, "Program.cs");
                                                }
                                                else
                                                {
                                                    users[i].Cards[0].Balance -= 100;
                                                    Console.WriteLine(users[i].Cards[0].Balance);
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cash 100$",
                                                        Time = DateTime.Now
                                                    });
                                                }

                                            }
                                            catch (NegativeBalanceException ex)
                                            {
                                                ex.Show();

                                            }


                                        }
                                        else if (n == 5)
                                        {
                                            Console.WriteLine("Input amount:");
                                            int num = Convert.ToInt32(Console.ReadLine());
                                            try
                                            {
                                                if (users[i].Cards[0].Balance - num < 0)
                                                {
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cant cash money",
                                                        Time = DateTime.Now
                                                    });
                                                    throw new NegativeBalanceException("Balance is not enought", DateTime.Now, 377, "Program.cs");
                                                }
                                                else
                                                {
                                                    users[i].Cards[0].Balance -= num;
                                                    Console.WriteLine(users[i].Cards[0].Balance);
                                                    notifications.Add(new CashNotf
                                                    {
                                                        Text = $"{users[i].Name} cash {num}$",
                                                        Time = DateTime.Now
                                                    });
                                                }
                                            }
                                            catch (NegativeBalanceException ex)
                                            {
                                                ex.Show();
                                            }


                                        }

                                        break;
                                    }
                                case (int)Operation.Notification:
                                    {
                                        foreach (var notf in notifications)
                                        {
                                            notf.Print();
                                        }
                                        break;
                                    }
                                case (int)Operation.CardToCard:
                                    {
                                        int ctr = 0;
                                        Console.WriteLine("Input pin:");
                                        string pins = Console.ReadLine();
                                        try
                                        {
                                            if (pins.Length != 4)
                                                throw new WrongPinLengthException("Pin must be 4length", DateTime.Now, 408, "Program.cs");
                                            if (!int.TryParse(pins, out int number))
                                            {
                                                throw new NotNumberException("Pin should be integer type", DateTime.Now, 236, "Program.cs");
                                            }
                                            else
                                            {
                                                for (int j = 0; j < user_count; j++)
                                                {
                                                    ++ctr;
                                                    if (pins == users[j].Cards[0].Pin)
                                                    {
                                                        Console.WriteLine("Input amount:");
                                                        int amount = Convert.ToInt32(Console.ReadLine());
                                                        try
                                                        {
                                                            if (users[i].Cards[0].Balance - amount < 0)
                                                            {
                                                                notifications.Add(new CardtoCardNotf
                                                                {
                                                                    Text = $"{users[i].Name} cant send {amount}$ to {users[j].Name}",
                                                                    Time = DateTime.Now
                                                                });
                                                                throw new NegativeBalanceException("Balance is not enought", DateTime.Now, 421, "Program.cs");
                                                            }
                                                            else
                                                            {
                                                                users[j].Cards[0].Balance += amount;
                                                                users[i].Cards[0].Balance -= amount;
                                                                notifications.Add(new CardtoCardNotf
                                                                {
                                                                    Text = $"{users[i].Name} send {amount}$ to {users[j].Name}",
                                                                    Time = DateTime.Now
                                                                });
                                                            }
                                                        }
                                                        catch (NegativeBalanceException ex)
                                                        {
                                                            ex.Show();
                                                        }

                                                    }
                                                    else if (pins != users[j].Cards[0].Pin && ctr == 3)
                                                        Console.WriteLine("Pin number is wrong");
                                                }
                                            }
                                        }
                                        catch (WrongPinLengthException ex)
                                        {
                                            ex.Show();

                                        }
                                        catch (NotNumberException ex)
                                        {
                                            ex.Show();
                                        }

                                        break;
                                    }
                                case (int)Operation.Exit:
                                    {
                                        //return;
                                        ++counter;
                                        break;
                                    }

                            }

                            if (counter != 0)
                            {
                                counter = 0;
                                break;
                            }
                        }
                    }
                }
            }

        }

    }

    class Program
    {
        static void Main(string[] args)
        {
            Helper h = new Helper();
            h.Start();
        }
    }
}

