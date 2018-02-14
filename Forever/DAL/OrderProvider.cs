using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using Forever.DTO;

namespace Forever.DAL
{
    public class OrderProvider
    {
        public int CountAll()
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Orders.Count();
                }
                catch
                {
                    throw;
                }
            }
        }

        public List<Order> Search(string keywords, string type)
        {
            using (Context context = new Context())
            {
                try
                {
                    var contacts = from b in context.Orders
                                   orderby b.Date descending
                                   where (
                                          (b.Nom.Contains(keywords))
                                            || (b.Prenom.Contains(keywords))
                                            || (b.Notes.Contains(keywords))
                                          )
                                   select b;
                    return contacts.ToList();
                }
                catch
                {
                    throw;
                }
            }
        }

        public int? Create(Order Order)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Orders.Add(Order);
                    context.SaveChanges();
                    int? id = Order.Id;
                    return id;
                }
                catch
                {
                    throw;
                }
            }
        }

        public Order GetOrderById(int ID)
        {
            using (Context context = new Context())
            {
                try
                {
                    return context.Orders.Find(ID);
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Update(Order order)
        {
            using (Context context = new Context())
            {
                try
                {
                    context.Orders.Attach(order);
                    context.Entry(order).State = EntityState.Modified;
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }

        public void Delete(Order order)
        {
            using (Context context = new Context())
            {

                try
                {
                    context.Orders.Attach(order);
                    context.Orders.Remove(order);
                    context.SaveChanges();
                }
                catch
                {
                    throw;
                }
            }
        }
    }
}
