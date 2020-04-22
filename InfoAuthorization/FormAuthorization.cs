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
using System.Data.Sql;

namespace Personal_cardsApp1
{
    public partial class FormAuthorization : Form
    {
        public FormAuthorization()
        {
            InitializeComponent();
        }


        private void Form1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.personal_cardsDataSet.User);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {

                string loginUser = txtboxlog.Text;
                string passUser = txtboxpas.Text;
                DB db = new DB();

                DataTable table = new DataTable();
                SqlDataAdapter adapter = new SqlDataAdapter();
                SqlCommand commandPersonalCards = new SqlCommand("SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role= 'prog'", db.GetConnection());
                commandPersonalCards.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandPersonalCards.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter.SelectCommand = commandPersonalCards;
                adapter.Fill(table);
                DataTable table1 = new DataTable();
                SqlDataAdapter adapter1 = new SqlDataAdapter();
                SqlCommand commandkadr = new SqlCommand("SELECT * FROM [User] WHERE Login = @uL AND Password = @uP AND Role = 'kadr'", db.GetConnection());
                commandkadr.Parameters.Add("@uL", SqlDbType.VarChar).Value = loginUser;
                commandkadr.Parameters.Add("@uP", SqlDbType.VarChar).Value = passUser;
                adapter1.SelectCommand = commandkadr;
                adapter1.Fill(table1);
                if (table.Rows.Count > 0)
                {
                    Form ifrm = new FormMenu();
                    ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                    ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                    ifrm.Show(); // отображаем Form2
                    this.Hide(); // скрываем Form1 (this - текущая форма)
                }
                else
                {
                    if (table1.Rows.Count > 0)
                    {
                        Form ifrm = new FormKadrPersonalCards();
                        ifrm.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
                        ifrm.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
                        ifrm.Show(); // отображаем Form2
                        this.Hide(); // скрываем Form1 (this - текущая форма)
                    }
                    else
                    {
                        MessageBox.Show("Неверный логин или пароль");
                        txtboxlog.Clear();
                        txtboxpas.Clear();
                        a++;
                        if (a == 3)
                        {
                            a = 0;
                            timer1.Enabled = true;
                            button1.Enabled = false;
                            label2.Visible = true;
                            button2.Enabled = false;
                            txtboxlog.Enabled = false;
                            txtboxpas.Enabled = false;
                        }
                    }
                }
            }
            finally { }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        int a = 0, b = 15, s = 0, d = 15;

        private void timer1_Tick(object sender, EventArgs e)
        {
            if (b > 0)
            {
                b--;
                label2.Text = ("Вы заблокированы. Пожалуйста подождите: " + b);
                if (b == 0)
                {
                    b = d;
                    d += 5;
                    timer1.Enabled = false;
                    button1.Enabled = true;
                    label2.Visible = false;
                    button2.Enabled = true;
                    label2.Text = "";
                    txtboxlog.Enabled = true;
                    txtboxpas.Enabled = true;
                }
            }
            s++;
        }
    }
    }

