using System;
using System.Collections.Generic;
using System.Text;

namespace Lotfi.OnlineShoping.Domain.Entities
{
    public class BaseEntity
    {
        public BaseEntity()
        {
            CreatedTime = DateTime.Now;
            UpdatedTime = DateTime.Now;
        }

        public int Id { get; set; }
        public DateTime CreatedTime { get; set; }
        public DateTime UpdatedTime { get; set; }
    }
}
