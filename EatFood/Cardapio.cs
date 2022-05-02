using System.Collections.Generic;
using System.Globalization;

namespace EatFood{
    public class Cardapio{
        public Cardapio(){

        }
        public List<Prato> Pratos{ get; set; } = new List<Prato>();
        public void addPrato(Prato prato){
            Pratos.Add(prato);
        }
        
        public string menu(){
            string pratos = "";
            foreach (Prato prato in Pratos)
                pratos += $"\n==============================\nCódigo: {prato.codigo} \nNome: {prato.nome}\nComposição: {prato.composicao}\nPreço: R${prato.preco}\n{prato.foto}\n";
            
            return pratos;
        }
        
        public Prato getPrato(Prato prato){
            return prato;
        }
    }
}