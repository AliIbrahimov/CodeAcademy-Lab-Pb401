namespace EFCorePractise.Entities;

public abstract class AuitableEntity<TId> : ITimeSpan
{
    public TId Id { get; set; }
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedTime { get; set; }

    protected AuitableEntity()
    {
        Id = default(TId);
    }
    protected AuitableEntity(TId id)
    {
        Id = id;
    }
}
