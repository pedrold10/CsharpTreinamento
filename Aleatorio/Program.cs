
namespace Aleatorio{
    class Program{
        static void Main(string[] args){
            RepositorioDeCarros repositorioDeCarros = new RepositorioDeCarros();

            Carro Ka = new Carro();
            Ka.Ano = 2022;
            Ka.Cor = Cor.Branco;
            Ka.Modelo = "Ka";
            Ka.Chassi = "112";
            Ka.Placa = "AGJ7829";
            Ka.Marca = new Marca(1, "Ford");

            repositorioDeCarros.Adicionar(Ka);
            //Console.WriteLine(Ka);

            Carro Fiesta = new Carro();
            Fiesta.Ano = 2022;
            Fiesta.Cor = Cor.Branco;
            Fiesta.Modelo = "Fiesta";
            Fiesta.Chassi = "113";
            Fiesta.Placa = "AGJ7329";
            Fiesta.Marca = new Marca(1, "Ford");
            
            repositorioDeCarros.Adicionar(Fiesta);
            //Console.WriteLine(Fiesta);
            while(true){
                Console.Write("Informe um chassi para busca:");
                var chassiParaBusca = Console.ReadLine();
                var carroParaBusca = repositorioDeCarros.Find(chassiParaBusca);
                Console.WriteLine(carroParaBusca);
            }
        }
    }
}
      