using System.Collections.Generic;
using Repositories;

namespace Models
{
    public class Funcionario
    {
        // Get - Set 
        private int Id { get; set; }
        public string Nome {get; set; }
        public string Cpf {get; set; }
        
        // Construtor
        public Funcionario (int id, string nome, string cpf)
            { 
                Id = id;
                Nome = nome;
                Cpf = cpf;
                RepositoryFunc.addFunc(this);
            }

        // Funções
        public static List<Funcionario> returnFunc()
            {
                return RepositoryFunc.returnFunc();
            }
            
        public override string ToString()
            {
                return $"\nId: {Id} \nNome: {Nome} \nCPF: {Cpf}\n";
            }
    }
}