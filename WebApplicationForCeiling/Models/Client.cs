using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.Text.Json.Serialization;
using System.Threading.Tasks;

namespace WebApplicationForCeiling.Models
{
    [DataContract]

    public class Client
    {
        public int ClientId { get; set; }

       // [JsonPropertyName("First_Name")]
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public DateTime CreatedAt { get; set; }

        public List <Order> Orders { get; set; }

    }
}
