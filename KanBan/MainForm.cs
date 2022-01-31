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
    public partial class MainForm : Form
    {
        
        public MainForm()
        {
            InitializeComponent();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            label1.Hide();
            txtProjeAdi.Hide();
            btnKaydet.Hide();

            FormKanBan fkb = new FormKanBan();
            fkb.MdiParent = this;
            fkb.Text = txtProjeAdi.Text;
            fkb.Show();
            FormNot frnot = new FormNot();
            frnot.MdiParent = FormKanBan.ActiveForm;

           
        }
    }
}
