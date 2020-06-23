using System;
using System.Collections.Generic;

namespace Aula23_Sprint4_ListasDeObjetos
{
    class Program
    {
        static void Main(string[] args)
        {
            
            // Criamos uma nova lista do tipo "Produto"
            List<Produto> produtos = new List<Produto>();

            // Criamos um produto através do construtor padrão
            Produto produto1 = new Produto();
            produto1.Codigo = 1;
            produto1.Nome = "SmartTv LG";
            produto1.Preco = 2300.99f;

            //Adicionamos o produto criado na lista
            produtos.Add( produto1);

            //Adicionamos mais produtos utilizando o novo construtor
            produtos.Add(new Produto(2,"Geladeira Eletrolux", 6800f));
            produtos.Add(new Produto(3,"Microondas", 2800f));
            produtos.Add(new Produto(4,"Fogão Brastemp", 4800f));
            produtos.Add(new Produto(3,"Microondas", 2800f));
            produtos.Add(new Produto(5,"Xbox Series X", 16800f));
            produtos.Add(new Produto(6,"PS5", 16800f));

            // Varremos a Lista com foreach
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"R$ {item.Preco} - {item.Nome} ");
                Console.ResetColor();
            }
            System.Console.WriteLine();

            // Remover item passando o objeto como argumento
            produtos.Remove(produto1);
            

            //Remover item pelo índice
            produtos.RemoveAt(2);

            //Usamos expressão lambda para eliminar  um registro
            produtos.RemoveAll(y => y.Nome== "Microondas");

            //Varremos nossa lista depos que foi alterada
            foreach(Produto item in produtos)
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"R$ {item.Preco} - {item.Nome} ");
                Console.ResetColor();
            }

            System.Console.WriteLine();

            //Podemos encontrar um produto específico usando Lambda
            Produto ps5 = produtos.Find(x => x.Codigo ==6);
            Console.WriteLine("PS5 - R$ "+ps5.Preco);

            //Aplicar o complemento da atividade:
            Cartao mastercard = new Cartao();
            mastercard.Titular= "Marcos Alberto";
            mastercard.Numero= "3536626662626";
            mastercard.CVV="123";
            mastercard.Bandeira="MasterCard";

            Cartao elo = new Cartao("João alberto", "4242425116272", "132", "Elo");

            List<Cartao> cartoes = new List<Cartao>();
            cartoes.Add(mastercard);
            cartoes.Add(elo);
            cartoes.Add(new Cartao("Roberto alberto", "5428237823982", "432", "Cielo"));
            cartoes.Add(new Cartao("Gabriel Roberto", "968986823982", "542", "Visa"));

            foreach(Cartao cartiones in cartoes){
                Console.ForegroundColor = ConsoleColor.Red;
                System.Console.WriteLine($"O titular do cartão é {cartiones.Titular}, o número do cartão é {cartiones.Numero}, o CVV é {cartiones.CVV} e a bandeira é {cartiones.Bandeira}");
                Console.ResetColor();
            }

            cartoes.Remove(elo);
            produtos.RemoveAll(b => b.Nome== "Marcos Alberto");

            System.Console.WriteLine();

            foreach(Cartao cartiones in cartoes){
                Console.ForegroundColor = ConsoleColor.Green;
                System.Console.WriteLine($"O titular do cartão é {cartiones.Titular}, o número do cartão é {cartiones.Numero}, o CVV é {cartiones.CVV} e a bandeira é {cartiones.Bandeira}");
                Console.ResetColor();
            }


        }
    }
}
