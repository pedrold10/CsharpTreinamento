namespace Aleatorio{
    public class Carro{
        public string Id{ get; set; }
        public string Modelo{ get; set; }
        public Cor Cor{ get; set; }
        public Marca Marca { get; set; }
        public int MarcaId{ get; set; }
        public int Ano { get; set; }
        public string Chassi { get; set; }
        public string Placa { get; set; }

        public override string ToString()
        {
            return $"=========\nAno: {this.Ano}\nCor: {this.Cor}\nModelo: {this.Modelo}\nMarca: {this.Marca.Nome}";
        }
    }
}