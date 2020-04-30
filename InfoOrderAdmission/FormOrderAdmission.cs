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
using Word = Microsoft.Office.Interop.Word;

namespace Personal_cardsApp1
{
    public partial class FormRegistraciya : Form
    {
        private readonly string TemplateFileName = @"c:\prikaz1.docx";
        public FormRegistraciya()
        {
            InitializeComponent();
        }

        private void order_admissionBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.order_admissionBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormOrderAdmission_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Order_admission". При необходимости она может быть перемещена или удалена.
            this.order_admissionTableAdapter.Fill(this.personal_cardsDataSet.Order_admission);

        }

        private void buttonExportWord_Click(object sender, EventArgs e)
        {
            var ID_order = ID_orderTextBox.Text;
            var NameOrganization = NameOrganizationTextBox.Text;
            var DocumentNumber = DocumentNumberTextBox.Text;
            var Compilation = CompilationTextBox.Text;
            var TakeWith = TakeWithTextBox.Text;
            var ServiceNumber = ServiceNumberTextBox.Text;
            var FIO = FIOTextBox.Text;
            var Division = DivisionTextBox.Text;
            var Position = PositionTextBox.Text;
            var Work = WorkTextBox.Text;
            var Tariff = TariffTextBox.Text;
            var Premium = PremiumTextBox.Text;
            var Period = PeriodTextBox.Text;
            var Contract = ContractTextBox.Text;
            var ContractNum = ContractNumTextBox.Text;

            //TODO: Word Export
            var wordApp = new Word.Application();
            wordApp.Visible = false;

            try
            {
                var wordDocument = wordApp.Documents.Open(TemplateFileName);
                ReplaceWordStub("{ID_order}", ID_order, wordDocument);
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

        private void FormOrderAdmission_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form OrderAdmission = Application.OpenForms[1];
            OrderAdmission.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            OrderAdmission.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            OrderAdmission.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            OrderAdmission.Show(); // отображаем Form2
            this.Hide();
        }

        private void buttonAdd_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_order = int.Parse(ID_orderTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            String querySave = "INSERT INTO Order_admission (ID_order, Name_organization, Document_number, Date_compilation, To_take_with, Service_number, FIO, Structural_division, Position, Nature_work, With_tariff_rate, At_premium, With_trial_period, Employment_contract_from, Contract_number) VALUES ('" + ID_order + "','" + NameOrganizationTextBox.Text + "','" + DocumentNumberTextBox.Text + "','" + CompilationTextBox.Text + "','" + TakeWithTextBox.Text + "','" + ServiceNumberTextBox.Text + "','" + FIOTextBox.Text + "','" + DivisionTextBox.Text + "','" + PositionTextBox.Text + "','" + WorkTextBox.Text + "','" + TariffTextBox.Text + "','" + PremiumTextBox.Text + "','" + PeriodTextBox.Text + "','" + ContractTextBox.Text + "','" + ContractNumTextBox.Text + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Приказ добавлен в базу данных");
        }

        private void FormRegistraciya_FormClosing(object sender, FormClosingEventArgs e)
        {
            var result = MessageBox.Show("Вы действительно хотите выйти?", "Внимание",
                          MessageBoxButtons.YesNo,
                          MessageBoxIcon.Question);
            if (result != DialogResult.Yes)
                e.Cancel = true;
        }
    }
}
