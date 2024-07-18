namespace EFCorePractise.Entities;

public interface ITimeSpan
{
    public DateTime CreatedDate { get; set; }
    public DateTime? UpdatedDate { get; set; }
    public DateTime? DeletedTime { get; set; }
}


