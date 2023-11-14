using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCafe
{
    public partial class fAdmin : Form
    {
        Classes.ConnectData dtBase = new Classes.ConnectData();
        Classes.CommonFunctions functions = new Classes.CommonFunctions();
        public fAdmin()
        {
            InitializeComponent();
        }

		private void dtgvBill_CellContentClick(object sender, DataGridViewCellEventArgs e)
		{

		}
	}
}
