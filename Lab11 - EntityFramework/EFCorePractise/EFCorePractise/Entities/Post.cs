namespace EFCorePractise.Entities;

internal class Post : AuitableEntity<int>, IHasSoftdelete
{
    public string Title { get; set; }
    public string Content { get; set; }
    public ICollection<Comment> Comments { get; set; }
    public bool IsDeleted { get; set; }

    public Post()
    {
      
        Comments = new List<Comment>();
    }
}
