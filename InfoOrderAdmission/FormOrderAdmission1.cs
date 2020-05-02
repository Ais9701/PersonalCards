using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Personal_cardsApp1
{
    public partial class FormOrderAdmission1 : Form
    {
        private readonly string TemplateFileName = @"C:\Users\Home\Desktop\ВКР\prikaz1.docx";
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
            String queryDelete = "DELETE FROM Order_admission where iD_order ='" + ID_orderTextBox.Text + "'";
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

        private void buttonExportWord_Click(object sender, EventArgs e)
        {
            var ID_order = ID_orderTextBox.Text;
            var NameOrganization = NameOrganizationTextBox.Text;
            var DocumentNumber = DocumentNumberTextBox.Text;
            var Compilation = CompilationDateTimePicker.Value.ToShortDateString();
            var TakeWith = TakeWithDateTimePicker.Value.ToShortDateString();
            var ServiceNumber = ServiceNumberTextBox.Text;
            var FIO = FIOTextBox.Text;
            var Division = DivisionTextBox.Text;
            var Position = PositionTextBox.Text;
            var Work = WorkTextBox.Text;
            var Tariff = TariffTextBox.Text;
            var Premium = PremiumTextBox.Text;
            var Period = PeriodTextBox.Text;
            var Contract = ContractDateTimePicker.Value.ToShortDateString();
            var ContractNum = ContractNumTextBox.Text;

            //TODO: Word Export
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{iD_order}", ID_order, wordDocument);
                ReplaceWordStub("{NameOrganization}", NameOrganization, wordDocument);
                ReplaceWordStub("{DocumentNumber}", DocumentNumber, wordDocument);
                ReplaceWordStub("{Compilation}", Compilation, wordDocument);
                ReplaceWordStub("{TakeWith}", TakeWith, wordDocument);
                ReplaceWordStub("{ServiceNumber}", ServiceNumber, wordDocument);
                ReplaceWordStub("{FIO}", FIO, wordDocument);
                ReplaceWordStub("{Division}", Division, wordDocument);
                ReplaceWordStub("{Position}", Position, wordDocument);
                ReplaceWordStub("{Work}", Work, wordDocument);
                ReplaceWordStub("{Tariff}", Tariff, wordDocument);
                ReplaceWordStub("{Premium}", Premium, wordDocument);
                ReplaceWordStub("{Period}", Period, wordDocument);
                ReplaceWordStub("{Contract}", Contract, wordDocument);
                ReplaceWordStub("{ContractNum}", ContractNum, wordDocument);

                wordDocument.SaveAs(@"C:\result.docx");
                wordApp.Visible = true;
            }
            catch
            {
                MessageBox.Show("Произошла ошибка");
            }
        }
            private void ReplaceWordStub(string stubToReplace, string text, Word.Document wordDocument)
            {
                var range = wordDocument.Content;
                range.Find.ClearFormatting();
                range.Find.Execute(FindText: stubToReplace, ReplaceWith: text);
            }

        private void FormOrderAdmission1_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }

        private void buttonrukovodstvoword_Click(object sender, EventArgs e)
        {
            Process.Start(@"C:\Users\Home\Desktop\ВКР\Руководства\Руководство по экспорту в Word.pdf");
        }
    }
    }

