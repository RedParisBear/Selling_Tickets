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
    public partial class Form1 : Form
    {
        public Form1()
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

        public static int is_admin = Form4.is_admin;
        public static SqlConnection con = Form4.con;

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 newMDIChild1 = new Form2();
            newMDIChild1.MdiParent = this;
            newMDIChild1.StartPosition = FormStartPosition.Manual;
            newMDIChild1.Location = new Point(0, 0);
            newMDIChild1.Show();

            Form3 newMDIChild2 = new Form3();
            newMDIChild2.MdiParent = this;
            newMDIChild2.StartPosition = FormStartPosition.Manual;
            newMDIChild2.Location = new Point(389, 0);
            newMDIChild2.Show();
        }

        private void ближайшиеМероприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form2 newMDIChild1 = new Form2();
            newMDIChild1.MdiParent = this;
            newMDIChild1.StartPosition = FormStartPosition.Manual;
            newMDIChild1.Location = new Point(0, 0);
            newMDIChild1.Show();
        }

        private void поискМероприятияToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Form3 newMDIChild2 = new Form3();
            newMDIChild2.MdiParent = this;
            newMDIChild2.StartPosition = FormStartPosition.Manual;
            newMDIChild2.Location = new Point(389, 0);
            newMDIChild2.Show();
        }

        private void дляАдминистраторовToolStripMenuItem_Click(object sender, EventArgs e)      //изменение и удаление информации администраторами
        {
            if (is_admin == 1)
            {
                Form5 newMDIChild3 = new Form5();
                newMDIChild3.MdiParent = this;
                newMDIChild3.Show();
            }
        }

        private void выходToolStripMenuItem_Click(object sender, EventArgs e)       //выход
        {
            con.Close();
            Environment.Exit(0);
        }
    }
}