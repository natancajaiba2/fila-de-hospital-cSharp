using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace hospital
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Paciente paciente = new Paciente();
            int qntPaciente = 11;
            string[] fila = new string[qntPaciente];
            int totalPacientes = 0;
            int opcao;
            do
            {
                Console.WriteLine("sistema de Controle de Pacientes");
                Console.WriteLine("1. cadastrar Paciente");
                Console.WriteLine("2. inserir Paciente na Fila");
                Console.WriteLine("3. listar Fila de Pacientes");
                Console.WriteLine("4. incluir Paciente Prioritário");
                Console.WriteLine("5. atender Paciente");
                Console.WriteLine("0. sair");
                Console.Write("escolha uma opção: ");
                opcao = int.Parse(Console.ReadLine());

                switch (opcao)
                {
                    case 1:
                        inscreverPaciente();
                        break;
                     case 2:
                         inserirPaciente();
                         break;
                     case 3:
                         mostrarLista();
                         break;
                     /*case 4:
                         incluirPrioridade();
                         break;*/
                     case 5:
                         atenderPaciente();
                         break; 
                    case 0:
                        Console.WriteLine("saindo do sistema");
                        break;
                    default:
                        Console.WriteLine("opção invalida");
                        break;
                }
            } while (opcao != 0);
            void inscreverPaciente()
            {
                if (totalPacientes < qntPaciente)
                {
                    Console.WriteLine("Cadastro de paciente");
                    paciente.cadastrarPaciente();
                    fila[totalPacientes] = paciente.nome;
                    totalPacientes++;
                    Console.WriteLine("paciente cadastrado");
                    Console.WriteLine(paciente.nome);
                    Console.WriteLine("total paciente:" + totalPacientes);
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("quantidade maxima de cliente antigida");

                }

            }
            void inserirPaciente()
            {
                if (totalPacientes > 0)
                {
                    Console.WriteLine("digite o nome do paciente que será inserido na fila");
                    paciente.nome = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = 0; i < totalPacientes; i++)
                    {
                        if (fila[i] == paciente.nome)
                        {
                            encontrado = true;
                            Console.WriteLine(paciente.nome + " inserido na fila com sucesso ");
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("paciente não encontrado");
                    }
                }  
            }
            void mostrarLista()
            {
                Console.WriteLine("fila de pacientes");
                for (int i = 0; i < totalPacientes; i++)
                {
                    Console.WriteLine($"{i + 1}. {fila[i]}");
                }
            }
            void atenderPaciente()
            {
                if (totalPacientes>0)
                {
                    Console.WriteLine("Atendendo paciente:" + fila[0]);
                    for (int i = 0;i < totalPacientes - 1; i++)
                    {
                        fila[i] = fila[i + 1];

                    }
                } else {
                    Console.WriteLine("não há paciente na fila");
                        }
            }
        }
    }
}
       