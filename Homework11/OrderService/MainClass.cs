using MySql.Data.MySqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;


namespace OrderApp {

  class MainClass {
    public static void Main() {
      try {
                using (var db = new OrderContext()) {
         var order=db.OrderItems.FirstOrDefault();
         
        }
        

      }catch (Exception e) {
        Console.WriteLine(e.Message);
        Console.WriteLine(e.StackTrace);
      }

    }
  }
}
