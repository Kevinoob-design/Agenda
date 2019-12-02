﻿using System;
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
    }
}
