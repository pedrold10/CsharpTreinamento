using System;

namespace EatFood{
    public class Program{
        public static void Main(string[] args){

            Cardapio cardapio = new Cardapio();
            string pizza_imagem = "                         ___\n                         |  ~~--.\n                         |%=@%%/\n                         |o%%%/\n                      __ |%%o/\n                _,--~~ | |(_/ ._\n             ,/'  m%%%%| |o/ /  `.\n            /' m%%o(_)%| |/ /o%%m `\n          /' %%@=%o%%%o|   /(_)o%%% `\n         /  %o%%%%%=@%%|  /%%o%%@=%%  \n        |  (_)%(_)%%o%%| /%%%=@(_)%%%  |\n        | %%o%%%%o%%%(_|/%o%%o%%%%o%%% |\n        | %%o%(_)%%%%%o%(_)%%%o%%o%o%% |\n        |  (_)%%=@%(_)%o%o%%(_)%o(_)%  |\n          ~%%o%%%%%o%o%=@%%o%%@%%o%~ /\n          . ~o%%(_)%%%o%(_)%%(_)o~ ,/\n            _ ~o%=@%(_)%o%%(_)%~ _/\n              `_~~o%%%o%%%%%~~_/'\n                 `--..____,,--";
            string hotdog_imagem = "          ______________\n       .-`              `-.\n      (____________________)\n       (                  )\n       (`----------------`)\n       `------------------´\n       ";
            Prato pizza = new Prato("Pizza", pizza_imagem, 1, "Borda recheada, tomate, calabreza", 35.0);
            Prato hotdog = new Prato("Hot-Dog", hotdog_imagem, 2, "Pão, salsicha, batata-palha", 10.5);
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

