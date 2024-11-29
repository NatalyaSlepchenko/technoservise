using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ОООТехносервис.View
{
    public partial class EditRequest : Form
    {
        Model.Request Request; // Глобальная для окна

        public EditRequest()
        {
            InitializeComponent();
        }
        /// <summary>
        /// Конструктор с параметром 
        /// </summary>
        /// <param name="id">Номер выбранной заявки</param>
        public EditRequest(int id)
        {
            InitializeComponent();
            Request = Classes.Helper.DBRequest.Request.Where(r => r.RequestID == id).FirstOrDefault();
        }

        private void buttonExit_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
