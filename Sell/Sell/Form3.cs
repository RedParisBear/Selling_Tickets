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
    public partial class Form3 : Form
    {
        public Form3()
        {
            InitializeComponent();
        }

        public static int is_admin = Form4.is_admin;
        public static SqlConnection con = Form4.con;
        int i = 0;

        private void button1_Click(object sender, EventArgs e)      //поиск мероприятия
        {
            if (textBox1.Text != "")        //поиск по наименованию
            {
                dataGridView1.Rows.Clear();     //очистка

                string sqlExpression = "SELECT Events.Name, Events.Type, Events.DateTime, Events.Price, Places.Place_name FROM Events INNER JOIN Places ON Events.Place_Id = Places.Place_Id";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object name = reader["Name"];
                        object type = reader["Type"];
                        object date = reader["DateTime"];
                        object price = reader["Price"];
                        object place = reader["Place_name"];

                        string event_name = Convert.ToString(name);

                        if (string.Compare(event_name, textBox1.Text) == 0)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = name;
                            dataGridView1.Rows[i].Cells[1].Value = type;
                            dataGridView1.Rows[i].Cells[2].Value = date;
                            dataGridView1.Rows[i].Cells[3].Value = place;
                            dataGridView1.Rows[i].Cells[4].Value = price;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }

            if (textBox2.Text != "")        //поиск по типу
            {
                dataGridView1.Rows.Clear();     //очистка

                string sqlExpression = "SELECT Events.Name, Events.Type, Events.DateTime, Events.Price, Places.Place_name FROM Events INNER JOIN Places ON Events.Place_Id = Places.Place_Id";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object name = reader["Name"];
                        object type = reader["Type"];
                        object date = reader["DateTime"];
                        object price = reader["Price"];
                        object place = reader["Place_name"];

                        string type_name = Convert.ToString(type);

                        if (string.Compare(type_name, textBox2.Text) == 0)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = name;
                            dataGridView1.Rows[i].Cells[1].Value = type;
                            dataGridView1.Rows[i].Cells[2].Value = date;
                            dataGridView1.Rows[i].Cells[3].Value = place;
                            dataGridView1.Rows[i].Cells[4].Value = price;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }

            if (textBox4.Text != "")        //поиск по месту
            {
                dataGridView1.Rows.Clear();     //очистка

                string sqlExpression = "SELECT Events.Name, Events.Type, Events.DateTime, Events.Price, Places.Place_name FROM Events INNER JOIN Places ON Events.Place_Id = Places.Place_Id";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object name = reader["Name"];
                        object type = reader["Type"];
                        object date = reader["DateTime"];
                        object price = reader["Price"];
                        object place = reader["Place_name"];

                        string place_name = Convert.ToString(place);

                        if (string.Compare(place_name, textBox4.Text) == 0)
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = name;
                            dataGridView1.Rows[i].Cells[1].Value = type;
                            dataGridView1.Rows[i].Cells[2].Value = date;
                            dataGridView1.Rows[i].Cells[3].Value = place;
                            dataGridView1.Rows[i].Cells[4].Value = price;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }

            if (textBox5.Text != "")        //поиск по цене
            {
                dataGridView1.Rows.Clear();     //очистка

                string sqlExpression = "SELECT Events.Name, Events.Type, Events.DateTime, Events.Price, Places.Place_name FROM Events INNER JOIN Places ON Events.Place_Id = Places.Place_Id";

                SqlCommand command = new SqlCommand(sqlExpression, con);
                SqlDataReader reader = command.ExecuteReader();

                int i = 0;

                if (reader.HasRows)     //если есть данные
                {
                    while (reader.Read())
                    {
                        object name = reader["Name"];
                        object type = reader["Type"];
                        object date = reader["DateTime"];
                        object price = reader["Price"];
                        object place = reader["Place_name"];

                        int price_value = Convert.ToInt32(price);

                        if (price_value <= Convert.ToInt32(textBox5.Text))
                        {
                            dataGridView1.Rows.Add();
                            dataGridView1.Rows[i].Cells[0].Value = name;
                            dataGridView1.Rows[i].Cells[1].Value = type;
                            dataGridView1.Rows[i].Cells[2].Value = date;
                            dataGridView1.Rows[i].Cells[3].Value = place;
                            dataGridView1.Rows[i].Cells[4].Value = price;
                            i++;
                        }
                    }

                    reader.Close();
                }
            }
        }

        private void button2_Click(object sender, EventArgs e)      //Добавление
        {
            //string sqlExpression = "SELECT * FROM Places";

            //SqlCommand command = new SqlCommand(sqlExpression, con);
            //SqlDataReader reader = command.ExecuteReader();

            //int i = 0;

            //if (reader.HasRows)     //если есть данные
            //{
            //    while (reader.Read())
            //    {
            //        object place = reader["Place_name"];

            //        if (price_value <= Convert.ToInt32(textBox5.Text))
            //        {
            //            dataGridView1.Rows.Add();
            //            dataGridView1.Rows[i].Cells[0].Value = name;
            //            dataGridView1.Rows[i].Cells[1].Value = type;
            //            dataGridView1.Rows[i].Cells[2].Value = date;
            //            dataGridView1.Rows[i].Cells[3].Value = place;
            //            dataGridView1.Rows[i].Cells[4].Value = price;
            //            i++;
            //        }
            //    }

            //    reader.Close();
            //}

            //string sqlExpression = string.Format("INSERT INTO Events (Event_Id, Name, Type, DateTime, Price) VALUES (@Event_Id, @Name, @Type, @DateTime)");       //добавление в базу данных
            //SqlCommand command = new SqlCommand(sqlExpression, con);

            //command.Parameters.AddWithValue("@Event_Id", 2);
            //command.Parameters.AddWithValue("@Name", log);
            //command.Parameters.AddWithValue("@Type", pas);
            //command.Parameters.AddWithValue("@DateTime", null);

            //command.ExecuteNonQuery();
        }

        private void button3_Click(object sender, EventArgs e)      //Изменение
        {
            string name = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            string sqlExpression = string.Format("UPDATE Events SET Price = @Price WHERE Name = @Name");
            SqlCommand command = new SqlCommand(sqlExpression, con);

            command.Parameters.AddWithValue("@Price", dataGridView1.CurrentRow.Cells[4].Value);
            command.Parameters.AddWithValue("@Name", name);

            command.ExecuteNonQuery();
        }

        private void button4_Click(object sender, EventArgs e)      //Удаление
        {
            string name = Convert.ToString(dataGridView1.CurrentRow.Cells[0].Value);

            string sqlExpression = string.Format("DELETE FROM Events WHERE Name = @Name");
            SqlCommand command = new SqlCommand(sqlExpression, con);

            command.Parameters.AddWithValue("@Name", name);

            command.ExecuteNonQuery();
        }

        private void button5_Click(object sender, EventArgs e)      //Купить
        {
            dataGridView2.Rows.Add();
            dataGridView2.Rows[i].Cells[0].Value = textBox6.Text;
            i++;
        }

        private void button6_Click(object sender, EventArgs e)      //Печать
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application(); 
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing); 
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;

            for (int i = 1; i < dataGridView2.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView2.Columns[i - 1].HeaderText;
            }
  
            for (int i = 0; i < dataGridView2.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView2.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView2.Rows[i].Cells[j].Value.ToString();
                }
            }
              
            workbook.SaveAs("places.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing); 
            app.Quit();

            MessageBox.Show("Отчёт о занятых местах успешно распечатан!");
        }

        private void Form3_Load(object sender, EventArgs e)     //Отключение кнопок
        {
            if (is_admin == 0)
            {
                button2.Enabled = false;
                button3.Enabled = false;
                button4.Enabled = false;
                dataGridView1.ReadOnly = true;
            }
            
            if (is_admin == 1)
            {
                button5.Enabled = false;
                //button6.Enabled = false;
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)     //выбор плана (изображения)
        {
            string place = Convert.ToString(dataGridView1.CurrentRow.Cells[3].Value);

            if (string.Compare(place, "КЗЦ Миллениум") == 0)
            {
                pictureBox1.Load("C:\\Documents\\Технологии разработки ПО\\m.jpg");
                dataGridView2.Rows.Clear();
            }

            if (string.Compare(place, "ТЮЗ") == 0)
            {
                pictureBox1.Load("C:\\Documents\\Технологии разработки ПО\\t.jpg");
                dataGridView2.Rows.Clear();
            }

            if (string.Compare(place, "Арена 2000") == 0)
            {
                pictureBox1.Load("C:\\Documents\\Технологии разработки ПО\\a.jpg");
                dataGridView2.Rows.Clear();
            }

            if (string.Compare(place, "Стадион Шинник") == 0)
            {
                pictureBox1.Load("C:\\Documents\\Технологии разработки ПО\\sh.jpg");
                dataGridView2.Rows.Clear();
            }

            if (string.Compare(place, "Бассейн Лазурный") == 0)
            {
                pictureBox1.Load("C:\\Documents\\Технологии разработки ПО\\lp.jpg");
                dataGridView2.Rows.Clear();
            }

            if (string.Compare(place, "Театр им. Волкова") == 0)
            {
                pictureBox1.Load("C:\\Documents\\Технологии разработки ПО\\v.jpg");
                dataGridView2.Rows.Clear();
            }
        }
    }
}
