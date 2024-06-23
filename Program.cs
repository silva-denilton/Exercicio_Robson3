using System;
using System.Collections.Generic;
using System.Diagnostics.Eventing.Reader;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Atividade_Final_3
{
    internal class Program
    {

        static void Main(string[] args)
        {
            Funcionario lista;
            CadastroDeServicos Servicos;
            Cliente Cliente;
            List<Cliente> ListaClientes;
            List<Funcionario> ListaFuncionarios;
            List<CadastroDeServicos> ListaServicos;
            List<string> Agendamentos = new List<string>();
            ListaClientes = new List<Cliente>();
            ListaFuncionarios = new List<Funcionario>();
            ListaServicos = new List<CadastroDeServicos>();
            lista = new Funcionario();
            Servicos = new CadastroDeServicos();
            Cliente = new Cliente();
            int opcao;
            do
            {

                Console.WriteLine("Escolha uma opção:");
                Console.WriteLine("(1) para cadastrar cliente:");
                Console.WriteLine("(2) para cadastrar funcionario:");
                Console.WriteLine("(3) para cadastrar serviço:");
                Console.WriteLine("(4) para fazer agendamento:");
                Console.WriteLine("(5) para verificar os agendamentos:");
                Console.WriteLine("(0) para sair:");
                Console.WriteLine();
                opcao = int.Parse(Console.ReadLine());
                Console.WriteLine();

                if (opcao == 1)
                {
                    Console.Write("Digite o nome do Cliente: ");
                    Cliente.Nome = Console.ReadLine();
                    Console.Write("Digite o telefone: ");
                    Cliente.Telefone = Console.ReadLine();
                    ListaClientes.Add(Cliente);
                    Console.WriteLine();
                }
                else if (opcao == 2)
                {
                    Console.Write("Digite o nome do funcionario: ");
                    lista.Nome = Console.ReadLine();
                    ListaFuncionarios.Add(lista);
                    Console.WriteLine();
                }
                else if (opcao == 3)
                {
                    Console.Write("Digite o serviço: ");
                    Servicos.Servico = Console.ReadLine();
                    Console.Write("Digite a descrição: ");
                    Servicos.Descricao = Console.ReadLine();
                    ListaServicos.Add(Servicos);
                    Console.WriteLine();
                }
                else if (opcao == 4)
                {
                    Console.Write("Digite o nome do Cliente: ");
                    var NomeCliente = Console.ReadLine();
                    Console.Write("Digite o nome do funcionário: ");
                    var NomeFuncionario = Console.ReadLine();
                    Console.Write("Digite o serviço: ");
                    var NomeServico = Console.ReadLine();
                    Console.Write("Digite o horario: ");
                    DateTime horario = DateTime.Parse(Console.ReadLine());
                    Console.WriteLine();
                    foreach (var cliente in ListaClientes)
                    {
                        if (NomeCliente == cliente.Nome)
                        {
                            Agendamentos.Add(NomeCliente);
                        }
                        else
                        {
                            Console.WriteLine("Cliente não encontrado!!");
                            Console.WriteLine();
                        }
                    }
                    foreach (var funcionarios in ListaFuncionarios)
                    {
                        if (NomeFuncionario == funcionarios.Nome)
                        {
                            Agendamentos.Add(NomeFuncionario);
                        }
                        else
                        {
                            Console.WriteLine("Funcionário não encontrado!!");
                            Console.WriteLine();
                        }
                    }
                    foreach (var servicos in ListaServicos)
                    {
                        if (NomeServico == servicos.Servico)
                        {
                            Agendamentos.Add(NomeServico);
                        }
                        else
                        {
                            Console.WriteLine("Serviço não encontrado!!");
                            Console.WriteLine();
                        }
                    }
                    Agendamentos.Add(horario.ToString());
                }
                else if (opcao == 5)
                {
                    foreach (var item in Agendamentos)
                    {
                        Console.WriteLine(item);
                    }
                }
            }
            while (opcao != 0);

            Console.ReadLine();
        }

    }
}
