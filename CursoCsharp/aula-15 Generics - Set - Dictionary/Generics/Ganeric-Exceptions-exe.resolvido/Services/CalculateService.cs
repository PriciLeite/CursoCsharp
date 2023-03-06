using System;


namespace CursoCsharp.aula_15_Generics___Set___Dictionary.Generics.Ganeric_Exceptions_exe.resolvido.Services
{
    class CalculateService
    {
        public T Max<T>(List<T> list) where T : IComparable
        {
            if (list.Count == 0)
            {
                throw new ArgumentException("the list can not be empty!");
            }

            T max = list[0];
            for (int i = 1; i < list.Count; i++)
            {
                if (list[i].CompareTo(max) > 0)
                {
                    max = list[i];
                }
            }
            return max;        
        }
    
    
    
    
    }
}
