﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Projeto_teste.Entities.Enums;
using Projeto_teste.Entities;

namespace Projeto_teste.Entities
{
    internal class Order
    {
        public DateTime Moment { get; set; }

        public OrderStatus Status { get; set; }

        public List<OrderItem> Items { get; set; } = new List<OrderItem>();

        public Client Client { get; set; }



        public Order() { }

        public Order(DateTime moment, OrderStatus status, Client client)
        {
            Moment = moment;
            Status = status;
            Client = client;
        }


        public void AddItem(OrderItem items)
        {
            Items.Add(items);
        }

        public void RemoveItem(OrderItem items)
        {
            Items.Remove(items);
        }

        public double Total()
        {
            double sum = 0;
            foreach (OrderItem item in Items)
            {
                sum = sum + item.SubTotal();
            }


            return sum;
        }



        public override string ToString()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("Order moment: " + Moment.ToString("dd/MM/yyyy HH:mm:ss"));
            sb.AppendLine("Order status: " + Status);
            sb.AppendLine("Client: " + Client);
            sb.AppendLine("Order items:");
            foreach (OrderItem item in Items)
            {
                sb.AppendLine(item.ToString());
            }
            sb.AppendLine("Total price: $" + Total());
            return sb.ToString();

        }
    }
}

