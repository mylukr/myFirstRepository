using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Collections;

namespace Students
{
    class Group : IEnumerable, ICloneable
    {
        public string Title { get; set; }
        private List<Student> group = new List<Student>();
        private int amount = 0;

        public void Insert(Student student)
        {
            amount++;
            group.Add(student);
        }
        
        public int Amount { get { return amount; } }

        public bool IsInGroup(Student student)
        {
            foreach(Student s in group)
            {
                if(s.ToString() == student.ToString())
                {
                    return true;
                }
            }
            return false;
        }

        public bool IsInGroup(string FirstName, string LastName)
        {
            foreach (Student s in group)
            {
                if (s.FirstName == FirstName && s.LastName == LastName)
                {
                    return true;
                }
            }
            return false;
        }

        public void Sort()
        {
            group.Sort();
        }

        public void ConsolePrint()
        {
            foreach(Student a in group)
            {
                a.ConsolePrint();
                Console.WriteLine();
            }
        }

        public void Remove(string LastName, string FirstName)
        {
            foreach (Student a in group)
            {
                if(a.FirstName == FirstName && a.LastName==LastName)
                {
                    amount--;
                    group.Remove(a);
                    return;
                }
            }
        }

        public void AnonConsolePrint()
        {
            foreach (Student a in group)
            {
                a.AnonConsolePrint();
                Console.WriteLine();
            }
        }


        public void Print(ref StreamWriter writer)
        {
            foreach(Student student in group)
            {
                student.Print(ref writer);
                writer.WriteLine();
            }
        }

        public Student this[int pos]
        {
            get
            {
                return group[pos];
            }
        }

        public IEnumerator GetEnumerator()
        {
            return group.GetEnumerator();
        }

        public object Clone()
        {
            return this.MemberwiseClone();
        }
    }
}
