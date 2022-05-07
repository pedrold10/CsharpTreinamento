namespace Aleatorio{
    public class RepositorioDeCarros{
        public RepositorioDeCarros(){
            Carros = new List<Carro>();
        }
        
        private Contexto _contexto;

        public List<Carro> Carros { get; set; }
        public void Adicionar(Carro carro){
            _contexto.Carros.Add(carro);
        }
        public Carro Find(string chassi){
            return _contexto.Carros
                   .FirstOrDefault(x=> x.Chassi == chassi);
        }
        public void Persistir(){
            _contexto.Carros.Add();
        }
    }
}


