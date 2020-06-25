namespace Policy.Data.KernelAttributes
{
    public interface IHasUserTracking<T>
    {
        T CreatedBy { get; set; }
        T UpdatedBy { get; set; }
    }
}