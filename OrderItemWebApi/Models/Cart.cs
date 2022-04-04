using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace OrderItemWebApi.Models
{
    public class Cart
    {
        public int Id { get; set; }
        public int UserId { get; set; }
        public int MenuItemId { get; set; }
        public string MenuItemName { get; set; }

        public Cart(int id, int userid, int menuitemid, string menuitemname)
        {
            this.Id = id;
            this.UserId = userid;
            this.MenuItemId = menuitemid;
            this.MenuItemName = menuitemname;
        }
    }
}
