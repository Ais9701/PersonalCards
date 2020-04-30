namespace Personal_cardsApp1
{
    partial class FormAdditionalInformation
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.more_informationBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.more_informationTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.More_informationTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.buttonBack3 = new System.Windows.Forms.Button();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.ID_additional_informationTextBox = new System.Windows.Forms.TextBox();
            this.dismissalTextBox = new System.Windows.Forms.TextBox();
            this.the_order_numberTextBox = new System.Windows.Forms.TextBox();
            this.Date_of_dismissalTextBox = new System.Windows.Forms.TextBox();
            this.Date_of_orderTextBox = new System.Windows.Forms.TextBox();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            this.buttonprint = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.more_informationBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // more_informationBindingSource
            // 
            this.more_informationBindingSource.DataMember = "More_information";
            this.more_informationBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // more_informationTableAdapter
            // 
            this.more_informationTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Granting_leaveTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = this.more_informationTableAdapter;
            this.tableAdapterManager.Order_admissionTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.Staff_listTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Enabled = false;
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для 0";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // buttonBack3
            // 
            this.buttonBack3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack3.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack3.Location = new System.Drawing.Point(1072, 470);
            this.buttonBack3.Name = "buttonBack3";
            this.buttonBack3.Size = new System.Drawing.Size(151, 52);
            this.buttonBack3.TabIndex = 2;
            this.buttonBack3.Text = "Назад";
            this.buttonBack3.UseVisualStyleBackColor = false;
            this.buttonBack3.Click += new System.EventHandler(this.buttonBack3_Click);
            // 
            // buttonAdd
            // 
            this.buttonAdd.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd.Location = new System.Drawing.Point(1072, 296);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(151, 55);
            this.buttonAdd.TabIndex = 13;
            this.buttonAdd.Text = "Добавить";
            this.buttonAdd.UseVisualStyleBackColor = false;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(261, 241);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(247, 50);
            this.label1.TabIndex = 3;
            this.label1.Text = "ID сотрудника:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(261, 308);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(212, 50);
            this.label2.TabIndex = 4;
            this.label2.Text = "Увольнение:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(261, 364);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(290, 50);
            this.label3.TabIndex = 5;
            this.label3.Text = "Дата увольнения:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(261, 427);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(261, 50);
            this.label4.TabIndex = 6;
            this.label4.Text = "Номер приказа:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 17.87234F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(261, 491);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(234, 50);
            this.label5.TabIndex = 7;
            this.label5.Text = "Дата приказа:";
            // 
            // ID_additional_informationTextBox
            // 
            this.ID_additional_informationTextBox.Location = new System.Drawing.Point(595, 262);
            this.ID_additional_informationTextBox.Name = "ID_additional_informationTextBox";
            this.ID_additional_informationTextBox.Size = new System.Drawing.Size(100, 26);
            this.ID_additional_informationTextBox.TabIndex = 8;
            // 
            // dismissalTextBox
            // 
            this.dismissalTextBox.Location = new System.Drawing.Point(595, 325);
            this.dismissalTextBox.Name = "dismissalTextBox";
            this.dismissalTextBox.Size = new System.Drawing.Size(266, 26);
            this.dismissalTextBox.TabIndex = 9;
            // 
            // the_order_numberTextBox
            // 
            this.the_order_numberTextBox.Location = new System.Drawing.Point(595, 448);
            this.the_order_numberTextBox.Name = "the_order_numberTextBox";
            this.the_order_numberTextBox.Size = new System.Drawing.Size(100, 26);
            this.the_order_numberTextBox.TabIndex = 11;
            // 
            // Date_of_dismissalTextBox
            // 
            this.Date_of_dismissalTextBox.Location = new System.Drawing.Point(595, 385);
            this.Date_of_dismissalTextBox.Name = "Date_of_dismissalTextBox";
            this.Date_of_dismissalTextBox.Size = new System.Drawing.Size(158, 26);
            this.Date_of_dismissalTextBox.TabIndex = 14;
            // 
            // Date_of_orderTextBox
            // 
            this.Date_of_orderTextBox.Location = new System.Drawing.Point(595, 512);
            this.Date_of_orderTextBox.Name = "Date_of_orderTextBox";
            this.Date_of_orderTextBox.Size = new System.Drawing.Size(158, 26);
            this.Date_of_orderTextBox.TabIndex = 15;
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // buttonprint
            // 
            this.buttonprint.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonprint.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonprint.Location = new System.Drawing.Point(1072, 357);
            this.buttonprint.Name = "buttonprint";
            this.buttonprint.Size = new System.Drawing.Size(151, 55);
            this.buttonprint.TabIndex = 100;
            this.buttonprint.Text = "Печать";
            this.buttonprint.UseVisualStyleBackColor = false;
            this.buttonprint.Click += new System.EventHandler(this.buttonprint_Click);
            // 
            // FormAdditionalInformation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.buttonprint);
            this.Controls.Add(this.Date_of_orderTextBox);
            this.Controls.Add(this.Date_of_dismissalTextBox);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.the_order_numberTextBox);
            this.Controls.Add(this.dismissalTextBox);
            this.Controls.Add(this.ID_additional_informationTextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack3);
            this.Name = "FormAdditionalInformation";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление дополнительных сведений";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormAdditionalInformation_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAdditionalInformation_FormClosed);
            this.Load += new System.EventHandler(this.FormAdditionalInformation_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.more_informationBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource more_informationBindingSource;
        private Personal_cardsDataSetTableAdapters.More_informationTableAdapter more_informationTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.Button buttonBack3;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox ID_additional_informationTextBox;
        private System.Windows.Forms.TextBox dismissalTextBox;
        private System.Windows.Forms.TextBox the_order_numberTextBox;
        private System.Windows.Forms.TextBox Date_of_dismissalTextBox;
        private System.Windows.Forms.TextBox Date_of_orderTextBox;
        private System.Drawing.Printing.PrintDocument printDocument1;
        private System.Windows.Forms.Button buttonprint;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
    }
}