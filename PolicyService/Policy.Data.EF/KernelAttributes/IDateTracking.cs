using System;

namespace Policy.Data.KernelAttributes
{
    public interface IDateTracking
    {
        DateTime? CreatedDate { get; set; }
        DateTime? UpdatedDate { get; set; }
    }
}