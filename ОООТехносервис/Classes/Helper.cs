namespace ОООТехносервис.Classes
{
    // Класс с глобальными для всего проекта величинами
    public class Helper
    {
        //internal static object user;

        // Связка с БД static значит, что объект будет в единственном экземпляре
        public static Model.ConnectDBRequest DBRequest { get; set; }
        public static object userNow { get; internal set; }

        public static Model.User user;
    }
}
