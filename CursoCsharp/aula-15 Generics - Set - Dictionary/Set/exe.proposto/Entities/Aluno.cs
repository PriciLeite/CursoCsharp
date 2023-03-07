using System;


namespace CursoCsharp.aula_15_Generics___Set___Dictionary.Set.exe.proposto.Entities
{
    class Aluno
    {
        
        public int Id { get; set; }

        public Aluno(Aluno id)
        {
        }


        public Aluno(int id)
        {
            this.Id = id;
        }

       
    }
}
