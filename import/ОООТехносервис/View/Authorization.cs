using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ОООТехносервис.Model;
using ОООТехносервис.Classes; //для сокращения, чтобы не псиать слово классес 

namespace ОООТехносервис
{
    public partial class Authorization : Form
    {
        public Authorization()
        {
            InitializeComponent();
            try
            {
                Classes.Helper.DBrequest = new Model.Db_Slepchenko_connection();
            }
            
            catch (Exception)
            {
                Environment.Exit(-1); // Аварийный выход из приложения            
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void Authorization_Load(object sender, EventArgs e)
        {

            {
                try
                {
                    Classes.Helper.DBrequest = new Model.Db_Slepchenko_connection();
                    MessageBox.Show("К БД подключились");
                }
                catch
                {
                    MessageBox.Show("Не удалось подключиться к БД"); Environment.Exit(-1);
                }
            }
        }
    

        private void button2_Click(object sender, EventArgs e)
        {

            //Вход в систему по логину и паролю
            string login, password;
            login = textBox1.Text;
            password = textBox2.Text;
            //Результат запроса на получение всех пользователей
            List<Model.User> users = Classes.Helper.DBrequest.User.ToList();
            Model.User user = null;
            //Перебор всех пользователей
            foreach (Model.User u in users)
            {
                if (u.User_Login == login && u.User_Password == password)
                {
                    user = u;
                    break;
                }
            }
            if (user != null)
            {
                MessageBox.Show("Найдено. Вы вошли сролью " + user.Role_Slepchenko.Roll_Name);

            }
            else
            {
                MessageBox.Show("Не найдено");
            }
        }

    }
}
