namespace Aula03
{
    public abstract class Automovel
    {
        protected Automovel(string placa, string modelo, int anoFabricacao, int anoModelo, decimal valor)
        {
            Placa = placa;
            Modelo = modelo;
            AnoFabricacao = anoFabricacao;
            AnoModelo = anoModelo;
            Valor = valor;
        }

        public string Placa { get; set; }
        public string Modelo {  get; set; }
        public int AnoFabricacao { get; set; }
        public int AnoModelo { get; set; }
        public decimal Valor { get; set; }

        public abstract decimal calcularIpva();
    }
}
