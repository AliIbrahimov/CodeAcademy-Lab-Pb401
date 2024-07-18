namespace EFCorePractise.Entities;

internal class Comment : AuitableEntity<Guid>
{
    public string Content { get; set; }
    public int PostId { get; set; }
    public Post Post { get; set; }
}
