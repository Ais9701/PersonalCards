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

namespace Personal_cardsApp1.InfoPersonalCards
{
    public partial class FormAddPersonalCards1 : Form
    {
        public FormAddPersonalCards1()
        {
            InitializeComponent();
        }

        private void employee_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddPersonalCards1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Employee_information". При необходимости она может быть перемещена или удалена.
            this.employee_informationTableAdapter.Fill(this.personal_cardsDataSet.Employee_information);

        }

        private void buttonBack15_Click(object sender, EventArgs e)
        {
            Form PersonalCards = Application.OpenForms[2];
            PersonalCards.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            PersonalCards.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            PersonalCards.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            PersonalCards.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonSave1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_employee = int.Parse(id_employeeTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Employee_information (ID_employee, Firstname, Middlename, Lastname, Number_passport, Place_of_issue, Date_of_issue, Date_of_birth, Place_of_birth, Citizenship, Phone, Foreign_language_knowledge_name, Foreign_language_knowledge_proficiency, Marital_status, State_of_the_family, The_name_of_a_profession, Experience, ID_additional_information, ID_social_benefits, ID_vacation, ID_award, ID_retraining, ID_qualification, ID_of_reception_and_transfer_to_work, ID_education, ID_certification, ID_military_registration, ID_level_of_education, ID_schedules, ID_granting_leave, ID_order) VALUES ('" + ID_employee + "','" + FirstnameTextBox.Text + "','" + MiddlenameTextBox.Text + "','" + LastnameTextBox.Text + "','" + Number_passportTextBox.Text + "','" + Place_of_issueTextBox.Text + "','" + Date_of_issueTextBox.Text + "','" + Date_of_birthTextBox.Text + "','" + Place_of_birthTextBox.Text + "','" + CitizenshipTextBox.Text + "','" + PhoneTextBox.Text + "','" + Foreign_language_knowledge_nameTextBox.Text + "','" + Foreign_language_knowledge_proficiencyTextBox.Text + "','" + Marital_statusTextBox.Text + "','" + State_of_the_familyTextBox.Text + "','" + The_name_of_a_professionTextBox.Text + "','" + ExperienceTextBox.Text + "','" + ID_additional_informationTextBox.Text + "','" + ID_social_benefitsTextBox.Text + "','" + ID_vacationTextBox.Text + "','" + ID_awardTextBox.Text + "','" + ID_retrainingTextBox.Text + "','" + ID_qualificationTextBox.Text + "','" + ID_of_reception_and_transfer_to_workTextBox.Text + "','" + ID_educationTextBox.Text + "','" + ID_certificationTextBox.Text + "','" + ID_military_registrationTextBox.Text + "','" + ID_level_of_educationTextBox.Text + "','" + ID_schedulesTextBox.Text + "','" + ID_granting_leaveTextBox.Text + "','" + ID_orderTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddPersonalCards1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
