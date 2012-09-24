using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Data.OleDb;
using System.Configuration;

namespace HotelMana
{
    class Employ
    {
        private String room,from,to,total,gia;
        Double cost;
        public Employ(String rroom, String ffrom, String tto, String ttotal, String ggia, Double ccost)
        {
            this.room = rroom;
            this.from = ffrom;
            this.to= tto;
            this.total = ttotal;
            this.gia = ggia;
            this.cost = ccost;
        }
        public void SaveToDatabase()
        {
            ExcuteQuery(this.room ,this.from ,this.to,this.total,this.gia,this.cost);
        }
        private void ExcuteQuery(String rroom, String ffrom, String tto, String ttotal, String ggia, Double ccost)
        {
            String constr = "Provider=Microsoft.Jet.OLEDB.4.0;Data Source=|DataDirectory|\\data.mdb;Persist Security Info=false";
            OleDbConnection con = new OleDbConnection(constr);
            OleDbCommand com = new OleDbCommand();
            com.Connection = con;
            com.CommandType = System.Data.CommandType.Text;
            com.CommandText = "Insert into Employ([id_phong],[from],[to],[total],[gia],[cost]) values(@room,@from,@to,@total,@gia,@cost)";
            com.Parameters.AddWithValue("@room", rroom);
            com.Parameters.AddWithValue("@from", ffrom);
            com.Parameters.AddWithValue("@to", tto);
            com.Parameters.AddWithValue("@total", ttotal);
            com.Parameters.AddWithValue("@gia", ggia);
            com.Parameters.AddWithValue("@cost", ccost);
            con.Open();
            com.ExecuteNonQuery();
            con.Close();
        }
    }
}
