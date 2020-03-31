using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;
//1、在OrderService中添加一个Export方法，可以将所有的订单序列化为XML文件；添加一个Import方法可以从XML文件中载入订单。
//2、对订单程序中OrderService的各个Public方法添加测试用例。
namespace OrderManage
{
    public class Program
    {
        static void Main(string[] args)
        {
            

            OrderDetails wcx = new OrderDetails(2, "魏昌鑫", "书包", 100, "四川", 1);
            OrderDetails wcx2 = new OrderDetails(3, "魏昌鑫2", "笔记本", 20, "武汉", 2);
            wcx.Equals(wcx2);
            OrderService wcxService = new OrderService();
            wcxService.addOrder(wcx);
            wcxService.addOrder(wcx2);
            wcxService.showOrder();
            Console.WriteLine();
            wcxService.sortOrder();
            Console.WriteLine();
            wcxService.queryOrderByID(2);
            wcxService.deleteOrder(wcx);
            wcxService.showOrder();
            wcxService.Export();
            
            
        }
    }


    public class Order
    {
        //存放订单数据
       
        public int orderID { get; set; }
       
        public double ordersum { get { return ordersum; }
            set
            {
                foreach(OrderDetails temp in OrderDetailsList)
                {
                    ordersum += temp.orderNum * temp.price;
                }
            } }
        public Order(int i)
        {
            orderID = i;
        }
        public override string ToString()
        {
            return "orderID：" + orderID + "总价：" + ordersum;
        }
        List<OrderDetails> OrderDetailsList = new List<OrderDetails>();

    }
    class OKOrder : Order
    {
        public OKOrder(int i) : base(i)
        {

        }
        public override bool Equals(object obj)
        {
            OKOrder order = obj as OKOrder;

            return order != null && order.orderID == orderID;
        }
    }

    public class OrderDetails//订单细节
    {
        public int orderID { set; get; }
        public string customerID { get; set; }
        public string productID { set; get; }
        public double price { set; get; }
        public string address { set; get; }
        public int orderNum { get; set; }
        public OrderDetails(int orderID,string customerID,string productID,double price,string address,int orderNum)
        {
            this.orderID = orderID;
            this.customerID = customerID;
            this.productID = productID;
            this.price = price;
            this.address = address;
            this.orderNum = orderNum;
        }
        public override string ToString()
        {
            return "  orderID:" + orderID + "  customer:" + customerID + "  productID:" + productID + "  discount:" + price + "  address:" + address+"  orderNum:"+orderNum;
        }
        public OrderDetails() { }
         
    }
    public class OKOrderDetails : OrderDetails
    {
        public OKOrderDetails(int orderID, string customerID, string productID, double price, string address,int orderNum) : base(orderID,customerID,productID,price,address,orderNum){

        }
        public override bool Equals(object obj)
        {
            OKOrderDetails o = obj as OKOrderDetails;
            return o != null && o.orderID == orderID;
        }
    }
    [Serializable]
    public class OrderService//订单服务类
    {
        List<OrderDetails> orderList = new List<OrderDetails>();
        public void addOrder(OrderDetails order)
        {
            if (orderList.Contains(order))
                throw new ApplicationException($"Add Order Error: Order with id {order.orderID} already exists!");
            orderList.Add(order);
        }

        public void deleteOrder(OrderDetails order)//删除订单
        {
            if(order != null)
            {
            orderList.Remove(order);
            }
           
        }

        public void queryOrderByID(int id)//查找订单
        {
            var query = orderList.Where((o => o.orderID == id));
            foreach(var q in query)
            {
                Console.WriteLine(q);
            }

        }
        public void sortOrder()//排序订单
        {
            var query2 = orderList.OrderBy(o => o.orderID);
            foreach(var q in query2)
            {
                Console.WriteLine(q);
            }
        }
        public void showOrder()//展示全部订单
        {
            foreach (OrderDetails o in orderList)
            {
                Console.WriteLine(o.ToString());
            }
        }
        public void UpdateOrder(OrderDetails order)//更新订单
        {

            deleteOrder(order);
            addOrder(order);
        }
        public void Export()//序列化导出
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof (List<OrderDetails>));
            using (FileStream fs = new FileStream("Order.xml", FileMode.Create))
            {
                xmlSerializer.Serialize(fs, orderList);
            }
        }
        public void Import(string path)//序列化导入
        {
            XmlSerializer xmlSerializer = new XmlSerializer(typeof(List<OrderDetails>));
            using (FileStream fs=new FileStream(path, FileMode.Open))
            {
                List<OrderDetails> orders = (List<OrderDetails>)xmlSerializer.Deserialize(fs);
            }
        }

    }

 
}
