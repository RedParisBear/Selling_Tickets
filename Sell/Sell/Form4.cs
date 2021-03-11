using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using Microsoft.SqlServer.Management.Smo;
using Microsoft.SqlServer.Management.Common;

namespace Sell
{
    public partial class Form4 : Form
    {
        public Form4()
        {
            InitializeComponent();
        }

        /*public class Client
        {
            public int Client_Id { get; set; }
            public string Login { get; set; }
            public string Password { get; set; }
            public int Is_Admin { get; set; }
        }*/

        public static int is_admin = 2;
        public static SqlConnection con;
        public int index = 3;

        private void button1_Click(object sender, EventArgs e)      //Вход
        {
            String ConnectString = "Integrated Security=false;User Id=" + textBox1.Text + ";Password=" + textBox2.Text + ";Initial Catalog=Selling_Tickets;server=HPAC150\\SQLEXPRESS";
            con = new SqlConnection(ConnectString);

            Exception error = null;

            try
            {
                con.Open();

                //this.Hide();
            }

            catch(Exception ex)
            {
                error = ex;
                MessageBox.Show("Вход не был осуществлён.", "Ошибка!", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            finally
            {
                if (error == null)
                {
                    //MessageBox.Show("Подключение установлено.");
                    string sqlExpression = "SELECT * FROM Clients";      //определение статуса

                    SqlCommand command = new SqlCommand(sqlExpression, con);
                    SqlDataReader reader = command.ExecuteReader();

                    if (reader.HasRows)     //если есть данные
                    {
                        while (reader.Read())
                        {
                            object status = reader["Is_Admin"];
                            object login = reader["Login"];
                            object password = reader["Password"];

                            string l = Convert.ToString(login);
                            string p = Convert.ToString(password);

                            if ((string.Compare(textBox1.Text, l) == 0) && (string.Compare(textBox2.Text, p) == 0))
                            {
                                is_admin = Convert.ToInt32(status);
                                break;
                            }
                        }

                        reader.Close();


                        if (is_admin != 2)
                        {
                            Form1 form = new Form1();       //создание главного окна
                            form.Show();
                        }
                    }

                }
                
                //con.Close();
            }   
        }

        private void button2_Click(object sender, EventArgs e)      //Регистрация
        {
            //String ConnectString = @"Data Source=.\\SQLEXPRESS;Integrated Security = true;Initial Catalog = Selling_Tickets;server = HPAC150\\SQLEXPRESS";

            //SqlConnection con = new SqlConnection(ConnectString);
            //ServerConnection servcon = new ServerConnection(con);

            Server srv = new Server("HPAC150\\SQLEXPRESS");                       //сервер
            Database db = srv.Databases["Selling_Tickets"];                       //база данных

            Login login = new Login(srv, textBox1.Text);        //создание логина
            login.LoginType = LoginType.SqlLogin;
            login.Create(textBox2.Text);

            string c = string.Concat("Client", Convert.ToString(index));

            User user = new User(db, c);                //создание пользователя для созданного логина
            user.Login = textBox1.Text;
            user.Create();

            DatabasePermissionSet perm = new DatabasePermissionSet();

            perm.Connect = true;
            perm.Select = true;
            db.Grant(perm, user.Name);

            String log = textBox1.Text;
            String pas = textBox2.Text;
            is_admin = 2;

            String ConnectString = "Integrated Security=true;Initial Catalog=Selling_Tickets;server=HPAC150\\SQLEXPRESS";
            SqlConnection con = new SqlConnection(ConnectString);

            con.Open();

            string sqlExpression = string.Format("INSERT INTO Clients (Client_Id, Login, Password, Is_Admin) VALUES (@Client_Id, @Login, @Password, @Is_Admin)");       //добавление в базу данных
            SqlCommand command = new SqlCommand(sqlExpression, con);

            command.Parameters.AddWithValue("@Client_Id", index);
            command.Parameters.AddWithValue("@Login", log);
            command.Parameters.AddWithValue("@Password", pas);
            command.Parameters.AddWithValue("@Is_Admin", 2);

            command.ExecuteNonQuery();

            index++;

            con.Close();

            MessageBox.Show("Регистрация успешно завершена!");
        }
    }
}
