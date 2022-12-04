using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoTask5.Models
{
    public abstract class BaseEntity
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
