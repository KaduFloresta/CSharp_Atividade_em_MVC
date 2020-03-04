using System.Collections.Generic;
using Models;
using Repositories;


namespace Controllers
{
    // : = Interface
    public class ControllerFunc
    {
        private static List<Models.Funcionario> funcionarios = new List<Models.Funcionario>();
        //Adicionando na Model        
        public static void addFunc(int id, string nome, string cpf){
        new Models.Funcionario(id, nome, cpf);

            }
                //Retorno para a View
                public static List<Funcionario> returnFunc(){
                return RepositoryFunc.returnFunc();
            }
    }
}   