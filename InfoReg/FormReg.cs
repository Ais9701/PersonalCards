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

namespace Personal_cardsApp1
{
    public partial class FormReg : Form
    {
        public FormReg()
        {
            InitializeComponent();
        }
        SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
        private void buttonregistraciya_Click(object sender, EventArgs e)
        {
            connection.Open();
            string query = "INSERT INTO [User] ([Login], [Password], [Role]) VALUES ('" + loginTextBox.Text + "','" + passwordTextBox.Text + "','" + roleTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(query, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Регистрация прошла успешно");
            FormProba a = new FormProba();
            a.Left = this.Left;
            a.Top = this.Top;
            a.Show();
            this.Hide();
        }

        private void userBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.userBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormReg_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.User". При необходимости она может быть перемещена или удалена.
            this.userTableAdapter.Fill(this.personal_cardsDataSet.User);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void FormReg_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
