using System;
using System.Collections.Generic;
using System.Text;

namespace homework0.Models
{
    internal class Student
    {
        private string _fullName ;
        public string FullName
        {
            get
            {
                return _fullName;
            }
            set
            {
                while (!CheckFullName(value))
                {
                    Console.WriteLine("Duzgun daxil et");
                    value=Console.ReadLine();
                }
                _fullName = value;
            }
        }

        private string _groupNo;
        public string GroupNo 
        {
            get
            {
                return _groupNo;
            }
            set
            {
                while (!CheckGroupNo(value))
                {
                    Console.WriteLine("Duzgun daxil et");
                    value=Console.ReadLine();
                }
                _groupNo = value;
            }
        }

        public int Age;

        public Student(string groupno,string fullname)
        {
            GroupNo = groupno;
            FullName = fullname;
            
        }
        static bool CheckGroupNo(string groupno)
        {
            if (groupno.Length == 4)
            {
                if (char.IsUpper(groupno[0]))
                {
                    for (int i = 1; i < groupno.Length; i++)
                    {
                        if (char.IsDigit(groupno[i]))
                        {
                            Console.WriteLine("Duzgundur");
                            return true;
                        }
                        else
                        {
                            Console.WriteLine("sehvdir");
                            break;
                        }
                        
                    }
                }
                else
                {
                    Console.WriteLine("Ilk indeks boyuk herf olmalidir");
                }

            }
            else
            {
                Console.WriteLine("4 elementden ibaret olmalidir..");
                return false;
            }
            return false;
        }



        //***************  SADECE 5 HERFLI ADLARDA ISLEYIR  ***************
        static bool CheckFullName(string fullname)
        {
            for (int i = 0; i < fullname.Length; i++)
            {
                if (char.IsWhiteSpace(fullname, 5))
                {
                    Console.WriteLine("Duzdur..");
                    return true;
                    break;
                }
                
                else
                {
                    Console.WriteLine("Bosluq olmalidir");
                    break;
                }
            }


            return false;
        }
    }
}
