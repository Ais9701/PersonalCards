using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
            FormOrderAdmission f30 = new FormOrderAdmission();
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
    }
}
