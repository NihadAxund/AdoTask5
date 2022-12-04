using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdoTask5.Models
{
    public class Group : BaseEntity
    {
        public int Rating { get; set; }

        public int Year { get; set; }
    }
}
