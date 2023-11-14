using ManageCafe.DAO;
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
        public fAdmin()
        {
            InitializeComponent();
            LoadAccountList();
        }

        void LoadAccountList()
        {
            string query = "EXEC dbo.USP_GetAccountByUserName @userName";

            DataProvider provider = new DataProvider();

            dtgvAccount.DataSource = provider.ExecuteQuery(query, new object[] {"staff"});

        }

		//void LoadFoodCategory()
		//{
		//	string query = "select * from dbo.FoodCategory";
        //void loadfoodcategory()
        //{
        //    string query = "select * from dbo.foodcategory";

		//	DataProvider provider = new DataProvider();

		//	dtgvCategory.DataSource = provider.ExecuteQuery(query);
        //    dtgvcategory.datasource = provider.executequery(query);

		//}
        //}



	}
    }
}
