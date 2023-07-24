using ProtoBuf;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ECM.Repo.Domain
{
    public class EntityBase : IEntityBase
    {

        [ProtoMember(1000)]
        [Key]
        public Guid Id { get; set; }
        public DateTime CreatedOn { get; set; } = DateTime.Now;

        [Required]
        public string CreatedBy { get; set; } = string.Empty;

        public DateTime ModifiedOn { get; set; } = DateTime.Now;

        [Required]
        public string ModifiedBy { get; set; } = string.Empty;

    }
}
