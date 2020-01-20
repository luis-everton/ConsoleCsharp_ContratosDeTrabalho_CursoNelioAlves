using System;
using ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves.Entities;
using ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves.Entities.Enums;
using System.Globalization;

namespace ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves
{
    class Program
    {
        static void Main(string[] args)
        {
            // fazendo a leitura e apresentação dos dados conforme enunciado do problema
            Console.Write("Enter department's name: ");
            string deptName = Console.ReadLine();

            Console.WriteLine("Enter worker data: ");
            Console.Write("Name: ");
            string name = Console.ReadLine();
            Console.Write("Level (Junior/MidLevel/Senior): ");
            WorkerLevel level = Enum.Parse<WorkerLevel>(Console.ReadLine());        //leitura do enum
            Console.Write("Base salary: ");
            double baseSalary = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);

            Department dept = new Department(deptName); // instanciando um departamento
            Worker worker = new Worker(name, level, baseSalary, dept);  //instanciando um trabalhador

            Console.Write("How many contracts to this worker? ");   //obtendo a quantidade de contratos de trabalho 
            int n = int.Parse(Console.ReadLine());
            for (int i = 1; i <= n; i++)    //cada ciclo do for corresponde a um contrato até o limite n
            {
                Console.WriteLine($"Enter #{i} contract data:");
                Console.Write("Date (DD/MM/YYYY): ");
                DateTime date = DateTime.Parse(Console.ReadLine());
                Console.Write("Value per hour: ");
                double valuePerHour = double.Parse(Console.ReadLine(), CultureInfo.InvariantCulture);
                Console.Write("Duration (hours): ");
                int hours = int.Parse(Console.ReadLine());

                HourContract contract = new HourContract(date, valuePerHour, hours);
                worker.AddContract(contract);   // adicionando o novo contrato ao trabalhador
            }

            Console.WriteLine();
            Console.Write("Enter month and year to calculate income (MM/YYYY): "); // obtendo o mes e ano que se deseja ver o faturamento
            string monthAndYear = Console.ReadLine();
            int month = int.Parse(monthAndYear.Substring(0, 2));
            int year = int.Parse(monthAndYear.Substring(3));

            Console.WriteLine("Name: " + worker.Name);
            Console.WriteLine("Department: " + worker.Department.Name);
            Console.WriteLine("Income for " + monthAndYear + "; " + worker.Income(year, month).ToString("F2", CultureInfo.InvariantCulture));

        }
    }
}
