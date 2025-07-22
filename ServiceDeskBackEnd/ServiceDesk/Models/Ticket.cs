using System;
using System.Collections.Generic;

#nullable disable

namespace ServiceDesk
{
    public partial class Ticket
    {
        public Ticket()
        {
            BookMarkeds = new HashSet<BookMarked>();
        }

        public int Id { get; set; }
        public bool? Status { get; set; }
        public string TicketName { get; set; }
        public string Issue { get; set; }
        public string OpenedBy { get; set; }

        public virtual Resolution Resolution { get; set; }
        public virtual ICollection<BookMarked> BookMarkeds { get; set; }
    }
}