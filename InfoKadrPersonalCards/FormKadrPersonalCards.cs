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
    public partial class FormKadrPersonalCards : Form
    {
        public FormKadrPersonalCards()
        {
            InitializeComponent();
        }

        private void employee_informationBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.employee_informationBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void kadr_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Employee_information". При необходимости она может быть перемещена или удалена.
            this.employee_informationTableAdapter.Fill(this.personal_cardsDataSet.Employee_information);

        }

        private void buttonBack_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form Authorization = Application.OpenForms[0];
            Authorization.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Authorization.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Authorization.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Authorization.Show(); // отображаем Form2
            this.Hide();
        }

        private void FormKadrPersonalCards_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}
