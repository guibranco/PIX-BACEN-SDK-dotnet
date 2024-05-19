namespace PIXBacen
{
    using System;

    public class Pix
    {
        public string EndToEndId { get; set; }
        public string TxId { get; set; }

        public decimal Valor { get; set; }

        public DateTime Horario { get; set; }
        public string InfoPagador { get; set; }

        public Devolucao[] Devolucoes { get; set; }
    }
}