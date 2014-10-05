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
            this.id = id;
            this.owner = owner;
            this.script = script;
            this.location = location;
        }
    }
}
