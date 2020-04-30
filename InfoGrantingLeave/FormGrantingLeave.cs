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

namespace Personal_cardsApp1.InfoPersonalCards
{
    public partial class FormGrantingLeave : Form
    {
        public FormGrantingLeave()
        {
            InitializeComponent();
        }

        private void granting_leaveBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.granting_leaveBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormGrantingLeave_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Granting_leave". При необходимости она может быть перемещена или удалена.
            this.granting_leaveTableAdapter.Fill(this.personal_cardsDataSet.Granting_leave);
            SqlConnection con = new SqlConnection("Data Source='.\\SQLEXPRESS';Integrated Security = 'true'; Initial Catalog = 'Personal_cards'");
            SqlCommand cmd = new SqlCommand("SELECT FIO FROM granting_leave", con);
            con.Open();
            SqlDataReader reader = cmd.ExecuteReader();
            AutoCompleteStringCollection SCollection = new
           AutoCompleteStringCollection();
            while (reader.Read())
            {
                SCollection.Add(reader.GetString(0));
            }
            textBoxavtozapolnenie.AutoCompleteCustomSource = SCollection;
            con.Close();
        }


        private void buttonExcelGrantingLeave_Click(object sender, EventArgs e)
        {
            DVG_TO_EXCEL(granting_leaveDataGridView);
        }

        public void DVG_TO_EXCEL(DataGridView granting_leaveDataGridView)
        {
            Microsoft.Office.Interop.Excel._Application app = new Microsoft.Office.Interop.Excel.Application();
            Microsoft.Office.Interop.Excel._Workbook workbook = app.Workbooks.Add(Type.Missing);
            Microsoft.Office.Interop.Excel._Worksheet worksheet = null;
            app.Visible = true;
            worksheet = workbook.Sheets["Лист1"];
            worksheet = workbook.ActiveSheet;
            for (int i = 1; i < granting_leaveDataGridView.Columns.Count + 1; i++)
            {
                worksheet.Cells[1, i + 1] = granting_leaveDataGridView.Columns[i - 1].HeaderText;
            }
            for (int i = 0; i < granting_leaveDataGridView.Rows.Count - 1; i++)
            {
                for (int j = 0; j < granting_leaveDataGridView.Columns.Count; j++)
                {
                    if (granting_leaveDataGridView.Rows[i].Cells[j].Value != null)
                    {
                        worksheet.Cells[i + 2, j + 2] = granting_leaveDataGridView.Rows[i].Cells[j].Value.ToString();
                    }
                    else
                    {
                        worksheet.Cells[i + 2, j + 2] = "";
                    }
                }
            }
            for (int i = 0; i < granting_leaveDataGridView.Rows.Count; i++)
            {
                worksheet.Cells[i + 2, 1] = granting_leaveDataGridView.Rows[i].HeaderCell.Value;
            }
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_granting_leave = int.Parse(ID_granting_leaveTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Granting_leave (ID_granting_leave, Name_organization, Document_number, Date_compilation, Service_number, FIO, Structural_division, Position, Period_working_with, [Period_working_ for], Number_vacation_days, Provided_with, [Provided_ for]) VALUES ('" + ID_granting_leave + "','" + Name_organizationTextBox.Text + "','" + Document_numberTextBox.Text + "','" + Date_compilationTextBox.Text + "','" + Service_numberTextBox.Text + "','" + FIOTextBox.Text + "','" + Structural_divisionTextBox.Text + "','" + PositionTextBox.Text + "','" + Period_working_withTextBox.Text + "','" + Period_forTextBox.Text + "','" + Number_vacation_daysTextBox.Text + "','" + Provided_withTextBox.Text + "','" + ProvidedforTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Отпуск зарегистрирован");
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

        private void buttonDelete_Click(object sender, EventArgs e)
        {
            granting_leaveDataGridView.Rows.RemoveAt(granting_leaveDataGridView.CurrentCell.RowIndex);
            granting_leaveTableAdapter.Update(personal_cardsDataSet);
            MessageBox.Show("Запись удалена из базы данных");
        }

        private void granting_leaveDataGridView_UserDeletingRow(object sender, DataGridViewRowCancelEventArgs e)
        {
            DialogResult dr = MessageBox.Show("Удалить запись?", "Удаление", MessageBoxButtons.OKCancel,
            MessageBoxIcon.Warning, MessageBoxDefaultButton.Button2);
            if (dr == DialogResult.Cancel)
            {
                e.Cancel = true;
            }
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

        private void FormGrantingLeave_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void textBoxavtozapolnenie_TextChanged(object sender, EventArgs e)
        {
            granting_leaveBindingSource.Filter = "FIO = \'" + textBoxavtozapolnenie.Text + "\'";
        }

        private void buttonotobrazitvse_Click(object sender, EventArgs e)
        {
            granting_leaveBindingSource.Filter = null;
            textBoxavtozapolnenie.Clear();
        }

        private void FormGrantingLeave_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
    }

