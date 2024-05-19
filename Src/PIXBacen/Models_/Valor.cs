namespace PIXBacen
{
    public class Valor
    {
        public decimal Original { get; set; }

        public Multa Multa { get; set; }

        public Juros Juros { get; set; }

        public Desconto Desconto { get; set; }

        public decimal Final { get; set; }
    }
}