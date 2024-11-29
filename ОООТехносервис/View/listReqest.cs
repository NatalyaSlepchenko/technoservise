using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОООТехносервис.Classes;
using ОООТехносервис.Model;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace ОООТехносервис.View
{
    public partial class listRequest : Form
    {
        public listRequest()
        {
            InitializeComponent();
        }

        public void Show_Requests()
        {
            // Получить записи из БД
            List<Model.Request> list = Classes.Helper.DBRequest.Request.ToList();
            // фильтрация по заявкам  ы
            switch (Helper.user.UserRoleId)
            {
                case 1:  //Заказчик
                    list = list.Where(r => r.RequestClientId == Helper.user.UserId).ToList();
                    break;
                case 2:  //Мастер
                    list = list.Where(r => r.RequestMasterId == Helper.user.UserId).ToList();
                    buttonEditRequest.Visible = true;
                    break;
                case 3:  //Оператор
                    buttonEditRequest.Visible = true;
                    buttonAddRequest.Visible = true;

                    break;
                case 4:  //Менеджер
                    buttonReport.Visible = true;
                    break;
            }
            this.dataGridViewRequest.Rows.Clear();
            int numberStatus = (int)comboBoxRequest.SelectedIndex;

            // Фильтрация по статусу
            if (numberStatus > 0)
            {
                list = list.Where(r => r.RequestStatusId == numberStatus).ToList();
            }

            // Поиск по номеру
            if (textBox1.Text != "") ;
            {
                list = list.Where(r => r.RequestId.ToString().Contains(textBox1.Text)).ToList();
            }

            // Очистили все строки
            this.dataGridViewRequest.Rows.Clear();

            // Цикл по перебору всех заявок
            int i = 0;
            foreach (Model.Request request in list)
            {
                this.dataGridViewRequest.Rows.Add();
                dataGridViewRequest.Rows[i].Cells[0].Value = request.RequestId;
                dataGridViewRequest.Rows[i].Cells[1].Value = request.RequestDate.ToLongDateString();
                dataGridViewRequest.Rows[i].Cells[2].Value = request.Device.DeviceName;
                dataGridViewRequest.Rows[i].Cells[3].Value = request.User.UserFullName;
                dataGridViewRequest.Rows[i].Cells[4].Value = request.Status.StatusName;
                dataGridViewRequest.Rows[i].Cells[5].Value = request.User1.UserFullName;
                dataGridViewRequest.Rows[i].Cells[6].Value = request.Stage.StageName;
                i++;
            }
        }


        /// <summary>
        /// Кнопка Выход
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void button2_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void listReqest_Load(object sender, EventArgs e)
        {  //Заполнить комбобокс статусами из БД
            List<Model.Status> statuses = Classes.Helper.DBRequest.Status.ToList();
            //Новый статус
            Model.Status status = new Model.Status();
            status.StatusId = 0;
            status.StatusName = "Все статусы";
            //Добавить новый статус к остальным
            statuses.Insert(0, status);

            comboBoxRequest.DataSource = statuses;

            //Какое поле будет видеть пользователь
            comboBoxRequest.DisplayMember = "StatusName";
            comboBoxRequest.ValueMember = "Statusid";
            comboBoxRequest.SelectedIndex = 0;
            Show_Requests();
            // Отобразить список заявок в сетке
            //dataGridViewReques  t.DataSource = list;
        }

        /// <summary>
        /// Выбор статуса для фильтрации
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void comboBoxStatus_SelectedIndexChanged(object sender, EventArgs e)
        {
            Show_Requests();
        }

        private void textBoxNumber_TextChanged(object sender, EventArgs e)
        {
            Show_Requests();
        }

        private void buttonAddRequest_Click(object sender, EventArgs e)
        {
            //Создать окно одной заявки и передать ему значение 0
            //Т.к. для новой заявки нет номера выбранной заявки
            //Можно любое число, хоть отрицательное, занчения которого нет в id заявок
            View.WorkRequest workRequest = new View.WorkRequest(0);
            this.Hide();
            workRequest.ShowDialog();
            this.Show();
        }

        private void buttonEditRequest_Click(object sender, EventArgs e)
        {
            if (dataGridViewRequest.SelectedRows.Count > 0)
            {
                int id = (int)dataGridViewRequest.CurrentRow.Cells[0].Value;
                View.EditRequest workRequest = new View.WorkRequest(id);
                this.Hide();
                workRequest.ShowDialog();
                this.Show();
            }
            else
            {
                MessageBox.Show("Не выбрана заявка для редактирования");
            }
        }

        private void buttonAddRequest_Click_1(object sender, EventArgs e)
        {
            //Создать окно одной заявки и передать ему значение 0
            //Т.к. для новой заявки нет номера выбранной заявки
            //Можно любое число, хоть отрицательное, занчения которого нет в id заявок
            View.EditRequest workRequest = new View.WorkRequest(0);
            this.Hide();
            workRequest.ShowDialog();
            this.Show();
        }
    }

    internal class WorkRequest : EditRequest
    {
        private int id;

        public WorkRequest(int id)
        {
            this.id = id;
        }
    }
}
