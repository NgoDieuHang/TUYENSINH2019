using Microsoft.Office.Interop.Excel;
using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Reflection;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using TS_2018.Controller;
using TS_2018.Model.Database;
using TS_2018.Model.Schema;
using Application = System.Windows.Forms.Application;

namespace TS_2018.View
{
    public partial class FormExport : Form
    {
        public USER CanBoUser;
        private readonly FuncSV _controllerSv;

        public FormExport()
        {
            InitializeComponent();
            _controllerSv = new FuncSV();
        }

        private void FormExport_Load(object sender, EventArgs e)
        {
            cbbBanThuHS.DataSource = _controllerSv.GetListUserWithoutAdmin();
            cbbBanThuHS.DisplayMember = "Username";
            cbbBanThuHS.ValueMember = "ID";
            cbbBuoi.SelectedIndex = 0;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            try
            {
                List<BienLaiExcel> listBienLai;
                if (checkExportAll.Checked)
                {
                    listBienLai = _controllerSv.GetListBienLaiExcel(Convert.ToInt32(cbbBanThuHS.SelectedValue), dateTimePicker.Value);
                }
                else
                {
                    listBienLai = _controllerSv.GetListBienLaiExcel(Convert.ToInt32(cbbBanThuHS.SelectedValue), dateTimePicker.Value, Convert.ToInt32(cbbBuoi.SelectedIndex));
                }

                if (listBienLai.Count < 1)
                {
                    MessageBox.Show("Danh sách biên lai rỗng", "Thông báo");
                    return;
                }
                string saveExcelFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\DataExport\" + dateTimePicker.Value.ToString("dd-MM-yyyy") + "_" + cbbBuoi.Text + "_" + cbbBanThuHS.Text + ".xlsx";
                if (checkExportAll.Checked)
                {
                    saveExcelFile = Path.GetDirectoryName(Application.ExecutablePath) + @"\DataExport\All_" + DateTime.Now.ToString("dd-MM-yyyy") + "_" + CanBoUser.Username + ".xlsx";
                }
                Microsoft.Office.Interop.Excel.Application xlApp = new Microsoft.Office.Interop.Excel.Application();

                xlApp.Visible = false;

                object misValue = Missing.Value;

                Workbook wb = xlApp.Workbooks.Add(misValue);

                Worksheet ws = (Worksheet)wb.Worksheets[1];

                if (ws == null)
                {
                    MessageBox.Show("Không thể tạo được WorkSheet");
                    return;
                }
                int row = 1;
                string fontName = "Times New Roman";
                int fontSizeTieuDe = 18;
                int fontSizeTenTruong = 14;
                int fontSizeNoiDung = 12;

                //Xuất dòng Tiêu đề của File báo cáo: Lưu ý
                Range row1TieuDeThongKeBienLai = ws.get_Range("A1", "N1");
                row1TieuDeThongKeBienLai.Merge();
                row1TieuDeThongKeBienLai.Font.Size = fontSizeTieuDe;
                row1TieuDeThongKeBienLai.Font.Name = fontName;
                row1TieuDeThongKeBienLai.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row1TieuDeThongKeBienLai.Value2 = checkExportAll.Checked ? "THỐNG KÊ DANH SÁCH TẤT CẢ BIÊN LAI" : "THỐNG KÊ DANH SÁCH BIÊN LAI-" + cbbBanThuHS.Text.ToUpper() + "-NGÀY " + dateTimePicker.Value.ToString("dd/MM/yyyy") + "-BUỔI " + cbbBuoi.Text;

                //Tạo Ô Số Thứ Tự (STT)
                Range row23Stt = ws.get_Range("A2", "A3");//Cột A dòng 2 và dòng 3
                row23Stt.Merge();
                row23Stt.Font.Size = fontSizeTenTruong;
                row23Stt.Font.Name = fontName;
                row23Stt.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23Stt.Value2 = "STT";

                //Tạo Ô Số báo danh :
                Range row23Sbd = ws.get_Range("B2", "B3");//Cột B dòng 2 và dòng 3
                row23Sbd.Merge();
                row23Sbd.Font.Size = fontSizeTenTruong;
                row23Sbd.Font.Name = fontName;
                row23Sbd.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23Sbd.Value2 = "SBD";
                row23Sbd.ColumnWidth = 15;

                //Tạo Ô Tên sinh viên :
                Range row23TenSv = ws.get_Range("C2", "C3");//Cột C dòng 2 và dòng 3
                row23TenSv.Merge();
                row23TenSv.Font.Size = fontSizeTenTruong;
                row23TenSv.Font.Name = fontName;
                row23TenSv.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23TenSv.ColumnWidth = 40;
                row23TenSv.Value2 = "Họ tên sinh viên";

                //Tạo Ô Mã ngành :
                Range row23MaNganh = ws.get_Range("D2", "D3");//Cột D dòng 2 và dòng 3
                row23MaNganh.Merge();
                row23MaNganh.Font.Size = fontSizeTenTruong;
                row23MaNganh.Font.Name = fontName;
                row23MaNganh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23MaNganh.ColumnWidth = 15;
                row23MaNganh.Value2 = "Mã ngành";

                //Tạo Ô Tên ngành :
                Range row23TenNganh = ws.get_Range("E2", "E3");//Cột E dòng 2 và dòng 3
                row23TenNganh.Merge();
                row23TenNganh.Font.Size = fontSizeTenTruong;
                row23TenNganh.Font.Name = fontName;
                row23TenNganh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23TenNganh.ColumnWidth = 40;
                row23TenNganh.Value2 = "Tên ngành";

                //Tạo Ô Tên lớp :
                Range row23Lop = ws.get_Range("F2", "F3");//Cột F dòng 2 và dòng 3
                row23Lop.Merge();
                row23Lop.Font.Size = fontSizeTenTruong;
                row23Lop.Font.Name = fontName;
                row23Lop.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23Lop.ColumnWidth = 10;
                row23Lop.Value2 = "Lớp";

                //Tạo Ô Tên chương trình :
                Range row23TenChuongTrinh = ws.get_Range("G2", "G3");//Cột G dòng 2 và dòng 3
                row23TenChuongTrinh.Merge();
                row23TenChuongTrinh.Font.Size = fontSizeTenTruong;
                row23TenChuongTrinh.Font.Name = fontName;
                row23TenChuongTrinh.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row23TenChuongTrinh.ColumnWidth = 30;
                row23TenChuongTrinh.Value2 = "Chương trình";

                //Tạo Ô tiền :
                Range row2Tien = ws.get_Range("H2", "N2");//Cột H->N của dòng 2
                row2Tien.Merge();
                row2Tien.Font.Size = fontSizeTenTruong;
                row2Tien.Font.Name = fontName;
                row2Tien.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row2Tien.Value2 = "Tiền đã thu";

                //Tạo Ô Học phí:
                Range row3TienHp = ws.get_Range("H3", "H3");//Ô H3
                row3TienHp.Font.Size = fontSizeTenTruong;
                row3TienHp.Font.Name = fontName;
                row3TienHp.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TienHp.Value2 = "Học phí";
                row3TienHp.ColumnWidth = 20;

                //Tạo Ô BHYT:
                Range row3TienBhyt = ws.get_Range("I3", "I3");//Ô I3
                row3TienBhyt.Font.Size = fontSizeTenTruong;
                row3TienBhyt.Font.Name = fontName;
                row3TienBhyt.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TienBhyt.Value2 = "Tiền BHYT";
                row3TienBhyt.ColumnWidth = 20;

                //Tạo Ô BHTT:
                Range row3TienBtyt = ws.get_Range("J3", "J3");//Ô J3
                row3TienBtyt.Font.Size = fontSizeTenTruong;
                row3TienBtyt.Font.Name = fontName;
                row3TienBtyt.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TienBtyt.Value2 = "Tiền BHTT";
                row3TienBtyt.ColumnWidth = 20;

                //Tạo Ô tiền GDQP:
                Range row3TienGdqp = ws.get_Range("K3", "K3");//Ô K3
                row3TienGdqp.Font.Size = fontSizeTenTruong;
                row3TienGdqp.Font.Name = fontName;
                row3TienGdqp.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TienGdqp.Value2 = "Tiền GDQP";
                row3TienGdqp.ColumnWidth = 20;

                //Tạo Ô tiền AVDV:
                Range row3TienAvdv = ws.get_Range("L3", "L3");//Ô L3
                row3TienAvdv.Font.Size = fontSizeTenTruong;
                row3TienAvdv.Font.Name = fontName;
                row3TienAvdv.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TienAvdv.Value2 = "Tiền Thi AVDV";
                row3TienAvdv.ColumnWidth = 20;

                //Tạo Ô tiền khám sức khỏe:
                Range row3TienKhamSk = ws.get_Range("M3", "M3");//Ô M3
                row3TienKhamSk.Font.Size = fontSizeTenTruong;
                row3TienKhamSk.Font.Name = fontName;
                row3TienKhamSk.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TienKhamSk.Value2 = "Tiền khám SK";
                row3TienKhamSk.ColumnWidth = 20;

                //Tạo Ô tổng tiền:
                Range row3TongTienThu = ws.get_Range("N3", "N3");//Ô N3
                row3TongTienThu.Font.Size = fontSizeTenTruong;
                row3TongTienThu.Font.Name = fontName;
                row3TongTienThu.Cells.HorizontalAlignment = XlHAlign.xlHAlignCenter;
                row3TongTienThu.Value2 = "Tổng tiền đã thu";
                row3TongTienThu.ColumnWidth = 20;

                //Tô nền vàng các cột tiêu đề:
                Range row23CotTieuDe = ws.get_Range("A2", "N3");
                //nền vàng
                row23CotTieuDe.Interior.Color = ColorTranslator.ToOle(Color.Yellow);
                //in đậm
                row23CotTieuDe.Font.Bold = true;
                //chữ đen
                row23CotTieuDe.Font.Color = ColorTranslator.ToOle(Color.Black);

                int stt = 0;
                row = 3;//dữ liệu xuất bắt đầu từ dòng số 4 trong file Excel (khai báo 3 để vào vòng lặp nó ++ thành 4)
                foreach (BienLaiExcel bienLai in listBienLai)
                {
                    stt++;
                    row++;
                    dynamic[] arr =
                    {
                        stt, "\'" + bienLai.SBD, bienLai.Name, bienLai.MaNganh, bienLai.TenNganh, bienLai.Lop,
                        bienLai.TenChuongTrinh, bienLai.TienHocPhi, bienLai.TienBHYT, bienLai.TienBHTT,
                        bienLai.TienGDQP, bienLai.TienAVDV, bienLai.TienKhamSK, bienLai.TongTienDaThu
                    };
                    Range rowData = ws.get_Range("A" + row, "N" + row);//Lấy dòng thứ row ra để đổ dữ liệu

                    rowData.Font.Size = fontSizeNoiDung;
                    rowData.Font.Name = fontName;
                    Range rowCurrence = ws.get_Range("H" + row, "N" + row);
                    if (bienLai.DaNopTien)
                    {
                        rowCurrence.NumberFormat = "###,###,###,###";
                    }

                    Range rowMaNganh = ws.get_Range("D" + row, "D" + row);
                    rowMaNganh.NumberFormat = "@";
                    Range rowSBD = ws.get_Range("B" + row, "B" + row);
                    rowSBD.NumberFormat = "@";

                    rowData.Value2 = arr;
                }

                row = row + 1;
                Range rowNH = ws.get_Range("H" + row, "N" + row);
                rowNH.Font.Size = fontSizeNoiDung;
                rowNH.Font.Name = fontName;
                rowNH.Font.FontStyle = "bold";

                Range rowSumColH = ws.get_Range("H" + row, "H" + row);
                rowSumColH.Formula = "=sum(H4:H" + (row - 1) + ")";
                Range rowSumColI = ws.get_Range("I" + row, "I" + row);
                rowSumColI.Formula = "=sum(I4:I" + (row - 1) + ")";
                Range rowSumColJ = ws.get_Range("J" + row, "J" + row);
                rowSumColJ.Formula = "=sum(J4:J" + (row - 1) + ")";
                Range rowSumColK = ws.get_Range("K" + row, "K" + row);
                rowSumColK.Formula = "=sum(K4:K" + (row - 1) + ")";
                Range rowSumColL = ws.get_Range("L" + row, "L" + row);
                rowSumColL.Formula = "=sum(L4:L" + (row - 1) + ")";
                Range rowSumColM = ws.get_Range("M" + row, "M" + row);
                rowSumColM.Formula = "=sum(M4:M" + (row - 1) + ")";
                Range rowSumColN = ws.get_Range("N" + row, "N" + row);
                rowSumColN.Formula = "=sum(N4:N" + (row - 1) + ")";

                //Kẻ khung toàn bộ
                BorderAround(ws.get_Range("A2", "N" + row));

                //Lưu file excel xuống Ổ cứng
                wb.SaveAs(saveExcelFile);

                //đóng file để hoàn tất quá trình lưu trữ
                wb.Close(true, misValue, misValue);
                //thoát và thu hồi bộ nhớ cho COM
                xlApp.Quit();
                ReleaseObject(ws);
                ReleaseObject(wb);
                ReleaseObject(xlApp);

                //Mở File excel sau khi Xuất thành công
                Process.Start(saveExcelFile);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //Hàm kẻ khung cho Excel
        private void BorderAround(Range range)
        {
            Borders borders = range.Borders;
            borders[XlBordersIndex.xlEdgeLeft].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeTop].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeBottom].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlEdgeRight].LineStyle = XlLineStyle.xlContinuous;
            borders.Color = Color.Black;
            borders[XlBordersIndex.xlInsideVertical].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlInsideHorizontal].LineStyle = XlLineStyle.xlContinuous;
            borders[XlBordersIndex.xlDiagonalUp].LineStyle = XlLineStyle.xlLineStyleNone;
            borders[XlBordersIndex.xlDiagonalDown].LineStyle = XlLineStyle.xlLineStyleNone;
        }

        //Hàm thu hồi bộ nhớ cho COM Excel
        private static void ReleaseObject(object obj)
        {
            try
            {
                Marshal.ReleaseComObject(obj);
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex.Message);
            }
            finally
            { GC.Collect(); }
        }
    }
}