namespace Policy.Data.KernelAttributes
{
    public interface IHasSoftDelete
    {
        bool IsDeleted { get; set; }
    }
}