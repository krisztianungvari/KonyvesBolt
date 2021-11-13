using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace KonyvesBolt
{
    class AdatKapcsolat
    {

        MySqlConnection connection;
        MySqlCommand command;

        const string server = "localhost";
        const string user = "root";
        const uint port = 3306;
        const string password = "";
        const string database = "konyvesbolt";
        const MySqlSslMode sslMode = MySqlSslMode.None;

        public AdatKapcsolat()
        {
            Csatlakozas();
        }

        public void Csatlakozas()
        {
            MySqlConnectionStringBuilder stringBuilder = new MySqlConnectionStringBuilder();

            stringBuilder.Server = server;
            stringBuilder.UserID = user;
            stringBuilder.Port = port;
            stringBuilder.Password = password;
            stringBuilder.Database = database;
            stringBuilder.SslMode = sslMode;

            string connectionString = stringBuilder.ToString();

            try
            {
                connection = new MySqlConnection(connectionString);
                connection.Open();

                command = new MySqlCommand();
                command.Connection = connection;
            }
            catch (MySqlException ex)
            {
                MessageBox.Show("Hiba az adatbázis csatlakozás közben: ", ex.Message);
                Environment.Exit(0);
            }
        }
        public void KapcsolatBontasa()
        {
            try
            {
                connection.Close();
                command.Dispose();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Hiba az adatbázis kapcsolat bontása közben: ", ex.Message);

            }

        }
        public void TudomanyosKonyvekListazasa()
        {
            try
            {
                Program.form1.listBox_TudomanyosKonyv.Items.Clear();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM tudomanyoskonyv";
                List<TudomanyosKonyvOsztaly> tudomanyoskonyv = new List<TudomanyosKonyvOsztaly>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string cim = reader["Cim"].ToString();
                    string szerzo = reader["Szerzo"].ToString();
                    int oldalszam = reader.IsDBNull(3) ? 0 : reader.GetInt32("OldalSzam");
                    int ar = reader.IsDBNull(4) ? 0 : reader.GetInt32("Ar");
                    int kiadasev = (int)reader["KiadasEv"];
                    TudomanyTerulet tudomanyTerulet = (TudomanyTerulet)Enum.Parse(typeof(TudomanyTerulet), reader["TudomanyTerulet"].ToString());
                    //Bool?
                    //   bool elismert = reader.IsDBNull(7) ? 0 : reader.GetBoolean("ElismertKonyvE");
                    bool elismert = false;
                    if (reader.GetInt16("ElismertKonyvE") == 1)
                    {
                        elismert = true;
                    }
                  

                    Program.form1.listBox_TudomanyosKonyv.Items.Add(new TudomanyosKonyvOsztaly(cim, szerzo, oldalszam, ar, kiadasev, tudomanyTerulet, elismert));
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás!", ex);
            }

        }
        public void TudomanyosKonyvFelvitel(TudomanyosKonyvOsztaly tudomanyoskonyv)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO tudomanyoskonyv VALUES (@cim,@szerzo,@oldalszam,@ar,@kiadasev,@tudomanTerulet,@elismert)";
                command.Parameters.AddWithValue("@cim", tudomanyoskonyv.Cim);
                command.Parameters.AddWithValue("@szerzo", tudomanyoskonyv.Szerzo);
                command.Parameters.AddWithValue("@oldalszam", tudomanyoskonyv.Oldalszam);
                command.Parameters.AddWithValue("@ar", tudomanyoskonyv.Ar);
                command.Parameters.AddWithValue("@kiadasev", tudomanyoskonyv.Kiadasev);
                command.Parameters.AddWithValue("@tudomanTerulet", tudomanyoskonyv.TudomanyTerulet.ToString());
                command.Parameters.AddWithValue("@elismert", tudomanyoskonyv.Elismert);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen feltöltés!", ex);
            }
        }

        public void TudomanyosKonyvModositasa(TudomanyosKonyvOsztaly tudomanyoskonyv)
        {

            try
            {
                command.Parameters.Clear();
                command.CommandText = "UPDATE tudomanyoskonyv SET `Ar` = @ar WHERE Cim = @cim";
                command.Parameters.AddWithValue("@ar", tudomanyoskonyv.Ar);
                command.Parameters.AddWithValue("@cim", tudomanyoskonyv.Cim);


                command.ExecuteNonQuery();

                command.Parameters.Clear();
                command.CommandText = "UPDATE tudomanyoskonyv SET `ElismertKonyvE` = @elismert WHERE Cim = @cim";
                command.Parameters.AddWithValue("@elismert", tudomanyoskonyv.Elismert);
                command.Parameters.AddWithValue("@cim", tudomanyoskonyv.Cim);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen módosítás!", ex);
            }
        }
        public void TudomanyosKonyvTorlese(TudomanyosKonyvOsztaly tudomanyoskonyv)

        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "DELETE FROM tudomanyoskonyv WHERE Cim = @cim";
                command.Parameters.AddWithValue("@cim", tudomanyoskonyv.Cim);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
        }
        public void IrodalmiKonyvekListazasa()
        {
            try
            {
                Program.form1.listBox_IrodalmiKonyv.Items.Clear();
                command.Parameters.Clear();
                command.CommandText = "SELECT * FROM irodalmikonyv";
                List<IrodalmiKonyvOsztaly> irodalmikonyv = new List<IrodalmiKonyvOsztaly>();
                MySqlDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    string cim = reader["Cim"].ToString();
                    string szerzo = reader["Szerzo"].ToString();
                    int oldalszam = reader.IsDBNull(3) ? 0 : reader.GetInt32("OldalSzam");
                    int ar = reader.IsDBNull(4) ? 0 : reader.GetInt32("Ar");
                    int kiadasev = (int)reader["KiadasEv"];
                    Kategoria kategoria = (Kategoria)Enum.Parse(typeof(Kategoria), reader["Kategoria"].ToString());


                    Program.form1.listBox_IrodalmiKonyv.Items.Add(new IrodalmiKonyvOsztaly(cim, szerzo, oldalszam, ar, kiadasev, kategoria));
                }
                reader.Close();

            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen listázás!", ex);
            }
        }
        public void IrodalmiKonyvFelvitel(IrodalmiKonyvOsztaly irodalmikonyv)
        {
            try
            {
                command.Parameters.Clear();
                command.CommandText = "INSERT INTO irodalmikonyv VALUES (@cim,@szerzo,@oldalszam,@ar,@kiadasev,@kategoria)";
                command.Parameters.AddWithValue("@cim", irodalmikonyv.Cim);
                command.Parameters.AddWithValue("@szerzo", irodalmikonyv.Szerzo);
                command.Parameters.AddWithValue("@oldalszam", irodalmikonyv.Oldalszam);
                command.Parameters.AddWithValue("@ar", irodalmikonyv.Ar);
                command.Parameters.AddWithValue("@kiadasev", irodalmikonyv.Kiadasev);              
                command.Parameters.AddWithValue("@kategoria", irodalmikonyv.Kategoria);
                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {

                throw new Exception("Sikertelen feltöltés!", ex);
            }
        }




        public void IrodalmiKonyvModositasa(IrodalmiKonyvOsztaly irodalmikonyv)
        {

            try
            {

                command.Parameters.Clear();
                command.CommandText = "UPDATE irodalmikonyv SET `Ar` = @ar WHERE Cim = @cim";
                command.Parameters.AddWithValue("@ar", irodalmikonyv.Ar);
                command.Parameters.AddWithValue("@cim", irodalmikonyv.Cim);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen módosítás!", ex);
            }
        }
        public void IrodalmiKonyvTorlese(IrodalmiKonyvOsztaly irodalmikonyv)

        {
            try
            {

                command.Parameters.Clear();
                command.CommandText = "DELETE FROM irodalmikonyv WHERE Cim = @cim";
                command.Parameters.AddWithValue("@cim", irodalmikonyv.Cim);

                command.ExecuteNonQuery();
            }
            catch (Exception ex)
            {
                throw new Exception("Sikertelen törlés!", ex);
            }
        }
    }
}
