using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtCuoiKy.DTO
{
    public class SV
    {
        [Key]
        [Required]
        public string MSSV { get; set; }
        public string Name { get; set; }
        public string ID_KHOA { get; set; }

        [ForeignKey("ID_KHOA")]
        public virtual KHOA khoa { get; set; }
    }
}
