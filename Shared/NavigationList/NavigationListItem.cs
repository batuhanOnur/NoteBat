using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NoteBat.Shared.NavigationList
{
    public class NavigationListItem
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public string? Icon { get; set; }
        public bool isOpen { get; set; }
        public int ParentId { get; set; }
    }
}
