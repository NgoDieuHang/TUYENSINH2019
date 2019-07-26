using Microsoft.Office.Interop.Word;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using TS_2018.Controller;
using TS_2018.Model.Database;
using TS_2018.Model.Schema;

namespace TS_2018.View
{
    public partial class ListOfSV : Form
    {
        public USER CanBoUser;
        private FuncSV controllerSv;
        private bool isFormLoaded;
        private decimal tongTien;
        const decimal bhyt = 6000000;
        public ListOfSV()
        {
            InitializeComponent();

            controllerSv = new FuncSV();
            isFormLoaded = false;
            tongTien = 0;
        }

        private void ListOfSV_Load(object sender, EventArgs e)
        {
            if (CanBoUser.Username == "admin")
            {
                btnExport.Visible = true;
            }

            cbb_nganh.DataSource = controllerSv.GetAllNganhHoc();
            cbb_nganh.DisplayMember = "Ten_Nganh";
            cbb_nganh.ValueMember = "ID_Nganh";

            //cbb_BHYT.DataSource = controllerSv.GetListBHYT();
            //cbb_BHYT.DisplayMember = "Loai_BHYT";
            //cbb_BHYT.ValueMember = "ID_BHYT";

            cbb_CT.DataSource = controllerSv.GetAllChuongTrinh();
            cbb_CT.DisplayMember = "Ten_CT";
            cbb_CT.ValueMember = "ID_CT";

            cbbFilter.SelectedIndex = 2;

            LoadAllControl();
            isFormLoaded = true;
        }

        private void LoadAllControl()
        {
            try
            {
                splitContainer1.Panel2.Enabled = false;

                //cbb_BHYT.SelectedIndex = -1;
                cbb_CT.SelectedIndex = -1;
                cbb_nganh.SelectedIndex = -1;

                txtTien.Text = "";
                txtAddress.Text = "";
                txtCMND.Text = "";
                txtName.Text = "";
                txtSBD.Text = "";
                txtTel.Text = "";
                txtLop.Text = "";

                checkGT1.Checked = false;
                checkGT2.Checked = false;
                checkGT3.Checked = false;
                checkGT4.Checked = false;
                checkGT5.Checked = false;
                checkGT6.Checked = false;
                checkGT7.Checked = false;
                checkGT8.Checked = false;
                checkGT9.Checked = false;
                checkGT10.Checked = false;
                checkGT11.Checked = false;

                checkDaNopHocPhi.Checked = false;

                but_Can.Enabled = false;
                but_OK.Enabled = false;
                but_Print.Enabled = false;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        private void dataGridView1_RowHeaderMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            try
            {
                this.Enabled = false;
                string SBD = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
                LoadinforSV(SBD);
                this.Enabled = true;
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void txtSearch_TextChanged(object sender, EventArgs e)
        {
            try
            {
                RefreshDataGridView();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void LoadinforSV(string SBD)
        {
            try
            {
                SINHVIEN sv = controllerSv.GetSVBySBD(SBD);
                txtSBD.Text = sv.SBD;
                txtName.Text = sv.Name;
                txtTel.Text = sv.Tel;
                txtAddress.Text = sv.Address;
                cbb_nganh.SelectedValue = sv.ID_Nganh;
                txtCMND.Text = sv.CMND;
                txtLop.Text = sv.Lop;

                checkGT1.Checked = sv.PHIEUNHAPHOC.GT1;
                checkGT2.Checked = sv.PHIEUNHAPHOC.GT2;
                checkGT3.Checked = sv.PHIEUNHAPHOC.GT3;
                checkGT4.Checked = sv.PHIEUNHAPHOC.GT4;
                checkGT5.Checked = sv.PHIEUNHAPHOC.GT5;
                checkGT6.Checked = sv.PHIEUNHAPHOC.GT6;
                checkGT7.Checked = sv.PHIEUNHAPHOC.GT7;
                checkGT8.Checked = sv.PHIEUNHAPHOC.GT8;
                checkGT9.Checked = sv.PHIEUNHAPHOC.GT9;
                checkGT10.Checked = sv.PHIEUNHAPHOC.GT10;
                checkGT11.Checked = sv.PHIEUNHAPHOC.GT11;

                //cbb_BHYT.SelectedValue = sv.BIENLAI.ID_BHYT;
                cbb_CT.SelectedValue = sv.BIENLAI.ID_CT;

                checkDaNopHocPhi.Checked = sv.DaNopHocPhi;

                but_Can.Enabled = true;
                but_OK.Enabled = true;
                but_Print.Enabled = true;

                TinhTongTien();

                splitContainer1.Panel2.Enabled = true;
            }
            catch (Exception e)
            {
                Console.WriteLine(e);
                throw e;
            }
        }

        private void but_OK_Click(object sender, EventArgs e)
        {
            try
            {
                SINHVIEN sv = new SINHVIEN
                {
                    SBD = txtSBD.Text,
                    Name = txtName.Text,
                    Tel = txtTel.Text,
                    Address = txtAddress.Text,
                    ID_Nganh = cbb_nganh.SelectedValue.ToString(),
                    ID_CT = (int)cbb_CT.SelectedValue,
                    CMND = txtCMND.Text,
                    Lop = txtLop.Text,
                    DaNopHocPhi = checkDaNopHocPhi.Checked,

                    PHIEUNHAPHOC = new PHIEUNHAPHOC()
                    {
                        GT1 = checkGT1.Checked,
                        GT2 = checkGT2.Checked,
                        GT3 = checkGT3.Checked,
                        GT4 = checkGT4.Checked,
                        GT5 = checkGT5.Checked,
                        GT6 = checkGT6.Checked,
                        GT7 = checkGT7.Checked,
                        GT8 = checkGT8.Checked,
                        GT9 = checkGT9.Checked,
                        GT10 = checkGT10.Checked,
                        GT11 = checkGT11.Checked
                    },
                    BIENLAI = new BIENLAI()
                    {
                        
                        //ID_BHYT = Convert.ToInt32(cbb_BHYT.SelectedValue),
                        ID_CT = Convert.ToInt32(cbb_CT.SelectedValue),
                        TienAVDV = 50000,
                        TienBHTT = 80000,
                        TienKhamSK = 77000,
                        TienGDQP = 670000,
                        TienBHYT = bhyt,
                        TienHocPhi = controllerSv.GetHocPhiTheoChuongTrinh(Convert.ToInt32(cbb_CT.SelectedValue)),
                        TongTien = tongTien,
                        IdUserUpdate = CanBoUser.ID,
                        NgayUpdate = DateTime.Now
                    }
                };
                if (checkDaNopHocPhi.Checked)
                {
                    if (MessageBox.Show("Sinh viên đã nộp học phí.\nBạn vẫn muốn lưu thông tin sinh viên này?",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                    {
                        if (controllerSv.UpdateInforSV(sv, checkDaNopHocPhi.Checked))
                        {
                            if (MessageBox.Show(
                                    "Cập nhật thông tin sinh viên thành công.\nBạn có muốn in thông tin sinh viên này hay không?",
                                    "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Question) == DialogResult.Yes)
                            {
                                panel1.Enabled = false;
                                if(Print(@"\TS2018.docx"))
                                {
                                    controllerSv.UpdateInforUserPrint(sv.SBD, CanBoUser.ID);
                                }
                                panel1.Enabled = true;
                            }
                        }
                    }
                    else
                    {
                        MessageBox.Show("Cập nhật thông tin sinh viên không thành công", "Thông báo", MessageBoxButtons.OK,
                            MessageBoxIcon.Error);
                    }
                }
                else
                {
                    if (MessageBox.Show("Sinh viên chưa nộp học phí.\nBạn vẫn muốn lưu thông tin sinh viên này?",
                            "Thông báo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning) == DialogResult.Yes)
                    {
                        if (controllerSv.UpdateInforSV(sv, checkDaNopHocPhi.Checked))
                        {
                            if (MessageBox.Show(
                                    "Cập nhật thông tin sinh viên thành công.\nSinh viên này chưa nộp học phí.\nBạn vẫn muốn in thông tin sinh viên này?",
                                    "Thông báo", MessageBoxButtons.YesNo,
                                    MessageBoxIcon.Warning) == DialogResult.Yes)
                            {
                                panel1.Enabled = false;
                                if (Print(@"\TS20180-only1.docx"))
                                {
                                    controllerSv.UpdateInforUserPrint(sv.SBD, CanBoUser.ID);
                                }
                                    panel1.Enabled = true;
                            }
                        }
                        else
                        {
                            MessageBox.Show("Cập nhật thông tin sinh viên không thành công", "Thông báo",
                                MessageBoxButtons.OK,
                                MessageBoxIcon.Error);
                        }
                    }
                }
                RefreshDataGridView();
                LoadAllControl();
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_Can_Click(object sender, EventArgs e)
        {
            try
            {
                if (MessageBox.Show(
                        "Bạn có chắc chắn muốn hủy hồ sơ nhập học của sinh viên này?",
                        "Thông báo", MessageBoxButtons.YesNo,
                        MessageBoxIcon.Warning) == DialogResult.Yes)
                {
                    controllerSv.HuyHoSoSinhVien(txtSBD.Text);
                    LoadAllControl();
                    RefreshDataGridView();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_BHYT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                if (isFormLoaded)
                {
                    TinhTongTien();
                }
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void cbb_CT_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void but_Print_Click(object sender, EventArgs e)
        {
            panel1.Enabled = false;
            Print(@"\TS20180-only1.docx");
            panel1.Enabled = true;
        }

        private void cbbFilter_SelectedIndexChanged(object sender, EventArgs e)
        {
            LoadAllControl();
            RefreshDataGridView();
        }

        private void RefreshDataGridView()
        {
            List<ViewListSV> listSV = controllerSv.SearchSV(txtSearch.Text, cbbFilter.SelectedIndex, CanBoUser.ID, DateTime.Today);
            dataGridView1.DataSource = listSV;
            lblCount.Text = listSV.Count() + " sinh viên";
        }

        private void ReplaceContent(Microsoft.Office.Interop.Word.Application word)
        {
            try
            {
                SINHVIEN sv = controllerSv.GetSVBySBD(dataGridView1.SelectedRows[0].Cells[0].Value.ToString());
                FindAndReplace(word, "#hoVaTen", sv.Name);
                FindAndReplace(word, "#SBD", sv.SBD);
                FindAndReplace(word, "#tenNganh", sv.NGANHHOC.Ten_Nganh);
                FindAndReplace(word, "#maNganh", sv.ID_Nganh);
                FindAndReplace(word, "#diaChi", sv.Address);
                FindAndReplace(word, "#soCMND", sv.CMND);
                FindAndReplace(word, "#tenCanBo", CanBoUser.HoTenCanBo);
                FindAndReplace(word, "#tenLoaiBHYT", bhyt);
                FindAndReplace(word, "#soTien", controllerSv.HienThiTienTe(sv.BIENLAI.TongTien.ToString()));
                FindAndReplace(word, "#tienBangChu", controllerSv.DocTien(sv.BIENLAI.TongTien.ToString()));
                FindAndReplace(word, "#tienChuongTrinh ", controllerSv.HienThiTienTe(sv.BIENLAI.CHUONGTRINH.SoTien.ToString()));
                FindAndReplace(word, "#tienBaoHiem ", controllerSv.HienThiTienTe(bhyt.ToString()));

                FindAndReplace(word, "#gt1", sv.PHIEUNHAPHOC.GT1 ? "X" : "O");
                FindAndReplace(word, "#gt2", sv.PHIEUNHAPHOC.GT2 ? "X" : "O");
                FindAndReplace(word, "#gt3", sv.PHIEUNHAPHOC.GT3 ? "X" : "O");
                FindAndReplace(word, "#gt4", sv.PHIEUNHAPHOC.GT4 ? "X" : "O");
                FindAndReplace(word, "#gt5", sv.PHIEUNHAPHOC.GT5 ? "X" : "O");
                FindAndReplace(word, "#gt6", sv.PHIEUNHAPHOC.GT6 ? "X" : "O");
                FindAndReplace(word, "#gt7", sv.PHIEUNHAPHOC.GT7 ? "X" : "O");
                FindAndReplace(word, "#gt8", sv.PHIEUNHAPHOC.GT8 ? "X" : "O");
                FindAndReplace(word, "#gt9", sv.PHIEUNHAPHOC.GT9 ? "X" : "O");
                FindAndReplace(word, "#gt_10", sv.PHIEUNHAPHOC.GT10 ? "X" : "O");
                FindAndReplace(word, "#gt_11", sv.PHIEUNHAPHOC.GT11 ? "X" : "O");

                FindAndReplace(word, "#ngay", DateTime.Today.ToString("dd"));
                FindAndReplace(word, "#thang", DateTime.Today.ToString("MM"));
                FindAndReplace(word, "#nam", DateTime.Today.ToString("yyyy"));
                FindAndReplace(word, "#thoiGianIn", DateTime.Now);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private bool Print(string name)
        {
            try
            {
                Microsoft.Office.Interop.Word.Application word = new Microsoft.Office.Interop.Word.Application();
                object path = Path.GetDirectoryName(System.Windows.Forms.Application.ExecutablePath) + name;
                object read = "ReadWrite";
                object readOnly = false;
                object o = System.Reflection.Missing.Value;
                Document oDoc = word.Documents.Add(ref path, ref o, ref o, ref o);
                word.Visible = true;
                ReplaceContent(word);
                oDoc.PrintOut();
                return true;
            }
            catch(Exception)
            {
                return false;
            }
        }

        private void FindAndReplace(Microsoft.Office.Interop.Word.Application doc, object findText, object replaceWithText)
        {
            //options
            object matchCase = false;
            object matchWholeWord = true;
            object matchWildCards = false;
            object matchSoundsLike = false;
            object matchAllWordForms = false;
            object forward = true;
            object format = false;
            object matchKashida = false;
            object matchDiacritics = false;
            object matchAlefHamza = false;
            object matchControl = false;
            object read_only = false;
            object visible = true;
            object replace = 2;
            object wrap = 1;
            //execute find and replace
            doc.Selection.Find.Execute(ref findText, ref matchCase, ref matchWholeWord,
                ref matchWildCards, ref matchSoundsLike, ref matchAllWordForms, ref forward, ref wrap, ref format, ref replaceWithText, ref replace,
                ref matchKashida, ref matchDiacritics, ref matchAlefHamza, ref matchControl);
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                //controllerSv.UpdateCTSV(txtSBD.Text, Convert.ToInt32(cbb_CT.SelectedValue));
                //controllerSv.SetSinhVienCNTT();
                //controllerSv.SetSinhVienKTCLC();

                //SINHVIEN sv = new SINHVIEN
                //{
                //    SBD = dataGridView1.SelectedRows[0].Cells[0].Value.ToString(),
                //    Name = txtName.Text,
                //    Tel = txtTel.Text,
                //    Address = txtAddress.Text,
                //    ID_Nganh = cbb_nganh.SelectedValue.ToString(),
                //    CMND = txtCMND.Text,
                //    DaNopHocPhi = false,
                //    PHIEUNHAPHOC = new PHIEUNHAPHOC()
                //    {
                //        GT1 = checkGT1.Checked,
                //        GT2 = checkGT2.Checked,
                //        GT3 = checkGT3.Checked,
                //        GT4 = checkGT4.Checked,
                //        GT5 = checkGT5.Checked,
                //        GT6 = checkGT6.Checked,
                //        GT7 = checkGT7.Checked,
                //        GT8 = checkGT8.Checked,
                //        GT9 = checkGT9.Checked,
                //        GT10 = checkGT10.Checked,
                //        GT11 = checkGT11.Checked
                //    },
                //    BIENLAI = new BIENLAI()
                //    {
                //        ID_BHYT = Convert.ToInt32(cbb_BHYT.SelectedValue),
                //        ID_CT = Convert.ToInt32(cbb_CT.SelectedValue),
                //        TongTien = tongTien
                //    }
                //};
                //controllerSv.UpdateInforSV(sv);
            }
            catch (Exception exception)
            {
                MessageBox.Show(exception.Message, "Thông báo", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void TinhTongTien()
        {
            tongTien = 0;
            tongTien += controllerSv.TinhTienHocPhi(Convert.ToInt32(cbb_CT.SelectedValue), bhyt);
            txtTien.Text = controllerSv.HienThiTienTe(tongTien.ToString());
        }

        private void btnExport_Click(object sender, EventArgs e)
        {
            FormExport formExport = new FormExport();
            formExport.CanBoUser = CanBoUser;
            formExport.ShowDialog();
        }

        private void dataGridView1_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            this.Enabled = false;
            string SBD = dataGridView1.SelectedRows[0].Cells[0].Value.ToString();
            LoadinforSV(SBD);
            this.Enabled = true;
        }
    }
}