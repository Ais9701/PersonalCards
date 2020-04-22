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
    public partial class FormAddCertification : Form
    {
        public FormAddCertification()
        {
            InitializeComponent();
        }

        private void certificationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.certificationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddCertification_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Certification". При необходимости она может быть перемещена или удалена.
            this.certificationTableAdapter.Fill(this.personal_cardsDataSet.Certification);

        }

        private void buttonBack7_Click(object sender, EventArgs e)
        {
            Form Certification = Application.OpenForms[1];
            Certification.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Certification.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Certification.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Certification.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_certification = int.Parse(ID_certificationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Certification (ID_certification, Date_of_certification, Commission_decision, Protocol_number, Date_of_report) VALUES ('" + ID_certification + "','" + Date_of_certificationTextBox.Text + "','" + Commission_decisionTextBox.Text + "','" + Protocol_numberTextBox.Text + "','" + Date_of_reportTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddCertification_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
