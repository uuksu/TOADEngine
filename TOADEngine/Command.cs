using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOADEngine
{
    class Command
    {
        private string id;
        private string owner;
        private string script;
        private string location;

        public string ID
        {
            get { return this.id; }
            set { this.id = value; }
        }

        public string Owner
        {
            get { return this.owner; }
            set { this.owner = value; }
        }

        public string Script
        {
            get { return this.script; }
            set { this.script = value; }
        }

        public string Location
        {
            get { return this.location; }
            set { this.location = value; }
        }

        public Command(string id, string owner, string location, string script)
        {
            // Checking if values are found from the database
            if (id.Length == 0)
            {
                Console.WriteLine("Invalid scene with missing id detected.");
                Environment.Exit(-1);
            } else if (owner.Length == 0) 
            {
                Console.WriteLine("Invalid command with missing owner detected. Description missing in command \"{0}\".", id);
                Environment.Exit(-1);
            }
            else if (script.Length == 0)
            {
                Console.WriteLine("Invalid command with missing script detected. Script missing in command \"{0}\".", id);
                Environment.Exit(-1);
            }
            else if (location.Length == 0) 
            {
                Console.WriteLine("Invalid command with missing location detected. Location missing in command \"{0}\".", id);
                Environment.Exit(-1);
            }

            this.id = id.ToLower();
            this.owner = owner.ToLower();
            this.script = script;
            this.location = location.ToLower();
        }
    }
}
