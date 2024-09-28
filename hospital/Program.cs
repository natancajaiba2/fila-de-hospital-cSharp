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

            string troca;
            Paciente paciente = new Paciente();
            Paciente prioritario = new Paciente();
            int qntPaciente = 11;
            int qntPrioritario = 11;
            string[] fila = new string[qntPaciente];
            string[] filaprio = new string[qntPrioritario];
            int totalPacientes = 0;
            int totalPrioritario = 0;
            string opcao;
            do
            {
                Console.WriteLine("sistema de Controle de Pacientes");
                Console.WriteLine("1. cadastrar Paciente");
                Console.WriteLine("2. inserir Paciente na Fila");
                Console.WriteLine("3. inserir Paciente na fila prioritária");
                Console.WriteLine("4. listar Fila de Pacientes");
                Console.WriteLine("5. listar fila de Pacientes prioritários");
                Console.WriteLine("6. atender Paciente");
                Console.WriteLine("7. atender paciente prioritário");
                Console.Write("escolha uma opção ou digite 'q' para sair \n");
                opcao = Console.ReadLine();

                switch (opcao)
                {
                    case "1":
                        Console.WriteLine("\nO paciente é prioritário? s/n \n");
                        troca = Console.ReadLine();
                        if (troca == "s")
                        {
                            inscreverPrioritario();
                        }
                        else
                        {
                            inscreverPaciente();
                        }
                        break;
                     case "2":
                         inserirPaciente();
                         break;
                     case "3":
                         inserirPrioritario();
                        break;
                     case "4":
                         mostrarLista();
                         break;
                     case "5":
                         mostrarPrioritaria();
                         break;
                     case "6":
                         atenderPaciente();
                         break; 
                     case "7":
                        atenderPrioritario();
                        break;
                     case "q":
                        Console.WriteLine("saindo do sistema");
                        break;
                     default:
                        Console.WriteLine("opção invalida");
                        break;
                }
            } while (opcao != "q");
            void inscreverPrioritario()
            {
                if (totalPrioritario < qntPrioritario)
                {
                    Console.WriteLine("\nCadastro de paciente");
                    paciente.cadastrarPaciente();
                    filaprio[totalPrioritario] = paciente.nome;
                    totalPrioritario++;
                    Console.WriteLine("\npaciente prioritario cadastrado");
                    paciente.mostrarDados();
                    //Console.WriteLine(paciente.nome);
                    Console.WriteLine("total pacientes prioritarios:" + totalPrioritario + "\n");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("quantidade maxima de pacientes prioritarios antigida \n");

                }

            }
            void inscreverPaciente()
            {
                if (totalPacientes < qntPaciente)
                {
                    Console.WriteLine("\nCadastro de paciente");
                    paciente.cadastrarPaciente();
                    fila[totalPacientes] = paciente.nome;
                    totalPacientes++;
                    Console.WriteLine("\npaciente cadastrado");
                    paciente.mostrarDados();
                    //Console.WriteLine(paciente.nome);
                    Console.WriteLine("total paciente:" + totalPacientes + "\n");
                    Console.ReadKey();

                }
                else
                {
                    Console.WriteLine("quantidade maxima de clientes antigida \n");

                }

            }
            void inserirPrioritario()
            {
                if (totalPrioritario > 0)
                {
                    Console.WriteLine("\ndigite o nome do paciente que será inserido na fila prioritária");
                    paciente.nome = Console.ReadLine();
                    bool encontrado = false;
                    for (int i = 0; i < totalPrioritario; i++)
                    {
                        if (filaprio[i] == paciente.nome)
                        {
                            encontrado = true;
                            Console.WriteLine(paciente.nome + " inserido na fila prioritária com sucesso \n");
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("paciente não encontrado \n");
                    }
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
                            Console.WriteLine(paciente.nome + " inserido na fila com sucesso \n");
                            break;
                        }
                    }
                    if (!encontrado)
                    {
                        Console.WriteLine("paciente não encontrado \n");
                    }
                }  
            }
            void mostrarPrioritaria()
            {
                Console.WriteLine("\nfila de pacientes prioritarios");
                for (int i = 0; i < totalPrioritario; i++)
                {
                    Console.WriteLine($"{i + 1}. {filaprio[i]}\n");
                }
            }
            void mostrarLista()
            {
                Console.WriteLine("\nfila de pacientes");
                for (int i = 0; i < totalPacientes; i++)
                {
                    Console.WriteLine($"{i + 1}. {fila[i]}\n");
                }
            }
            void atenderPrioritario()
            {
                if (totalPrioritario > 0)
                {
                    Console.WriteLine("\nAtendendo paciente prioritário:" + filaprio[0] + "\n");
                    for (int i = 0; i < totalPrioritario - 1; i++)
                    {
                        filaprio[i] = filaprio[i + 1];

                    }
                }
                else
                {
                    Console.WriteLine("não há pacientes na fila prioritária \n");
                }
            }
            void atenderPaciente()
            {
                if (totalPacientes>0)
                {
                    Console.WriteLine("\nAtendendo paciente:" + fila[0] + "\n");
                    for (int i = 0;i < totalPacientes - 1; i++)
                    {
                        fila[i] = fila[i + 1];

                    }
                } else 
                {
                    Console.WriteLine("não há pacientes na fila \n");
                }
            }
        }
    }
}
       