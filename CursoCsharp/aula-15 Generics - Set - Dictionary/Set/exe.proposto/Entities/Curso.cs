using System;
using CursoCsharp.aula_15_Generics___Set___Dictionary.Set.exe.proposto.Entities;

namespace CursoCsharp.aula_15_Generics___Set___Dictionary.Set.exe.proposto.Entities
{
    class Curso : Aluno
    {
        public Aluno Id { get; set; }



        public Curso(Aluno id) : base(id)
        {
            this.Id = id;
        }


        public Curso(int id) : base(id)
        {
        }
        


        public override bool Equals(object? obj)
        {
            if(!(obj is Curso))
            {
                return false;
            }
            Curso other = obj as Curso;
            return Id.Equals(other.Id);
        }
       

    
    
    }


}
