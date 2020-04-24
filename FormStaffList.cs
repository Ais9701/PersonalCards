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
    public partial class FormStaffList : Form
    {
        public FormStaffList()
        {
            InitializeComponent();
        }

        private void staff_listBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.staff_listBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormStaffList_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Staff_list". При необходимости она может быть перемещена или удалена.
            this.staff_listTableAdapter.Fill(this.personal_cardsDataSet.Staff_list);

        }

        private void buttonExcelStaffList_Click(object sender, EventArgs e)
        {
            DVG_TO_EXCEL(staff_listDataGridView);
        }

        public void DVG_TO_EXCEL(DataGridView staff_listDataGridView)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < staff_listDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i + 1] = staff_listDataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < staff_listDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < staff_listDataGridView.Columns.Count; j++)
                {
                    if (staff_listDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 2] = staff_listDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 2] = "";
                    }
                }
            }
            for (int i = 0; i < staff_listDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = staff_listDataGridView.Rows[i].HeaderCell.Value;
            }
        }

        private void FormStaffList_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_schedules = int.Parse(ID_schedulesTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Staff_list (ID_schedules, Name_organization, Document_number, Date_compilation, Order_organization_from, Order_number, For_period, Date, Staff_number_units, Name, Code, Position, [Number_ staff_units], Tariff_rate, Allowances, Total_rubles) VALUES ('" + ID_schedules + "','" + Name_organizationTextBox.Text + "','" + Document_numberTextBox.Text + "','" + Date_compilationTextBox.Text + "','" + Order_organization_fromTextBox.Text + "','" + Order_numberTextBox.Text + "','" + For_periodTextBox.Text +  "','" + DateTextBox.Text + "','" + Staff_number_unitsTextBox.Text + "','" + NameTextBox.Text + "','" + CodeTextBox .Text + "','" + PositionTextBox.Text + "','" + NumberunitsTextBox .Text + "','" + Tariff_rateTextBox.Text + "','" + AllowancesTextBox.Text + "','" + Staff_number_unitsTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Расписание добавлено в базу данных");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(40, 40));
        }

        private void buttonPrint_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            staff_listDataGridView.Rows.RemoveAt(staff_listDataGridView.CurrentCell.RowIndex);
            staff_listTableAdapter.Update(personal_cardsDataSet);
            MessageBox.Show("Запись удалена из базы данных");
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

        private void staff_listDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
        }
    }
    }
