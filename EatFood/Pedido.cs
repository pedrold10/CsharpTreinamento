using System;
using System.Collections.Generic;

namespace EatFood{
    public class Pedido{
        public List<Prato> Pedidos{ get; set; } = new List<Prato>();
        public void addPrato(Prato prato){
                Pedidos.Add(
                    new Prato(
                        prato.nome, 
                        prato.foto,
                        prato.codigo,
                        prato.composicao,
                        prato.preco
                    )     
                );
            }
        public string pedido(){
            
            DateTime dt = new DateTime(2022, 4, 26);
            int itensDoPedido = 0;
            string pedidos = "";
            double subtotal = 0;
            foreach(Prato prato in Pedidos){
                if(dt.DayOfWeek==DayOfWeek.Tuesday){
                    if(itensDoPedido==2)
                        subtotal+=prato.preco/2;
                    else 
                        subtotal+=prato.preco;
                }
                itensDoPedido+=1;
                pedidos += $"Prato: {prato.nome}\nPreço: R${prato.preco} \n-------------\n";
            }
            return $"{pedidos}\nSubtotal: R${subtotal}";
        }

        public void fazerPedido(string codigo, Cardapio cardapio){
            int codigo_int = Convert.ToInt32(codigo);
            if(codigo_int!=0){
                string saida = "";
                foreach(Prato prato in cardapio.Pratos){
                        if (codigo_int==prato.codigo){
                            this.addPrato(cardapio.getPrato(prato));
                            
                        }
                        else if(codigo_int>cardapio.Pratos.Count)
                            saida = $"Número {codigo_int} Inválido";
                }
                Console.WriteLine(saida);
            }
            else 
                Console.WriteLine(this.pedido());
        }
    }
}
