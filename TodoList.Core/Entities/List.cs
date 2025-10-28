using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TodoList.Core.Entities
{
    public class List(int Id, List<Item> items, DateOnly EndDate)
    {
        public int Id { get; set; } = Id;
        public List<Item> Items { get; set; } = items;
        public DateOnly EndDate { get; set; } = EndDate;

    }
}
