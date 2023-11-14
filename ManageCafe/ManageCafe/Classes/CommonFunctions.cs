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
		public string SinhMaTuDong(String TenBang, string MaBatDau, string TruongMa)
		{
			int id = 0;
			bool dung = false;
			string ma;
			do
			{
				ma = MaBatDau + id.ToString();
				DataTable dt = dtBase.ReadData("Select * from " + TenBang + " Where " + TruongMa + "='" + ma + "'");
				if (dt.Rows.Count == 0)
				{
					dung = true;
				}
				else
				{
					id++;
				}
			} while (dung == false);
			return ma;
		}
	}
}
