namespace ОООТехносервис.View
{
    partial class listRequest
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
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.dataGridViewRequest = new System.Windows.Forms.DataGridView();
            this.ColumnID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDevice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnCustomer = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStatus = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnMaster = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnStage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.buttonAddRequest = new System.Windows.Forms.Button();
            this.buttonEditRequest = new System.Windows.Forms.Button();
            this.buttonReport = new System.Windows.Forms.Button();
            this.comboBoxRequest = new System.Windows.Forms.ComboBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).BeginInit();
            this.SuspendLayout();
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(693, 28);
            this.button2.Margin = new System.Windows.Forms.Padding(2);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(95, 27);
            this.button2.TabIndex = 8;
            this.button2.Text = "Назад";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(190, 35);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(89, 13);
            this.label1.TabIndex = 7;
            this.label1.Text = "Список заказов";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // dataGridViewRequest
            // 
            this.dataGridViewRequest.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridViewRequest.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnID,
            this.ColumnDate,
            this.ColumnDevice,
            this.ColumnCustomer,
            this.ColumnStatus,
            this.ColumnMaster,
            this.ColumnStage});
            this.dataGridViewRequest.Location = new System.Drawing.Point(21, 122);
            this.dataGridViewRequest.Name = "dataGridViewRequest";
            this.dataGridViewRequest.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridViewRequest.Size = new System.Drawing.Size(743, 242);
            this.dataGridViewRequest.TabIndex = 9;
            // 
            // ColumnID
            // 
            this.ColumnID.HeaderText = "Номер заявки";
            this.ColumnID.Name = "ColumnID";
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Дата заявки";
            this.ColumnDate.Name = "ColumnDate";
            // 
            // ColumnDevice
            // 
            this.ColumnDevice.HeaderText = "Оборудование";
            this.ColumnDevice.Name = "ColumnDevice";
            // 
            // ColumnCustomer
            // 
            this.ColumnCustomer.HeaderText = "ФИО клиента";
            this.ColumnCustomer.Name = "ColumnCustomer";
            // 
            // ColumnStatus
            // 
            this.ColumnStatus.HeaderText = "Статус заявки";
            this.ColumnStatus.Name = "ColumnStatus";
            // 
            // ColumnMaster
            // 
            this.ColumnMaster.HeaderText = "Мастер";
            this.ColumnMaster.Name = "ColumnMaster";
            // 
            // ColumnStage
            // 
            this.ColumnStage.HeaderText = "Этап выполнеия заявки";
            this.ColumnStage.Name = "ColumnStage";
            // 
            // buttonAddRequest
            // 
            this.buttonAddRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonAddRequest.Location = new System.Drawing.Point(52, 393);
            this.buttonAddRequest.Name = "buttonAddRequest";
            this.buttonAddRequest.Size = new System.Drawing.Size(186, 36);
            this.buttonAddRequest.TabIndex = 10;
            this.buttonAddRequest.Text = "Добавить новую заявку";
            this.buttonAddRequest.UseVisualStyleBackColor = true;
            this.buttonAddRequest.Click += new System.EventHandler(this.buttonAddRequest_Click_1);
            // 
            // buttonEditRequest
            // 
            this.buttonEditRequest.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonEditRequest.Location = new System.Drawing.Point(303, 393);
            this.buttonEditRequest.Name = "buttonEditRequest";
            this.buttonEditRequest.Size = new System.Drawing.Size(165, 36);
            this.buttonEditRequest.TabIndex = 11;
            this.buttonEditRequest.Text = "Редактировать заявку";
            this.buttonEditRequest.UseVisualStyleBackColor = true;
            this.buttonEditRequest.Click += new System.EventHandler(this.buttonEditRequest_Click);
            // 
            // buttonReport
            // 
            this.buttonReport.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.buttonReport.Location = new System.Drawing.Point(521, 393);
            this.buttonReport.Name = "buttonReport";
            this.buttonReport.Size = new System.Drawing.Size(162, 36);
            this.buttonReport.TabIndex = 12;
            this.buttonReport.Text = "Создать отчет";
            this.buttonReport.UseVisualStyleBackColor = true;
            // 
            // comboBoxRequest
            // 
            this.comboBoxRequest.FormattingEnabled = true;
            this.comboBoxRequest.Location = new System.Drawing.Point(556, 77);
            this.comboBoxRequest.Name = "comboBoxRequest";
            this.comboBoxRequest.Size = new System.Drawing.Size(238, 21);
            this.comboBoxRequest.TabIndex = 13;
            this.comboBoxRequest.SelectedIndexChanged += new System.EventHandler(this.comboBoxStatus_SelectedIndexChanged);
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(134, 78);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(228, 20);
            this.textBox1.TabIndex = 14;
            this.textBox1.TextChanged += new System.EventHandler(this.textBoxNumber_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(49, 85);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(80, 13);
            this.label2.TabIndex = 15;
            this.label2.Text = "Номер заявки";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(471, 81);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(80, 13);
            this.label3.TabIndex = 16;
            this.label3.Text = "Статус заявки";
            // 
            // listRequest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(806, 455);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.comboBoxRequest);
            this.Controls.Add(this.buttonReport);
            this.Controls.Add(this.buttonEditRequest);
            this.Controls.Add(this.buttonAddRequest);
            this.Controls.Add(this.dataGridViewRequest);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.label1);
            this.Name = "listRequest";
            this.Text = "listReqest";
            this.Load += new System.EventHandler(this.listReqest_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridViewRequest)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.DataGridView dataGridViewRequest;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDevice;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnCustomer;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStatus;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnMaster;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnStage;
        private System.Windows.Forms.Button buttonAddRequest;
        private System.Windows.Forms.Button buttonEditRequest;
        private System.Windows.Forms.Button buttonReport;
        private System.Windows.Forms.ComboBox comboBoxRequest;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}