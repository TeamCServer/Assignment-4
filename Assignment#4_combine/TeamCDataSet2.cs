using System.Collections.Generic;
using System.Data.SqlClient;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Assignment_4_combine
{


    partial class TeamCDataSet2
    {
    }
}

namespace Assignment_4_combine.TeamCDataSet2TableAdapters {
    
    
    

    public partial class CommentTableAdapter
    {
        internal static void InsertQuery(int user_id, string category, string star, string comment)
        {
            // 在這裡添加將數據插入到數據庫的邏輯
            // 這可能涉及到與數據庫的互動，具體取決於你的應用程式架構和數據庫結構。
            // 例如，你可能需要使用 ADO.NET、Entity Framework 或其他 ORM 框架。

            // 這裡是一個簡單的示例，假設你使用 ADO.NET：

            using (SqlConnection connection = new SqlConnection("Data Source=140.118.5.93,14433;Initial Catalog=TeamC;Persist Security Info=True;User ID=TeamCServer;Password=TeamC123@"))
            {
                connection.Open();

                using (SqlCommand command = new SqlCommand("INSERT INTO Comment (user_id, category, star, comment) VALUES (@user_idTextBox1, @comboBox1, @comboBox2, @textBox9)", connection))
                {
                    command.Parameters.AddWithValue("@user_idTextBox1", user_id);
                    command.Parameters.AddWithValue("@comboBox1", category);
                    command.Parameters.AddWithValue("@comboBox2", star);
                    command.Parameters.AddWithValue("@textBox9", comment);

                    command.ExecuteNonQuery();
                    
                }
            }
        }
    }
}
