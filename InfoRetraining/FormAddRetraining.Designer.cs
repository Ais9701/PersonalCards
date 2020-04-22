namespace Personal_cardsApp1
{
    partial class FormAddRetraining
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormAddRetraining));
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.retrainingBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.retrainingTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.RetrainingTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.retrainingBindingNavigator = new System.Windows.Forms.BindingNavigator(this.components);
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
            this.retrainingBindingNavigatorSaveItem = new System.Windows.Forms.ToolStripButton();
            this.buttonBack7 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.ID_retrainingTextBox = new System.Windows.Forms.TextBox();
            this.Completion_of_retrainingTextBox = new System.Windows.Forms.TextBox();
            this.The_beginning_of_the_trainingTextBox = new System.Windows.Forms.TextBox();
            this.SpecialtyTextBox = new System.Windows.Forms.TextBox();
            this.Document_nameTextBox = new System.Windows.Forms.TextBox();
            this.Document_numberTextBox = new System.Windows.Forms.TextBox();
            this.DateTextBox = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingNavigator)).BeginInit();
            this.retrainingBindingNavigator.SuspendLayout();
            this.SuspendLayout();
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // retrainingBindingSource
            // 
            this.retrainingBindingSource.DataMember = "Retraining";
            this.retrainingBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // retrainingTableAdapter
            // 
            this.retrainingTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RetrainingTableAdapter = this.retrainingTableAdapter;
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = null;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // retrainingBindingNavigator
            // 
            this.retrainingBindingNavigator.AddNewItem = this.bindingNavigatorAddNewItem;
            this.retrainingBindingNavigator.BindingSource = this.retrainingBindingSource;
            this.retrainingBindingNavigator.CountItem = this.bindingNavigatorCountItem;
            this.retrainingBindingNavigator.DeleteItem = this.bindingNavigatorDeleteItem;
            this.retrainingBindingNavigator.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.retrainingBindingNavigator.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
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
            this.retrainingBindingNavigatorSaveItem});
            this.retrainingBindingNavigator.Location = new System.Drawing.Point(0, 0);
            this.retrainingBindingNavigator.MoveFirstItem = this.bindingNavigatorMoveFirstItem;
            this.retrainingBindingNavigator.MoveLastItem = this.bindingNavigatorMoveLastItem;
            this.retrainingBindingNavigator.MoveNextItem = this.bindingNavigatorMoveNextItem;
            this.retrainingBindingNavigator.MovePreviousItem = this.bindingNavigatorMovePreviousItem;
            this.retrainingBindingNavigator.Name = "retrainingBindingNavigator";
            this.retrainingBindingNavigator.PositionItem = this.bindingNavigatorPositionItem;
            this.retrainingBindingNavigator.Size = new System.Drawing.Size(1290, 32);
            this.retrainingBindingNavigator.TabIndex = 0;
            this.retrainingBindingNavigator.Text = "bindingNavigator1";
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
            // retrainingBindingNavigatorSaveItem
            // 
            this.retrainingBindingNavigatorSaveItem.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.retrainingBindingNavigatorSaveItem.Image = ((System.Drawing.Image)(resources.GetObject("retrainingBindingNavigatorSaveItem.Image")));
            this.retrainingBindingNavigatorSaveItem.Name = "retrainingBindingNavigatorSaveItem";
            this.retrainingBindingNavigatorSaveItem.Size = new System.Drawing.Size(34, 28);
            this.retrainingBindingNavigatorSaveItem.Text = "Сохранить данные";
            this.retrainingBindingNavigatorSaveItem.Visible = false;
            this.retrainingBindingNavigatorSaveItem.Click += new System.EventHandler(this.retrainingBindingNavigatorSaveItem_Click);
            // 
            // buttonBack7
            // 
            this.buttonBack7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack7.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack7.Location = new System.Drawing.Point(1117, 566);
            this.buttonBack7.Name = "buttonBack7";
            this.buttonBack7.Size = new System.Drawing.Size(128, 48);
            this.buttonBack7.TabIndex = 8;
            this.buttonBack7.Text = "Назад";
            this.buttonBack7.UseVisualStyleBackColor = false;
            this.buttonBack7.Click += new System.EventHandler(this.buttonBack7_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(281, 217);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(354, 57);
            this.label1.TabIndex = 9;
            this.label1.Text = "ID переподготовки:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label2.Location = new System.Drawing.Point(281, 272);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(442, 57);
            this.label2.TabIndex = 10;
            this.label2.Text = "Начало переподготовки:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Location = new System.Drawing.Point(281, 331);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(505, 57);
            this.label3.TabIndex = 11;
            this.label3.Text = "Окончание переподготовки:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label4.Location = new System.Drawing.Point(281, 388);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(290, 57);
            this.label4.TabIndex = 12;
            this.label4.Text = "Специальность:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label5.Location = new System.Drawing.Point(281, 443);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(475, 57);
            this.label5.TabIndex = 13;
            this.label5.Text = "Наименование документа:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label6.Location = new System.Drawing.Point(281, 500);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(333, 57);
            this.label6.TabIndex = 14;
            this.label6.Text = "Номер документа:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label7.Location = new System.Drawing.Point(281, 557);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(116, 57);
            this.label7.TabIndex = 15;
            this.label7.Text = "Дата:";
            // 
            // ID_retrainingTextBox
            // 
            this.ID_retrainingTextBox.Location = new System.Drawing.Point(641, 243);
            this.ID_retrainingTextBox.Name = "ID_retrainingTextBox";
            this.ID_retrainingTextBox.Size = new System.Drawing.Size(82, 26);
            this.ID_retrainingTextBox.TabIndex = 16;
            // 
            // Completion_of_retrainingTextBox
            // 
            this.Completion_of_retrainingTextBox.Location = new System.Drawing.Point(805, 357);
            this.Completion_of_retrainingTextBox.Name = "Completion_of_retrainingTextBox";
            this.Completion_of_retrainingTextBox.Size = new System.Drawing.Size(205, 26);
            this.Completion_of_retrainingTextBox.TabIndex = 17;
            // 
            // The_beginning_of_the_trainingTextBox
            // 
            this.The_beginning_of_the_trainingTextBox.Location = new System.Drawing.Point(775, 298);
            this.The_beginning_of_the_trainingTextBox.Name = "The_beginning_of_the_trainingTextBox";
            this.The_beginning_of_the_trainingTextBox.Size = new System.Drawing.Size(205, 26);
            this.The_beginning_of_the_trainingTextBox.TabIndex = 18;
            // 
            // SpecialtyTextBox
            // 
            this.SpecialtyTextBox.Location = new System.Drawing.Point(600, 414);
            this.SpecialtyTextBox.Name = "SpecialtyTextBox";
            this.SpecialtyTextBox.Size = new System.Drawing.Size(272, 26);
            this.SpecialtyTextBox.TabIndex = 19;
            // 
            // Document_nameTextBox
            // 
            this.Document_nameTextBox.Location = new System.Drawing.Point(788, 469);
            this.Document_nameTextBox.Name = "Document_nameTextBox";
            this.Document_nameTextBox.Size = new System.Drawing.Size(222, 26);
            this.Document_nameTextBox.TabIndex = 20;
            // 
            // Document_numberTextBox
            // 
            this.Document_numberTextBox.Location = new System.Drawing.Point(641, 526);
            this.Document_numberTextBox.Name = "Document_numberTextBox";
            this.Document_numberTextBox.Size = new System.Drawing.Size(154, 26);
            this.Document_numberTextBox.TabIndex = 21;
            // 
            // DateTextBox
            // 
            this.DateTextBox.Location = new System.Drawing.Point(412, 583);
            this.DateTextBox.Name = "DateTextBox";
            this.DateTextBox.Size = new System.Drawing.Size(159, 26);
            this.DateTextBox.TabIndex = 22;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 12.25532F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(1114, 509);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(131, 48);
            this.button1.TabIndex = 23;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormAddRetraining
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1290, 797);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.DateTextBox);
            this.Controls.Add(this.Document_numberTextBox);
            this.Controls.Add(this.Document_nameTextBox);
            this.Controls.Add(this.SpecialtyTextBox);
            this.Controls.Add(this.The_beginning_of_the_trainingTextBox);
            this.Controls.Add(this.Completion_of_retrainingTextBox);
            this.Controls.Add(this.ID_retrainingTextBox);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.buttonBack7);
            this.Controls.Add(this.retrainingBindingNavigator);
            this.Name = "FormAddRetraining";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Добавление переподготовки";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormAddRetraining_FormClosed);
            this.Load += new System.EventHandler(this.FormAddRetraining_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retrainingBindingNavigator)).EndInit();
            this.retrainingBindingNavigator.ResumeLayout(false);
            this.retrainingBindingNavigator.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource retrainingBindingSource;
        private Personal_cardsDataSetTableAdapters.RetrainingTableAdapter retrainingTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingNavigator retrainingBindingNavigator;
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
        private System.Windows.Forms.ToolStripButton retrainingBindingNavigatorSaveItem;
        private System.Windows.Forms.Button buttonBack7;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox ID_retrainingTextBox;
        private System.Windows.Forms.TextBox Completion_of_retrainingTextBox;
        private System.Windows.Forms.TextBox The_beginning_of_the_trainingTextBox;
        private System.Windows.Forms.TextBox SpecialtyTextBox;
        private System.Windows.Forms.TextBox Document_nameTextBox;
        private System.Windows.Forms.TextBox Document_numberTextBox;
        private System.Windows.Forms.TextBox DateTextBox;
        private System.Windows.Forms.Button button1;
    }
}