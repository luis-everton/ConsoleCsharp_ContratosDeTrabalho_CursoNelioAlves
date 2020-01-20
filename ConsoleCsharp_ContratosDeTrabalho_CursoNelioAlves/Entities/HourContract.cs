using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves.Entities
{
    class HourContract
    {
        //propriedades
        public DateTime Date { get; set; }
        public double ValuePerHour { get; set; }
        public int Hours { get; set; }

        //contrutor padrão
        public HourContract()
        {
        }

        //contrutor com argumentos/parametros
        public HourContract(DateTime date, double valuePerHour, int hours)
        {
            Date = date;
            ValuePerHour = valuePerHour;
            Hours = hours;
        }
    }
}
