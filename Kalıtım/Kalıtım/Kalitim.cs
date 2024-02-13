using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Kalıtım
{
     class Person
    {
        public int age { get; set; }
        public string name { get; set; }
        public string surname { get; set; }
        public Person(string name,string surname,int age)
        {
            this.name = name;
            this.surname = surname;
            this.age = age;
            Console.WriteLine("Person nesnesi olsuturuldu.");
        }
        public virtual void Show()
        {
            Console.Write($"\n{this.name} {this.surname} {this.age}");
        }
    }
    class Student:Person
    {
        public int no { get; set; }
        public Student(string name, string surname, int age,int no) :base( name,  surname,  age)//miras alınan cons cağırır
        {
            this.no=no;
            Console.WriteLine("Student nesnesi olusturldu");
        }
        public override void Show()//overide ve virtual gerek yok ama belitsek guzel olu
        {
            base.Show();//extends edilen sınıfın metedu çağırır
            Console.Write($" {this.no}\n");
        }
    }

}
