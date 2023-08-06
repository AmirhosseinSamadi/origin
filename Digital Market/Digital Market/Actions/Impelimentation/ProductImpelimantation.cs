using Digital_Market.Actions.Interfaces;
using Digital_Market.Models.Product;

namespace Digital_Market.Actions.Impelimentation
{
    public class ProductImpelimantation : IProductInterface , IGeneralInterface<ProductModel>
    {
        #region CustomMethod
        public void AddToFavorite(ProductModel pruduct)
        {
            //Add To Favorite
        }

        public void BuyProduct(ProductModel pruduct)
        {
            //Buy Product
        }
        #endregion

        #region GenericMethod
        void IGeneralInterface<ProductModel>.Add(ProductModel item)
        {

        }

        void IGeneralInterface<ProductModel>.Edit(ProductModel item)
        {

        }

        void IGeneralInterface<ProductModel>.Remove(ProductModel item)
        {

        }
        #endregion
    }
}
