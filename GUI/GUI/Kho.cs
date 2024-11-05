﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using BLL;
using DTO;

namespace GUI
{
    public partial class Kho : Form
    {
        private KhoBLL khoBLL;
        public Kho()
        {
            InitializeComponent();
            khoBLL = new KhoBLL();
        }

        private void LoadKhoData()
        {
            try
            {
                List<KhoDTO> khoList = khoBLL.GetKhoList();
                dgv_Kho.DataSource = khoList;

                dgv_Kho.Columns["IDKho"].HeaderText = "ID Kho";
                dgv_Kho.Columns["LoaiKho"].HeaderText = "Tên Kho";
                dgv_Kho.Columns["GhiChu"].HeaderText = "Ghi Chú";
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi khi load dữ liệu: " + ex.Message);
            }
        }

        private void dgv_Kho_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                DataGridViewRow row = dgv_Kho.Rows[e.RowIndex];

                txt_IDKho.Text = row.Cells["IDKho"].Value.ToString();
                txt_TenKho.Text = row.Cells["LoaiKho"].Value.ToString();
                txt_GhiChu.Text = row.Cells["GhiChu"].Value.ToString();
            }
        }

        private void CanhDeuDgv()
        {
            if (dgv_Kho.Columns.Count > 0)
            {
                int columnWidth = dgv_Kho.Width / dgv_Kho.Columns.Count;
                foreach (DataGridViewColumn column in dgv_Kho.Columns)
                {
                    column.Width = columnWidth;
                }
            }
        }

        private void ClearTxt()
        {
            txt_IDKho.Clear();
            txt_TenKho.Clear();
            txt_GhiChu.Clear();
        }

        private void Kho_Load(object sender, EventArgs e)
        {
            LoadKhoData();
            CanhDeuDgv();
        }

        private void dgv_Kho_Resize(object sender, EventArgs e)
        {
            CanhDeuDgv();
        }

        private void btn_LamMoi_Click(object sender, EventArgs e)
        {
            LoadKhoData();
            ClearTxt();
            txt_TenKho.Enabled = false;
            txt_GhiChu.Enabled = false;
            btn_Luu.Enabled = false;
            btn_CapNhat.Enabled = true;
            btn_Xoa.Enabled = true;
            btn_Them.Enabled = true;
        }

        private void btn_Them_Click(object sender, EventArgs e)
        {
            txt_TenKho.Enabled = true;
            txt_GhiChu.Enabled = true;
            ClearTxt(); 
            txt_TenKho.Focus();
            btn_Luu.Enabled = true;
            btn_CapNhat.Enabled = false;
            btn_Xoa.Enabled = false;
        }

        private void btn_Luu_Click(object sender, EventArgs e)
        {
            KhoDTO newKho = new KhoDTO
            {
                LoaiKho = txt_TenKho.Text, 
                GhiChu = txt_GhiChu.Text
            };

            try
            {
                khoBLL.ThemKho(newKho);
                MessageBox.Show("Thêm kho thành công!");
                LoadKhoData();
                ClearTxt();
                txt_TenKho.Enabled = false;
                txt_GhiChu.Enabled = false;
                btn_Luu.Enabled = false;
                btn_CapNhat.Enabled = true;
                btn_Xoa.Enabled = true;
                btn_Them.Enabled = true;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Lỗi: " + ex.Message);
            }
        }
    }
}
