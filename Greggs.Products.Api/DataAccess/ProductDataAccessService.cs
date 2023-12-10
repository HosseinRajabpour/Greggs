using System.Collections.Generic;
using Greggs.Products.Api.Models;
using System.Linq;

namespace Greggs.Products.Api.DataAccess
{
    // ProductDataAccessService.cs
public class ProductDataAccessService : IDataAccess<Product>
{
    private readonly IEnumerable<Product> _products;
    private readonly CurrencyService _currencyService;

    public ProductDataAccessService(IEnumerable<Product> products, CurrencyService currencyService)
    {
        _products = products;
        _currencyService = currencyService;
    }

    public IEnumerable<Product> GetLatestProducts()
    {
        foreach (var product in _products)
        {
            // Convert price to Euros
            product.PriceInEuros = _currencyService.ConvertToEuros(product.PriceInPounds);
        }

        return _products;
    }

    // Other methods as needed
}}
