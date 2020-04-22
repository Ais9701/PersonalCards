namespace Personal_cardsApp1
{
    partial class FormRewards
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
            System.Windows.Forms.Label the_name_of_the_awardsLabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label dateLabel;
            System.Windows.Forms.Label iD_rewardsLabel;
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormRewards));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.rewardsBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.rewardsTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.RewardsTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.rewardsBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
            this.bindingNavigatorAddNewItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorCountItem = new System.Windows.Forms.ToolStripLabel();
            this.bindingNavigatorDeleteItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveFirstItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMovePreviousItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorPositionItem = new System.Windows.Forms.ToolStripTextBox();
            this.bindingNavigatorSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.bindingNavigatorMoveNextItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorMoveLastItem = new System.Windows.Forms.ToolStripButton();
            this.bindingNavigatorSeparator2 = new System.Windows.Forms.ToolStripSeparator();
            this.rewardsBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.The_name_of_the_awardsTextBox = new System.Windows.Forms.TextBox();
            this.NumberTextBox = new System.Windows.Forms.TextBox();
            this.DateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.buttonBack7 = new System.Windows.Forms.Button();
            this.buttonSeal7 = new System.Windows.Forms.Button();
            this.buttonAdd7 = new System.Windows.Forms.Button();
            this.ID_rewardsTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.printDocument1 = new System.Drawing.Printing.PrintDocument();
            the_name_of_the_awardsLabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            dateLabel = new System.Windows.Forms.Label();
            iD_rewardsLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingNavigator)).BeginInit();
            this.rewardsBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // the_name_of_the_awardsLabel
            // 
            the_name_of_the_awardsLabel.AutoSize = true;
            the_name_of_the_awardsLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            the_name_of_the_awardsLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            the_name_of_the_awardsLabel.Location = new System.Drawing.Point(213, 258);
            the_name_of_the_awardsLabel.Name = "the_name_of_the_awardsLabel";
            the_name_of_the_awardsLabel.Size = new System.Drawing.Size(438, 57);
            the_name_of_the_awardsLabel.TabIndex = 1;
            the_name_of_the_awardsLabel.Text = "Наименование награды:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            numberLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            numberLabel.Location = new System.Drawing.Point(213, 326);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(145, 57);
            numberLabel.TabIndex = 3;
            numberLabel.Text = "Номер:";
            // 
            // dateLabel
            // 
            dateLabel.AutoSize = true;
            dateLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dateLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            dateLabel.Location = new System.Drawing.Point(213, 396);
            dateLabel.Name = "dateLabel";
            dateLabel.Size = new System.Drawing.Size(116, 57);
            dateLabel.TabIndex = 5;
            dateLabel.Text = "Дата:";
            // 
            // iD_rewardsLabel
            // 
            iD_rewardsLabel.AutoSize = true;
            iD_rewardsLabel.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            iD_rewardsLabel.ForeColor = System.Drawing.Color.MediumSpringGreen;
            iD_rewardsLabel.Location = new System.Drawing.Point(213, 196);
            iD_rewardsLabel.Name = "iD_rewardsLabel";
            iD_rewardsLabel.Size = new System.Drawing.Size(224, 57);
            iD_rewardsLabel.TabIndex = 14;
            iD_rewardsLabel.Text = "ID награды:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // rewardsBindingSource
            // 
            this.rewardsBindingSource.DataMember = "Rewards";
            this.rewardsBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // rewardsTableAdapter
            // 
            this.rewardsTableAdapter.ClearBeforeFill = true;
            // 
            // tableAdapterManager
            // 
            this.tableAdapterManager.Advanced_trainingTableAdapter = null;
            this.tableAdapterManager.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager.CertificationTableAdapter = null;
            this.tableAdapterManager.EducationTableAdapter = null;
            this.tableAdapterManager.Employee_informationTableAdapter = null;
            this.tableAdapterManager.Level_of_educationTableAdapter = null;
            this.tableAdapterManager.Military_registrationTableAdapter = null;
            this.tableAdapterManager.More_informationTableAdapter = null;
            this.tableAdapterManager.Reception_and_transferTableAdapter = null;
            this.tableAdapterManager.RetrainingTableAdapter = null;
            this.tableAdapterManager.RewardsTableAdapter = this.rewardsTableAdapter;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // rewardsBindingNavigator
            // 
            this.rewardsBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.rewardsBindingNavigator.BindingSource = this.rewardsBindingSource;
            this.rewardsBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.rewardsBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.rewardsBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.rewardsBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.bindingNavigatorMoveFirstItem,
            this.bindingNavigatorMovePreviousItem,
            this.bindingNavigatorSeparator,
            this.bindingNavigatorPositionItem,
            this.bindingNavigatorCountItem,
            this.bindingNavigatorSeparator1,
            this.bindingNavigatorMoveNextItem,
            this.bindingNavigatorMoveLastItem,
            this.bindingNavigatorSeparator2,
            this.bindingNavigatorAddNewItem,
            this.bindingNavigatorDeleteItem,
            this.rewardsBindingNavigatorSaveItem});
            this.rewardsBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.rewardsBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.rewardsBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.rewardsBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.rewardsBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.rewardsBindingNavigator.Name = "rewardsBindingNavigator";
            this.rewardsBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.rewardsBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.rewardsBindingNavigator.TabIndex = 0;
            this.rewardsBindingNavigator.Text = "bindingNavigator1";
            // 
            // bindingNavigatorAddNewItem
            // 
            this.bindingNavigatorAddNewItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorAddNewItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorAddNewItem.Image")));
            this.bindingNavigatorAddNewItem.Name = "bindingNavigatorAddNewItem";
            this.bindingNavigatorAddNewItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorAddNewItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorAddNewItem.Text = "Добавить";
            this.bindingNavigatorAddNewItem.Visible = false;
            // 
            // bindingNavigatorCountItem
            // 
            this.bindingNavigatorCountItem.Name = "bindingNavigatorCountItem";
            this.bindingNavigatorCountItem.Size = new System.Drawing.Size(65, 28);
            this.bindingNavigatorCountItem.Text = "для {0}";
            this.bindingNavigatorCountItem.ToolTipText = "Общее число элементов";
            // 
            // bindingNavigatorDeleteItem
            // 
            this.bindingNavigatorDeleteItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorDeleteItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorDeleteItem.Image")));
            this.bindingNavigatorDeleteItem.Name = "bindingNavigatorDeleteItem";
            this.bindingNavigatorDeleteItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorDeleteItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorDeleteItem.Text = "Удалить";
            this.bindingNavigatorDeleteItem.Visible = false;
            // 
            // bindingNavigatorMoveFirstItem
            // 
            this.bindingNavigatorMoveFirstItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveFirstItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveFirstItem.Image")));
            this.bindingNavigatorMoveFirstItem.Name = "bindingNavigatorMoveFirstItem";
            this.bindingNavigatorMoveFirstItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveFirstItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveFirstItem.Text = "Переместить в начало";
            // 
            // bindingNavigatorMovePreviousItem
            // 
            this.bindingNavigatorMovePreviousItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMovePreviousItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMovePreviousItem.Image")));
            this.bindingNavigatorMovePreviousItem.Name = "bindingNavigatorMovePreviousItem";
            this.bindingNavigatorMovePreviousItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMovePreviousItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMovePreviousItem.Text = "Переместить назад";
            // 
            // bindingNavigatorSeparator
            // 
            this.bindingNavigatorSeparator.Name = "bindingNavigatorSeparator";
            this.bindingNavigatorSeparator.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorPositionItem
            // 
            this.bindingNavigatorPositionItem.AccessibleName = "Положение";
            this.bindingNavigatorPositionItem.AutoSize = false;
            this.bindingNavigatorPositionItem.Font = new System.Drawing.Font("Segoe UI", 9.191489F);
            this.bindingNavigatorPositionItem.Name = "bindingNavigatorPositionItem";
            this.bindingNavigatorPositionItem.Size = new System.Drawing.Size(50, 31);
            this.bindingNavigatorPositionItem.Text = "0";
            this.bindingNavigatorPositionItem.ToolTipText = "Текущее положение";
            // 
            // bindingNavigatorSeparator1
            // 
            this.bindingNavigatorSeparator1.Name = "bindingNavigatorSeparator1";
            this.bindingNavigatorSeparator1.Size = new System.Drawing.Size(6, 32);
            // 
            // bindingNavigatorMoveNextItem
            // 
            this.bindingNavigatorMoveNextItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveNextItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveNextItem.Image")));
            this.bindingNavigatorMoveNextItem.Name = "bindingNavigatorMoveNextItem";
            this.bindingNavigatorMoveNextItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveNextItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveNextItem.Text = "Переместить вперед";
            // 
            // bindingNavigatorMoveLastItem
            // 
            this.bindingNavigatorMoveLastItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.bindingNavigatorMoveLastItem.Image = ((System.Drawing.Image)(resources.GetObject("bindingNavigatorMoveLastItem.Image")));
            this.bindingNavigatorMoveLastItem.Name = "bindingNavigatorMoveLastItem";
            this.bindingNavigatorMoveLastItem.RightToLeftAutoMirrorImage = true;
            this.bindingNavigatorMoveLastItem.Size = new System.Drawing.Size(34, 28);
            this.bindingNavigatorMoveLastItem.Text = "Переместить в конец";
            // 
            // bindingNavigatorSeparator2
            // 
            this.bindingNavigatorSeparator2.Name = "bindingNavigatorSeparator2";
            this.bindingNavigatorSeparator2.Size = new System.Drawing.Size(6, 32);
            // 
            // rewardsBindingNavigatorSaveItem
            // 
            this.rewardsBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.rewardsBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("rewardsBindingNavigatorSaveItem.Image")));
            this.rewardsBindingNavigatorSaveItem.Name = "rewardsBindingNavigatorSaveItem";
            this.rewardsBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.rewardsBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.rewardsBindingNavigatorSaveItem.Visible = false;
            this.rewardsBindingNavigatorSaveItem.Click += new System.EventHandler(this.rewardsBindingNavigatorSaveItem_Click);
            // 
            // The_name_of_the_awardsTextBox
            // 
            this.The_name_of_the_awardsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardsBindingSource, "The_name_of_the_awards", true));
            this.The_name_of_the_awardsTextBox.Location = new System.Drawing.Point(671, 284);
            this.The_name_of_the_awardsTextBox.Name = "The_name_of_the_awardsTextBox";
            this.The_name_of_the_awardsTextBox.Size = new System.Drawing.Size(246, 26);
            this.The_name_of_the_awardsTextBox.TabIndex = 2;
            // 
            // NumberTextBox
            // 
            this.NumberTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardsBindingSource, "Number", true));
            this.NumberTextBox.Location = new System.Drawing.Point(364, 352);
            this.NumberTextBox.Name = "NumberTextBox";
            this.NumberTextBox.Size = new System.Drawing.Size(129, 26);
            this.NumberTextBox.TabIndex = 4;
            // 
            // DateDateTimePicker
            // 
            this.DateDateTimePicker.DataBindings.Add(new System.Windows.Forms.Binding("Value", this.rewardsBindingSource, "Date", true));
            this.DateDateTimePicker.Location = new System.Drawing.Point(364, 420);
            this.DateDateTimePicker.Name = "DateDateTimePicker";
            this.DateDateTimePicker.Size = new System.Drawing.Size(176, 26);
            this.DateDateTimePicker.TabIndex = 6;
            // 
            // buttonBack7
            // 
            this.buttonBack7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack7.Location = new System.Drawing.Point(981, 481);
            this.buttonBack7.Name = "buttonBack7";
            this.buttonBack7.Size = new System.Drawing.Size(131, 49);
            this.buttonBack7.TabIndex = 14;
            this.buttonBack7.Text = "Назад";
            this.buttonBack7.UseVisualStyleBackColor = false;
            this.buttonBack7.Click += new System.EventHandler(this.buttonBack2_Click);
            // 
            // buttonSeal7
            // 
            this.buttonSeal7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonSeal7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonSeal7.Location = new System.Drawing.Point(981, 426);
            this.buttonSeal7.Name = "buttonSeal7";
            this.buttonSeal7.Size = new System.Drawing.Size(131, 49);
            this.buttonSeal7.TabIndex = 13;
            this.buttonSeal7.Text = "Печать";
            this.buttonSeal7.UseVisualStyleBackColor = false;
            this.buttonSeal7.Click += new System.EventHandler(this.buttonSeal7_Click);
            // 
            // buttonAdd7
            // 
            this.buttonAdd7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonAdd7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonAdd7.Location = new System.Drawing.Point(981, 316);
            this.buttonAdd7.Name = "buttonAdd7";
            this.buttonAdd7.Size = new System.Drawing.Size(131, 49);
            this.buttonAdd7.TabIndex = 12;
            this.buttonAdd7.Text = "Добавить";
            this.buttonAdd7.UseVisualStyleBackColor = false;
            this.buttonAdd7.Click += new System.EventHandler(this.buttonAdd2_Click);
            // 
            // ID_rewardsTextBox
            // 
            this.ID_rewardsTextBox.DataBindings.Add(new System.Windows.Forms.Binding("Text", this.rewardsBindingSource, "ID_rewards", true));
            this.ID_rewardsTextBox.Location = new System.Drawing.Point(443, 222);
            this.ID_rewardsTextBox.Name = "ID_rewardsTextBox";
            this.ID_rewardsTextBox.Size = new System.Drawing.Size(68, 26);
            this.ID_rewardsTextBox.TabIndex = 15;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(981, 371);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 49);
            this.button1.TabIndex = 16;
            this.button1.Text = "Удалить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // printDocument1
            // 
            this.printDocument1.PrintPage += new System.Drawing.Printing.PrintPageEventHandler(this.printDocument1_PrintPage);
            // 
            // FormRewards
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(iD_rewardsLabel);
            this.Controls.Add(this.ID_rewardsTextBox);
            this.Controls.Add(this.buttonBack7);
            this.Controls.Add(this.buttonSeal7);
            this.Controls.Add(this.buttonAdd7);
            this.Controls.Add(dateLabel);
            this.Controls.Add(this.DateDateTimePicker);
            this.Controls.Add(numberLabel);
            this.Controls.Add(this.NumberTextBox);
            this.Controls.Add(the_name_of_the_awardsLabel);
            this.Controls.Add(this.The_name_of_the_awardsTextBox);
            this.Controls.Add(this.rewardsBindingNavigator);
            this.Name = "FormRewards";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Награды";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormRewards_FormClosed);
            this.Load += new System.EventHandler(this.FormRewards_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.rewardsBindingNavigator)).EndInit();
            this.rewardsBindingNavigator.ResumeLayout(false);
            this.rewardsBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource rewardsBindingSource;
        private Personal_cardsDataSetTableAdapters.RewardsTableAdapter rewardsTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator rewardsBindingNavigator;
        private System.Windows.Forms.ToolStripButton bindingNavigatorAddNewItem;
        private System.Windows.Forms.ToolStripLabel bindingNavigatorCountItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorDeleteItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveFirstItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMovePreviousItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator;
        private System.Windows.Forms.ToolStripTextBox bindingNavigatorPositionItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator1;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveNextItem;
        private System.Windows.Forms.ToolStripButton bindingNavigatorMoveLastItem;
        private System.Windows.Forms.ToolStripSeparator bindingNavigatorSeparator2;
        private System.Windows.Forms.ToolStripButton rewardsBindingNavigatorSaveItem;
        private System.Windows.Forms.TextBox The_name_of_the_awardsTextBox;
        private System.Windows.Forms.TextBox NumberTextBox;
        private System.Windows.Forms.DateTimePicker DateDateTimePicker;
        private System.Windows.Forms.Button buttonBack7;
        private System.Windows.Forms.Button buttonSeal7;
        private System.Windows.Forms.Button buttonAdd7;
        private System.Windows.Forms.TextBox ID_rewardsTextBox;
        private System.Windows.Forms.Button button1;
        private System.Drawing.Printing.PrintDocument printDocument1;
    }
}