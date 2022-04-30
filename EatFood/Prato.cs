using System;
using System.Collections.Generic;

namespace EatFood{
    public class Prato
    {
        public string foto{ get; set; }
        public string nome{ get; set; }
        public int codigo{ get; set; }
        public string composicao{ get; set; }
        public double preco{ get; set; }

        public Prato( string nome, string foto, int codigo, string composicao, double preco){
            this.nome = nome;
            this.foto = foto;
            this.codigo = codigo;
            this.composicao = composicao;
            this.preco = preco;
        }

        public double getPreco(){
            return this.preco;
        }
    }

}