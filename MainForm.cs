using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using WinformTest;
using WinformTest.View;


namespace WinformTest
{
    //

    public partial class MainForm : Form
    {
        //
        private Form currentChildForm;

        public MainForm()
        {
            InitializeComponent();
            hideSubMenu();
            // disableSideMenuScrollbar();
        }

        private void disableSideMenuScrollbar()
        {
            this.panelSideMenu.AutoScroll = false;
        }

        private void hideSubMenu()
        {
            panelMenuDanhMuc.Visible = false;
            panelMenuHocPhi.Visible = false;
            panelMenuKQHP.Visible = false;
            panelMenuHoatDong.Visible = false;
            panelSubMenuHeThong.Visible = false;
            panelSubMenuThongKe.Visible = false;
        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void OpenChildForm(Form childForm)
        {
            //open only form
            if (currentChildForm != null)
            {
                currentChildForm.Close();
            }
            currentChildForm = childForm;
            //End
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            this.panelMain.Controls.Add(childForm);
            this.panelMain.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
            lblTitleChildForm.Text = childForm.Text;
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
            lblUser.Text = NguoiDung.HoTen + " | " + NguoiDung.MaCanBo;
        }

        private void buttonDanhMuc_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuDanhMuc);
        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMenuKQHP);
        }
        private void button3_Click(object sender, EventArgs e)
        {
            showSubMenu(panelMenuHoatDong);
        }

        private void btnHeThong_Click(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuHeThong);
        }

        private void button4_Click_1(object sender, EventArgs e)
        {
            showSubMenu(panelMenuHocPhi);
        }

        private void button2_Click_2(object sender, EventArgs e)
        {
            showSubMenu(panelSubMenuThongKe);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            OpenChildForm(new HomeForm());
        }

        private void btnGiangVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLGiangVien());
        }

        private void btnHocPhan_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLHocPhan());
        }

        private void btnLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLLopHocPhan());
        }

        private void btnChangeInfo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongTinTaiKhoan());
        }

        private void btnToeic_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmCapNhatDiem());
        }

        private void btnHocKy_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhGiaKQHT());
        }

        private void btnNienKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new Academic_YearForm());
        }


        private void btnPhieuThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLPhieuThu());
        }

        private void btnHoatDong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmTraCuuKQRenLuyen());
        }

        private void btnMucThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLMucThu());
        }

        private void btnKhoanThu_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLKhoanThu());
        }

        private void btnDuNo_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLDuNo());
        }

        private void btnKiemDuyetHoatDong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmKiemDuyetHDNK());
        }

        private void btnDiemRenLuyen_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmDanhGiaRenLuyen());
        }

        private void btnSinhVien_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLSinhVien());
        }

 

        //Change
        private void btnKetQua_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeKetQua());
        }

        private void btnCanhBaoDRL_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeCanhBaoDRL());
        }

        private void btnTruotMon_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeTruotMon());
        }
        private void btnDangKy_Click_1(object sender, EventArgs e)
        {
            OpenChildForm(new frmDangKyTaiKhoan() );
        }

        private void btnThayDoiMatKhau_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThayDoiMatKhau());
        }

        private void btnHoatDongNgoaiKhoa_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmQLHDNK());
        }
        private void btnHocBong_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeHocBong());
        }
        private void btnDangXuat_Click(object sender, EventArgs e)
        {
            DialogResult result = MessageBox.Show(
                "Bạn có chắc chắn muốn thoát không?",
                "Xác nhận",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                // Close the current form
                this.Close();

                // Check if the login form is still open and close it if it is
                Form frmDangNhap = Application.OpenForms["frmDangNhap"];
                if (frmDangNhap != null)
                {
                    frmDangNhap.Close();
                }
            }
        }

        private void btnSinhVienDKLop_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeSinhVienDKLop());
        }

        private void btnDuDKHB_Click(object sender, EventArgs e)
        {
            OpenChildForm(new frmThongKeDanhSachSVDuDKXetHB());
        }
    }
}
