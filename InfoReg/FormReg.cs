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

        private void buttonregistraciya_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_user = int.Parse(ID_userTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO [User] (ID_user, Login, Password, Role) VALUES ('" + ID_user + "','" + LoginTextBox.Text + "','" + PasswordTextBox.Text + "','" + RoleTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Вы зарегистрированы");
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
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Authorization = Application.OpenForms[1];
            Authorization.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Authorization.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Authorization.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Authorization.Show(); // отображаем Form2
            this.Hide();
        }

        private void FormReg_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
