namespace PIXBacen
{
    using System;

    public class Calendario
    {
        public DateTime Criacao { get; set; }

        public DateTime Apresentacao { get; set; }

        public long Expiracao { get; set; }

        public DateTime DataDeVencimento { get; set; }

        public long ValidadeAposVencimento { get; set; }
    }
}