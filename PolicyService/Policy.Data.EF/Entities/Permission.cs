using Policy.Data.KernelAttributes;
using Policy.Data.KernelEnum;
using Policy.Infrastructure.DomainEntity;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Text;

namespace Policy.Data.Entities
{
    [Table("Permission")]
    public class Permission : DomainEntity<string>, IDateTracking, IHasSoftDelete, IHasUserTracking<long>, ISwitchable
    {
        public DateTime? CreatedDate { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public bool IsDeleted { get; set; }
        public long CreatedBy { get; set; }
        public long UpdatedBy { get; set; }
        public Status Status { get; set; }

        public string Code { get; set; }
        public int UserType { get; set; }

        public Permission()
        {
            Status = Status.InActive;
        }

    }
}
