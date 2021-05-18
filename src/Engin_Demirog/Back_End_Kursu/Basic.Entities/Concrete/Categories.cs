
using System.ComponentModel.DataAnnotations;

using Basic.Core.Entities;

namespace Basic.Entities.Concrete
{
    public class Categories : IEntity
    {
        [Key]
        public int CategoryID { get; set; }

        public string CategoryName { get; set; }

        public string Description { get; set; }

        public byte[] Picture { get; set; }
    }
}
