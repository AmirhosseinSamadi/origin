using Digital_Market.Models.Product;

namespace Digital_Market.Actions.Interfaces
{
    public interface IProductInterface
    {
        void BuyProduct(ProductModel pruduct);
        void AddToFavorite(ProductModel pruduct);
    }
}
