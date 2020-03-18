using CodeFisrtCuoiKy.DAL;
using CodeFisrtCuoiKy.DTO;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeFisrtCuoiKy.BLL
{
    class CodeFirstQLSV_BLL
    {
        CodeFirstQLSV_DAL cfdal { get; set; }

        public CodeFirstQLSV_BLL()
        {
            cfdal = new CodeFirstQLSV_DAL();
        }
        public List<SV> Show_BLL()
        {
            //var query = (from a in cfdal.SVs
            //             join b in cfdal.KHOAs
            //             on a.ID_KHOA equals b.ID_KHOA
            //             select new
            //             {
            //                 a.Name,
            //                 a.MSSV,
            //                 a.ID_KHOA,
            //                 b.name_Khoa
            //             });
            //return query;

            var query = from sv in cfdal.SVs.AsEnumerable()
                        select sv;
            return query.ToList();
        }
        public void delete_BLL(SV sv)
        {
            SV delSV = cfdal.SVs.Where(p => p.MSSV == sv.MSSV).FirstOrDefault();
            cfdal.SVs.Remove(sv);
            cfdal.SaveChanges();
        }
        public void add_BLL(SV sv)
        {
            cfdal.SVs.Add(new SV() { MSSV = sv.MSSV, Name = sv.Name, ID_KHOA = sv.ID_KHOA });
            cfdal.KHOAs.Add(new KHOA() { ID_KHOA = sv.ID_KHOA });
            cfdal.SaveChanges();
        }

        public void update_BLL(SV sv)
        {
            SV upSV = cfdal.SVs.Where(p => p.MSSV == sv.MSSV).FirstOrDefault();
            upSV.Name = sv.Name;
            upSV.MSSV = sv.MSSV;
            upSV.ID_KHOA = sv.ID_KHOA;
            upSV.khoa.name_Khoa = "IT";
            cfdal.SaveChanges();
        }
        public List<SV> search_BLL(string s)
        {
            var x = from p in cfdal.SVs
                    where p.MSSV == s || p.ID_KHOA == s || p.Name == s
                    select p;
            return x.ToList();
        }

        public List<SV> sort_BLL(string s)
        {
            var x = new List<SV>();
            if (s == "HoTen")
            {
                x = cfdal.SVs.OrderBy(p => p.Name).ToList();
            }
            else if (s == "MSSV")
            {
                x = cfdal.SVs.OrderBy(p => p.MSSV).ToList();
            }
            else if (s == "ID_KHOA")
            {
                x = cfdal.SVs.OrderBy(p => p.ID_KHOA).ToList();
            }
            return x.ToList();
        }
    }
}
