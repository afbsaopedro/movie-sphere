using MovieSphere.Models;

namespace MovieSphere.Dto
{
    public record Feed(
        ICollection<FeedItem> Items
    );

    public record FeedItem(
        FeedItemType Type,
        dynamic Value,
        ApplicationUser User,
        Movie Movie,
        DateTime CreatedAt
    );

    public enum FeedItemType
    {
        Rating,
        Review
    }
}