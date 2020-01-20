using ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves.Entities.Enums;
using System.Collections.Generic;

namespace ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves.Entities
{
    class Worker    //trabalhador
    {
        //propriedades
        public string Name { get; set; }
        public WorkerLevel Level { get; set; }  //enumeração
        public double BaseSalary { get; set; }
        public Department Department { get; set; }  //associação com a classe Department
        public List<HourContract> Contracts { get; set; } = new List<HourContract>();   //um para muitos

        //contrutor padrão
        public Worker()
        {
        }

        //contrutor com argumentos/parametros 
        public Worker(string name, WorkerLevel level, double baseSalary, Department department)
        {
            Name = name;
            Level = level;
            BaseSalary = baseSalary;
            Department = department;
        }

        //método que adiciona contrato
        public void AddContract(HourContract contract)
        {
            Contracts.Add(contract);
        }

        // método de remoção de contrato
        public void RemoveContract(HourContract contratct)
        {
            Contracts.Remove(contratct);
        }

        //método de ganhos com o contrato
        public double Income(int year, int month)
        {
            double sum = BaseSalary;
            foreach (HourContract contract in Contracts)
            {
                if (contract.Date.Year == year && contract.Date.Month == month)
                {
                    sum += contract.TotalValue();
                }
            }
            return sum;
        }

    }
}