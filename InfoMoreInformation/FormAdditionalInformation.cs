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


namespace Personal_cardsApp1
{
    public partial class FormAdditionalInformation : Form
    {
        public FormAdditionalInformation()
        {
            InitializeComponent();
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
            DVG_TO_EXCEL(more_informationDataGridView);
        }

       public void DVG_TO_EXCEL(DataGridView more_informationDataGridView)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < more_informationDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i + 1] = more_informationDataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < more_informationDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < more_informationDataGridView.Columns.Count; j++)
                {
                    if (more_informationDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 2] = more_informationDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 2] = "";
                    }
                }
            }
            for (int i = 0; i < more_informationDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = more_informationDataGridView.Rows[i].HeaderCell.Value;
            }
        }

        private void more_informationDataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void more_informationBindingNavigator_RefreshItems(object sender, EventArgs e)
        {

        }
    }
}
