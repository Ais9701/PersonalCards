using Personal_cardsApp1.InfoPersonalCards;
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
    public partial class FormProba : Form
    {
       
        public FormProba()
        {
            InitializeComponent();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void employee_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormProba_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Retraining". При необходимости она может быть перемещена или удалена.
            this.retrainingTableAdapter.Fill(this.personal_cardsDataSet.Retraining);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Education". При необходимости она может быть перемещена или удалена.
            this.educationTableAdapter.Fill(this.personal_cardsDataSet.Education);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Certification". При необходимости она может быть перемещена или удалена.
            this.certificationTableAdapter.Fill(this.personal_cardsDataSet.Certification);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Military_registration". При необходимости она может быть перемещена или удалена.
            this.military_registrationTableAdapter.Fill(this.personal_cardsDataSet.Military_registration);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Rewards". При необходимости она может быть перемещена или удалена.
            this.rewardsTableAdapter.Fill(this.personal_cardsDataSet.Rewards);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Level_of_education". При необходимости она может быть перемещена или удалена.
            this.level_of_educationTableAdapter.Fill(this.personal_cardsDataSet.Level_of_education);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.personal_cardsDataSet.Vacation);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.personal_cardsDataSet.Advanced_training);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.personal_cardsDataSet.Advanced_training);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Reception_and_transfer". При необходимости она может быть перемещена или удалена.
            this.reception_and_transferTableAdapter.Fill(this.personal_cardsDataSet.Reception_and_transfer);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Social_benefits". При необходимости она может быть перемещена или удалена.
            this.social_benefitsTableAdapter.Fill(this.personal_cardsDataSet.Social_benefits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Social_benefits". При необходимости она может быть перемещена или удалена.
            this.social_benefitsTableAdapter.Fill(this.personal_cardsDataSet.Social_benefits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Social_benefits". При необходимости она может быть перемещена или удалена.
            this.social_benefitsTableAdapter.Fill(this.personal_cardsDataSet.Social_benefits);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.More_information". При необходимости она может быть перемещена или удалена.
            this.more_informationTableAdapter.Fill(this.personal_cardsDataSet.More_information);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Employee_information". При необходимости она может быть перемещена или удалена.
            this.employee_informationTableAdapter.Fill(this.personal_cardsDataSet.Employee_information);
            
        }

        private void number_passportLabel_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormAddPersonalCards1 f14 = new FormAddPersonalCards1();
            f14.StartPosition = FormStartPosition.CenterScreen;
            f14.ShowDialog(this);
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            FormAdditionalInformation f7 = new FormAdditionalInformation();
            f7.StartPosition = FormStartPosition.CenterScreen;
            f7.ShowDialog(this);
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM More_information where ID_additional_information ='" + iD_additional_informationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd3_Click(object sender, EventArgs e)
        {
            FormAddSocialBenefits f2 = new FormAddSocialBenefits();
            f2.StartPosition = FormStartPosition.CenterScreen;
            f2.ShowDialog(this);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Social_benefits where ID_social_benefits ='" + iD_social_benefitsTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd4_Click(object sender, EventArgs e)
        {
            FormAddReceptionTransfer f5 = new FormAddReceptionTransfer();
            f5.StartPosition = FormStartPosition.CenterScreen;
            f5.ShowDialog(this);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Reception_and_transfer where ID_of_reception_and_transfer_to_work ='" + iD_of_reception_and_transfer_to_workTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd5_Click(object sender, EventArgs e)
        {
            FormAddAdvancedTraining f12 = new FormAddAdvancedTraining();
            f12.StartPosition = FormStartPosition.CenterScreen;
            f12.ShowDialog(this);
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Advanced_training where ID_qualification ='" + iD_qualificationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd6_Click(object sender, EventArgs e)
        {
            FormAddPersonalCards f1 = new FormAddPersonalCards();
            f1.StartPosition = FormStartPosition.CenterScreen;
            f1.ShowDialog(this);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Vacation where ID_vacation ='" + iD_vacationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd12_Click(object sender, EventArgs e)
        {
            FormAddLevelEducation f9 = new FormAddLevelEducation();
            f9.StartPosition = FormStartPosition.CenterScreen;
            f9.ShowDialog(this);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Level_of_education where ID_level_of_education ='" + iD_level_of_educationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd7_Click(object sender, EventArgs e)
        {
            FormAddRewards f3 = new FormAddRewards();
            f3.StartPosition = FormStartPosition.CenterScreen;
            f3.ShowDialog(this);
        }

        private void button9_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Rewards where ID_rewards ='" + iD_rewardsTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd8_Click(object sender, EventArgs e)
        {
            FormAddMilitaryRegistration f8 = new FormAddMilitaryRegistration();
            f8.StartPosition = FormStartPosition.CenterScreen;
            f8.ShowDialog(this);
        }

        private void button10_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Military_registration where ID_military_registration ='" + iD_military_registrationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd9_Click(object sender, EventArgs e)
        {
            FormAddCertification f11 = new FormAddCertification();
            f11.StartPosition = FormStartPosition.CenterScreen;
            f11.ShowDialog(this);
        }

        private void button11_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Certification where ID_certification ='" + iD_certificationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd10_Click(object sender, EventArgs e)
        {
            FormAddEducation f10 = new FormAddEducation();
            f10.StartPosition = FormStartPosition.CenterScreen;
            f10.ShowDialog(this);
        }

        private void button12_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Education where ID_education ='" + iD_educationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonAdd11_Click(object sender, EventArgs e)
        {
            FormAddRetraining f4 = new FormAddRetraining();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.ShowDialog(this);
        }

        private void button13_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Retraining where ID_retraining ='" + iD_retrainingTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void FormProba_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void bindingNavigatorPositionItem_Click(object sender, EventArgs e)
        {

        }
        private void bindingNavigatorMoveNextItem_Click(object sender, EventArgs e)
        {

        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack15_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack16_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void button17_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack18_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack19_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack20_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack21_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack22_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack23_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonBack24_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void groupBox18_Enter(object sender, EventArgs e)
        {

        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Employee_information where ID_employee ='" + iD_employeeTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
       
        }

        private void FormProba_FormClosing(object sender, FormClosingEventArgs e)
        {
            
        }

        private void buttonexit_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Authorization = Application.OpenForms[0];
            Authorization.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Authorization.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Authorization.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Authorization.Show(); // отображаем Form2
            this.Hide();
        }
    }
}
