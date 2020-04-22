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
using System.Data.Odbc;

namespace Personal_cardsApp1
{
    public partial class FormAddEducation : Form
    {
        public FormAddEducation()
        {
            InitializeComponent();
        }

        private void educationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.educationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddEducation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Education". При необходимости она может быть перемещена или удалена.
            this.educationTableAdapter.Fill(this.personal_cardsDataSet.Education);

        }

        private void buttonBack7_Click(object sender, EventArgs e)
        {
            Form Education = Application.OpenForms[1];
            Education.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Education.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Education.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Education.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonSave_Click(object sender, EventArgs e)
        {
                SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
                connection.Open();
                int ID_education = int.Parse(iD_educationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            DateTime dateTime = DateTime.Parse(year_of_graduationDateTimePicker.Text);
        String querySave = "INSERT INTO Education (ID_education, Level_of_education, Name_of_educational_institution, Name_of_the_document_on_education, Series, Number, Year_of_graduation) VALUES ('" + ID_education + "','" + level_of_educationTextBox.Text + "','" + name_of_educational_institutionTextBox.Text + "','" + name_of_the_document_on_educationTextBox.Text + "','" + seriesTextBox.Text + "','" + numberTextBox.Text + "','" + dateTime + "')";
                SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
                SDA.SelectCommand.ExecuteNonQuery();
                connection.Close();
                MessageBox.Show("Сотрудник добавлен в базу данных");
            }

        private void FormAddEducation_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
    }

