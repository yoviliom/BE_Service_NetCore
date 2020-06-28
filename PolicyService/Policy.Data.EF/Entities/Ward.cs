using Policy.Data.KernelAttributes;
using Policy.Data.KernelEnum;
using Policy.Infrastructure.DomainEntity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Policy.Data.Entities
{
    [Table("Ward")]
    public class Ward : DomainEntity<string>, IDateTracking, IHasSoftDelete, IHasUserTracking<long>, ISwitchable
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public Status Status { get; set; }

        public string Name { get; set; }
        public string DistrictId { get; set; }

        public Ward()
        {
            Status = Status.InActive;
        }
    }
}
