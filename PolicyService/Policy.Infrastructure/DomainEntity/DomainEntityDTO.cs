namespace Policy.Infrastructure.DomainEntity
{
    public abstract class DomainEntityDTO<T>
    {
        public T Id { get; set; }

        public bool IsTransient()
        {
            return Id.Equals(default(T));
        }
    }
}