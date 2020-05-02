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
    public partial class FormAddAdvancedTraining : Form
    {
        public FormAddAdvancedTraining()
        {
            InitializeComponent();
        }

        private void advanced_trainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.advanced_trainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddAdvancedTraining_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.personal_cardsDataSet.Advanced_training);

        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            Form AdvancedTraining = Application.OpenForms[1];
            AdvancedTraining.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            AdvancedTraining.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            AdvancedTraining.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            AdvancedTraining.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_qualification = int.Parse(ID_qualificationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Advanced_training (ID_qualification, Beginning_of_training, The_end_of_the_training, Type_of_qualification, Name_of_educational_institution, Its_location, Document_name, Series_document_number, Date) VALUES ('" + ID_qualification + "','" + Beginning_of_trainingTextBox.Text + "','" + The_end_of_the_trainingTextBox.Text + "','" + Type_of_qualificationTextBox.Text + "','" + Name_of_educational_institutionTextBox.Text + "','" + Its_locationTextBox.Text + "','" + Document_nameTextBox.Text + "','" + Series_document_numberTextBox.Text + "','" + DateTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddAdvancedTraining_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonSeal2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(40, 40));
        }

        private void FormAddAdvancedTraining_FormClosing(object sender, FormClosingEventArgs e)
        {
          
        }
    }
}
