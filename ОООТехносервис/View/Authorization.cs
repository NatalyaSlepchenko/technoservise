using System;
using System.Linq;
using System.Windows.Forms;
using ОООТехносервис.Classes;

namespace ОООТехносервис
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            // Создали подключение к БД
            try
            {
                Classes.Helper.DBRequest = new Model.ConnectDBRequest();
                MessageBox.Show("К БД подключились");
            }
            catch
            {
                MessageBox.Show("Не удалось подключиться к БД");
                Environment.Exit(-1); //Аварийный выход из приложения
            }
        }

        private void Authorization_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //Получили данные от пользователя из интерфейса
            string login = textBoxLogin.Text;
            string password = textBoxPassword.Text;

            ////////////Результат запроса на получение всех пользователей
            //////////List<Model.User>   users =  Classes.Helper.DBRequest.User.ToList();
            ////////////Один пользователь
            //Model.User user=null;
            //////////Список отфильтраванных пользователей
            ////////List<Model.User> usersWhere = users.Where(u=>u.UserLogin == login && u.UserPassword == password).ToList();
            //////////Первый из отфильтрованных
            ////////user = usersWhere.FirstOrDefault();

            Helper.user = Classes.Helper.DBRequest.User.Where(u => u.UserLogin == login &&
            u.UserPassword == password).FirstOrDefault();

            ////////////////Перебор всех пользователей
            //////////////foreach (Model.User u in users) 
            //////////////{
            //////////////    if (u.UserLogin == login && u.UserPassword == password) //Нашли
            //////////////    {
            //////////////        user = u;
            //////////////        break;
            //////////////    }
            //////////////}

            if (Helper.user != null)
            {
                MessageBox.Show("Нашли. Вы вошли с ролью " + Helper.user.Role.RoleName);

                //Отобразить окно
                View.listRequest listRequests = new View.listRequest();   //Создали дополнительное окно
                this.Hide();    //Временно скрыли окно авторизации this - ссылка на окно, в котором сейчас находимся
                listRequests.ShowDialog();  //Открыть окно списка
                this.Show();        //Показать окно авторизации после закрытия окна списка
            }
            else
            {
                MessageBox.Show("Не нашли");
            }
        }

        private void textBoxLogin_TextChanged(object sender, EventArgs e)
        {

        }
    }
}