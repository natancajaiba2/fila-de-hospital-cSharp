using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Paciente
    {
        public string nome;
        public string dataNasc;
        public string cpf;
        public double numeroCadastro;
        public string tipoSanguineo;
        public string endereco;

        public virtual void cadastrarPaciente()
        {
            Console.WriteLine("digite o nome do paciente");
            nome = Console.ReadLine();
            Console.WriteLine("digite a data de nascimento do paciente");
            dataNasc = Console.ReadLine();
            Console.WriteLine("digite o cpf do paciente");
            cpf = Console.ReadLine();
            Console.WriteLine("digite o numero de cadastro do paciente");
            numeroCadastro = Double.Parse(Console.ReadLine());
            Console.WriteLine("digite o tipo sanguineo do paciente");
            tipoSanguineo = Console.ReadLine();
            Console.WriteLine("digite o endereço do paciente");
            endereco = Console.ReadLine();
            Console.ReadKey();
        }
        public virtual void mostrarDados()
        {
            Console.WriteLine("\nDados do paciente");
            Console.WriteLine("Nome: " + nome);
            Console.WriteLine("data de nascimento: " + dataNasc);
            Console.WriteLine("CPF: " + cpf);
            Console.WriteLine("numero de cadastro: " + numeroCadastro);
            Console.WriteLine("tipo sanguineo: " + tipoSanguineo);
            Console.WriteLine("Endereço: " + endereco + "\n");
            //Console.ReadKey();
        }
    }
}
