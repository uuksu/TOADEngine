using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOADEngine
{
    class Scene
    {
        private string id;
        private string description;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Description
        {
            get { return this.description; }
            set { this.description = value; }
        }

        public Scene(string id, string description)
        {
            this.id = id;
            this.description = description;
        }
    }
}
