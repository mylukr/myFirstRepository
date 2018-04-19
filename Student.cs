using System;
using System.IO;
using System.Collections.Generic;
using System.Text;

namespace Students
{
    class Student : IComparable
    {
        public Student(string FirstName, string LastName, DateTime Birthday, char Gender)
        {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Birthday = Birthday;
            this.Gender = Gender;
            this.DaysAlive = (DateTime.Now.Date - Birthday).Days;

        }
        public void Print(ref StreamWriter stream)
        {
            stream.Write(LastName + new string(' ', 15 - LastName.Length));
            stream.Write(FirstName + new string(' ', 15 - FirstName.Length));
            stream.Write(Birthday.ToShortDateString() + new string(' ', 15 - Birthday.ToShortDateString().Length));
            stream.Write(Gender + new string(' ', 5));
        }
        public virtual void ConsolePrint()
        {
            Console.Write(LastName + new string(' ', 15 - LastName.Length));
            Console.Write(FirstName + new string(' ', 15 - FirstName.Length));
            Console.Write(Birthday.ToShortDateString() + new string(' ', 15-Birthday.ToShortDateString().Length));
            Console.Write(Gender + new string(' ', 5));
        }

        public void AnonConsolePrint()
        {
            Console.Write(LastName + new string(' ', 15 - LastName.Length));
            Console.Write(FirstName + new string(' ', 15 - FirstName.Length));
            Console.Write((Gender == 'ж' ? new string(' ', Birthday.ToShortDateString().Length) : Birthday.ToShortDateString()) + new string(' ', 15-Birthday.ToShortDateString().Length));
            Console.Write(Gender + new string(' ', 5));
        }

        public override string ToString()
        {
            string result = string.Format("{0}{1}{2}", LastName, FirstName, DaysAlive);
            return result;
        }

        public int CompareTo(object obj)
        {
            return this.ToString().CompareTo(obj.ToString());
        }

        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTime Birthday { get; set; }
        public char Gender { get; set; }
        public int DaysAlive { get; set; }
    }
}
