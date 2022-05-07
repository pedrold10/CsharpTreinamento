namespace Aleatorio{
    public class RepositorioDeCarros{
        public RepositorioDeCarros(){
            Carros = new List<Carro>();
        }
        public List<Carro> Carros { get; set; }
        public void Adicionar(Carro carro){
            Carros.Add(carro);
        }
        public Carro Find(string chassi){
            return Carros
                   .FirstOrDefault(x=> x.Chassi == chassi);
        }
    }
}


