using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Word = Microsoft.Office.Interop.Word;

namespace Personal_cardsApp1
{
    public partial class FormOrderAdmission : Form
    {
        private readonly string TemplateFileName = @"c:\prikaz1.docx";
        public FormOrderAdmission()
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
            var IDOrder = IDOrderTextBox.Text;
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
                ReplaceWordStub("{IDOrder}", IDOrder, wordDocument);
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


    }
}
