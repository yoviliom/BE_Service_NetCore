using Policy.Data.KernelAttributes;
using Policy.Data.KernelEnum;
using Policy.Infrastructure.DomainEntity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Policy.Data.Entities
{
    [Table("Address")]
    public class Address : DomainEntity<string>, IDateTracking, IHasSoftDelete, IHasUserTracking<long>, ISwitchable
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public Status Status { get; set; }

        public string AddressDetails { get; set; }
        public long ProvinceOrCityId { get; set; }
        public long DistrictId { get; set; }
        public long WardId { get; set; }

        public Address()
        {
            Status = Status.InActive;
        }
    }
}