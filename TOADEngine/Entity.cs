using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOADEngine
{
    class Entity
    {
        private string id;
        private string location;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public Entity(string id, string location)
        {
            // Checking if values are found from the database
            if (id.Length == 0)
            {
                Console.WriteLine("Invalid entity with missing id detected.");
                Environment.Exit(-1);
            } else if (location.Length == 0) 
            {
                Console.WriteLine("Invalid entity with missing location id detected. Location id missing in entity \"{0}\".", id);
                Environment.Exit(-1);
            }

            this.id = id.ToLower();
            this.location = location.ToLower();
        }
    }
}
