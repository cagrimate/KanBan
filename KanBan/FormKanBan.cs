using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBan
{
    public partial class FormKanBan : Form
    {
        TextBox txtNotEkle;
        FormNot frnot;
        public FormKanBan()
        {
            InitializeComponent();
        }

        private void FormKanBan_Load(object sender, EventArgs e)
        {
           
        }
        Random rnd = new Random();

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            comboBox1.Items.Add(txtKategoriAdi.Text);
        }

        private void btnNotEkle_Click(object sender, EventArgs e)
        {
            //frnot = new FormNot();
            //frnot.Show();

            if (btnNotEkle==btnNotEkle.PerformClick)
            {

                int x = 10;
                int y = 15;
                txtNotEkle = new TextBox();
                txtNotEkle.Location = new Point(x, y);
                txtNotEkle.Size = new Size(180, 20);
                grpToDo.Controls.Add(txtNotEkle);
                y += 5;                
                        
            
        }
    }
}
