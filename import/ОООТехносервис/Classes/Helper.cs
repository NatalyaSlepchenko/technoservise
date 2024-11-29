using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ОООТехносервис.Classes
{
    public class Helper // класс с глобальными для всего проекта величинами
    {
       //Связка с бд
       public static Model.Db_Slepchenko_connection DBrequest { get; set; } // static означает, что объект будет в единственном экземпляре

        public static Model.User user;
    }
}
    