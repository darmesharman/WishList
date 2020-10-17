using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WishList.Models
{
    public class Item
    {
        public int Id { get; set; }
        public string ItemName { get; set; }
        public int UserId { get; set; }
    }
}
