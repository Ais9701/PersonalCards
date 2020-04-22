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
    public partial class FormAddSocialBenefits : Form
    {
        public FormAddSocialBenefits()
        {
            InitializeComponent();
        }

        private void social_benefitsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.social_benefitsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddSocialBenefits_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Social_benefits". При необходимости она может быть перемещена или удалена.
            this.social_benefitsTableAdapter.Fill(this.personal_cardsDataSet.Social_benefits);

        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            Form SocialBenefits = Application.OpenForms[1];
            SocialBenefits.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            SocialBenefits.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            SocialBenefits.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            SocialBenefits.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_social_benefits = int.Parse(ID_social_benefitsTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            DateTime dateTime = DateTime.Parse(Date_of_issueDateTimePicker.Text);
            String querySave = "INSERT INTO Social_benefits (ID_social_benefits, Name_of_benefit, Document_number, Date_of_issue) VALUES ('" + ID_social_benefits + "','" + Name_of_benefitTextBox.Text + "','" + Document_numberTextBox.Text + "','" + dateTime + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddSocialBenefits_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
