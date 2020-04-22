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
    public partial class FormMoreInformation : Form
    {
        public FormMoreInformation()
        {
            InitializeComponent();
        }

        private void more_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.more_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormMoreInformation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Employee_information". При необходимости она может быть перемещена или удалена.
            this.employee_informationTableAdapter.Fill(this.personal_cardsDataSet.Employee_information);
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.More_information". При необходимости она может быть перемещена или удалена.
            this.more_informationTableAdapter.Fill(this.personal_cardsDataSet.More_information);

        }

        private void dismissalLabel_Click(object sender, EventArgs e)
        {

        }

        private void date_of_dismissalLabel_Click(object sender, EventArgs e)
        {

        }

        private void the_order_numberLabel_Click(object sender, EventArgs e)
        {

        }

        private void date_of_orderLabel_Click(object sender, EventArgs e)
        {

        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form MoreInformation = Application.OpenForms[2];
            MoreInformation.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            MoreInformation.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            MoreInformation.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            MoreInformation.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonAdd2_Click(object sender, EventArgs e)
        {
            FormAdditionalInformation f7 = new FormAdditionalInformation();
            f7.StartPosition = FormStartPosition.CenterScreen;
            f7.ShowDialog(this);
        }

        private void buttonSeal2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM More_information where ID_additional_information ='" + iD_additional_informationTextBox.Text + "'";
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

        private void FormMoreInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
