public class CartaoDebito
{
    public CartaoDebito()
    {
        Bandeira = BandeiraCartao.Visa;
    }

    public string Numero { get; set; }
    public BandeiraCartao Bandeira { get; set; }
    public DateTime Vencimento { get; set; }
    public string Portador { get; set; }
    public string Cvv { get; set; }

    public class bool Debitar(decimal valor)
    {
        if (valor > saldo)
            return false;
    }

    public bool Debitar(decimal valor, bool usarLimite)
{
        if (usarLimite)
    {
         if (Valor <= (Saldo + limite))
        
    }    
}
}


public enum BandeiraCartao
{
    Visa,
    Mastercard,
    Amex,
    Elo
}