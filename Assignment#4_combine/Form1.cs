using Assignment_4_combine.TeamCDataSet2TableAdapters;
using Assignment_4_combine.TeamCDataSet3TableAdapters;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Assignment_4_combine
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            menuStrip1.Visible = false;
        }

        private void 使用者ToolStripMenuItem_Click(object sender, EventArgs e) //點擊使用者來做新增刪除變更
        {
            tabControl1.SelectedIndex = 0;
            tabControl1.Visible = true;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            menuStrip1.Visible = true;
        }

        private void 司機ToolStripMenuItem_Click(object sender, EventArgs e)//點擊司機來做新增刪除變更
        {
            tabControl1.SelectedIndex = 1;
            tabControl1.Visible = true;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            menuStrip1.Visible = true;
        }

        private void usersBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.usersBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.add_Delete_Edit_Users);

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: 這行程式碼會將資料載入 'add_Delete_Edit_Products.Products' 資料表。您可以視需要進行移動或移除。
            this.productsTableAdapter1.Fill(this.add_Delete_Edit_Products.Products);
            // TODO: This line of code loads data into the 'teamCDataSet21.Comment' table. You can move, or remove it, as needed.
            this.commentTableAdapter.Fill(this.teamCDataSet21.Comment);
            // TODO: This line of code loads data into the 'teamCDataSet2.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter2.Fill(this.teamCDataSet2.Users);
            // TODO: This line of code loads data into the 'teamCDataSet2.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter2.Fill(this.teamCDataSet2.Users);
            // TODO: This line of code loads data into the 'teamCDataSet2.Users' table. You can move, or remove it, as needed.
            //this.usersTableAdapter2.Fill(this.teamCDataSet2.Users);
            // TODO: This line of code loads data into the 'search_Product.Products' table. You can move, or remove it, as needed.
            this.productsTableAdapter.Fill(this.search_Product.Products);
            // TODO: This line of code loads data into the 'teamCDataSet1.Driver' table. You can move, or remove it, as needed.
            this.driverTableAdapter1.Fill(this.teamCDataSet1.Driver);
            // TODO: This line of code loads data into the 'teamCDataSet.Users' table. You can move, or remove it, as needed.
            this.usersTableAdapter1.Fill(this.teamCDataSet.Users);
            // TODO: 這行程式碼會將資料載入 'add_Delete_Edit_Driver.Driver' 資料表。您可以視需要進行移動或移除。
            this.driverTableAdapter.Fill(this.add_Delete_Edit_Driver.Driver);
            // TODO: 這行程式碼會將資料載入 'add_Delete_Edit_Driver.Driver' 資料表。您可以視需要進行移動或移除。
            this.driverTableAdapter.Fill(this.add_Delete_Edit_Driver.Driver);
            // TODO: 這行程式碼會將資料載入 'add_Delete_Edit_Users.Users' 資料表。您可以視需要進行移動或移除。
            this.usersTableAdapter.Fill(this.add_Delete_Edit_Users.Users);

        }

        private void 關閉ToolStripMenuItem_Click(object sender, EventArgs e)//結束form
        {
            this.Close();
        }

        private void button1_Click(object sender, EventArgs e)  //使用者添加
        {
            usersTableAdapter.InsertQuery(int.Parse(textBox1.Text.ToString()), textBox2.Text, textBox3.Text, textBox4.Text);
            usersTableAdapter.Fill(add_Delete_Edit_Users.Users);
            MessageBox.Show("Add success");
        }

        private void button2_Click(object sender, EventArgs e) //使用者刪除
        {
            usersTableAdapter.DeleteQuery(int.Parse(user_idTextBox.Text.ToString()));
            usersTableAdapter.Fill(add_Delete_Edit_Users.Users);
            MessageBox.Show("Delete Suscess");
        }

        private void button3_Click(object sender, EventArgs e) //使用者編輯
        {
            usersTableAdapter.UpdateQuery(firstNameTextBox.Text, lastNameTextBox.Text, emailTextBox.Text, int.Parse(user_idTextBox.Text.ToString()));
            usersTableAdapter.Fill(add_Delete_Edit_Users.Users);
            MessageBox.Show("修改成功");
        }

        private void button4_Click(object sender, EventArgs e) //司機新增
        {
            driverTableAdapter.InsertQuery(int.Parse(textBox5.Text.ToString()), int.Parse(textBox6.Text.ToString()), int.Parse(textBox7.Text.ToString()), textBox8.Text);
            driverTableAdapter.Fill(add_Delete_Edit_Driver.Driver);
            MessageBox.Show("添加成功");
        }

        private void button5_Click(object sender, EventArgs e)//司機刪除
        {
            driverTableAdapter.DeleteQuery(int.Parse(driver_idTextBox.Text.ToString()));
            driverTableAdapter.Fill(add_Delete_Edit_Driver.Driver);
            MessageBox.Show("刪除成功");
        }

        private void button6_Click(object sender, EventArgs e) //司機編輯
        {
            driverTableAdapter.UpdateQuery(int.Parse(ageTextBox.Text.ToString()), int.Parse(priceTextBox.Text.ToString()), phoneNumberTextBox.Text, int.Parse(driver_idTextBox.Text.ToString()));
            driverTableAdapter.Fill(add_Delete_Edit_Driver.Driver);
            MessageBox.Show("編輯成功");
        }

        private void 查詢ToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void 產品ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 0;
            tabControl1.Visible = false;
            tabControl2.Visible = true;
            tabControl3.Visible = false;
            menuStrip1.Visible = true;
        }

        private void fillByToolStripButton_Click(object sender, EventArgs e)
        {
            /*
            try
            {
                this.usersTableAdapter1.FillBy(this.teamCDataSet.Users, ((int)(System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }
            */
            try
            {
                if (!string.IsNullOrEmpty(keywordToolStripTextBox.Text))
                {
                    // 有值，執行有條件的搜尋
                    int userId = (int)System.Convert.ChangeType(keywordToolStripTextBox.Text, typeof(int));
                    this.usersTableAdapter1.FillBy(this.teamCDataSet.Users, userId);
                }
                else
                {
                    // 沒值，顯示全部資料
                    this.usersTableAdapter1.Fill(this.teamCDataSet.Users);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void 使用者ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 1;
            tabControl1.Visible = false;
            tabControl2.Visible = true;
            tabControl3.Visible = false;
            menuStrip1.Visible = true;
        }

        private void 司機ToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            tabControl2.SelectedIndex = 2;
            tabControl1.Visible = false;
            tabControl2.Visible = true;
            tabControl3.Visible = false;
            menuStrip1.Visible = true;
        }

        private void 回饋ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            
        }

        private void fillByToolStripButton1_Click(object sender, EventArgs e)
        {
            try
            {
                this.usersTableAdapter1.FillBy(this.teamCDataSet.Users, ((int)(System.Convert.ChangeType(keywordToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillByToolStripButton1_Click_1(object sender, EventArgs e)
        {
            try
            {
                this.driverTableAdapter1.FillBy(this.teamCDataSet1.Driver, ((int)(System.Convert.ChangeType(keywordToolStripTextBox1.Text, typeof(int)))));
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void fillBy1ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(keywordToolStripTextBox1.Text))
                {
                    int driverId = (int)System.Convert.ChangeType(keywordToolStripTextBox1.Text, typeof(int));
                    this.driverTableAdapter1.FillBy1(this.teamCDataSet1.Driver, driverId);
                }
                else
                {
                    this.driverTableAdapter1.Fill(this.teamCDataSet1.Driver);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        

        private void fillByToolStripButton2_Click(object sender, EventArgs e)
        {
            try
            {
                if (!string.IsNullOrEmpty(keywordToolStripTextBox3.Text))
                {
                    int userId = (int)System.Convert.ChangeType(keywordToolStripTextBox3.Text, typeof(int));
                    this.usersTableAdapter2.FillBy(this.teamCDataSet2.Users, userId);
                }
                else
                {
                    this.usersTableAdapter2.Fill(this.teamCDataSet2.Users);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }


        }

        private void 填寫ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedIndex = 0;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = true;
            menuStrip1.Visible = true;
        }

        private void button7_Click(object sender, EventArgs e)
        {
            CommentTableAdapter.InsertQuery(
                int.Parse(user_idTextBox1.Text), comboBox1.Text, comboBox2.Text, textBox9.Text
            );
            commentTableAdapter.Fill(teamCDataSet21.Comment);
            MessageBox.Show("新增成功");


        }

        private void 查看紀錄ToolStripMenuItem_Click(object sender, EventArgs e)
        {
            tabControl3.SelectedIndex = 1;
            tabControl1.Visible = false;
            tabControl2.Visible = false;
            tabControl3.Visible = true;
            menuStrip1.Visible = true;
        }

        private void dataGridView4_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            
        }

        private void button10_Click(object sender, EventArgs e)//產品添加
        {
            productsTableAdapter1.InsertQuery(
            int.Parse(textBox10.Text.ToString()),
            textBox11.Text,
            int.Parse(textBox12.Text.ToString()),
            textBox13.Text,
            textBox14.Text,
            textBox15.Text,
            int.Parse(textBox16.Text.ToString()),
            int.Parse(textBox17.Text.ToString())
            );
            productsTableAdapter1.Fill(add_Delete_Edit_Products.Products);
            MessageBox.Show("添加成功");

        }

        private void button8_Click(object sender, EventArgs e)//產品編輯
        {
            productsTableAdapter1.UpdateQuery(
            titleTextBox.Text,
            int.Parse(category_idTextBox.Text.ToString()),
            paymentTextBox.Text,
            locationTextBox.Text,
            countryTextBox.Text,
            int.Parse(conditionTextBox.Text.ToString()),
            int.Parse(priceTextBox1.Text.ToString()),
            int.Parse(product_idTextBox.Text.ToString())
            );
            productsTableAdapter1.Fill(add_Delete_Edit_Products.Products);
            MessageBox.Show("修改成功");

        }

        private void button9_Click(object sender, EventArgs e)//產品刪除
        {
            productsTableAdapter1.DeleteQuery(
            int.Parse(product_idTextBox.Text.ToString())
            );
            productsTableAdapter1.Fill(add_Delete_Edit_Products.Products);
            MessageBox.Show("刪除成功");

        }

        private void 產品ToolStripMenuItem1_Click(object sender, EventArgs e)//產品添加編輯刪除   
        {
            tabControl1.SelectedIndex = 2;
            tabControl1.Visible = true;
            tabControl2.Visible = false;
            tabControl3.Visible = false;
            menuStrip1.Visible = true;
        }

        private void button11_Click(object sender, EventArgs e)
        {
            // 取得使用者輸入的搜尋條件
            string title = textBox19.Text;
            int productId = string.IsNullOrEmpty(textBox18.Text) ? 0 : Convert.ToInt32(textBox18.Text);
            string payment = comboBox3.Text;
            string location = textBox20.Text;

            // 使用LINQ進行搜尋
            var result = from row in search_Product.Tables["Products"].AsEnumerable()
                         where (string.IsNullOrEmpty(title) || row.Field<string>("title").Contains(title))
                            && (productId == 0 || row.Field<int>("product_id") == productId)
                            && (string.IsNullOrEmpty(payment) || row.Field<string>("payment").Contains(payment))
                            && (string.IsNullOrEmpty(location) || row.Field<string>("location").Contains(location))
                         select row;

            // 如果所有條件都沒有輸入值，就顯示全部資料
            if (string.IsNullOrEmpty(title) && productId == 0 && string.IsNullOrEmpty(payment) && string.IsNullOrEmpty(location))
            {
                dataGridView3.DataSource = search_Product.Tables["Products"];
            }
            else
            {
                // 建立一個新的DataTable來儲存搜尋結果
                DataTable searchResultTable = result.Any() ? result.CopyToDataTable() : search_Product.Tables["Products"].Clone();

                // 將結果顯示在DataGridView中
                dataGridView3.DataSource = searchResultTable;
            }
        }

        private void fillBy2ToolStripButton_Click(object sender, EventArgs e)
        {
            try
            {
                int productId;
                if (int.TryParse(keywordToolStripTextBox2.Text, out productId))
                {
                    this.commentTableAdapter.FillBy2(this.teamCDataSet21.Comment, productId);
                }
                else
                {
                    this.commentTableAdapter.Fill(this.teamCDataSet21.Comment);
                }
            }
            catch (System.Exception ex)
            {
                System.Windows.Forms.MessageBox.Show(ex.Message);
            }

        }

        private void button12_Click(object sender, EventArgs e)
        {
            string account = textBox21.Text;
            string pass = textBox22.Text;
            if (account == "admin" && pass == "P@ssword")
            {
                MessageBox.Show("歡迎進入");
                tabControl1.Visible = true;
                tabControl2.Visible = false;
                tabControl3.Visible = false;
                menuStrip1.Visible = true;
            }
            else
            {
                MessageBox.Show("帳密錯誤");
            }
        }

        private void textBox22_TextChanged(object sender, EventArgs e)
        {
            TextBox passwordTextBox = new TextBox();
            textBox22.PasswordChar = '*'; // 你可以使用其他字符來代替星號
            textBox22.UseSystemPasswordChar = true;

        }
        /*
private void fillBy1ToolStripButton1_Click(object sender, EventArgs e)
{
try
{
this.usersTableAdapter2.FillBy1(this.teamCDataSet2.Users, ((int)(System.Convert.ChangeType(keywordToolStripTextBox4.Text, typeof(int)))));
}
catch (System.Exception ex)
{
System.Windows.Forms.MessageBox.Show(ex.Message);
}

}
*/
    }
}
