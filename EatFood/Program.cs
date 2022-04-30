using System;

namespace EatFood{
    public class Program{
        public static void Main(string[] args){
            Cardapio cardapio = new Cardapio();
            
            Prato pizza = new Prato("Pizza", "../Imagens/Pizza.jpg", 1, "Borda recheada, tomate, calabreza", 35.0);
            Prato hotdog = new Prato("Hot-Dog", "../Imagens/Hotdog.png", 2, "Pão, salsicha, batata-palha", 10.5);
            cardapio.addPrato(pizza);
            cardapio.addPrato(hotdog);

            Console.WriteLine(cardapio.menu());
            Pedido pedido = new Pedido();
            string codigo = "";
            while(codigo!="0"){
                Console.WriteLine("Insira seu pedido(0 pra parar):");
                codigo = Console.ReadLine();
                pedido.fazerPedido(codigo, cardapio);
            }
            
        }
    }
}

