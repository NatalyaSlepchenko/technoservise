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

namespace ОООТехносервис.View
{
    public partial class Auth : Form
    {
        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {
            {
                try
                {
                    Helper.DBRequest = new Model.ConnectDBRequest();
                    MessageBox.Show("К БД подключились");
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к БД"); Environment.Exit(-1);
                }
            }
        }

        private void textBoxPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void buttonAuth_Click(object sender, EventArgs e)
        {
            //Вход в систему по логину и паролю
            string login, password;
            login = textBoxLogin.Text;
            password = textBoxPassword.Text;
            //Результат запроса на получение всех пользователей
            List<Model.User> users = Helper.DBRequest.User.ToList();
            //Model.User user  = null;


            //// Первый вариант поиска по базе (перебор всех пользователей)
            //foreach (Model.User u in users)
            //{
            //    if (u.User_Login == login && u.User_Password == password)
            //    {
            //        user = u;
            //        break;
            //    }
            //}


            //// Второй вариант поиска по базе
            //List<Model.User> usersWhere = users.Where(u => u.User_Login == login && u.User_Password == password).ToList();
            //user = usersWhere.FirstOrDefault();


            // Третий вариант поиска по базе
            Helper.user = Helper.DBRequest.User.Where(u => u.UserLogin == login && u.UserPassword == password).FirstOrDefault();


            //Сообщение о нахождении записи в БД
            if (Helper.user != null)
            {
                MessageBox.Show("Найдено. Вы вошли как " + Helper.user.Role.RoleName);
                // Создание окна
                listRequest requestList = new listRequest();
                // Скрываем текущее окно
                this.Hide();
                requestList.ShowDialog(); // Открыть окно списка
                this.Show(); // Показать окно авторизации после закрытия окна списка

            }
            else
            {
                MessageBox.Show("Не найдено");
            }
        }
    }



    //internal class ListRequest
    //{
    //    internal void ShowDialog()
    //    {
    //        throw new NotImplementedException();
    //    }
    //}
}
