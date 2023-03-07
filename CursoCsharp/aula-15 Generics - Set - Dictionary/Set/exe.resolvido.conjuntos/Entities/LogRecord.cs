using System;

namespace CursoCsharp.aula_15_Generics___Set___Dictionary.Set.exe.resolvido.conjuntos.Entities
{
    class LogRecord
    {
        public string UserName { get; set; }
        public DateTime Instant { get; set; }


        public LogRecord(string userName, DateTime instant) 
        {
            this.UserName = userName;
            this.Instant = instant;
        }


        public override int GetHashCode()
        {
            return UserName.GetHashCode();
        }



        public override bool Equals(object? obj)
        {
            if (!(obj is LogRecord))
            {
                return false;
            }
            LogRecord other = obj as LogRecord;
            return UserName.Equals(other.UserName);
        }




    
    
    
    
    
    
    
    }            
        
}
