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
using System.Data.Odbc;
using Microsoft.Office.Interop.Excel;
using Rectangle = System.Drawing.Rectangle;
using Point = System.Drawing.Point;
using Application = System.Windows.Forms.Application;

namespace Personal_cardsApp1
{
    public partial class FormAdditionalInformation : Form
    {
        public FormAdditionalInformation()
        {
            InitializeComponent();
        }

        private void more_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.more_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAdditionalInformation_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.More_information". При необходимости она может быть перемещена или удалена.
            this.more_informationTableAdapter.Fill(this.personal_cardsDataSet.More_information);

        }

        private void buttonBack3_Click(object sender, EventArgs e)
        {
            Form MoreInformation = Application.OpenForms[1];
            MoreInformation.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            MoreInformation.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            MoreInformation.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            MoreInformation.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_additional_information = int.Parse(ID_additional_informationTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            string querySave = "INSERT INTO More_information (ID_additional_information, Dismissal, Date_of_dismissal, The_order_number, Date_of_order) VALUES ('" + ID_additional_information + "','" + dismissalTextBox.Text + "','" + Date_of_dismissalTextBox.Text + "','" + the_order_numberTextBox.Text + "','" + Date_of_orderTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAdditionalInformation_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(40, 40));
        }

        private void buttonprint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void buttonExcel_Click(object sender, EventArgs e)
        {
            //Приложение
            Microsoft.Office.Interop.Excel.Application ExcelApp = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel.Workbook ExcelWorkBook;
            Microsoft.Office.Interop.Excel.Worksheet ExcelWorkSheet;
            //Книга.
            ExcelWorkBook = ExcelApp.Workbooks.Add(System.Reflection.Missing.Value);
            //Таблица.
            ExcelWorkSheet = (Microsoft.Office.Interop.Excel.Worksheet)ExcelWorkBook.Worksheets.get_Item(1);

            for (int i = 0; i < more_informationDataGridView.Rows.Count; i++)
            {
                for (int j = 0; j < more_informationDataGridView.ColumnCount; j++)
                {
                    ExcelApp.Cells[i + 1, j + 1] = more_informationDataGridView.Rows[i].Cells[j].Value;
                }
            }
            //Вызываем нашу созданную эксельку.
            ExcelApp.Visible = true;
            ExcelApp.UserControl = true;
        }
    }
}
