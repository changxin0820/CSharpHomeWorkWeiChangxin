﻿using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Xml.Serialization;

namespace OrderApp {

  /**
   * 管理订单类
   * */
  public class OrderService {

    //the order list
    private List<Order> orders;


    public OrderService() {
      orders = new List<Order>();
    }

    public List<Order> Orders {
      get => orders;
    }

    public Order GetOrder(uint id) {
      return orders.Where(o => o.OrderId == id).FirstOrDefault();
    }

    public void AddOrder(Order order) {
      if (orders.Contains(order))
        throw new ApplicationException($"添加错误: 订单{order.OrderId} 已经存在了!");
      orders.Add(order);
    }

    public void RemoveOrder(uint orderId) {
      Order order = GetOrder(orderId);
      if (order != null) {
        orders.Remove(order);
      }
    }

    public List<Order> QueryOrdersByGoodsName(string goodsName) {
      var query = orders
              .Where(order => order.Items.Exists (item => item.GoodsName == goodsName))
              .OrderBy(o=>o.TotalPrice);
      return query.ToList();
    }

    public List<Order> QueryOrdersByCustomerName(string customerName) {
      return orders
          .Where(order => order.CustomerName == customerName)
          .OrderBy(o => o.TotalPrice)
          .ToList(); 
    }

    public void UpdateOrder(Order newOrder) {
      Order oldOrder = GetOrder(newOrder.OrderId);
      if(oldOrder==null)
        throw new ApplicationException($"修改错误：订单 {newOrder.OrderId} 不存在!");
      orders.Remove(oldOrder);
      orders.Add(newOrder);
    }

    public void Sort() {
      orders.Sort();
    }

    public void Sort(Func<Order, Order, int> func) {
      Orders.Sort((o1,o2)=>func(o1,o2));
    }

    public void Export(String fileName) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(fileName, FileMode.Create)) {
        xs.Serialize(fs, Orders);
      }
    }

    public void Import(string path) {
      XmlSerializer xs = new XmlSerializer(typeof(List<Order>));
      using (FileStream fs = new FileStream(path, FileMode.Open)) {
        List<Order> temp = (List<Order>)xs.Deserialize(fs);
        temp.ForEach(order => {
          if (!orders.Contains(order)) {
            orders.Add(order);
          }
        });
      }
    }

    public object QueryByTotalAmount(float amout) {
      return orders
         .Where(order => order.TotalPrice >= amout)
         .OrderByDescending(o => o.TotalPrice)
         .ToList();
    }
  }
}
