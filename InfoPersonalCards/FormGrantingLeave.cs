﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
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
    }
    }

