namespace PIXBacen
{
    public class Devolucao
    {
        public string Id { get; set; }

        public string RtrId { get; set; }

        public decimal Valor { get; set; }

        public Horario Horario { get; set; }

        public string Status { get; set; }
    }
}
