using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kasir
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {

        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {
            
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            picBaju.Visible = false;
            picTas.Visible = false;
            picSepatu.Visible = false;
            picTasbih.Visible = false;
            if (cmbBarang.Text == "Baju")
                picBaju.Visible = true;
            if (cmbBarang.Text == "Tas")
                picTas.Visible = true;
            if (cmbBarang.Text == "Sepatu")
                picSepatu.Visible = true;
            if (cmbBarang.Text == "Tasbih")
                picTasbih.Visible = true;
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnBeli_Click(object sender, EventArgs e)
        {
            picTas.Visible = false;
            picSepatu.Visible = false;
            picBaju.Visible = false;
            picTasbih.Visible = false;
            if (cmbBarang.Text == "Tas")
                picTas.Visible = true;
            if (cmbBarang.Text == "Sepatu")
                picSepatu.Visible = true;
            if (cmbBarang.Text == "Baju")
                picBaju.Visible = true;
            if (cmbBarang.Text == "Tasbih ")
                picTasbih.Visible = true;


            listBox1.Items.Clear();
            listBox1.Items.Add("Kamu telah mengambil : "
                + cmbBarang.Text);
            listBox1.Items.Add("Sebanyak :" +
                numSebanyak.Value.ToString() + "Buah");
            listBox1.Items.Add("Dengan Harga: Rp. " +
                cmbHarga.Text);
            listBox1.Items.Add("Total Harga :Rp. " +
                txtTotalHarga.Text);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            string message = "yakin ingin keluar?";
            string title = "Close Window";
            MessageBoxButtons buttons = MessageBoxButtons.YesNo;
            DialogResult result = MessageBox.Show(message, title, buttons);
            if (result == DialogResult.Yes)
            {
                this.Close();
            }
            else
            {
                // Do something  
            }
        }

        private void btnTambah_Click(object sender, EventArgs e)
        {
            if (txtTambahBarang.Text == "")
            {
                MessageBox.Show("Isi Data Terlebih Dahulu !!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else if (txtTotalHarga.Text == "")
            {
                MessageBox.Show("Isi Data Terlebih Dahulu !!!", "Warning!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                cmbBarang.Items.Add(txtTambahBarang.Text);
                cmbHarga.Items.Add(txtTotalHarga.Text.ToString());
                MessageBox.Show("Barang Berhasil Ditambahkan!", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtTambahBarang.Clear();
                txtTotalHarga.Clear();
            }

            string namabarang = txtTambahBarang.Text;
            cmbBarang.Items.Add(namabarang);

            string hargabarang = txtTotalHarga.Text;
            cmbHarga.Items.Add(hargabarang);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void picBaju_Click(object sender, EventArgs e)
        {
            
        }

        private void picSepatu_Click(object sender, EventArgs e)
        {

        }

        private void lblBarang_Click(object sender, EventArgs e)
        {

        }

        private void lblTotal_Click(object sender, EventArgs e)
        {

        }

        private void lblGambar_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            cmbBarang.Text = "";
            numSebanyak.Text = "";
            txtTambahBarang.Text = "";
            picSepatu.Text = "";
            picBaju.Text = "";
            picTas.Text = "";
            picTasbih.Text = "";
            listBox1.Text = "";
            cmbHarga.Text = "";
            txtTotalHarga.Text = "";
            listBox1.Items.Clear();
            picTas.Visible = false;
            picSepatu.Visible = false;
            picBaju.Visible = false;
            picTasbih.Visible = false;
           
        }

        private void btnBayar_Click(object sender, EventArgs e)
        {
            picTas.Visible = false;
            picSepatu.Visible = false;
            picBaju.Visible = false;
            picTasbih.Visible = false;
            if (cmbBarang.Text == "Tas")
                picTas.Visible = true;
            if (cmbBarang.Text == "Sepatu")
                picSepatu.Visible = true;
            if (cmbBarang.Text == "Baju")
                picBaju.Visible = true;
            if (cmbBarang.Text == "Tasbih")
                picTasbih.Visible = true;


            string num = numSebanyak.Value.ToString
                ();
            string cmb = cmbHarga.Text;

            var TH = double.Parse(num) *
                double.Parse(cmb);
            txtTotalHarga.Text = TH.ToString()+ ".000";


            listBox1.Items.Clear();
            listBox1.Items.Add("Kamu telah mengambil : "
                + cmbBarang.Text);
            listBox1.Items.Add("Sebanyak : " +
                numSebanyak.Value.ToString() + " Buah");
            listBox1.Items.Add("Dengan Harga: Rp. " +
                cmbHarga.Text);
            listBox1.Items.Add("Total Harga : Rp." +
                txtTotalHarga.Text);
        }
    }
}
