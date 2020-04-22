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
    public partial class FormAddPersonalCards : Form
    {
        public FormAddPersonalCards()
        {
            InitializeComponent();
        }

        private void vacationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.vacationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddVacation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Vacation". При необходимости она может быть перемещена или удалена.
            this.vacationTableAdapter.Fill(this.personal_cardsDataSet.Vacation);

        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            Form Vacation = Application.OpenForms[1];
            Vacation.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Vacation.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Vacation.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Vacation.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_vacation = int.Parse(ID_vacationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Vacation (ID_vacation, Type_of_vacation, Working_period_with, Period_of_work_on, Number_of_vacation_days, Start_date, Expiry_date) VALUES ('" + ID_vacation + "','" + Type_of_vacationTextBox.Text + "','" + Working_period_withTextBox.Text + "','" + Period_of_work_onTextBox.Text + "','" + Number_of_vacation_daysTextBox.Text + "','" + Start_dateTextBox.Text + "','" + Expiry_dateTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddPersonalCards_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(40, 40));
        }

        private void buttonSeal2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
