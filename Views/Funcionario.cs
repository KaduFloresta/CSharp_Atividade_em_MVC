using System;
using Models;

namespace View
{
    public class ViewFunc 
    {
        public static void addFunc(int id, String nome, string cpf){
        Controllers.ControllerFunc.addFunc(id, nome, cpf);
        }
        public static void returnFunc(){
             foreach (Models.Funcionario funcionario in Controllers.ControllerFunc.returnFunc())
            {
                Console.WriteLine(funcionario);
            }
        }               
    }
}