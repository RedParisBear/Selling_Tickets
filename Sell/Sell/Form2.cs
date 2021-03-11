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
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        public static SqlConnection con = Form4.con;

        private void button1_Click(object sender, EventArgs e)      //просмотр собственного календаря мероприятий
        {
            dataGridView1.Rows.Clear();     //очистка

            string sqlExpression = "SELECT DateTime, Name FROM Events ORDER BY DateTime";

            SqlCommand command = new SqlCommand(sqlExpression, con);
            SqlDataReader reader = command.ExecuteReader();

            int i = 0;

            if (reader.HasRows)     //если есть данные
            {
                while (reader.Read())
                {
                    object date = reader["DateTime"];
                    object name = reader["Name"];

                    DateTime onlyDate = Convert.ToDateTime(date).Date;

                    if ((onlyDate > Convert.ToDateTime(textBox1.Text)) && (onlyDate < Convert.ToDateTime(textBox2.Text)))
                    {
                        dataGridView1.Rows.Add();
                        dataGridView1.Rows[i].Cells[0].Value = date;
                        dataGridView1.Rows[i].Cells[1].Value = name;
                        i++;
                    }  
                }

                reader.Close();
            }
        }

        private void Form2_Load(object sender, EventArgs e)         //вывод ближайших мероприятий при загрузке окна
        {
            string sqlExpression = "SELECT DateTime, Name FROM Events ORDER BY DateTime DESC";

            SqlCommand command = new SqlCommand(sqlExpression, con);
            SqlDataReader reader = command.ExecuteReader();

            int i = 0;

            if (reader.HasRows)     //если есть данные
            {
                while (reader.Read())
                {
                    object date = reader["DateTime"];
                    object name = reader["Name"];

                    dataGridView1.Rows.Add();
                    dataGridView1.Rows[i].Cells[0].Value = date;
                    dataGridView1.Rows[i].Cells[1].Value = name;
                    i++;
                }

                reader.Close();
            }
        }

        private void button2_Click(object sender, EventArgs e)      //печать (в Excel)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            // creating new WorkBook within Excel application  
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            // creating new Excelsheet in workbook  
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            // see the excel sheet behind the program  
            //app.Visible = true;
            // get the reference of first sheet. By default its name is Sheet1.  
            // store its reference to worksheet  
            worksheet = workbook.Sheets[1];
            worksheet = workbook.ActiveSheet;
            // changing the name of active sheet  
            //worksheet.Name = "Exported from gridview";
            // storing header part in Excel  
            for (int i = 1; i < dataGridView1.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i] = dataGridView1.Columns[i - 1].HeaderText;
            }
            // storing Each row and column value to excel sheet  
            for (int i = 0; i < dataGridView1.Rows.Count - 1; i++)
            {
                for (int j = 0; j < dataGridView1.Columns.Count; j++)
                {
                    worksheet.Cells[i + 2, j + 1] = dataGridView1.Rows[i].Cells[j].Value.ToString();
                }
            }
            // save the application  
            workbook.SaveAs("calendar.xls", Type.Missing, Type.Missing, Type.Missing, Type.Missing, Type.Missing, Microsoft.Office.Interop.Excel.XlSaveAsAccessMode.xlExclusive, Type.Missing, Type.Missing, Type.Missing, Type.Missing);
            // Exit from the application  
            app.Quit();

            MessageBox.Show("Календарь успешно распечатан!");
        }
    }
}