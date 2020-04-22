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
    public partial class FormAddReceptionTransfer : Form
    {
        public FormAddReceptionTransfer()
        {
            InitializeComponent();
        }

        private void reception_and_transferBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.reception_and_transferBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddReceptionTransfer_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Reception_and_transfer". При необходимости она может быть перемещена или удалена.
            this.reception_and_transferTableAdapter.Fill(this.personal_cardsDataSet.Reception_and_transfer);

        }

        private void buttonBack2_Click(object sender, EventArgs e)
        {
            Form ReceptionTransfer = Application.OpenForms[1];
            ReceptionTransfer.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            ReceptionTransfer.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            ReceptionTransfer.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            ReceptionTransfer.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_of_reception_and_transfer_to_work = int.Parse(ID_of_reception_and_transfer_to_workTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            DateTime dateTime = DateTime.Parse(Date1DateTimePicker.Text);
            String querySave = "INSERT INTO Reception_and_transfer (ID_of_reception_and_transfer_to_work, Structural_subdivision, Position, Tariff_rate, Date) VALUES ('" + ID_of_reception_and_transfer_to_work + "','" + Structural_subdivisionTextBox.Text + "','" + PositionTextBox.Text + "','" + Tariff_rateTextBox.Text + "','" + dateTime + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddReceptionTransfer_FormClosed(object sender, FormClosedEventArgs e)
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
    }
}
