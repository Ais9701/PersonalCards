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
    public partial class FormAddMilitaryRegistration : Form
    {
        public FormAddMilitaryRegistration()
        {
            InitializeComponent();
        }

        private void military_registrationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.military_registrationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddMilitaryRegistration_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Military_registration". При необходимости она может быть перемещена или удалена.
            this.military_registrationTableAdapter.Fill(this.personal_cardsDataSet.Military_registration);

        }

        private void buttonBack7_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form MilitaryRegistration = Application.OpenForms[1];
            MilitaryRegistration.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            MilitaryRegistration.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            MilitaryRegistration.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            MilitaryRegistration.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_military_registration = int.Parse(ID_military_registrationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Military_registration (ID_military_registration, Stock_category, Military_rank, Composition_profile, Full_code_designation_VUS, Category_of_fitness_for_military_service, The_name_of_the_military_commissariat) VALUES ('" + ID_military_registration + "','" + Stock_categoryTextBox.Text + "','" + Military_rankTextBox.Text + "','" + Composition_profileTextBox.Text + "','" + Full_code_designation_VUSTextBox.Text + "','" + Category_of_fitness_for_military_serviceTextBox.Text + "','" + The_name_of_the_military_commissariatTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddMilitaryRegistration_FormClosed(object sender, FormClosedEventArgs e)
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

        private void FormAddMilitaryRegistration_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
