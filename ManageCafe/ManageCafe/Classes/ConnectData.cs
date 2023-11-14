using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ManageCafe.Classes
{
	internal class ConnectData
	{
		string strConnect = "Data Source = NQT; Initial Catalog = QuanLyQuanCafe;User ID=sa;Password=2504";
		public SqlConnection sqlCnn = null;
		//Ham mo ket noi
		private void OpenConnect()
		{
			sqlCnn = new SqlConnection(strConnect);
			if (sqlCnn.State != ConnectionState.Open)
			{
				sqlCnn.Open();
			}
		}
		//Ham dong ket noi
		private void CloseConnect()
		{
			if (sqlCnn.State != ConnectionState.Closed)
			{
				sqlCnn.Close();
				sqlCnn.Dispose();
			}
		}
		//Ham thuc hien lenh insert, update,delete
		public void ChangeData(string sql)
		{
			OpenConnect();
			SqlCommand command = new SqlCommand();
			command.Connection = sqlCnn;
			command.CommandText = sql;
			command.ExecuteNonQuery();
			CloseConnect();
			command.Dispose();
		}
		//Ham doc du lieu
		public DataTable ReadData(string sqlSelect)
		{
			DataTable dt = new DataTable();
			OpenConnect();
			SqlDataAdapter adapter = new SqlDataAdapter(sqlSelect, sqlCnn);
			adapter.Fill(dt);
			CloseConnect();
			adapter.Dispose();
			return dt;
		}
	}
}
