﻿using System;
using System.Data;
using System.Data.SqlClient;
using System.Globalization;
using System.Text;
using System.Windows.Forms;

namespace Nhom11.Classes
{
    class Functions
    {
        public static SqlConnection conn;
        public static string connstring;
        public static void Connect()
        {
            connstring = "Data Source=DESKTOP-297FAMM\\SQLEXPRESS;Initial Catalog=Nhom11;Integrated Security=True;";
            //connstring = "Data Source=LAPTOP-7BJDK7AQ\\SQLEXPRESS;Initial Catalog=csdl;Integrated Security=True;Encrypt=False"; //connstring cua bngoc
            //connstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=csdl;Integrated Security=True;Connect Timeout=30;Encrypt=False"; //connstring cua bngoc
            //connstring = "Data Source=DESKTOP-I7VGTSH\\LTNET;Initial Catalog=csdl;Integrated Security=True;Encrypt=False";
            //connstring = "Data Source=(localdb)\\ProjectModels;Initial Catalog=csdl;Integrated Security=True;Connect Timeout=30;Encrypt=False"; //connstring của bao pc
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
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            return table;
        }
        public static void FillComboBox(string sql, ComboBox cbo, string ma, string ten)
        {
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Functions.conn);
            DataTable table = new DataTable();
            mydata.Fill(table);
            cbo.DataSource = table;
            cbo.ValueMember = ma;
            cbo.DisplayMember = ten;
        }
        public static string GetFielbValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
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
            SqlDataAdapter mydata = new SqlDataAdapter(sql, Functions.conn);
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
            cmd.Connection = Classes.Functions.conn;
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
        // Kiểm tra xem ngày tháng nhập vào có hợp lệ không - hàm này đầy đủ và đúng hơn
        public static bool IsValidDate(string dateString)
        {
            string dateFormat = "dd/MM/yyyy";
            DateTime dateValue;
            bool isValid = DateTime.TryParseExact(
                dateString,
                dateFormat,
                CultureInfo.InvariantCulture,
                DateTimeStyles.None,
                out dateValue
            );

            return isValid;
        }
        // Hàm cũ - không chính xác
        public static bool IsDate(string d)
        {
            string[] parts = d.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) && (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
                return true;
            else
                return false;
        }

        public static string ConvertDateTime(string d)
        {
            string[] parts = d.Split('/');
            string dt = String.Format("{0}/{1}/{2}", parts[1], parts[0], parts[2]);
            return dt;
        }

        // Tự động điểu chỉnh độ rộng cột khi Datagridview có kích thước lớn hơn
        public static void ChangeColumnsSize(DataGridView view)
        {
            int totalColumnWidth = 0;
            foreach (DataGridViewColumn column in view.Columns)
            {
                totalColumnWidth += column.Width;
            }

            if (totalColumnWidth < view.Width)
            {
                foreach (DataGridViewColumn column in view.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
                }
            }
            else
            {
                foreach (DataGridViewColumn column in view.Columns)
                {
                    column.AutoSizeMode = DataGridViewAutoSizeColumnMode.AllCells;
                }
            }
        }

        // Hàm đổi số thành chữ
        private static readonly string[] Units = { "", "một", "hai", "ba", "bốn", "năm", "sáu", "bảy", "tám", "chín" };
        private static readonly string[] Tens = { "", "mười", "hai mươi", "ba mươi", "bốn mươi", "năm mươi", "sáu mươi", "bảy mươi", "tám mươi", "chín mươi" };
        private static readonly string[] Hundreds = { "", "một trăm", "hai trăm", "ba trăm", "bốn trăm", "năm trăm", "sáu trăm", "bảy trăm", "tám trăm", "chín trăm" };
        private static readonly string[] BigNumbers = { "", "nghìn", "triệu", "tỷ" };

        private static string ConvertThreeDigitNumber(int number)
        {
            int hundred = number / 100;
            int ten = (number % 100) / 10;
            int unit = number % 10;

            StringBuilder result = new StringBuilder();

            if (hundred > 0)
            {
                result.Append(Hundreds[hundred]);
            }

            if (ten == 0 && unit > 0)
            {
                if (hundred > 0)
                {
                    result.Append(" linh");
                }
                result.Append(" ").Append(Units[unit]);
            }
            else
            {
                if (ten > 0)
                {
                    if (hundred > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(Tens[ten]);
                }

                if (unit > 0)
                {
                    if (hundred > 0 || ten > 0)
                    {
                        result.Append(" ");
                    }
                    if (ten == 1 && unit == 1)
                    {
                        result.Append("một");
                    }
                    else if (ten > 1 && unit == 5)
                    {
                        result.Append("lăm");
                    }
                    else
                    {
                        result.Append(Units[unit]);
                    }
                }
            }

            return result.ToString().Trim();
        }

        public static string ConvertNumberToWords(long number)
        {
            if (number == 0)
            {
                return "không";
            }

            StringBuilder result = new StringBuilder();

            int[] groups = new int[4];
            int groupIndex = 0;

            while (number > 0)
            {
                groups[groupIndex] = (int)(number % 1000);
                number /= 1000;
                groupIndex++;
            }

            for (int i = groupIndex - 1; i >= 0; i--)
            {
                if (groups[i] > 0)
                {
                    if (result.Length > 0)
                    {
                        result.Append(" ");
                    }
                    result.Append(ConvertThreeDigitNumber(groups[i]));
                    if (i > 0)
                    {
                        result.Append(" ").Append(BigNumbers[i]);
                    }
                }
            }

            return result.ToString().Trim();
        }

        // Lấy thông tin cho ComboBox
        public static string GetFieldValues(string sql)
        {
            string ma = "";
            SqlCommand cmd = new SqlCommand(sql, Functions.conn);
            SqlDataReader reader;
            reader = cmd.ExecuteReader();
            while (reader.Read())
            {
                ma = reader.GetValue(0).ToString();
            }
            reader.Close();
            return ma;
        }

        // Xóa bản ghi
        public static void RunSqlDel(string sql)
        {
            SqlCommand cmd = new SqlCommand();
            cmd.Connection = Functions.conn;
            cmd.CommandText = sql;
            try
            {
                cmd.ExecuteNonQuery();
            }
            catch (System.Exception)
            {
                MessageBox.Show("Dữ liệu đang được dùng, không thể xóa...", "Thông báo",
                MessageBoxButtons.OK, MessageBoxIcon.Stop);
            }
            cmd.Dispose();
            cmd = null;
        }
        public static string CreateKey(string tiento)
        {
            string key = tiento;
            string[] partsDay;
            partsDay = DateTime.Now.ToShortDateString().Split('/');
            //Ví dụ 07/08/2009
            string d = String.Format("{0}{1}{2}", partsDay[0], partsDay[1], partsDay[2]);
            key = key + d;
            string[] partsTime;
            partsTime = DateTime.Now.ToLongTimeString().Split(':');
            //Ví dụ 7:08:03 PM hoặc 7:08:03 AM
            if (partsTime[2].Substring(3, 2) == "PM")
                partsTime[0] = ConvertTimeTo24(partsTime[0]);
            if (partsTime[2].Substring(3, 2) == "AM")
                if (partsTime[0].Length == 1)
                    partsTime[0] = "0" + partsTime[0];
            //Xóa ký tự trắng và PM hoặc AM
            partsTime[2] = partsTime[2].Remove(2, 3);
            string t;
            t = String.Format("{0}{1}{2}", partsTime[0], partsTime[1], partsTime[2]);
            key = key + t;
            return key;
        }
        public static string ConvertTimeTo24(string hour)
        {
            string h = "";
            switch (hour)
            {
                case "1":
                    h = "13";
                    break;
                case "2":
                    h = "14";
                    break;
                case "3":
                    h = "15";
                    break;
                case "4":
                    h = "16";
                    break;
                case "5":
                    h = "17";
                    break;
                case "6":
                    h = "18";
                    break;
                case "7":
                    h = "19";
                    break;
                case "8":
                    h = "20";
                    break;
                case "9":
                    h = "21";
                    break;
                case "10":
                    h = "22";
                    break;
                case "11":
                    h = "23";
                    break;
                case "12":
                    h = "0";
                    break;
            }
            return h;
        }
        public static bool Isdate(string date)
        {
            string[] parts = date.Split('/');
            if ((Convert.ToInt32(parts[0]) >= 1) && (Convert.ToInt32(parts[0]) <= 31) &&
                (Convert.ToInt32(parts[1]) >= 1) && (Convert.ToInt32(parts[1]) <= 12) && (Convert.ToInt32(parts[2]) >= 1900))
            {
                return true;
            }
            else return false;
        }
        
    }
 }

