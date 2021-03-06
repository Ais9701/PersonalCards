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
    public partial class FormAddRewards : Form
    {
        public FormAddRewards()
        {
            InitializeComponent();
        }

        private void rewardsBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.rewardsBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.personal_cardsDataSet);

        }

        private void FormAddRewards_Load(object sender, EventArgs e)
        {
            // TODO: данная строка кода позволяет загрузить данные в таблицу "personal_cardsDataSet.Rewards". При необходимости она может быть перемещена или удалена.
            this.rewardsTableAdapter.Fill(this.personal_cardsDataSet.Rewards);

        }

        private void buttonBack7_Click(object sender, EventArgs e)
        {
            Form Rewards = Application.OpenForms[1];
            Rewards.StartPosition = FormStartPosition.Manual; // меняем параметр StartPosition у Form1, иначе она будет использовать тот, который у неё прописан в настройках и всегда будет открываться по центру экрана
            Rewards.Left = this.Left; // задаём открываемой форме позицию слева равную позиции текущей формы
            Rewards.Top = this.Top; // задаём открываемой форме позицию сверху равную позиции текущей формы
            Rewards.Show(); // отображаем Form2
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection connection = new SqlConnection(@"Data Source=DESKTOP-DPL61M9\SQLEXPRESS;Initial Catalog=Personal_cards;Integrated Security=True");
            connection.Open();
            int ID_rewards = int.Parse(ID_rewardsTextBox.Text);//эта строчка кода преобразует введенный ID клиента из строкового типа в тип int
            DateTime dateTime = DateTime.Parse(DateDateTimePicker.Text);
            String querySave = "INSERT INTO Rewards (ID_rewards, The_name_of_the_awards, Number, Date) VALUES ('" + ID_rewards + "','" + The_name_of_the_awardsTextBox.Text + "','" + NumberTextBox.Text + "','"+ dateTime + "')";
            SqlDataAdapter SDA = new SqlDataAdapter(querySave, connection);
            SDA.SelectCommand.ExecuteNonQuery();
            connection.Close();
            MessageBox.Show("Сотрудник добавлен в базу данных");
        }

        private void FormAddRewards_FormClosed(object sender, FormClosedEventArgs e)
        {
            System.Windows.Forms.Application.Exit();
        }

        private void printDocument1_PrintPage(object sender, System.Drawing.Printing.PrintPageEventArgs e)
        {
            var bitmap = new Bitmap(Width, Height);
            DrawToBitmap(bitmap, new Rectangle(Point.Empty, bitmap.Size));
            e.Graphics.DrawImage(bitmap, new Point(40, 40));
        }

        private void buttonSeal2_Click(object sender, EventArgs e)
        {
            printDocument1.Print();
        }

        private void FormAddRewards_FormClosing(object sender, FormClosingEventArgs e)
        {
           
        }
    }
}
