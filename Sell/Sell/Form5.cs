using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Sell
{
    public partial class Form5 : Form
    {
        public Form5()
        {
            InitializeComponent();
        }

        public static SqlConnection con = Form4.con;

        private void button1_Click(object sender, EventArgs e)      //Поиск
        {
            if (textBox6.Text != "")        //поиск по паролю
            {
                dataGridView2.Rows.Clear();     //очистка

                string sqlExpression = "SELECT * FROM Clients";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object login = reader["Login"];
                        object password = reader["Password"];
                        object status = reader["Is_Admin"];

                        string log = Convert.ToString(login);

                        if (string.Compare(log, textBox6.Text) == 0)
                        {
                            dataGridView2.Rows.Add();
                            dataGridView2.Rows[i].Cells[0].Value = login;
                            dataGridView2.Rows[i].Cells[1].Value = password;
                            dataGridView2.Rows[i].Cells[2].Value = status;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }

            if (textBox7.Text != "")        //поиск по типу
            {
                dataGridView2.Rows.Clear();     //очистка

                string sqlExpression = "SELECT * FROM Clients";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object login = reader["Login"];
                        object password = reader["Password"];
                        object status = reader["Is_Admin"];

                        string pas = Convert.ToString(password);

                        if (string.Compare(pas, textBox7.Text) == 0)
                        {
                            dataGridView2.Rows.Add();
                            dataGridView2.Rows[i].Cells[0].Value = login;
                            dataGridView2.Rows[i].Cells[1].Value = password;
                            dataGridView2.Rows[i].Cells[2].Value = status;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }

            if (textBox8.Text != "")        //поиск по статусу
            {
                dataGridView2.Rows.Clear();     //очистка

                string sqlExpression = "SELECT * FROM Clients";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object login = reader["Login"];
                        object password = reader["Password"];
                        object status = reader["Is_Admin"];

                        int stat = Convert.ToInt32(status);

                        if (stat == Convert.ToInt32(textBox8.Text))
                        {
                            dataGridView2.Rows.Add();
                            dataGridView2.Rows[i].Cells[0].Value = login;
                            dataGridView2.Rows[i].Cells[1].Value = password;
                            dataGridView2.Rows[i].Cells[2].Value = status;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Изменение
        {
            string login = Convert.ToString(dataGridView2.CurrentRow.Cells[0].Value);

            string sqlExpression = string.Format("UPDATE Clients SET Is_Admin = @Is_Admin WHERE Login = @Login");
            SqlCommand command = new SqlCommand(sqlExpression, con);

            command.Parameters.AddWithValue("@Is_Admin", dataGridView2.CurrentRow.Cells[2].Value);
            command.Parameters.AddWithValue("@Login", login);

            command.ExecuteNonQuery();
        }
    }
}
