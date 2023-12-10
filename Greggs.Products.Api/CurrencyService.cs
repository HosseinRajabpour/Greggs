
public class CurrencyService
{
    private readonly decimal _exchangeRate;

    public CurrencyService(decimal exchangeRate)
    {
        _exchangeRate = exchangeRate;
    }

    public decimal ConvertToEuros(decimal priceInGBP)
    {
        return priceInGBP * _exchangeRate;
    }
}
