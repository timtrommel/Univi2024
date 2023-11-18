using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Univi.Shared
{
    public class KindofMalfunction
    {
        [Key]
        public int Id { get; set; }
        public string? Kindof { get; set; }
    }
}
