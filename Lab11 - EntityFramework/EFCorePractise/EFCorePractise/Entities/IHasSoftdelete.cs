namespace EFCorePractise.Entities;

internal interface IHasSoftdelete
{
    public bool IsDeleted { get; set; }

    void ChangeIsDeleteStatus()
    {
        IsDeleted = true;
    }
}
