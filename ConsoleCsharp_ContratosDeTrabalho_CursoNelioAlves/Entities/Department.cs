namespace ConsoleCsharp_ContratosDeTrabalho_CursoNelioAlves.Entities
{
    class Department
    {
        //propriedade
        public string Name { get; set; }

        //construtor padrão
        public Department()
        {
        }
        //construtor com um argumento/parametro
        public Department(string name)
        {
            Name = name;
        }
    }
}
