class PagamentoCartao : IPagamento
{
    public decimal ValorTrasacao {get; private set;}
    private string numeroCartao;
    {
        this.numeroCartao = numeroCartao;
    }
    public bool ProcessarPagamento(decimal valor)
    {
        ValorTransacao = valor;
        System.Console.WriteLine($"Processando pagamento de R$ {valor} no cartão {numeroCartao}");
        return true;
    }

    public string ObterComprovante()
    {
        return $"Coprovante Cartão: R$ {ValorTransacao}";
    }
    public void CancelarTransacao();
    {
        System.Console.WriteLine("Estornando valor no cartão");
    }
}