using System;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Nhom11.Class
{
    class Funtions
    {
        public static SqlConnection conn;
        public static string connstring;
        public static void Connect()
        {
            connstring = "";
            conn = new SqlConnection(connstring);
            conn.Open();
        }
        public static void Close()
        {
            if (conn.State == ConnectionState.Open)
            {
                conn.Close();
                conn.Dispose();
                conn = null;
            }
        }
        public static DataTable GetDataToTable(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Funtions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        public static void FillComboBox(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Funtions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static string GetFielbValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Funtions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }
        public static bool CheckKey(string sql)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Funtions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            if (table.Rows.Count > 0)
            {
                return true;
            }
            return false;
        }
        public static void RunSql(string sql)
        {
            SqlCommand cmd;
            cmd = new SqlCommand();
            cmd.Connection = Class.Funtions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
            cmd.Dispose();
            cmd = null;
        }
        // Kiểm tra xem ngày tháng nhập vào có hợp lệ không, không quá chính xác với tháng 2
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }
        // Hàm format lại định dạng của ngày trong mask textbox trong trường hợp ngày tháng có định dạng "MM/dd/yyyy" nó sẽ chuyển về thành "dd/MM/yyyy"
        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }
    }
}
