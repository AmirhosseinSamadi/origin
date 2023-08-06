using Digital_Market.Models.Blog;

namespace Digital_Market.Actions.Interfaces
{
    public interface IBlogInterface
    {
        void AddComment(BlogModel Blog);
        void ShareBlog(string SocialMedia);
    }
}
