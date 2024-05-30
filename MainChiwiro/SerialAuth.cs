using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MainChiwiro
{
    public class SerialAuth
    {

        private void PoliticaLicencia()
        {
            string mensaje = "Términos y condiciones de la licencia:\n\n" +
                             "- Uso autorizado únicamente para propósitos legales.\n" +
                             "- No se permite la redistribución del software.\n" +
                             "- No se garantiza la ausencia de errores.\n" +
                             "- Los autores no se hacen responsables de daños causados por el uso de este software.\n" +
                             "- Este software puede recopilar información sobre el uso con fines estadísticos.\n" +
                             "- El usuario debe proporcionar una dirección de correo electrónico válida para fines de contacto y soporte.\n" +
                             "- Se prohíbe modificar, descompilar o realizar ingeniería inversa sobre el software.\n\n" +
                             "Política de reembolso:\n" +
                             "Se ofrece un período de reembolso de 3 días desde la fecha de compra. Después de este período, no se realizarán reembolsos.\n\n" +
                             "¿Acepta estos términos y condiciones?";

            DialogResult resultado = MessageBox.Show(mensaje, "Política de Licencia", MessageBoxButtons.YesNo);

            if (resultado == DialogResult.Yes)
            {
                MessageBox.Show("¡Gracias por aceptar los términos de la licencia!");
            }
            else
            {
                MessageBox.Show("Para usar este software, debe aceptar los términos de la licencia.");
                Environment.Exit(0);
            }
        }

        private readonly string connectionString;

        public SerialAuth(string connectionString)
        {
            this.connectionString = connectionString;
        }

        public void CheckSerialAndAddVipDays(string serial)
        {
            using (MySqlConnection connection = new MySqlConnection(connectionString))
            {
                connection.Open();
                string checkSerialQuery = "SELECT Serial, Fecha FROM datos WHERE Serial = @Serial";
                using (MySqlCommand checkSerialCommand = new MySqlCommand(checkSerialQuery, connection))
                {
                    checkSerialCommand.Parameters.AddWithValue("@Serial", serial);
                    using (MySqlDataReader reader = checkSerialCommand.ExecuteReader())
                    {
                        if (reader.Read())
                        {
                            DateTime? fecha = null;
                            int fechaColumnIndex = reader.GetOrdinal("Fecha");
                            try
                            {
                                fecha = reader.GetDateTime(fechaColumnIndex);
                            }
                            catch (MySql.Data.Types.MySqlConversionException)
                            {
                                fecha = null;
                            }

                            

                            if (!fecha.HasValue || fecha.Value == DateTime.MinValue)
                            {
                                PoliticaLicencia();
                                reader.Close();
                                string updateQuery = "UPDATE datos SET Fecha = @FechaNueva WHERE Serial = @Serial";
                                using (MySqlCommand updateCommand = new MySqlCommand(updateQuery, connection))
                                {
                                    updateCommand.Parameters.AddWithValue("@Serial", serial);
                                    updateCommand.Parameters.AddWithValue("@FechaNueva", DateTime.Now.AddDays(30));
                                    updateCommand.ExecuteNonQuery();
                                    MessageBox.Show("Fecha VIP agregada correctamente.");
                                    Auth pauth = new Auth();
                                    pauth.Visible = false;
                                    Main form = new Main();
                                    pauth.Close();
                                    form.Show();
                                }
                            }
                            else if (fecha.Value.AddDays(30) > DateTime.Now)
                            {
                                MessageBox.Show("Bienvenido, aún cuentas con días VIP.");
                                Auth pauth = new Auth();
                                pauth.Visible = false;
                                Main form = new Main();
                                pauth.Close();
                                form.Show();
                            }
                            else
                            {
                                MessageBox.Show("Membresía terminada.");
                            }
                        }
                        else
                        {
                            MessageBox.Show("Serial incorrecto.");
                        }
                    }
                }
            }
        }

    }



}

