using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes.Classes
{
    internal class Student
    {
        public string name;
        public string surname;
        public string group;
        public int point;
        public bool isDraduated=true;
        public Student(string name, string surname, string group, int point, bool isDraduated)
        {
            this.name = name;
            this.surname = surname;
            this.group = group;
            this.point = point;
            isDraduated=isDraduated && point > 65;
            
            
        }
        public void GetInfo()
        {
            Console.WriteLine($"ad:{name}");
            Console.WriteLine($"soyad:{surname}");
            Console.WriteLine($"qrup:{group}");
            Console.WriteLine($"bal:{point}");
            Console.WriteLine($"mezun olub olmadigi:{(isDraduated ? "mezun" : "mezun deyil")}");


        }
        public void CheckGraduate()
        {
            if (point>65)
            {
                Console.WriteLine("mezun olub");
            }
            else { Console.WriteLine("mezun olmuyub"); }
        }
        public void GetDiplomDegree() {
            if (point < 65) { Console.WriteLine("mezun olmuyub"); }
            else if (point>65 && point<80)
            {
                Console.WriteLine("adi");
            }
            else if (point>80 && point<90 )
            {
                Console.WriteLine("seref");
            }
            else 
            {
                Console.WriteLine("yuksek seref");
            }
            
        
        }
        }
    }
