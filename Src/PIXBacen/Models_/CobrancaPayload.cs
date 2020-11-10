namespace PIXBacen
{
    public class CobrancaPayload
    {
        public Calendario Calendario { get; set; }

        public Pessoa Devedor { get; set; }

        public Pessoa Recebedor { get; set; }

        public string TxId { get; set; }

        public string Revisao { get; set; }

        public Loc Loc { get; set; }

        public string Status { get; set; }

        public Valor Valor { get; set; }

        public string Chave { get; set; }
        public string SolicitacaoPagador { get; set; }

        public InfoAdicional[] InfoAdicionais { get; set; }

        public Pix[] Pix { get; set; }
    }
}
