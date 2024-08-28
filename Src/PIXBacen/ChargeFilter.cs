namespace PIXBacen
{
    using System;

    public class ChargeFilter
    {
        public DateTime Inicio { get; set; }

        public DateTime Fim { get; set; }

        public string Cpf { get; set; }

        public string Cnpj { get; set; }

        public bool LocationPresente { get; set; }

        public string Status { get; set; }
        public int PaginaAtual { get; set; }

        public int ItensPorPagina { get; set; }
    }
}
