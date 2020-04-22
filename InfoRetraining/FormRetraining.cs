﻿using System;
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
    public partial class FormRetraining : Form
    {
        public FormRetraining()
        {
            InitializeComponent();
        }

        private void retrainingBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.retrainingBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormRetraining_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Retraining". При необходимости она может быть перемещена или удалена.
            this.retrainingTableAdapter.Fill(this.personal_cardsDataSet.Retraining);

        }

        private void buttonAdd11_Click(object sender, EventArgs e)
        {
            FormAddRetraining f4 = new FormAddRetraining();
            f4.StartPosition = FormStartPosition.CenterScreen;
            f4.ShowDialog(this);
        }

        private void buttonBack11_Click(object sender, EventArgs e)
        {
            // вызываем главную форму, которая открыла текущую, главная форма всегда = 0 - [0]
            Form PersonalCards = Application.OpenForms[2];
            PersonalCards.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            PersonalCards.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            PersonalCards.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            PersonalCards.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            String queryDelete = "DELETE FROM Retraining where ID_retraining ='" + ID_retrainingTextBox.Text + "'";
            SqlDataAdapter SDA = new SqlDataAdapter(queryDelete, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Запись успешно удалена");
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(50, 50));
        }

        private void buttonSeal11_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void FormRetraining_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }
    }
}