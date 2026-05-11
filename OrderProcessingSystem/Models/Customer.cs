using System.Collections.Generic;
namespace OrderProcessingSystem.Models
{
    public class Customer
    {
        private int id;
        private string name;
        private string email;

        public int Id
        {
            get { return id; }
            set
            {
                if (value > 0)
                    id = value;
            }
        }

        public string Name
        {
            get { return name; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    name = value;
            }
        }

        public string Email
        {
            get { return email; }
            set
            {
                if (!string.IsNullOrWhiteSpace(value))
                    email = value;
            }
        }

        public List<Order> Orders { get; set; }

        public Customer(int id, string name, string email)
        {
            Id = id;
            Name = name;
            Email = email;
            Orders = new List<Order>();
        }

        public override string ToString()
        {
            return Name;
        }
    }
}