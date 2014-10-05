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
            this.id = id;
            this.location = location;
        }
    }
}
