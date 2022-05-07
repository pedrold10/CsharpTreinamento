namespace Aleatorio{
    public class Marca{
        public Marca(int MarcaId, string Nome){
            this.MarcaId = MarcaId;
            this.Nome = Nome;
        }   
        public int MarcaId { get; set; }

        public string Nome { get; set; }
    }
}