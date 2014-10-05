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
            // Checking if values are found from the database
            if (id.Length == 0)
            {
                Console.WriteLine("Invalid scene with missing id detected.");
                Environment.Exit(-1);
            } else if (description.Length == 0) 
            {
                Console.WriteLine("Invalid scene with missing description detected. Description missing in scene \"{0}\".", id);
                Environment.Exit(-1);
            }

            this.id = id.ToLower();
            this.description = description;
        }
    }
}
