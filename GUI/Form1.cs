using CodeFisrtCuoiKy.BLL;
using CodeFisrtCuoiKy.DAL;
using CodeFisrtCuoiKy.DTO;
using ExcelDataReader;
using OfficeOpenXml;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Z.Dapper.Plus;
using static CodeFisrtCuoiKy.Program;
using static System.Net.WebRequestMethods;
using File = System.IO.File;

namespace CodeFisrtCuoiKy
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        CodeFirstQLSV_DAL cfdal = new CodeFirstQLSV_DAL();

        private void btn_Show_Click(object sender, EventArgs e)
        {
            CodeFirstQLSV_BLL bll = new CodeFirstQLSV_BLL();
            datagr_1.DataSource = bll.Show_BLL();
        }

        private void btn_Delete_Click(object sender, EventArgs e)
        {
            CodeFirstQLSV_BLL bll = new CodeFirstQLSV_BLL();
            bll.delete_BLL(getSV());

            btn_Show_Click(sender, e);
        }
        public SV getSV()
        {
            SV newSV = new SV();
            newSV.MSSV = txtbox_MSSV.Text;
            newSV.Name = txtbox_HoTen.Text;
            newSV.ID_KHOA = txtbox_IDKhoa.Text;
            //newSV.khoa.name_Khoa = txtbox_TenKhoa.Text;
            return newSV;
        }

        private void datagr_1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            string s = datagr_1.Rows[e.RowIndex].Cells[0].Value.ToString();

            SV newSV = cfdal.SVs.Where(p => p.MSSV == s).FirstOrDefault();
            txtbox_MSSV.Text = newSV.MSSV;
            txtbox_HoTen.Text = newSV.Name;
            txtbox_IDKhoa.Text = newSV.ID_KHOA;
            txtbox_TenKhoa.Text = newSV.khoa.name_Khoa;
        }

        private void btn_Add_Click(object sender, EventArgs e)
        {
            CodeFirstQLSV_BLL bll = new CodeFirstQLSV_BLL();
            bll.add_BLL(getSV());
            btn_Show_Click(sender, e);
        }

        private void btn_Update_Click(object sender, EventArgs e)
        {
            CodeFirstQLSV_BLL bll = new CodeFirstQLSV_BLL();
            bll.update_BLL(getSV());
            btn_Show_Click(sender, e);
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            CodeFirstQLSV_BLL bll = new CodeFirstQLSV_BLL();
            datagr_1.DataSource = bll.search_BLL(txtBox_Search.Text);
        }

        private void btn_Sort_Click(object sender, EventArgs e)
        {
            CodeFirstQLSV_BLL bll = new CodeFirstQLSV_BLL();
            try
            {
                datagr_1.DataSource = bll.sort_BLL(cbBox_Sort.Text);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btn_Import_Click_1(object sender, EventArgs e)
        {
            // tạo ra danh sách UserInfo rỗng để hứng dữ liệu.
            List<UserInfo> userList = new List<UserInfo>();
            try
            {
                // mở file excel
                var package = new ExcelPackage(new FileInfo("TestImportC#.xlsx"));

                // lấy ra sheet đầu tiên để thao tác
                ExcelWorksheet workSheet = package.Workbook.Worksheets[1];

                // duyệt tuần tự từ dòng thứ 2 đến dòng cuối cùng của file. lưu ý file excel bắt đầu từ số 1 không phải số 0
                for (int i = workSheet.Dimension.Start.Row + 1; i <= workSheet.Dimension.End.Row; i++)
                {
                    try
                    {
                        // biến j biểu thị cho một column trong file
                        int j = 1;

                        // lấy ra cột MSSV tương ứng giá trị tại vị trí [i, 1]. i lần đầu là 2
                        // tăng j lên 1 đơn vị sau khi thực hiện xong câu lệnh
                        string mssv = workSheet.Cells[i, j++].Value.ToString();
                        string name = workSheet.Cells[i, j++].Value.ToString();
                        string id_khoa = workSheet.Cells[i, j++].Value.ToString();
                        string khoa = workSheet.Cells[i, j++].Value.ToString();

                        // tạo UserInfo từ dữ liệu đã lấy được
                        UserInfo user = new UserInfo()
                        {
                            MSSV = mssv,
                            Name = name,
                            ID_KHOA = id_khoa,
                        };
                        user.name_Khoa = khoa;
                        // add UserInfo vào danh sách userList
                        userList.Add(user);

                    }
                    catch (Exception exe)
                    {

                    }
                }
            }
            catch (Exception ee)
            {
                MessageBox.Show("Error!");
            }

            datagr_1.DataSource = userList;
        }

        private void cbbox_import2_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataTable dt = tableCollection[cbbox_import2.SelectedItem.ToString()];
            //datagr_1.DataSource = dt;
            if (dt != null)
            {
                List<SVexceltoSQL> SVs = new List<SVexceltoSQL>();
                for (int i = 0; i < dt.Rows.Count; i++)
                {
                    SVexceltoSQL sv = new SVexceltoSQL();
                    sv.MSSV = dt.Rows[i][0].ToString();
                    sv.Name = dt.Rows[i][1].ToString();
                    sv.ID_KHOA = dt.Rows[i][2].ToString();
                    //sv.name_Khoa = dt.Rows[i][3].ToString();
                    SVs.Add(sv);
                    
                }
                datagr_1.DataSource = SVs;
            }
        }

        DataTableCollection tableCollection;

        private void btn_Import2_Click(object sender, EventArgs e)
        {
            try
            {
                string connectionString = @"Data Source=PC-20161209ULNU\SQLEXPRESS;Initial Catalog=DBdemoExcel;User ID=sa;Password=123456";

                DapperPlusManager.Entity<KHOA>().Table("KHOAs");
                List<KHOA> khoas = datagr_1.DataSource as List<KHOA>;
                if (khoas != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(khoas);
                    }
                }

                DapperPlusManager.Entity<SVexceltoSQL>().Table("SVs");
                List<SVexceltoSQL> svs = datagr_1.DataSource as List<SVexceltoSQL>;
                if (svs != null)
                {
                    using (IDbConnection db = new SqlConnection(connectionString))
                    {
                        db.BulkInsert(svs);
                    }
                }
                MessageBox.Show("FINISH !!!");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Message" , MessageBoxButtons.OK, MessageBoxIcon.Warning);
                //throw;
            }
        }

        private void btn_FileExcel_Click(object sender, EventArgs e)
        {
            using (OpenFileDialog openFileDialog = new OpenFileDialog() { Filter = "TestImportC#|*.xlsx" })
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    txtBox_FileExcel.Text = openFileDialog.FileName;
                    using (var stream = File.Open(openFileDialog.FileName, FileMode.Open, FileAccess.Read))
                    {
                        using (IExcelDataReader reader = ExcelReaderFactory.CreateReader(stream))
                        {
                            DataSet result = reader.AsDataSet(new ExcelDataSetConfiguration()
                            {
                                ConfigureDataTable = (_) => new ExcelDataTableConfiguration() { UseHeaderRow = true }
                            });
                            tableCollection = result.Tables;
                            cbbox_import2.Items.Clear();
                            foreach (DataTable item in tableCollection)
                            {
                                cbbox_import2.Items.Add(item.TableName);
                            }
                        }
                    }
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'dBexcelDEMO1DataSet.SVs' table. You can move, or remove it, as needed.
            this.sVsTableAdapter.Fill(this.dBexcelDEMO1DataSet.SVs);
            // TODO: This line of code loads data into the 'dBexcelDEMO1DataSet.KHOAs' table. You can move, or remove it, as needed.
            this.kHOAsTableAdapter.Fill(this.dBexcelDEMO1DataSet.KHOAs);

        }

        //private void btn_Export_Click_1(object sender, EventArgs e)
        //{
        //    string filePath = "";
        //    // tạo SaveFileDialog để lưu file excel
        //    SaveFileDialog dialog = new SaveFileDialog();

        //    // chỉ lọc ra các file có định dạng Excel
        //    dialog.Filter = "Excel | *.xlsx | Excel 2003 | *.xls";

        //    // Nếu mở file và chọn nơi lưu file thành công sẽ lưu đường dẫn lại dùng
        //    if (dialog.ShowDialog().Equals(true))
        //    {
        //        filePath = dialog.FileName;
        //        MessageBox.Show("Da luu filepath");
        //    }
        //    filePath = dialog.FileName;

        //    // nếu đường dẫn null hoặc rỗng thì báo không hợp lệ và return hàm
        //    if (string.IsNullOrEmpty(filePath))
        //    {
        //        MessageBox.Show("Đường dẫn báo cáo không hợp lệ");
        //        return;
        //    }

        //    try
        //    {
        //        using (ExcelPackage p = new ExcelPackage())
        //        {
        //            // đặt tên người tạo file
        //            p.Workbook.Properties.Author = "Kteam by K9";

        //            // đặt tiêu đề cho file
        //            p.Workbook.Properties.Title = "Báo cáo thống kê";

        //            //Tạo một sheet để làm việc trên đó
        //            p.Workbook.Worksheets.Add("Kteam sheet");

        //            // lấy sheet vừa add ra để thao tác
        //            ExcelWorksheet ws = p.Workbook.Worksheets[1];

        //            // đặt tên cho sheet
        //            ws.Name = "Kteam sheet";
        //            // fontsize mặc định cho cả sheet
        //            ws.Cells.Style.Font.Size = 11;
        //            // font family mặc định cho cả sheet
        //            ws.Cells.Style.Font.Name = "Calibri";

        //            // Tạo danh sách các column header
        //            string[] arrColumnHeader = {
        //                                        "Họ tên",
        //                                        "Năm sinh"
        //        };

        //            // lấy ra số lượng cột cần dùng dựa vào số lượng header
        //            var countColHeader = arrColumnHeader.Count();

        //            // merge các column lại từ column 1 đến số column header
        //            // gán giá trị cho cell vừa merge là Thống kê thông tni User Kteam
        //            ws.Cells[1, 1].Value = "Thống kê thông tin User Kteam";
        //            ws.Cells[1, 1, 1, countColHeader].Merge = true;
        //            // in đậm
        //            ws.Cells[1, 1, 1, countColHeader].Style.Font.Bold = true;
        //            // căn giữa
        //            ws.Cells[1, 1, 1, countColHeader].Style.HorizontalAlignment = ExcelHorizontalAlignment.Center;

        //            int colIndex = 1;
        //            int rowIndex = 2;

        //            //tạo các header từ column header đã tạo từ bên trên
        //            foreach (var item in arrColumnHeader)
        //            {
        //                var cell = ws.Cells[rowIndex, colIndex];

        //                //set màu thành gray
        //                var fill = cell.Style.Fill;
        //                fill.PatternType = ExcelFillStyle.Solid;
        //                fill.BackgroundColor.SetColor(System.Drawing.Color.LightBlue);

        //                //căn chỉnh các border
        //                var border = cell.Style.Border;
        //                border.Bottom.Style =
        //                    border.Top.Style =
        //                    border.Left.Style =
        //                    border.Right.Style = ExcelBorderStyle.Thin;

        //                //gán giá trị
        //                cell.Value = item;

        //                colIndex++;
        //            }

        //            // lấy ra danh sách UserInfo từ ItemSource của DataGrid
        //            List<UserInfo> userList = new List<UserInfo>();
        //            foreach (DataGridViewRow itemRow in datagr_1.Rows)
        //            {
        //                UserInfo user = new UserInfo()
        //                {
        //                    Name = itemRow.Cells[0].Value.ToString(),
        //                    Birthday = (DateTime)itemRow.Cells[1].Value,
        //                };
        //                userList.Add(user);
        //            }

        //            //List<UserInfo> userList = dtgExcel.ItemsSource.Cast<UserInfo>().ToList();

        //            // với mỗi item trong danh sách sẽ ghi trên 1 dòng
        //            foreach (var item in userList)
        //            {
        //                // bắt đầu ghi từ cột 1. Excel bắt đầu từ 1 không phải từ 0
        //                colIndex = 1;

        //                // rowIndex tương ứng từng dòng dữ liệu
        //                rowIndex++;

        //                //gán giá trị cho từng cell                      
        //                ws.Cells[rowIndex, colIndex++].Value = item.Name;

        //                // lưu ý phải .ToShortDateString để dữ liệu khi in ra Excel là ngày như ta vẫn thấy.Nếu không sẽ ra tổng số :v
        //                ws.Cells[rowIndex, colIndex++].Value = item.Birthday.ToShortDateString();

        //            }

        //            //Lưu file lại
        //            Byte[] bin = p.GetAsByteArray();
        //            File.WriteAllBytes(filePath, bin);
        //        }
        //        MessageBox.Show("Xuất excel thành công!");
        //    }
        //    catch (Exception EE)
        //    {
        //        MessageBox.Show("Có lỗi khi lưu file!");
        //    }
        //}
    }
}
