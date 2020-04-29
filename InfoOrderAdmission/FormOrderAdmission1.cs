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
    public partial class FormOrderAdmission1 : Form
    {
        public FormOrderAdmission1()
        {
            InitializeComponent();
        }

        private void order_admissionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_admissionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormOrderAdmission1_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Order_admission". При необходимости она может быть перемещена или удалена.
            this.order_admissionTableAdapter.Fill(this.personal_cardsDataSet.Order_admission);

        }

        private void FormOrderAdmission1_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            FormRegistraciya f30 = new FormRegistraciya();
            f30.StartPosition = FormStartPosition.CenterScreen;
            f30.ShowDialog(this);
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Menu = Application.OpenForms[1];
            Menu.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Menu.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Menu.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Menu.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonpoisk_Click(object sender, EventArgs e)
        {
            order_admissionBindingSource.Filter = "[FIO] LIKE'" + textBoxpoisk.Text + "%'";
        }

        private void buttonfilter_Click(object sender, EventArgs e)
        {
            order_admissionBindingSource.Filter = null;
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Order_admission where iD_order ='" + iD_orderTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(40, 40));
        }

        private void buttonSeal10_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }
    }
}
