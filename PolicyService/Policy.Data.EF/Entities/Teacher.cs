using Policy.Data.KernelAttributes;
using Policy.Data.KernelEnum;
using Policy.Infrastructure.DomainEntity;
using System;
using System.ComponentModel.DataAnnotations.Schema;

namespace Policy.Data.Entities
{
    [Table("Teacher")]
    public class Teacher : DomainEntity<string>, IDateTracking, IHasSoftDelete, IHasUserTracking<long>, ISwitchable
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public Status Status { get; set; }

        public string Code { get; set; }
        public string AddressId { get; set; }
        public string Fullname { get; set; }
        public DateTime? BirthDate { get; set; }
        public string Mobile { get; set; }

        public Teacher()
        {
            Status = Status.InActive;
        }
    }
}
