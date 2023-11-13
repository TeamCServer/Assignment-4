using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.teamCDataSet);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'products_Category.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.products_Category.Products);
            // TODO: 這行程式碼會將資料載入 'products_Category.Category' 資料表。您可以視需要進行移動或移除。
            this.categoryTableAdapter.Fill(this.products_Category.Category);
            // TODO: 這行程式碼會將資料載入 'products_Category.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter.Fill(this.products_Category.Products);
            // TODO: 這行程式碼會將資料載入 'products_Category.Category' 資料表。您可以視需要進行移動或移除。
            this.categoryTableAdapter.Fill(this.products_Category.Category);
            // TODO: 這行程式碼會將資料載入 'rating_Users.Ratings' 資料表。您可以視需要進行移動或移除。
            this.ratingsTableAdapter.Fill(this.rating_Users.Ratings);
            // TODO: 這行程式碼會將資料載入 'teamCDataSet.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter.Fill(this.teamCDataSet.Users);

        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter1.FillBy(this.productSearchDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.productsTableAdapter1.FillBy(this.productSearchDataSet.Products);
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }
    }
}
