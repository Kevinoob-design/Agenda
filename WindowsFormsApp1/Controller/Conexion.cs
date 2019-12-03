using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;
using System.Collections.Generic;

namespace Controller
{
    static class Conexion
    {
        static SqlConnection con;
        static SqlCommand cmd;
        static SqlDataReader dr;
        static SqlDataAdapter da;

        static string SourcePC;
        static string InitialCat;
        static string IntSecuirity;
        static string UserID;

        static Conexion()
        {
            //SourcePC = "Data source = Hector-Macbook;";
            //SourcePC = "Data source = Hector-PC;";
            //InitialCat = "Initial catalog = Agenda;";
            //InitialCat = "Initial catalog = AGENDAPrueba;";
            //IntSecuirity = "Integrated security = true";

            SourcePC = "Data source = 2620:9b::1907:5199,1433;";
            InitialCat = "Initial catalog = AGENDAPrueba;";
            UserID = "User ID = Wander; Password = 123456789;";

            //con = new SqlConnection(SourcePC + InitialCat + IntSecuirity);
            con = new SqlConnection(SourcePC + InitialCat + UserID);
            con.Open();
        }

        public static List<T> Load<T>(Dictionary<string, string> items, string spName) where T : new()
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;

            if (items != null)
            {
                foreach (var item in items)
                {
                    cmd.Parameters.AddWithValue($"@{item.Key}", item.Value);
                }
            }

            dr = cmd.ExecuteReader();

            List<T> listOfItems = new List<T>();

            while (dr.Read())
            {
                T item = new T();
                Type type = item.GetType();

                for (int i = 0; i < dr.FieldCount; i++)
                {
                    object boxed = item;

                    type.GetProperty(dr.GetName(i)).SetValue(boxed, dr.GetValue(i).ToString());

                    item = (T)boxed;
                }

                listOfItems.Add(item);
            }
            dr.Close();

            return listOfItems;
        }

        public static void Save(Dictionary<string, string> items, string spName)
        {
            cmd = con.CreateCommand();
            cmd.CommandType = CommandType.StoredProcedure;
            cmd.CommandText = spName;

            foreach (var item in items)
            {
                cmd.Parameters.AddWithValue($"@{item.Key}", item.Value);
            }

            cmd.ExecuteNonQuery();
        }



        public static void LoadData(DataGridView Dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter("exec Select_Events_Completly", con);

            DataSet ds = new DataSet();


            da.Fill(ds, "EVENTS");
            Dgv.DataSource = ds;
            Dgv.DataMember = "EVENTS";

        }
        public static void LoadDataEvent(DataGridView Dgv,int contactID)
        {

            SqlDataAdapter da = new SqlDataAdapter($"exec  Select__Contact_Event {contactID}", con);

            DataSet ds = new DataSet();


            da.Fill(ds, "EVENTS");
            Dgv.DataSource = ds;
            Dgv.DataMember = "EVENTS";

        }

        public static void LoadDataContact(DataGridView Dgv)
        {
            SqlDataAdapter da = new SqlDataAdapter($"exec  Select_Contact_Info", con);

            DataSet ds = new DataSet();


            da.Fill(ds, "CONTACTS");
            Dgv.DataSource = ds;
            Dgv.DataMember = "CONTACTS";

        }

        public static void LoadDataContactRemove(DataGridView Dgv,int eventID)
        {

            SqlDataAdapter da = new SqlDataAdapter($"exec  Select__Event_Contact {eventID}", con);

            DataSet ds = new DataSet();


            da.Fill(ds, "CONTACTS");
            Dgv.DataSource = ds;
            Dgv.DataMember = "CONTACTS";

        }

        public static void EliminarRelacion(int eventID)
        {
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "EXECUTE R__Eliminar__Events_In_Contacts @eventID";
            cmd.Parameters.AddWithValue("@eventID", eventID);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Evento Removido de lista");
        }

        public static void EliminarRelacionEvento(int contactoID)
        {
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "EXECUTE R__Eliminar__Contact_in_Event @contactoID";
            cmd.Parameters.AddWithValue("@contactoID", contactoID);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Contacto Removido de lista");
        }

        public static void InsertarRelacion(int contact, int events)
        {
            MessageBox.Show(contact.ToString(), events.ToString());
            dr.Close();
            cmd = con.CreateCommand();
            cmd.CommandText = "EXECUTE R__Insertar__Contacts_Events @contactID,@eventID ";
            cmd.Parameters.AddWithValue("@contactID", contact);
            cmd.Parameters.AddWithValue("@eventID", events);
            cmd.ExecuteNonQuery();

            MessageBox.Show("Evento Incertado");

        }

        
        

        public static string countRows(string contactID)
        {
            SqlDataAdapter da = new SqlDataAdapter($"exec  Select__Contact_Event {contactID}", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "EVENTS");

            string numberofRows = (ds.Tables[0].Rows.Count).ToString();      
            return numberofRows;
        }


        public static string countRowsContact(string eventID)
        {
            SqlDataAdapter da = new SqlDataAdapter($"exec  Select__Event_Contact {eventID}", con);

            DataSet ds = new DataSet();
            da.Fill(ds, "CONTACTS");

            string numberofRows = (ds.Tables[0].Rows.Count).ToString();
            return numberofRows;
        }
    }
}
