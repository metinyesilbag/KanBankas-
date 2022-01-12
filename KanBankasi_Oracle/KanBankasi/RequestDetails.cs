using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KanBankasi
{


    public partial class RequestDetails : Form
    {
        public String tcAl;
        

        public RequestDetails()
        {
            InitializeComponent();
        }

        private void btnKapat_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void RequestDetails_Load(object sender, EventArgs e)
        {
            MessageBox.Show(tcAl, "Veri Kaydı", MessageBoxButtons.OK, MessageBoxIcon.Information);
        }
    }
}
