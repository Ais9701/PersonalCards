namespace Personal_cardsApp1
{
    partial class FormAuthorization
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.Label loginLabel;
            System.Windows.Forms.Label passwordLabel;
            this.personal_cardsDataSet = new Personal_cardsApp1.Personal_cardsDataSet();
            this.userBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.userTableAdapter = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.UserTableAdapter();
            this.tableAdapterManager = new Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager();
            this.userBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.button1 = new System.Windows.Forms.Button();
            this.txtboxlog = new System.Windows.Forms.TextBox();
            this.txtboxpas = new System.Windows.Forms.TextBox();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            loginLabel = new System.Windows.Forms.Label();
            passwordLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // loginLabel
            // 
            loginLabel.AutoSize = true;
            loginLabel.Font = new System.Drawing.Font("Sitka Banner", 28.0851F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            loginLabel.ForeColor = System.Drawing.Color.Black;
            loginLabel.Location = new System.Drawing.Point(63, 212);
            loginLabel.Name = "loginLabel";
            loginLabel.Size = new System.Drawing.Size(200, 79);
            loginLabel.TabIndex = 7;
            loginLabel.Text = "Логин:";
            // 
            // passwordLabel
            // 
            passwordLabel.AutoSize = true;
            passwordLabel.Font = new System.Drawing.Font("Sitka Banner", 28.0851F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            passwordLabel.ForeColor = System.Drawing.Color.Black;
            passwordLabel.Location = new System.Drawing.Point(63, 301);
            passwordLabel.Name = "passwordLabel";
            passwordLabel.Size = new System.Drawing.Size(222, 79);
            passwordLabel.TabIndex = 8;
            passwordLabel.Text = "Пароль:";
            // 
            // personal_cardsDataSet
            // 
            this.personal_cardsDataSet.DataSetName = "Personal_cardsDataSet";
            this.personal_cardsDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // userBindingSource
            // 
            this.userBindingSource.DataMember = "User";
            this.userBindingSource.DataSource = this.personal_cardsDataSet;
            // 
            // userTableAdapter
            // 
            this.userTableAdapter.ClearBeforeFill = true;
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
            this.tableAdapterManager.RewardsTableAdapter = null;
            this.tableAdapterManager.Social_benefitsTableAdapter = null;
            this.tableAdapterManager.UpdateOrder = Personal_cardsApp1.Personal_cardsDataSetTableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager.UserTableAdapter = this.userTableAdapter;
            this.tableAdapterManager.VacationTableAdapter = null;
            // 
            // userBindingSource1
            // 
            this.userBindingSource1.DataMember = "User";
            this.userBindingSource1.DataSource = this.personal_cardsDataSet;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button1.Font = new System.Drawing.Font("Algerian", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.button1.Location = new System.Drawing.Point(360, 482);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(188, 75);
            this.button1.TabIndex = 7;
            this.button1.Text = "Войти";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // txtboxlog
            // 
            this.txtboxlog.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.87234F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxlog.Location = new System.Drawing.Point(316, 240);
            this.txtboxlog.Name = "txtboxlog";
            this.txtboxlog.Size = new System.Drawing.Size(297, 47);
            this.txtboxlog.TabIndex = 9;
            this.txtboxlog.Text = "admin";
            // 
            // txtboxpas
            // 
            this.txtboxpas.Font = new System.Drawing.Font("Microsoft Sans Serif", 17.87234F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.txtboxpas.Location = new System.Drawing.Point(316, 329);
            this.txtboxpas.Name = "txtboxpas";
            this.txtboxpas.PasswordChar = '*';
            this.txtboxpas.Size = new System.Drawing.Size(297, 47);
            this.txtboxpas.TabIndex = 10;
            this.txtboxpas.Text = "123";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.button2.Font = new System.Drawing.Font("Algerian", 13.78723F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.Location = new System.Drawing.Point(360, 575);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(188, 75);
            this.button2.TabIndex = 11;
            this.button2.Text = "Выйти";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.label1.Location = new System.Drawing.Point(248, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(862, 57);
            this.label1.TabIndex = 12;
            this.label1.Text = "Для входа в систему введите свои логин и пароль";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Sitka Banner", 10.21277F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(311, 400);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(318, 60);
            this.label2.TabIndex = 13;
            this.label2.Text = "После трех неудачных попыток,\r\nсистема заблокируется на 15 секунд\r\n";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.MediumSpringGreen;
            this.label3.Font = new System.Drawing.Font("Sitka Banner", 28.0851F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(78, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(1170, 79);
            this.label3.TabIndex = 14;
            this.label3.Text = "Добро пожаловать в систему для Отдела кадров";
            this.label3.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Personal_cardsApp1.Properties.Resources.концепция_искать_я_профессиона_ьного_вещества_65272839;
            this.pictureBox1.Location = new System.Drawing.Point(786, 174);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(508, 504);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 15;
            this.pictureBox1.TabStop = false;
            // 
            // FormAuthorization
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.txtboxpas);
            this.Controls.Add(this.txtboxlog);
            this.Controls.Add(passwordLabel);
            this.Controls.Add(loginLabel);
            this.Controls.Add(this.button1);
            this.Name = "FormAuthorization";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.personal_cardsDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userBindingSource1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Personal_cardsDataSet personal_cardsDataSet;
        private System.Windows.Forms.BindingSource userBindingSource;
        private Personal_cardsDataSetTableAdapters.UserTableAdapter userTableAdapter;
        private Personal_cardsDataSetTableAdapters.TableAdapterManager tableAdapterManager;
        private System.Windows.Forms.BindingSource userBindingSource1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.TextBox txtboxlog;
        private System.Windows.Forms.TextBox txtboxpas;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox pictureBox1;
    }
}

