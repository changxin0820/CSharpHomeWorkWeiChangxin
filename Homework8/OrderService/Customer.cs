using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {

    //客户类
  public class Customer {
    public string ID { get; set; }//客户ID
    public string Name { get; set; }//客户名字

    public Customer() {
    }

    public Customer(string id, string name) {

      ID = id;

      Name = name;

    }

    public override bool Equals(object obj) {//判断是否相同
      var customer = obj as Customer;
      return customer != null &&
             ID == customer.ID &&
             Name == customer.Name;
    }

    public override int GetHashCode() {
      var hashCode = 1479869798;
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(ID);
      hashCode = hashCode * -1521134295 + EqualityComparer<string>.Default.GetHashCode(Name);
      return hashCode;
    }
  }
}
