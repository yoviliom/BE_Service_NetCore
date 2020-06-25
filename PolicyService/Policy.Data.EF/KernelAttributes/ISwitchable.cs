using Policy.Data.KernelEnum;

namespace Policy.Data.KernelAttributes
{
    public interface ISwitchable
    {
        Status Status { get; set; }
    }
}