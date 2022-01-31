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
    public partial class FormNot : Form
    {
        public FormNot()
        {
            InitializeComponent();
        }

        private void FormNot_Load(object sender, EventArgs e)
        {
            txtNotGiris.MaxLength = 140;
            
        }

        private void txtNotGiris_TextChanged(object sender, EventArgs e)
        {
            int kalan = (140 - txtNotGiris.TextLength);
            lblKalanHarf.Text = kalan.ToString();
            if (kalan==0)
            {
                lblKalanHarf.ForeColor = Color.Red;
            }

        }
    }
}
