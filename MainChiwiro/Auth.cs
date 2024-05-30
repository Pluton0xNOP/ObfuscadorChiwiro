using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;

namespace MainChiwiro
{
    public partial class Auth : MaterialForm
    {
        string connectionString = "server=localhost;user=root;database=chiwiro;port=3306;password=";

        public Auth()
        {
            InitializeComponent();
        }

        private void Auth_Load(object sender, EventArgs e)
        {

        }

        private void Ingresar_Click(object sender, EventArgs e)
        {

            string connectionString = "server=localhost;user=root;database=chiwiro;port=3306;password=";
            string serial = Serial.Text;
            SerialAuth auth = new SerialAuth(connectionString);
            auth.CheckSerialAndAddVipDays(serial);

        }

       
    }
}
