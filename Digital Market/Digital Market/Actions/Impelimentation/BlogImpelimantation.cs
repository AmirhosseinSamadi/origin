using Digital_Market.Actions.Interfaces;
using Digital_Market.Models.Blog;

namespace Digital_Market.Actions.Impelimentation
{
    public class BlogImpelimantation : IBlogInterface , IGeneralInterface<BlogModel>
    {
        #region CustomMethod
        public void AddComment(BlogModel Blog)
        {
            //Add Comment
        }

        public void ShareBlog(string SocialMedia)
        {
            //Share Blog
        }
        #endregion

        #region GenericMethod
        void IGeneralInterface<BlogModel>.Add(BlogModel item)
        {

        }

        void IGeneralInterface<BlogModel>.Edit(BlogModel item)
        {

        }

        void IGeneralInterface<BlogModel>.Remove(BlogModel item)
        {

        }
        #endregion
    }
}
