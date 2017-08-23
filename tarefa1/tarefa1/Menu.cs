using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tarefa1
{
    class Menu
    {
        static ConsoleKeyInfo opcao;
        string nome;
        int flag = 0;

        static List<Pessoa> listaPessoa = new List<Pessoa>();

        public void Home()
        {
            Clear();
            Console.WriteLine(" ---------------- CADASTRO DE PESSOAS ----------------- ");            
            Console.WriteLine(" 1-Consultar | 2-Listar | 3-Incluir | 4-Alterar | 5-Excluir ");
            opcao = Console.ReadKey();
            MenuSelecionado(opcao.Key);
        }

        public void Pagina(int opcao)
        {
            Clear();
            if (opcao == 1){
                Consulta(); 
            }
            else if (opcao == 2){
                Lista();
            }
            else if (opcao == 3){
                Inclui(); 
            }
            else if (opcao == 4){
                Altera();
            }
            else if (opcao == 5){
                 Exclui();
            }
        }

        private void MenuSelecionado(ConsoleKey opcao)
        {
            if (opcao == ConsoleKey.D1){
                Pagina(1);
            }
            else if (opcao == ConsoleKey.D2){
                Pagina(2);
            }
            else if (opcao == ConsoleKey.D3){
                Pagina(3);
            }
            else if (opcao == ConsoleKey.D4){
                Pagina(4);
            }
            else if (opcao == ConsoleKey.D5){
                Pagina(5);
            }
            else if (opcao == ConsoleKey.D0){
                Home();
            }
            Home();
        }

        public void Clear(){
            Console.Clear();
        }

        private void Inclui(){
            Pessoa pessoa = new Pessoa();
            Console.WriteLine("Cadastrar:");
            Console.WriteLine("Tipo [J]urídica [F]ísica: ");
            pessoa.setTipo(Console.ReadLine());
            Console.WriteLine("Nome: ");
            pessoa.setNome(Console.ReadLine());            
            listaPessoa.Add(pessoa);

            Console.WriteLine("Pessoa inserida com sucesso!");
            Console.WriteLine("Pressione ENTER para voltar...");
            opcao = Console.ReadKey();
        }

        private void Lista()
        {

            foreach (Pessoa pes in listaPessoa)
            {
                Console.WriteLine("Tipo: " + pes.getTipo());
                Console.WriteLine("Nome: " + pes.getNome());
                Console.WriteLine(" ");
            }

            Console.WriteLine("Pressione ENTER para voltar...");
            opcao = Console.ReadKey();
        }

        private void Consulta()
        {
            Console.WriteLine("Digite o nome da pessoa a ser consultada:");
            nome = Console.ReadLine();
            flag = 0;
            foreach (Pessoa pes in listaPessoa)
            {
                if (pes.getNome() == nome)
                {
                    flag = 1;
                    Console.WriteLine("Tipo: " + pes.getTipo());
                    Console.WriteLine("Nome: " + pes.getNome());
                }
            }
            if (flag == 0)
            {
                Console.WriteLine("Nome não encontrado!");
            }
            
            Console.WriteLine("Pressione ENTER para voltar...");
            opcao = Console.ReadKey();
        }

        private void Altera(){
            Console.WriteLine("Digite o nome da pessoa que os dados serão alterados: ");
            nome = Console.ReadLine();
            flag = 0;
            foreach (Pessoa pes in listaPessoa){
                if (pes.getNome() == nome){
                    flag = 1;
                    Console.WriteLine("Tipo: " + pes.getTipo());
                    Console.WriteLine("Novo Tipo");
                    pes.setTipo(Console.ReadLine());
                    Console.WriteLine("Nome: " + pes.getNome());
                    Console.WriteLine("Novo Nome");
                    pes.setNome(Console.ReadLine());                    
                }
            }
            if (flag == 0){
                Console.WriteLine("Nome não encontrado!");
            }

            Console.WriteLine("Alteração realizada com sucesso!");
            Console.WriteLine("Pressione ENTER para voltar...");
            opcao = Console.ReadKey();
        }

        private void Exclui(){
            Console.WriteLine("Digite o nome da pessoa a ser excluído: ");
            nome = Console.ReadLine();
            flag = 0;
            foreach (Pessoa pes in listaPessoa){
                if (pes.getNome() == nome){
                    flag = 1;
                }
            }

            if (flag == 1){
                listaPessoa.RemoveAll(x => x.getNome() == nome);
                Console.WriteLine("Pessoa excluída com sucesso.");
            }
            else{
                Console.WriteLine("Nome não encontrado!");
            }

            Console.WriteLine("Pressione ENTER para voltar...");
            opcao = Console.ReadKey();
        }    

    }
}
