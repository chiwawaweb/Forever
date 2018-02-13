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
    }
}
