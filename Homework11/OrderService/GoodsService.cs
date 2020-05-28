using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OrderApp {
  public class GoodsService {

    public static void Add(Goods goods) {
      try {
        using (var db = new OrderContext()) {
          db.GoodItems.Add(goods);
          db.SaveChanges();
        }
      }
      catch (Exception e) {
        throw new ApplicationException($"添加错误!");
      }
    }

    public static List<Goods> GetAll() {
      using (var db = new OrderContext()) {
        return db.GoodItems.ToList();
      }
    }
  }
}
