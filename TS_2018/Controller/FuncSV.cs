using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using TS_2018.Model.Database;
using TS_2018.Model.Schema;

namespace TS_2018.Controller
{
    internal class FuncSV
    {
        private TS2018 context;

        public FuncSV()
        {
            context = new TS2018();
        }

        public List<USER> GetListUserWithoutAdmin()
        {
            return context.USER.Where(x => x.ID != 1).ToList();
        }

        public List<ViewListSV> GetListThongTinSV()
        {
            try
            {
                return context.SINHVIEN.Select(x => new ViewListSV()
                {
                    SBD = x.SBD,
                    Address = x.Address,
                    CMND = x.CMND,
                    Name = x.Name,
                    Tel = x.Tel,
                    TenNganh = x.NGANHHOC.Ten_Nganh,
                    TienDaNop = x.BIENLAI.TongTien,
                    Lop = x.Lop
                }).ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public List<ViewListSV> SearchSV(string keyword, int type, int idUser, DateTime ngayTuyenSinh)
        {
            try
            {
                if (idUser == 1)
                {
                    if (type == 0)
                    {
                        return context.SINHVIEN.Where(x => x.SBD.Contains(keyword) || x.Name.Contains(keyword) || x.CMND.Contains(keyword) || x.Lop.Contains(keyword)).Select(x => new ViewListSV()
                        {
                            SBD = x.SBD,
                            Address = x.Address,
                            CMND = x.CMND,
                            Name = x.Name,
                            Tel = x.Tel,
                            TenNganh = x.NGANHHOC.Ten_Nganh,
                            TienDaNop = x.BIENLAI.TongTien,
                            Lop = x.Lop
                        }).ToList();
                    }
                    else if (type == 1)
                    {
                        return context.SINHVIEN.Where(x => (x.SBD.Contains(keyword) || x.Name.Contains(keyword) || x.CMND.Contains(keyword) || x.Lop.Contains(keyword)) && x.DaNhapHoc).Select(x => new ViewListSV()
                        {
                            SBD = x.SBD,
                            Address = x.Address,
                            CMND = x.CMND,
                            Name = x.Name,
                            Tel = x.Tel,
                            TenNganh = x.NGANHHOC.Ten_Nganh,
                            TienDaNop = x.BIENLAI.TongTien,
                            Lop = x.Lop
                        }).ToList();
                    }
                    else
                    {
                        return context.SINHVIEN.Where(x => (x.SBD.Contains(keyword) || x.Name.Contains(keyword) || x.CMND.Contains(keyword) || x.Lop.Contains(keyword)) && !x.DaNhapHoc).Select(x => new ViewListSV()
                        {
                            SBD = x.SBD,
                            Address = x.Address,
                            CMND = x.CMND,
                            Name = x.Name,
                            Tel = x.Tel,
                            TenNganh = x.NGANHHOC.Ten_Nganh,
                            TienDaNop = x.BIENLAI.TongTien,
                            Lop = x.Lop
                        }).ToList();
                    }
                }
                else
                {
                    if (type == 0)
                    {
                        return context.SINHVIEN.Where(x => !x.DaXongNgay21 && x.NGANHHOC.IDUserTuyenSinh == idUser
                                                           && (x.SBD.Contains(keyword) || x.Name.Contains(keyword) || x.CMND.Contains(keyword) || x.Lop.Contains(keyword))
                                                           ).Select(x => new ViewListSV()
                                                           {
                                                               SBD = x.SBD,
                                                               Address = x.Address,
                                                               CMND = x.CMND,
                                                               Name = x.Name,
                                                               Tel = x.Tel,
                                                               TenNganh = x.NGANHHOC.Ten_Nganh,
                                                               TienDaNop = x.BIENLAI.TongTien,
                                                               Lop = x.Lop
                                                           }).ToList();
                    }
                    else if (type == 1)
                    {
                        return context.SINHVIEN.Where(x => !x.DaXongNgay21 && x.NGANHHOC.IDUserTuyenSinh == idUser
                                                           && (x.SBD.Contains(keyword) || x.Name.Contains(keyword) || x.CMND.Contains(keyword) || x.Lop.Contains(keyword)) && x.DaNhapHoc
                                                           ).Select(x => new ViewListSV()
                                                           {
                                                               SBD = x.SBD,
                                                               Address = x.Address,
                                                               CMND = x.CMND,
                                                               Name = x.Name,
                                                               Tel = x.Tel,
                                                               TenNganh = x.NGANHHOC.Ten_Nganh,
                                                               TienDaNop = x.BIENLAI.TongTien,
                                                               Lop = x.Lop
                                                           }).ToList();
                    }
                    else
                    {
                        return context.SINHVIEN.Where(x => !x.DaXongNgay21 && x.NGANHHOC.IDUserTuyenSinh == idUser
                                                           && (x.SBD.Contains(keyword) || x.Name.Contains(keyword) || x.CMND.Contains(keyword) || x.Lop.Contains(keyword)) && !x.DaNhapHoc
                                                           ).Select(x => new ViewListSV()
                                                           {
                                                               SBD = x.SBD,
                                                               Address = x.Address,
                                                               CMND = x.CMND,
                                                               Name = x.Name,
                                                               Tel = x.Tel,
                                                               TenNganh = x.NGANHHOC.Ten_Nganh,
                                                               TienDaNop = x.BIENLAI.TongTien,
                                                               Lop = x.Lop
                                                           }).ToList();
                    }
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public SINHVIEN GetSVBySBD(string SBD)
        {
            try
            {
                return context.SINHVIEN.FirstOrDefault(x => x.SBD == SBD);
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public List<NGANHHOC> GetAllNganhHoc()
        {
            try
            {
                return context.NGANHHOC.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public List<CHUONGTRINH> GetAllChuongTrinh()
        {
            try
            {
                return context.CHUONGTRINH.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public List<BHYT> GetListBHYT()
        {
            try
            {
                return context.BHYT.ToList();
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public decimal TinhTienHocPhi(int idChuongTrinh, int idBHYT)
        {
            try
            {
                BHYT bhyt = context.BHYT.FirstOrDefault(x => x.ID_BHYT == idBHYT);
                CHUONGTRINH ct = context.CHUONGTRINH.FirstOrDefault(x => x.ID_CT == idChuongTrinh);
                if (bhyt != null && ct != null)
                {
                    return Convert.ToDecimal(bhyt.LoaiTien + ct.SoTien + 670000 + 77000 + 80000 + 50000);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public decimal GetTienBHYT(int idBHYT)
        {
            try
            {
                BHYT bhyt = context.BHYT.FirstOrDefault(x => x.ID_BHYT == idBHYT);
                if (bhyt != null)
                {
                    return Convert.ToDecimal(bhyt.LoaiTien);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public decimal GetHocPhiTheoChuongTrinh(int idCT)
        {
            try
            {
                CHUONGTRINH ct = context.CHUONGTRINH.FirstOrDefault(x => x.ID_CT == idCT);
                if (ct != null)
                {
                    return Convert.ToDecimal(ct.SoTien);
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        public bool HuyHoSoSinhVien(string idSv)
        {
            try
            {
                SINHVIEN sv = context.SINHVIEN.FirstOrDefault(x => x.SBD == idSv);
                if (sv != null)
                {
                    sv.BIENLAI.TongTien = 0;
                    sv.BIENLAI.TienAVDV = 0;
                    sv.BIENLAI.TienBHTT = 0;
                    sv.BIENLAI.TienBHYT = 0;
                    sv.BIENLAI.TienGDQP = 0;
                    sv.BIENLAI.TienHocPhi = 0;
                    sv.BIENLAI.TienKhamSK = 0;
                    sv.BIENLAI.NgayUpdate = null;
                    sv.BIENLAI.IdUserUpdate = null;

                    sv.PHIEUNHAPHOC.GT1 = true;
                    sv.PHIEUNHAPHOC.GT2 = true;
                    sv.PHIEUNHAPHOC.GT3 = true;
                    sv.PHIEUNHAPHOC.GT4 = true;
                    sv.PHIEUNHAPHOC.GT5 = true;
                    sv.PHIEUNHAPHOC.GT6 = true;
                    sv.PHIEUNHAPHOC.GT7 = true;
                    sv.PHIEUNHAPHOC.GT8 = true;
                    sv.PHIEUNHAPHOC.GT9 = true;
                    sv.PHIEUNHAPHOC.GT10 = true;
                    sv.PHIEUNHAPHOC.GT11 = true;

                    sv.DaNhapHoc = false;
                    sv.DaNopHocPhi = false;

                    context.SaveChanges();
                    return true;
                }
                else
                {
                    return false;
                }
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public bool UpdateInforSV(SINHVIEN svIn, bool daDongTien)
        {
            try
            {
                SINHVIEN sv = context.SINHVIEN.FirstOrDefault(x => x.SBD == svIn.SBD);
                if (sv != null)
                {
                    if (daDongTien)
                    {
                        sv.BIENLAI.ID_BHYT = svIn.BIENLAI.ID_BHYT;
                        sv.BIENLAI.ID_CT = svIn.BIENLAI.ID_CT;
                        sv.BIENLAI.TongTien = svIn.BIENLAI.TongTien;
                        sv.BIENLAI.TienAVDV = svIn.BIENLAI.TienAVDV;
                        sv.BIENLAI.TienBHTT = svIn.BIENLAI.TienBHTT;
                        sv.BIENLAI.TienBHYT = svIn.BIENLAI.TienBHYT;
                        sv.BIENLAI.TienGDQP = svIn.BIENLAI.TienGDQP;
                        sv.BIENLAI.TienHocPhi = svIn.BIENLAI.TienHocPhi;
                        sv.BIENLAI.TienKhamSK = svIn.BIENLAI.TienKhamSK;
                        sv.BIENLAI.NgayUpdate = svIn.BIENLAI.NgayUpdate;
                    }
                    else
                    {
                        sv.BIENLAI.ID_BHYT = svIn.BIENLAI.ID_BHYT;
                        sv.BIENLAI.ID_CT = svIn.BIENLAI.ID_CT;
                        sv.BIENLAI.TongTien = 0;
                        sv.BIENLAI.TienAVDV = 0;
                        sv.BIENLAI.TienBHTT = 0;
                        sv.BIENLAI.TienBHYT = 0;
                        sv.BIENLAI.TienGDQP = 0;
                        sv.BIENLAI.TienHocPhi = 0;
                        sv.BIENLAI.TienKhamSK = 0;
                        sv.BIENLAI.NgayUpdate = svIn.BIENLAI.NgayUpdate;
                    }
                    sv.BIENLAI.IdUserUpdate = svIn.BIENLAI.IdUserUpdate;

                    sv.PHIEUNHAPHOC.GT1 = svIn.PHIEUNHAPHOC.GT1;
                    sv.PHIEUNHAPHOC.GT2 = svIn.PHIEUNHAPHOC.GT2;
                    sv.PHIEUNHAPHOC.GT3 = svIn.PHIEUNHAPHOC.GT3;
                    sv.PHIEUNHAPHOC.GT4 = svIn.PHIEUNHAPHOC.GT4;
                    sv.PHIEUNHAPHOC.GT5 = svIn.PHIEUNHAPHOC.GT5;
                    sv.PHIEUNHAPHOC.GT6 = svIn.PHIEUNHAPHOC.GT6;
                    sv.PHIEUNHAPHOC.GT7 = svIn.PHIEUNHAPHOC.GT7;
                    sv.PHIEUNHAPHOC.GT8 = svIn.PHIEUNHAPHOC.GT8;
                    sv.PHIEUNHAPHOC.GT9 = svIn.PHIEUNHAPHOC.GT9;
                    sv.PHIEUNHAPHOC.GT10 = svIn.PHIEUNHAPHOC.GT10;
                    sv.PHIEUNHAPHOC.GT11 = svIn.PHIEUNHAPHOC.GT11;

                    svIn.Address = svIn.Address;
                    sv.CMND = svIn.CMND;
                    sv.ID_Nganh = svIn.ID_Nganh;
                    sv.Name = svIn.Name;
                    sv.DaNopHocPhi = svIn.DaNopHocPhi;
                    sv.Tel = svIn.Tel;
                    sv.DaNhapHoc = true;

                    context.SaveChanges();
                }
                return true;
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        private String GetMD5(string txt)
        {
            String str = "";
            Byte[] buffer = System.Text.Encoding.UTF8.GetBytes(txt);
            System.Security.Cryptography.MD5CryptoServiceProvider md5 = new System.Security.Cryptography.MD5CryptoServiceProvider();
            buffer = md5.ComputeHash(buffer);
            foreach (Byte b in buffer)
            {
                str += b.ToString("X2");
            }
            return str;
        }

        public USER Login(string username, string password)
        {
            try
            {
                string userName = username;
                string passWord = GetMD5(password);
                USER user = context.USER.FirstOrDefault(x => x.Username == username);
                if (user == null)
                {
                    return null;
                }

                if (!user.Password.Equals(passWord))
                {
                    return null;
                }
                return user;
            }
            catch (Exception e)
            {
                return null;
            }
        }

        public string HienThiTienTe(string soTien)
        {
            string result = "";
            soTien = soTien.Replace(" ", "");
            string[] tachSo1 = soTien.Split('.');
            string[] tachSo2 = soTien.Split(',');
            string[] tachSo = null;
            if (tachSo2.Length > tachSo1.Length)
            {
                tachSo = tachSo2;
            }
            else
            {
                tachSo = tachSo1;
            }
            int chieuDai = tachSo[0].Length;
            while (chieuDai > 3)
            {
                result = "," + tachSo[0].Substring(chieuDai - 3, 3) + result;
                chieuDai -= 3;
            }
            result = tachSo[0].Substring(0, chieuDai) + result;
            if (tachSo.Length > 1)
            {
                result += ("." + (tachSo[1].Length > 2 ? tachSo[1].Substring(0, 2) : tachSo[1]));
            }
            if (result == "")
            {
                result = "0";
            }
            return result;
        }

        private string Chu(string gNumber)
        {
            string result = "";
            switch (gNumber)
            {
                case "0":
                    result = "không";
                    break;

                case "1":
                    result = "một";
                    break;

                case "2":
                    result = "hai";
                    break;

                case "3":
                    result = "ba";
                    break;

                case "4":
                    result = "bốn";
                    break;

                case "5":
                    result = "năm";
                    break;

                case "6":
                    result = "sáu";
                    break;

                case "7":
                    result = "bảy";
                    break;

                case "8":
                    result = "tám";
                    break;

                case "9":
                    result = "chín";
                    break;
            }
            return result;
        }

        private string Donvi(string so)
        {
            string Kdonvi = "";

            if (so.Equals("1"))
                Kdonvi = "";
            if (so.Equals("2"))
                Kdonvi = "nghìn";
            if (so.Equals("3"))
                Kdonvi = "triệu";
            if (so.Equals("4"))
                Kdonvi = "tỷ";
            if (so.Equals("5"))
                Kdonvi = "nghìn tỷ";
            if (so.Equals("6"))
                Kdonvi = "triệu tỷ";
            if (so.Equals("7"))
                Kdonvi = "tỷ tỷ";

            return Kdonvi;
        }

        private string Tach(string tach3)
        {
            string Ktach = "";
            if (tach3.Equals("000"))
                return "";
            if (tach3.Length == 3)
            {
                string tr = tach3.Trim().Substring(0, 1).ToString().Trim();
                string ch = tach3.Trim().Substring(1, 1).ToString().Trim();
                string dv = tach3.Trim().Substring(2, 1).ToString().Trim();
                if (tr.Equals("0") && ch.Equals("0"))
                    Ktach = " không trăm lẻ " + Chu(dv.ToString().Trim()) + " ";
                if (!tr.Equals("0") && ch.Equals("0") && dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm ";
                if (!tr.Equals("0") && ch.Equals("0") && !dv.Equals("0"))
                    Ktach = Chu(tr.ToString().Trim()).Trim() + " trăm lẻ " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (tr.Equals("0") && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = " không trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (tr.Equals("0") && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = " không trăm mười " + Chu(dv.Trim()).Trim() + " ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("0"))
                    Ktach = " không trăm mười ";
                if (tr.Equals("0") && ch.Equals("1") && dv.Equals("5"))
                    Ktach = " không trăm mười lăm ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi " + Chu(dv.Trim()).Trim() + " ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi ";
                if (Convert.ToInt32(tr) > 0 && Convert.ToInt32(ch) > 1 && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm " + Chu(ch.Trim()).Trim() + " mươi lăm ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && Convert.ToInt32(dv) > 0 && !dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười " + Chu(dv.Trim()).Trim() + " ";

                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("0"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười ";
                if (Convert.ToInt32(tr) > 0 && ch.Equals("1") && dv.Equals("5"))
                    Ktach = Chu(tr.Trim()).Trim() + " trăm mười lăm ";
            }
            return Ktach;
        }

        private string So_chu(double gNum)
        {
            if (gNum == 0)
                return "Không";

            string lso_chu = "";
            string tach_mod = "";
            string tach_conlai = "";
            double Num = Math.Round(gNum, 0);
            string gN = Convert.ToString(Num);
            int m = Convert.ToInt32(gN.Length / 3);
            int mod = gN.Length - m * 3;
            string dau = "[+]";

            // Dau [+ , - ]
            if (gNum < 0)
                dau = "[-]";
            dau = "";

            // Tach hang lon nhat
            if (mod.Equals(1))
                tach_mod = "00" + Convert.ToString(Num.ToString().Trim().Substring(0, 1)).Trim();
            if (mod.Equals(2))
                tach_mod = "0" + Convert.ToString(Num.ToString().Trim().Substring(0, 2)).Trim();
            if (mod.Equals(0))
                tach_mod = "000";
            // Tach hang con lai sau mod :
            if (Num.ToString().Length > 2)
                tach_conlai = Convert.ToString(Num.ToString().Trim().Substring(mod, Num.ToString().Length - mod)).Trim();

            ///don vi hang mod
            int im = m + 1;
            if (mod > 0)
                lso_chu = Tach(tach_mod).ToString().Trim() + " " + Donvi(im.ToString().Trim());
            /// Tach 3 trong tach_conlai

            int i = m;
            int _m = m;
            int j = 1;
            string tach3 = "";
            string tach3_ = "";

            while (i > 0)
            {
                tach3 = tach_conlai.Trim().Substring(0, 3).Trim();
                tach3_ = tach3;
                lso_chu = lso_chu.Trim() + " " + Tach(tach3.Trim()).Trim();
                m = _m + 1 - j;
                if (!tach3_.Equals("000"))
                    lso_chu = lso_chu.Trim() + " " + Donvi(m.ToString().Trim()).Trim();
                tach_conlai = tach_conlai.Trim().Substring(3, tach_conlai.Trim().Length - 3);

                i = i - 1;
                j = j + 1;
            }
            if (lso_chu.Trim().Substring(0, 1).Equals("k"))
                lso_chu = lso_chu.Trim().Substring(10, lso_chu.Trim().Length - 10).Trim();
            if (lso_chu.Trim().Substring(0, 1).Equals("l"))
                lso_chu = lso_chu.Trim().Substring(2, lso_chu.Trim().Length - 2).Trim();
            if (lso_chu.Trim().Length > 0)
                lso_chu = dau.Trim() + " " + lso_chu.Trim().Substring(0, 1).Trim().ToUpper() + lso_chu.Trim().Substring(1, lso_chu.Trim().Length - 1).Trim();
            return lso_chu.ToString().Trim();
        }

        public string DocTien(string so)
        {
            string tien = "";
            string[] soThapPhan1 = so.Split('.');
            string[] soThapPhan2 = so.Split(',');
            string phanThapPhan = "";
            string phanChan = soThapPhan1[0];
            if (soThapPhan1.Length > 1)
            {
                phanThapPhan = soThapPhan1[1];
            }
            if (soThapPhan2.Length > 1)
            {
                phanThapPhan = soThapPhan2[1];
            }
            try
            {
                tien = So_chu(Convert.ToDouble(phanChan));
                if (phanThapPhan != "")
                {
                    tien += " phẩy " + So_chu(Convert.ToDouble(phanThapPhan)) + " đồng";
                }
                else
                {
                    tien += " đồng chẵn";
                }
            }
            catch { }
            return tien;
        }

        public List<BienLaiExcel> GetListBienLaiExcel(int idUser, DateTime date, int type = 100)
        {
            try
            {
                if (idUser == 4)
                {
                    date.AddDays(1);
                }
                if (type == 0)
                {
                    if (idUser == 9)
                    {
                        return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc && x.SINHVIEN.DaNopHocPhi && x.NgayUpdate != null && DbFunctions.TruncateTime(x.NgayUpdate).Value.Day == date.Date.Day && DbFunctions.TruncateTime(x.NgayUpdate).Value.Month == date.Date.Month && DbFunctions.TruncateTime(x.NgayUpdate).Value.Year == date.Date.Year).Select(x => new BienLaiExcel()
                        {
                            SBD = x.SBD,
                            Lop = x.SINHVIEN.Lop,
                            TienAVDV = x.TienAVDV,
                            TienKhamSK = x.TienKhamSK,
                            TienGDQP = x.TienGDQP,
                            TienBHYT = x.TienBHYT,
                            TienHocPhi = x.TienHocPhi,
                            Name = x.SINHVIEN.Name,
                            TienBHTT = x.TienBHTT,
                            CMND = x.SINHVIEN.CMND,
                            MaNganh = x.SINHVIEN.ID_Nganh,
                            TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                            TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                            TongTienDaThu = x.TongTien,
                            DaNopTien = x.SINHVIEN.DaNopHocPhi
                        }).ToList();
                    }
                    else
                        return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc && x.SINHVIEN.DaNopHocPhi && x.IdUserUpdate == idUser && x.NgayUpdate != null && DbFunctions.TruncateTime(x.NgayUpdate).Value.Day == date.Date.Day && DbFunctions.TruncateTime(x.NgayUpdate).Value.Month == date.Date.Month && DbFunctions.TruncateTime(x.NgayUpdate).Value.Year == date.Date.Year).Select(x => new BienLaiExcel()
                        {
                            SBD = x.SBD,
                            Lop = x.SINHVIEN.Lop,
                            TienAVDV = x.TienAVDV,
                            TienKhamSK = x.TienKhamSK,
                            TienGDQP = x.TienGDQP,
                            TienBHYT = x.TienBHYT,
                            TienHocPhi = x.TienHocPhi,
                            Name = x.SINHVIEN.Name,
                            TienBHTT = x.TienBHTT,
                            CMND = x.SINHVIEN.CMND,
                            MaNganh = x.SINHVIEN.ID_Nganh,
                            TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                            TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                            TongTienDaThu = x.TongTien,
                            DaNopTien = x.SINHVIEN.DaNopHocPhi
                        }).ToList();
                }
                else if (type == 1)
                {
                    if (idUser == 9)
                    {
                        return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc && x.SINHVIEN.DaNopHocPhi && x.NgayUpdate != null && DbFunctions.TruncateTime(x.NgayUpdate).Value.Day == date.Date.Day && DbFunctions.TruncateTime(x.NgayUpdate).Value.Month == date.Date.Month && DbFunctions.TruncateTime(x.NgayUpdate).Value.Year == date.Date.Year && x.NgayUpdate.Value.Hour < 13).Select(x => new BienLaiExcel()
                        {
                            SBD = x.SBD,
                            Lop = x.SINHVIEN.Lop,
                            TienAVDV = x.TienAVDV,
                            TienKhamSK = x.TienKhamSK,
                            TienGDQP = x.TienGDQP,
                            TienBHYT = x.TienBHYT,
                            TienHocPhi = x.TienHocPhi,
                            Name = x.SINHVIEN.Name,
                            TienBHTT = x.TienBHTT,
                            CMND = x.SINHVIEN.CMND,
                            MaNganh = x.SINHVIEN.ID_Nganh,
                            TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                            TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                            TongTienDaThu = x.TongTien,
                            DaNopTien = x.SINHVIEN.DaNopHocPhi
                        }).ToList();
                    }
                    else
                        return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc && x.SINHVIEN.DaNopHocPhi && x.IdUserUpdate == idUser && x.NgayUpdate != null && DbFunctions.TruncateTime(x.NgayUpdate).Value.Day == date.Date.Day && DbFunctions.TruncateTime(x.NgayUpdate).Value.Month == date.Date.Month && DbFunctions.TruncateTime(x.NgayUpdate).Value.Year == date.Date.Year && x.NgayUpdate.Value.Hour < 13).Select(x => new BienLaiExcel()
                        {
                            SBD = x.SBD,
                            Lop = x.SINHVIEN.Lop,
                            TienAVDV = x.TienAVDV,
                            TienKhamSK = x.TienKhamSK,
                            TienGDQP = x.TienGDQP,
                            TienBHYT = x.TienBHYT,
                            TienHocPhi = x.TienHocPhi,
                            Name = x.SINHVIEN.Name,
                            TienBHTT = x.TienBHTT,
                            CMND = x.SINHVIEN.CMND,
                            MaNganh = x.SINHVIEN.ID_Nganh,
                            TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                            TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                            TongTienDaThu = x.TongTien,
                            DaNopTien = x.SINHVIEN.DaNopHocPhi
                        }).ToList();
                }
                else if (type == 2)
                {
                    if (idUser == 9)
                    {
                        return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc && x.SINHVIEN.DaNopHocPhi && x.NgayUpdate != null && DbFunctions.TruncateTime(x.NgayUpdate).Value.Day == date.Date.Day && DbFunctions.TruncateTime(x.NgayUpdate).Value.Month == date.Date.Month && DbFunctions.TruncateTime(x.NgayUpdate).Value.Year == date.Date.Year && x.NgayUpdate.Value.Hour >= 13).Select(x => new BienLaiExcel()
                        {
                            SBD = x.SBD,
                            Lop = x.SINHVIEN.Lop,
                            TienAVDV = x.TienAVDV,
                            TienKhamSK = x.TienKhamSK,
                            TienGDQP = x.TienGDQP,
                            TienBHYT = x.TienBHYT,
                            TienHocPhi = x.TienHocPhi,
                            Name = x.SINHVIEN.Name,
                            TienBHTT = x.TienBHTT,
                            CMND = x.SINHVIEN.CMND,
                            MaNganh = x.SINHVIEN.ID_Nganh,
                            TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                            TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                            TongTienDaThu = x.TongTien,
                            DaNopTien = x.SINHVIEN.DaNopHocPhi
                        }).ToList();
                    }
                    else
                    {
                        return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc && x.SINHVIEN.DaNopHocPhi && x.IdUserUpdate == idUser && x.NgayUpdate != null && DbFunctions.TruncateTime(x.NgayUpdate).Value.Day == date.Date.Day && DbFunctions.TruncateTime(x.NgayUpdate).Value.Month == date.Date.Month && DbFunctions.TruncateTime(x.NgayUpdate).Value.Year == date.Date.Year && x.NgayUpdate.Value.Hour >= 13).Select(x => new BienLaiExcel()
                        {
                            SBD = x.SBD,
                            Lop = x.SINHVIEN.Lop,
                            TienAVDV = x.TienAVDV,
                            TienKhamSK = x.TienKhamSK,
                            TienGDQP = x.TienGDQP,
                            TienBHYT = x.TienBHYT,
                            TienHocPhi = x.TienHocPhi,
                            Name = x.SINHVIEN.Name,
                            TienBHTT = x.TienBHTT,
                            CMND = x.SINHVIEN.CMND,
                            MaNganh = x.SINHVIEN.ID_Nganh,
                            TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                            TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                            TongTienDaThu = x.TongTien,
                            DaNopTien = x.SINHVIEN.DaNopHocPhi
                        }).ToList();
                    }
                }
                else
                {
                    return context.BIENLAI.Where(x => x.SINHVIEN.DaNhapHoc).Select(x => new BienLaiExcel()
                    {
                        SBD = x.SBD,
                        Lop = x.SINHVIEN.Lop,
                        TienAVDV = x.TienAVDV,
                        TienKhamSK = x.TienKhamSK,
                        TienGDQP = x.TienGDQP,
                        TienBHYT = x.TienBHYT,
                        TienHocPhi = x.TienHocPhi,
                        Name = x.SINHVIEN.Name,
                        TienBHTT = x.TienBHTT,
                        CMND = x.SINHVIEN.CMND,
                        MaNganh = x.SINHVIEN.ID_Nganh,
                        TenChuongTrinh = x.CHUONGTRINH.Ten_CT,
                        TenNganh = x.SINHVIEN.NGANHHOC.Ten_Nganh,
                        TongTienDaThu = x.TongTien,
                        DaNopTien = x.SINHVIEN.DaNopHocPhi
                    }).ToList();
                }
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void SetSinhVienCNTT()
        {
            try
            {
                var sinhViens = context.SINHVIEN.Where(x => x.ID_Nganh == "7480201DT");
                foreach (var sv in sinhViens)
                {
                    sv.BIENLAI.ID_CT = 3;
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        public void SetSinhVienKTCLC()
        {
            try
            {
                var sinhViens = context.SINHVIEN.Where(x => x.ID_Nganh == "7580101CLC");
                foreach (var sv in sinhViens)
                {
                    sv.BIENLAI.ID_CT = 3;
                }

                context.SaveChanges();
            }
            catch (Exception e)
            {
                throw e;
            }
        }

        //public void UpdateCTSV(string sbd, int idCT)
        //{
        //    context.BIENLAI.FirstOrDefault(x => x.SBD == sbd).ID_CT = idCT;
        //    context.SaveChanges();
        //}
    }
}