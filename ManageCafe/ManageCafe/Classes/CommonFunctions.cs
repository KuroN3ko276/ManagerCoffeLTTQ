using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ManageCafe.Classes
{
	internal class CommonFunctions
	{
		Classes.ConnectData dtBase = new Classes.ConnectData();
		public void FillComboBox(ComboBox comboName, DataTable data, string displayMember, string valueMember)
		{
			comboName.DataSource = data;
			comboName.DisplayMember = displayMember;
			comboName.ValueMember = valueMember;
		}
	}
}
