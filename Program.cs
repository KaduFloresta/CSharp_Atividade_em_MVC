using System;
using View;

namespace MVC
{
    public class Program
    {
        public static void Main()
        {
        //Adiciona Funcionários
        ViewFunc.addFunc(1,"Carlos Eduardo Floresta", "250.250.250.25");
        ViewFunc.addFunc(2,"Leonardo Balitski Filipini", "100.100.100.10");
        ViewFunc.addFunc(3,"Matheus Henrique Rech", "021.021.021.02");
            
        //Retorno            
        ViewFunc.returnFunc();
        }
    }
    
}