using System;


namespace CursoCsharp.aula_11_Tratamento_de_Excecoes.Entities.Exceptions3
{
    class DomianException : ApplicationException
    {   
        public DomianException(string message) : base(message)
        {            
        }
    }
}
