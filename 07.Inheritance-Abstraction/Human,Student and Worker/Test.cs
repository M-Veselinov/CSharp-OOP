using System;
using System.Collections.Generic;
using System.Linq;
namespace Human_Student_and_Worker
{
    class Test
    {
        static void Main()
        {
            List<Student> studentsList = new List<Student>();
            Student Mario = new Student("123456891s");
            Mario.firstName = "Mario";
            Student Minka = new Student("523456891d");
            Minka.firstName = "Minka";
            Student Pesho = new Student("323456891f");
            Pesho.firstName = "Pesho";
            Student Gosho = new Student("623456891g");
            Gosho.firstName = "Gosho";
            Student Milena = new Student("923456891h");
            Milena.firstName = "Milena";
            Student Raina = new Student("823456891b");
            Raina.firstName = "Raina";
            Student Misho = new Student("423456891v");
            Misho.firstName = "Misho";
            Student Niki = new Student("223456891y");
            Niki.firstName = "Niki";
            Student Diana = new Student("023456891q");
            Diana.firstName = "Diana";
            Student Ralica = new Student("723456891z");
            Ralica.firstName = "Ralica";
            Student[] arr = {Mario,Minka,Pesho,Gosho,Milena,Raina,Misho,Niki,Diana,Ralica};
            for (int i = 0; i < arr.Length; i++)
            {
                studentsList.Add(arr[i]); 
            }
            IEnumerable<Student> sortedStudents = studentsList.OrderBy(student => student.facultyNumber);
            foreach (Student student in sortedStudents)
            {
                Console.WriteLine("- {0}", student.facultyNumber);
            }
            List<Worker> workersList = new List<Worker>();
            Worker Ivan = new Worker(280, 8);
            Ivan.firstName = "Ivan";
            Ivan.lastName = "Petkov";
            Ivan.MoneyPerHour();
            Worker Maria = new Worker(380, 8);
            Maria.MoneyPerHour();
            Maria.firstName = "Maria";
            Worker Ivanka = new Worker(580, 8);
            Ivanka.MoneyPerHour();
            Ivanka.firstName = "Ivanka";
            Worker Petranka = new Worker(680, 8);
            Petranka.MoneyPerHour();
            Petranka.firstName = "Petranka";
            Worker Iordanka = new Worker(480, 8);
            Iordanka.MoneyPerHour();
            Iordanka.firstName = "Iordanka";
            Worker Stanka = new Worker(780, 8);
            Stanka.MoneyPerHour();
            Stanka.firstName = "Stanka";
            Worker Ivana = new Worker(180, 8);
            Ivana.MoneyPerHour();
            Ivana.firstName = "Ivana";
            Worker Anjela = new Worker(80, 8);
            Anjela.MoneyPerHour();
            Anjela.firstName = "Anjela";
            Worker Antoniq = new Worker(240, 8);
            Antoniq.MoneyPerHour();
            Antoniq.firstName = "Antoniq";
            Worker Anita = new Worker(510, 8);
            Anita.MoneyPerHour();
            Anita.firstName = "Anita";
            Worker[] arr1 = {Ivan,Maria,Ivanka,Petranka,Iordanka,Stanka,Ivana,Anjela,Antoniq,Anita};
            for (int i = 0; i < arr1.Length; i++)
            {
                workersList.Add(arr1[i]);
            }
            IEnumerable<Worker> sortedWorkers = workersList.OrderBy(worker => worker.moneyPerHour);

            foreach (Worker pet in sortedWorkers)
            {
                Console.WriteLine("- {0}", pet.moneyPerHour);
            }
            List<Human> humanList = new List<Human>();
            for (int i = 0; i < arr.Length; i++)
            {
                humanList.Add(arr[i]);
            }
            for (int i = 0; i < arr1.Length; i++)
            {
                humanList.Add(arr1[i]);
            }
            IEnumerable<Human> sortedHumans = humanList.OrderBy(human => human.firstName);
            foreach (Human human in sortedHumans)
            {
                Console.WriteLine(human.firstName);
            }
        }
    }
}
