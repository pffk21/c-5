
// using System;
// internal class Program
// {
//     static void Main(string[] args)  
//       {
//         try     
//         {
//             Card card1 = new Card(1234567818, "Primer Primer", 19, 611, 5000);
//             Card card2 = new Card(987654321, "Ivan Ivanov", 25, 123, 3000);

//             Console.WriteLine(card1);
//             Console.WriteLine(card2);

//             card1 += 2000;  
//             Console.WriteLine($"\nПосле пополнения: {card1}");

//             card1 -= 1000;
//             Console.WriteLine($"\nПосле снятия: {card1}");

//             Console.WriteLine($"Равен ли CVC: {card1 == card2}");
//             Console.WriteLine($"card1 > card2: {card1 > card2}");
//             Console.WriteLine($"card1 < card2: {card1 < card2}");
//             Console.WriteLine($"card1 != card2: {card1 != card2}");

             

//         }        
//         catch (ArgException ex)
//         {   Console.WriteLine($"Ошибка: {ex.Message}");
//             Console.WriteLine($"Некорректное значение: {ex.Value}");     
//         }
//         catch (CVCException ex)     
//         {
//             Console.WriteLine($"Ошибка: {ex.Message}");         
//             Console.WriteLine($"Некорректное значение: {ex.Value}");
//         }  
//         }
// }
// class Card{
//     private int num;   
//     private string fio;
//     private int data;    
//     private int cvc; 
//     private decimal balance;
//     public Card(int num, string fio, int data, int cvc, decimal balance)
//     {   this.num = num;
//         this.fio = fio;      
//         Data = data;
//         CVC = cvc;   
//         Balance=balance;
 

//     }
//     public int Data
//     {        
//         get { return data; }
//         set       
//         {
//             if (value < 16)       
//             {
//               throw new ArgException("Лицам до 16 регистрация запрещена", value);    
//             }
//             data = value;    
//         }
//     }
//     public int CVC    
//     {
//         get { return cvc; }    
//         set
//         {          
//             if (value < 100 || value > 999)
//             {               
//                 throw new CVCException("CVC указан не верно", value);
//             }          
//             cvc = value; 
//         }   
//     }
//     public decimal Balance
//     {
//         get { return balance; }
//         set
//         {
//             if (value < 0)
//             {
//                 throw new ArgumentException("Баланс отрицательный");
//             }
//             balance = value;
//         }
//     }
//     public static Card operator +(Card card, decimal amount)
//     {
//         card.Balance += amount;
//         return card;
//     }
//     public static Card operator -(Card card, decimal amount)
//     {
//         if (amount > card.Balance)
//         {
//             throw new InvalidOperationException("На карте нету денег");
//         }
//         card.Balance -= amount;
//         return card;
//     }

// public static bool operator ==(Card card1, Card card2)
// {
//     return card1.CVC == card2.CVC;
// }

// public static bool operator <(Card card1, Card card2)
// {
//     return card1.Balance < card2.Balance;
// }

// public static bool operator >(Card card1, Card card2)
// {
//     return card1.Balance > card2.Balance;
// }
// public static bool operator !=(Card card1, Card card2)
// {
//     return !(card1 == card2);
// }



// public override string ToString()
// {       
//     return $"\nНомер карты: {num}\nФИО: {fio}\nВозраст: {data}\nCVC: {cvc}\nБаланс: {balance} грн";
// }

// }


// class ArgException : Exception
// {   public int Value { get; }
//     public ArgException(string message, int val) : base(message)  
//     {
//         Value = val;  
//     }
// }
// class CVCException : Exception
// {
//     public int Value { get; }  
//     public CVCException(string message, int val) : base(message)
//     {       
//         Value = val;
//     }
// }







//задание 2
// using System;

// internal class Program
// {
//     static void Main(string[] args)
//     {
//         try
//         {
//             Passport passport = new Passport(1234567890, "Primer Primer", new DateTime(2021, 5, 20));
//             Console.WriteLine(passport);
//         }
//         catch (DateIssueException ex)
//         {
//             Console.WriteLine($"Ошибка: {ex.Message}");
//             Console.WriteLine($"Некорректная дата: {ex.InvalidDate.ToShortDateString()}");
//         }
//     }
// }

// class Passport
// {
//     private int number;
//     private string name;
//     private DateTime date;

//     public Passport(int number, string name, DateTime date)
//     {
//         PassportNumber = number;
//         FullName = name;
//         Date= date; 
//     }

//     public int PassportNumber
//     {
//         get { return number; }
//         set
//         {
//             if (value.ToString().Length != 10)
//             {
//                 throw new ArgumentException("В номере паспорта должно быть 10 цифр");
//             }
//             number = value;
//         }
//     }
//     public string FullName
//     {
//         get { return name; }
//         set { name = value; }
//     }
//     public DateTime Date
//     {
//         get { return date; }
//         set
//         {
//             DateTime today = DateTime.Now;

//             if (value > today)
//             {
//                 throw new DateIssueException("Дата выдачи не правильная", value);
//             }

//             date = value;
//         }
//     }

//     public override string ToString()
//     {
//         return $"Номер паспорта: {number}\nФИО: {name}\nДата выдачи: {date.ToShortDateString()}";
//     }
// }

// class DateIssueException : Exception
// {
//     public DateTime InvalidDate { get; }

//     public DateIssueException(string message, DateTime invalidDate) : base(message)
//     {
//         InvalidDate = invalidDate;
//     }
// }








//задание 1

// using System;
// internal class Program
// {
//     static void Main(string[] args)
//     {
//         while (true)
//         {
//             Console.WriteLine(" Калькулятор");
//             Console.WriteLine("1) Десятичная -> Двоичная");
//             Console.WriteLine("2) Десятичная -> Восьмеричная");
//             Console.WriteLine("3) Двоичная -> Десятичная");
//             Console.WriteLine("5) Восьмеричная -> Десятичная");
//             Console.Write("Выберите: ");

//             if (!int.TryParse(Console.ReadLine(), out int choice) || choice < 0 || choice > 5)
//             {
//                 Console.WriteLine("Ошибка");
//             }
//             Console.Write("Введите число: ");
//             string input = Console.ReadLine();
//             try
//             {
//                 switch (choice)
//                 {
//                     case 1:  
//                         int decToBin = int.Parse(input);
//                         Console.WriteLine($"Десятичная -> Двоичная: {Convert.ToString(decToBin, 2)}");
//                         break;

//                     case 2:  
//                         int decToOct = int.Parse(input);
//                         Console.WriteLine($"Десятичная -> Восьмеричная: {Convert.ToString(decToOct, 8)}");
//                         break;

//                     case 4:  
//                         int binToDec = Convert.ToInt32(input, 2);
//                         Console.WriteLine($"Двоичная -> Десятичная: {binToDec}");
//                         break;

//                     case 5:  
//                         int octToDec = Convert.ToInt32(input, 8);
//                         Console.WriteLine($"Восьмеричная -> Десятичная: {octToDec}");
//                         break;
//                 }
//             }
//             catch (FormatException)
//             {
//                 Console.WriteLine("Ошибка, некорректное число");
//             }
//             catch (OverflowException)
//             {
//                 Console.WriteLine("Ошибка, число вышло за пределыо диапазона");
//             }
//             break;
//         }
//     }
// }
