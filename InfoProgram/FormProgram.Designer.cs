namespace Personal_cardsApp1
{
    partial class FormProgram
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormProgram));
            this.label1 = new System.Windows.Forms.Label();
            this.buttonBack11 = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Sitka Banner", 19.91489F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.ForeColor = System.Drawing.Color.MediumSpringGreen;
            this.label1.Location = new System.Drawing.Point(253, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(832, 456);
            this.label1.TabIndex = 0;
            this.label1.Text = resources.GetString("label1.Text");
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // buttonBack11
            // 
            this.buttonBack11.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.buttonBack11.Font = new System.Drawing.Font("Times New Roman", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.buttonBack11.Location = new System.Drawing.Point(1108, 548);
            this.buttonBack11.Name = "buttonBack11";
            this.buttonBack11.Size = new System.Drawing.Size(137, 61);
            this.buttonBack11.TabIndex = 3;
            this.buttonBack11.Text = "Назад";
            this.buttonBack11.UseVisualStyleBackColor = false;
            this.buttonBack11.Click += new System.EventHandler(this.buttonBack11_Click);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.button1.Font = new System.Drawing.Font("Times New Roman", 13.78723F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.button1.Location = new System.Drawing.Point(31, 539);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(422, 70);
            this.button1.TabIndex = 4;
            this.button1.Text = "Руководство пользователя";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // FormProgram
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.ClientSize = new System.Drawing.Size(1357, 746);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.buttonBack11);
            this.Controls.Add(this.label1);
            this.Name = "FormProgram";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "О программе";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormProgram_FormClosing);
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormProgram_FormClosed);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonBack11;
        private System.Windows.Forms.Button button1;
    }
}