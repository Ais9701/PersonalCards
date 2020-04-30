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
    public partial class FormAddRetraining : Form
    {
        public FormAddRetraining()
        {
            InitializeComponent();
        }

        private void retrainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.retrainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddRetraining_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Retraining". При необходимости она может быть перемещена или удалена.
            this.retrainingTableAdapter.Fill(this.personal_cardsDataSet.Retraining);

        }

        private void buttonBack7_Click(object sender, EventArgs e)
        {
            Form Retraining = Application.OpenForms[1];
            Retraining.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Retraining.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Retraining.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Retraining.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_retraining = int.Parse(ID_retrainingTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Retraining (ID_retraining, The_beginning_of_the_training, Completion_of_retraining, Specialty, Document_name, Document_number, Date) VALUES ('" + ID_retraining + "','" + The_beginning_of_the_trainingTextBox.Text + "','" + Completion_of_retrainingTextBox.Text + "','" + SpecialtyTextBox.Text + "','" + Document_nameTextBox.Text + "','" + Document_numberTextBox.Text + "','" + DateTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddRetraining_FormClosed(object sender, FormClosedEventArgs e)
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

        private void FormAddRetraining_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
