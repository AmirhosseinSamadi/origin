using Digital_Market.Actions.Interfaces;
using Digital_Market.Models.User;

namespace Digital_Market.Actions.Impelimentation
{
    public class UserImpelimentation : IUserInterface , IGeneralInterface<UserModel>
    {
        #region CustomMethod
        public void ChageWallet(int Money)
        {
            //Chage Wallet
        }
        #endregion

        #region GeneralMethod
        void IGeneralInterface<UserModel>.Add(UserModel item)
        {

        }

        void IGeneralInterface<UserModel>.Edit(UserModel item)
        {

        }

        void IGeneralInterface<UserModel>.Remove(UserModel item)
        {

        }
        #endregion
    }
}
