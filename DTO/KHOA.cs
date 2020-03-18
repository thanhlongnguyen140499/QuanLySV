using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtCuoiKy.DTO
{
    public class KHOA
    {
        [Key]
        [Required]
        public string ID_KHOA { get; set; }
        public string name_Khoa { get; set; }

        public virtual ICollection<SV> SVs { get; set; }
    }
}
