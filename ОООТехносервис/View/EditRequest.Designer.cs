namespace ОООТехносервис.View
{
    partial class EditRequest
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(EditRequest));
            this.exit_button = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.data = new System.Windows.Forms.Label();
            this.Date_Text = new System.Windows.Forms.Label();
            this.equipment_Text = new System.Windows.Forms.Label();
            this.Client_Text = new System.Windows.Forms.Label();
            this.overview_Text = new System.Windows.Forms.Label();
            this.Master_Text = new System.Windows.Forms.Label();
            this.duration_Text = new System.Windows.Forms.Label();
            this.Priory_Text = new System.Windows.Forms.Label();
            this.Stage_Text = new System.Windows.Forms.Label();
            this.Status_Text = new System.Windows.Forms.Label();
            this.Comment_Text = new System.Windows.Forms.Label();
            this.Problem_Text = new System.Windows.Forms.Label();
            this.form_button = new System.Windows.Forms.Button();
            this.textBoxDate = new System.Windows.Forms.TextBox();
            this.textBoxTime = new System.Windows.Forms.TextBox();
            this.textBoxDescription = new System.Windows.Forms.TextBox();
            this.textBoxComment = new System.Windows.Forms.TextBox();
            this.comboBoxEquipment = new System.Windows.Forms.ComboBox();
            this.comboBoxClient = new System.Windows.Forms.ComboBox();
            this.comboBoxMaster = new System.Windows.Forms.ComboBox();
            this.comboPriority = new System.Windows.Forms.ComboBox();
            this.comboBoxStage = new System.Windows.Forms.ComboBox();
            this.comboBoxStatus = new System.Windows.Forms.ComboBox();
            this.comboBoxProblem = new System.Windows.Forms.ComboBox();
            this.NumberText = new System.Windows.Forms.Label();
            this.number = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.exit_button.Location = new System.Drawing.Point(645, 24);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(142, 51);
            this.exit_button.TabIndex = 0;
            this.exit_button.Text = "Назад";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(11, 11);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(97, 87);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 2;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // data
            // 
            this.data.AutoSize = true;
            this.data.Font = new System.Drawing.Font("Microsoft Sans Serif", 28F);
            this.data.Location = new System.Drawing.Point(201, 37);
            this.data.Name = "data";
            this.data.Size = new System.Drawing.Size(321, 44);
            this.data.TabIndex = 3;
            this.data.Text = "Данные о заявке";
            // 
            // Date_Text
            // 
            this.Date_Text.AutoSize = true;
            this.Date_Text.Location = new System.Drawing.Point(201, 170);
            this.Date_Text.Name = "Date_Text";
            this.Date_Text.Size = new System.Drawing.Size(71, 13);
            this.Date_Text.TabIndex = 4;
            this.Date_Text.Text = "Дата подачи";
            this.Date_Text.Click += new System.EventHandler(this.label2_Click);
            // 
            // equipment_Text
            // 
            this.equipment_Text.AutoSize = true;
            this.equipment_Text.Location = new System.Drawing.Point(201, 203);
            this.equipment_Text.Name = "equipment_Text";
            this.equipment_Text.Size = new System.Drawing.Size(80, 13);
            this.equipment_Text.TabIndex = 5;
            this.equipment_Text.Text = "Оборудование";
            // 
            // Client_Text
            // 
            this.Client_Text.AutoSize = true;
            this.Client_Text.Location = new System.Drawing.Point(201, 239);
            this.Client_Text.Name = "Client_Text";
            this.Client_Text.Size = new System.Drawing.Size(43, 13);
            this.Client_Text.TabIndex = 6;
            this.Client_Text.Text = "Клиент";
            // 
            // overview_Text
            // 
            this.overview_Text.AutoSize = true;
            this.overview_Text.Location = new System.Drawing.Point(201, 276);
            this.overview_Text.Name = "overview_Text";
            this.overview_Text.Size = new System.Drawing.Size(57, 13);
            this.overview_Text.TabIndex = 7;
            this.overview_Text.Text = "Описание";
            // 
            // Master_Text
            // 
            this.Master_Text.AutoSize = true;
            this.Master_Text.Location = new System.Drawing.Point(201, 309);
            this.Master_Text.Name = "Master_Text";
            this.Master_Text.Size = new System.Drawing.Size(45, 13);
            this.Master_Text.TabIndex = 8;
            this.Master_Text.Text = "Мастер";
            // 
            // duration_Text
            // 
            this.duration_Text.AutoSize = true;
            this.duration_Text.Location = new System.Drawing.Point(201, 338);
            this.duration_Text.Name = "duration_Text";
            this.duration_Text.Size = new System.Drawing.Size(80, 13);
            this.duration_Text.TabIndex = 9;
            this.duration_Text.Text = "Длительность";
            this.duration_Text.Click += new System.EventHandler(this.label7_Click);
            // 
            // Priory_Text
            // 
            this.Priory_Text.AutoSize = true;
            this.Priory_Text.Location = new System.Drawing.Point(201, 378);
            this.Priory_Text.Name = "Priory_Text";
            this.Priory_Text.Size = new System.Drawing.Size(61, 13);
            this.Priory_Text.TabIndex = 10;
            this.Priory_Text.Text = "Приоритет";
            // 
            // Stage_Text
            // 
            this.Stage_Text.AutoSize = true;
            this.Stage_Text.Location = new System.Drawing.Point(201, 413);
            this.Stage_Text.Name = "Stage_Text";
            this.Stage_Text.Size = new System.Drawing.Size(31, 13);
            this.Stage_Text.TabIndex = 11;
            this.Stage_Text.Text = "Этап";
            // 
            // Status_Text
            // 
            this.Status_Text.AutoSize = true;
            this.Status_Text.Location = new System.Drawing.Point(201, 445);
            this.Status_Text.Name = "Status_Text";
            this.Status_Text.Size = new System.Drawing.Size(106, 13);
            this.Status_Text.TabIndex = 12;
            this.Status_Text.Text = "Статус выполнения";
            this.Status_Text.Click += new System.EventHandler(this.label10_Click);
            // 
            // Comment_Text
            // 
            this.Comment_Text.AutoSize = true;
            this.Comment_Text.Location = new System.Drawing.Point(201, 476);
            this.Comment_Text.Name = "Comment_Text";
            this.Comment_Text.Size = new System.Drawing.Size(77, 13);
            this.Comment_Text.TabIndex = 13;
            this.Comment_Text.Text = "Комментарий";
            // 
            // Problem_Text
            // 
            this.Problem_Text.AutoSize = true;
            this.Problem_Text.Location = new System.Drawing.Point(201, 514);
            this.Problem_Text.Name = "Problem_Text";
            this.Problem_Text.Size = new System.Drawing.Size(59, 13);
            this.Problem_Text.TabIndex = 14;
            this.Problem_Text.Text = "Проблема";
            this.Problem_Text.Click += new System.EventHandler(this.label12_Click);
            // 
            // form_button
            // 
            this.form_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F);
            this.form_button.Location = new System.Drawing.Point(261, 557);
            this.form_button.Name = "form_button";
            this.form_button.Size = new System.Drawing.Size(242, 47);
            this.form_button.TabIndex = 15;
            this.form_button.Text = "Сформировать";
            this.form_button.UseVisualStyleBackColor = true;
            // 
            // textBoxDate
            // 
            this.textBoxDate.Enabled = false;
            this.textBoxDate.Location = new System.Drawing.Point(332, 170);
            this.textBoxDate.Name = "textBoxDate";
            this.textBoxDate.Size = new System.Drawing.Size(171, 20);
            this.textBoxDate.TabIndex = 16;
            // 
            // textBoxTime
            // 
            this.textBoxTime.Enabled = false;
            this.textBoxTime.Location = new System.Drawing.Point(332, 335);
            this.textBoxTime.Name = "textBoxTime";
            this.textBoxTime.Size = new System.Drawing.Size(171, 20);
            this.textBoxTime.TabIndex = 17;
            // 
            // textBoxDescription
            // 
            this.textBoxDescription.Location = new System.Drawing.Point(332, 273);
            this.textBoxDescription.Name = "textBoxDescription";
            this.textBoxDescription.Size = new System.Drawing.Size(171, 20);
            this.textBoxDescription.TabIndex = 18;
            // 
            // textBoxComment
            // 
            this.textBoxComment.Location = new System.Drawing.Point(332, 473);
            this.textBoxComment.Name = "textBoxComment";
            this.textBoxComment.Size = new System.Drawing.Size(171, 20);
            this.textBoxComment.TabIndex = 19;
            // 
            // comboBoxEquipment
            // 
            this.comboBoxEquipment.FormattingEnabled = true;
            this.comboBoxEquipment.Location = new System.Drawing.Point(332, 203);
            this.comboBoxEquipment.Name = "comboBoxEquipment";
            this.comboBoxEquipment.Size = new System.Drawing.Size(170, 21);
            this.comboBoxEquipment.TabIndex = 20;
            this.comboBoxEquipment.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBoxClient
            // 
            this.comboBoxClient.FormattingEnabled = true;
            this.comboBoxClient.Location = new System.Drawing.Point(332, 236);
            this.comboBoxClient.Name = "comboBoxClient";
            this.comboBoxClient.Size = new System.Drawing.Size(170, 21);
            this.comboBoxClient.TabIndex = 21;
            // 
            // comboBoxMaster
            // 
            this.comboBoxMaster.FormattingEnabled = true;
            this.comboBoxMaster.Location = new System.Drawing.Point(333, 301);
            this.comboBoxMaster.Name = "comboBoxMaster";
            this.comboBoxMaster.Size = new System.Drawing.Size(170, 21);
            this.comboBoxMaster.TabIndex = 22;
            // 
            // comboPriority
            // 
            this.comboPriority.FormattingEnabled = true;
            this.comboPriority.Location = new System.Drawing.Point(332, 370);
            this.comboPriority.Name = "comboPriority";
            this.comboPriority.Size = new System.Drawing.Size(170, 21);
            this.comboPriority.TabIndex = 23;
            // 
            // comboBoxStage
            // 
            this.comboBoxStage.Enabled = false;
            this.comboBoxStage.FormattingEnabled = true;
            this.comboBoxStage.Location = new System.Drawing.Point(333, 405);
            this.comboBoxStage.Name = "comboBoxStage";
            this.comboBoxStage.Size = new System.Drawing.Size(170, 21);
            this.comboBoxStage.TabIndex = 24;
            // 
            // comboBoxStatus
            // 
            this.comboBoxStatus.Enabled = false;
            this.comboBoxStatus.FormattingEnabled = true;
            this.comboBoxStatus.Location = new System.Drawing.Point(333, 437);
            this.comboBoxStatus.Name = "comboBoxStatus";
            this.comboBoxStatus.Size = new System.Drawing.Size(170, 21);
            this.comboBoxStatus.TabIndex = 25;
            // 
            // comboBoxProblem
            // 
            this.comboBoxProblem.FormattingEnabled = true;
            this.comboBoxProblem.Location = new System.Drawing.Point(333, 506);
            this.comboBoxProblem.Name = "comboBoxProblem";
            this.comboBoxProblem.Size = new System.Drawing.Size(170, 21);
            this.comboBoxProblem.TabIndex = 26;
            // 
            // NumberText
            // 
            this.NumberText.AutoSize = true;
            this.NumberText.Location = new System.Drawing.Point(201, 132);
            this.NumberText.Name = "NumberText";
            this.NumberText.Size = new System.Drawing.Size(41, 13);
            this.NumberText.TabIndex = 27;
            this.NumberText.Text = "Номер";
            // 
            // number
            // 
            this.number.Enabled = false;
            this.number.Location = new System.Drawing.Point(331, 129);
            this.number.Name = "number";
            this.number.Size = new System.Drawing.Size(171, 20);
            this.number.TabIndex = 28;
            // 
            // EditRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(835, 625);
            this.Controls.Add(this.number);
            this.Controls.Add(this.NumberText);
            this.Controls.Add(this.comboBoxProblem);
            this.Controls.Add(this.comboBoxStatus);
            this.Controls.Add(this.comboBoxStage);
            this.Controls.Add(this.comboPriority);
            this.Controls.Add(this.comboBoxMaster);
            this.Controls.Add(this.comboBoxClient);
            this.Controls.Add(this.comboBoxEquipment);
            this.Controls.Add(this.textBoxComment);
            this.Controls.Add(this.textBoxDescription);
            this.Controls.Add(this.textBoxTime);
            this.Controls.Add(this.textBoxDate);
            this.Controls.Add(this.form_button);
            this.Controls.Add(this.Problem_Text);
            this.Controls.Add(this.Comment_Text);
            this.Controls.Add(this.Status_Text);
            this.Controls.Add(this.Stage_Text);
            this.Controls.Add(this.Priory_Text);
            this.Controls.Add(this.duration_Text);
            this.Controls.Add(this.Master_Text);
            this.Controls.Add(this.overview_Text);
            this.Controls.Add(this.Client_Text);
            this.Controls.Add(this.equipment_Text);
            this.Controls.Add(this.Date_Text);
            this.Controls.Add(this.data);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.exit_button);
            this.Name = "EditRequest";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.EditRequest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label data;
        private System.Windows.Forms.Label Date_Text;
        private System.Windows.Forms.Label equipment_Text;
        private System.Windows.Forms.Label Client_Text;
        private System.Windows.Forms.Label overview_Text;
        private System.Windows.Forms.Label Master_Text;
        private System.Windows.Forms.Label duration_Text;
        private System.Windows.Forms.Label Priory_Text;
        private System.Windows.Forms.Label Stage_Text;
        private System.Windows.Forms.Label Status_Text;
        private System.Windows.Forms.Label Comment_Text;
        private System.Windows.Forms.Label Problem_Text;
        private System.Windows.Forms.Button form_button;
        private System.Windows.Forms.TextBox textBoxDate;
        private System.Windows.Forms.TextBox textBoxTime;
        private System.Windows.Forms.TextBox textBoxDescription;
        private System.Windows.Forms.TextBox textBoxComment;
        private System.Windows.Forms.ComboBox comboBoxEquipment;
        private System.Windows.Forms.ComboBox comboBoxClient;
        private System.Windows.Forms.ComboBox comboBoxMaster;
        private System.Windows.Forms.ComboBox comboPriority;
        private System.Windows.Forms.ComboBox comboBoxStage;
        private System.Windows.Forms.ComboBox comboBoxStatus;
        private System.Windows.Forms.ComboBox comboBoxProblem;
        private System.Windows.Forms.Label NumberText;
        private System.Windows.Forms.TextBox number;
    }
}