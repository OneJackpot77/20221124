using Microsoft.Data.SqlClient;
using WinFormsApp1.Properties;

namespace WinFormsApp1
{
    public partial class form1 : Form
    {
        public form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
           using SqlConnection conn = new(
              connectionString:
              "Server=(localdb)\\MSSQLLocalDB;" +
              "Database=pelda;" +
              "Trusted_Connection=Yes;");
               conn.Open();

            SqlDataReader reader = new SqlCommand(
                "SELECT * from emberek;",conn
                ).ExecuteReader();

          

            while (reader.Read())
            {
                dataGridView1.Rows.Add
                    (
                     reader[0],
                     reader[1],
                     reader[2],
                     reader[3]
                    ) ;
            }

        }
    }
 
}