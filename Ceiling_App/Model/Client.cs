using System;
using System.Collections.Generic;

#nullable disable

namespace Ceiling_App.Model
{
    public partial class Client
    {
        public Client()
        {
            Orders = new HashSet<Order>();
        }

        public int ClientId { get; set; }
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public DateTimeOffset CreatedAt { get; set; }

        public virtual ICollection<Order> Orders { get; set; }
        public override string ToString()
        {
            return $"{FirstName} {LastName}";
        }
    }
}
