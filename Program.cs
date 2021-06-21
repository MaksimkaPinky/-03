using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ЛР03
{
    class Employee
    {
        public int ID { get; set; } 
        public string FIO { get; set; }  
        public string Post { get; set; }
        public double Salary { get; set; }
    }
    class Program
    {
        static void Main(string[] args)
        {
            List<Employee> EMP = new List<Employee>();
            Employee e1 = new Employee()
            {
                ID = 1,
                FIO = "Махотина А.",
                Post = "Инженер",
                Salary = 38000
            };
            EMP.Add(e1);
            EMP.Add(new Employee()
            {
                ID = 2,
                FIO = "Гуськов Б.",
                Post = "Менеджер",
                Salary = 45000
            });
            EMP.Add(new Employee()
            {
                ID = 3,
                FIO = "Луценко А.",
                Post = "Директор",
                Salary = 60000
            });
            EMP.Add(new Employee()
            {
                ID = 4,
                FIO = "Кемаев А.",
                Post = "Инженер",
                Salary = 38000
            });
            EMP.Add(new Employee()
            {
                ID = 5,
                FIO = "Антонова С.",
                Post = "Менеджер",
                Salary = 40000
            });
            Show(EMP, "Начальное содержание");
            Employee e2 = new Employee()
            {
                ID = 6,
                FIO = "Семенов Б.",
                Post = "Менеджер",
                Salary = 58000
            };
            EMP.Insert(2, e2);
            Show(EMP, "Вставлен сотрудник Семенов Б.");
            Employee e3 = EMP.Find(z => z.ID == 4);
            if (e3 != null)
            {
                EMP.Remove(e3);
                Show(EMP, "Удален сотрудник с ID =4");
            }
            EMP.Sort(FIO);
            Show(EMP, "Сортировка по ФИО");

            EMP.Sort(ZP);
            Show(EMP, "Сортировка по зарплате");


            Console.ReadKey();
        }
        static void Show(List<Employee> emp, string comment)
        {
            Console.Write("//////////////");
            Console.Write(" " + comment + " ");
            Console.WriteLine("//////////////");
            // цикл по объектам коллекции
            foreach (Employee e in emp)
            {
                Console.Write($"Индекс = {emp.IndexOf(e)};");
                Console.WriteLine($"Сотрудник: ID = {e.ID}, ФИО = {e.FIO}, должность = {e.Post}, зарплата = {e.Salary}");
            }
        }
        static int FIO(Employee e1, Employee e2)
        {
            int n = e1.FIO.CompareTo(e2.FIO);
            return n;
        }

        static int ZP(Employee e1, Employee e2)
        {
            if (e1.Salary < e2.Salary) return -1;
            if (e1.Salary == e2.Salary) return 0;
            else return 1;
        }
    }

}

