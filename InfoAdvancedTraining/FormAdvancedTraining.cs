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
    public partial class FormAdvancedTraining : Form
    {
        public FormAdvancedTraining()
        {
            InitializeComponent();
        }

        private void advanced_trainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.advanced_trainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAdvancedTraining_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Advanced_training". При необходимости она может быть перемещена или удалена.
            this.advanced_trainingTableAdapter.Fill(this.personal_cardsDataSet.Advanced_training);

        }

        private void buttonBack5_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form PersonalCards = Application.OpenForms[2];
            PersonalCards.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            PersonalCards.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            PersonalCards.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            PersonalCards.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonAdd5_Click(object sender, EventArgs e)
        {
            FormAddAdvancedTraining f12 = new FormAddAdvancedTraining();
            f12.StartPosition = FormStartPosition.CenterScreen;
            f12.ShowDialog(this);
        }

        private void buttonSeal5_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Advanced_training where ID_qualification ='" + ID_qualificationTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(50, 50));
        }

        private void FormAdvancedTraining_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
