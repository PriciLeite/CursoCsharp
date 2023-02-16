using System.Globalization;
namespace CursoCsharp.aula_06_Comportamento_de_Memoria___Arrays___Listas.Listas
{
    internal class Employee
    {
        public int Id { get; set; }

        public string Name { get; set; }

        public double Salary { get; set; }
    



       public Employee(int id, string name, double salary)
        {
            Id= id;
            Name= name;
            Salary= salary;
        }


        public double AumentoSalario(double porcentagem)
        {
            return Salary += Salary * porcentagem /100;
        }




        public override string ToString()
        {
            return "Id:" + Id 
                + ", " + "Nome: " + Name 
                + ", " + "Salário: " + Salary.ToString("F2", CultureInfo.InvariantCulture);
        }
    }


}
