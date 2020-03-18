using CodeFisrtCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtCuoiKy.DAL
{
    class CreatDB : CreateDatabaseIfNotExists<CodeFirstQLSV_DAL>
    {
        public CreatDB crDB { get; set; }
        public CreatDB()
        {
        }

        protected override void Seed(CodeFirstQLSV_DAL context)
        {
            context.SVs.Add(new SV { MSSV = "1", Name = "Nguyen Van A ", ID_KHOA = "101" });
            context.SVs.Add(new SV { MSSV = "2", Name = "Nguyen Van B ", ID_KHOA = "102" });
            context.SVs.Add(new SV { MSSV = "3", Name = "Nguyen Van B ", ID_KHOA = "103" });
            context.KHOAs.Add(new KHOA { ID_KHOA = "102", name_Khoa = "IT" });
            context.KHOAs.Add(new KHOA { ID_KHOA = "101", name_Khoa = "IT" });
            context.KHOAs.Add(new KHOA { ID_KHOA = "103", name_Khoa = "IT" });

            // note : add ==) 1 SV --> 1 KHOA , n SV --> n KHOA
        }

    }
}
