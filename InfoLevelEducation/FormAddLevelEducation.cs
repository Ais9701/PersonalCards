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
    public partial class FormAddLevelEducation : Form
    {
        public FormAddLevelEducation()
        {
            InitializeComponent();
        }

        private void level_of_educationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.level_of_educationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddLevelEducation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Level_of_education". При необходимости она может быть перемещена или удалена.
            this.level_of_educationTableAdapter.Fill(this.personal_cardsDataSet.Level_of_education);

        }

        private void buttonBack7_Click(object sender, EventArgs e)
        {
            Form LevelEducation = Application.OpenForms[1];
            LevelEducation.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            LevelEducation.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            LevelEducation.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            LevelEducation.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_level_of_education = int.Parse(ID_level_of_educationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Level_of_education (ID_level_of_education, Level_of_education) VALUES ('" + ID_level_of_education + "','" + Level_of_educationTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddLevelEducation_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
