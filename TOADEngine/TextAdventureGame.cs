using System;
using System.Collections;
using System.Collections.Generic;
using System.Data;
using System.IO;
using System.Linq;
using System.Text;

using System.Data.SQLite;
using Noesis.Javascript;

namespace TOADEngine
{
    class TextAdventureGame
    {
        private bool debugMode;

        private HashSet<Scene> Scenes = new HashSet<Scene>();
        private HashSet<Entity> Entities = new HashSet<Entity>();
        private HashSet<Command> Commands = new HashSet<Command>();
        private Hashtable Settings = new Hashtable();

        private JavascriptContext JSEngine = new JavascriptContext();

        private Scene currentScene;
        private string[] commandNotFoundStrings;
        private string[] entityNotFoundStrings;
        private HashSet<string> playerItems = new HashSet<string>();

        public Scene CurrentScene
        {
            get { return this.currentScene; }
            set { this.currentScene = value; }
        }

        public TextAdventureGame(string databasePath, bool debug)
        {
            this.debugMode = debug;

            this.LoadGame(databasePath);

            // Initializing Javascript Engine
            JavascriptActions javascriptActions = new JavascriptActions(this);
            this.JSEngine.SetParameter("TOAD", javascriptActions);

            this.ParseSettings();

            this.MainLoop();
        }

        private void ParseSettings()
        {
            this.currentScene = SceneExist(this.Settings["firstScene"].ToString());

            if (this.Settings["customCommandNotFoundStrings"].ToString().Length != 0)
            {
                this.commandNotFoundStrings = Settings["customCommandNotFoundStrings"].ToString().Split(';');
            }

            if (this.Settings["customEntityNotFoundStrings"].ToString().Length != 0)
            {
                this.entityNotFoundStrings = Settings["customEntityNotFoundStrings"].ToString().Split(';');
            }
        }

        private void LoadGame(string databasePath)
        {

            if (!File.Exists(databasePath))
            {
                Console.WriteLine("Loading game failed. Game file does not exist!");
                Environment.Exit(-1);
            }

            DataTable dataTable = new DataTable();

            try
            {
                SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + databasePath);
                connection.Open();

                // Loading scenes from database
                SQLiteCommand command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM scenes";
                SQLiteDataReader reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();

                if (dataTable.Rows.Count == 0)
                {
                    Console.WriteLine("Not a single scene was found from the game. Please try with another game file.");
                    Environment.Exit(-1);
                }

                foreach (DataRow row in dataTable.Rows)
                {
                    Scene scene = new Scene(row["id"].ToString(), row["description"].ToString());
                    this.Scenes.Add(scene);
                }

                // Loading entities from database
                dataTable = new DataTable();
                command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM entities";
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    Entity entity = new Entity(row["id"].ToString(), row["location"].ToString());
                    this.Entities.Add(entity);
                }

                // Loading commands from database
                dataTable = new DataTable();
                command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM commands";
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    Command command_ = new Command(row["id"].ToString(), row["owner"].ToString(), row["location"].ToString(), row["script"].ToString());
                    this.Commands.Add(command_);
                }

                // Loading settings from database
                dataTable = new DataTable();
                command = new SQLiteCommand(connection);
                command.CommandText = "SELECT * FROM settings";
                reader = command.ExecuteReader();
                dataTable.Load(reader);
                reader.Close();

                foreach (DataRow row in dataTable.Rows)
                {
                    this.Settings.Add(row["key"], row["value"]);
                }

                connection.Close();


            } catch (Exception) {
                Console.WriteLine("Loading game failed. Please try with different game file.");
                Environment.Exit(-1);
            }
        }

        public Scene SceneExist(string id)
        {
            foreach (Scene scene in this.Scenes)
            {
                if (scene.ID == id)
                {
                    return scene;
                }
            }

            return null;
        }

        private Entity EntityExist(string id, string location)
        {
            foreach (Entity entity in this.Entities)
            {
                if (entity.ID == id && entity.Location == location)
                {
                    return entity;
                }
            }

            return null;
        }

        private Command CommandExist(string id, string owner, string location)
        {
            foreach (Command command in this.Commands)
            {
                if (command.ID == id && command.Owner == owner && command.Location == location)
                {
                    return command;
                }
            }

            return null;
        }

        public bool PlayerHasItem(string itemName)
        {
            if (this.playerItems.Count == 0)
            {
                return false;
            }

            foreach (string item in this.playerItems) 
            {
                if (item == itemName) {
                    return true;
                } 
            }
            return false;
        }

        public void AddItem(string itemName)
        {
            this.playerItems.Add(itemName);
        }

        public void RemoveItem(string itemName)
        {
            this.playerItems.Remove(itemName);
        }

        public void RemoveEntity(string id)
        {
            Entity entity = EntityExist(id, this.currentScene.ID);
            if (entity != null)
            {
                this.Entities.Remove(entity);
            }
        }

        public void RemoveCommand(string id, string owner)
        {
            Command command = CommandExist(id, owner, this.currentScene.ID);
            if (command != null)
            {
                this.Commands.Remove(command);
            }
        }

        public void JavasriptInterpreter()
        {
            Console.Clear();
            Console.WriteLine("-- Javasript Interpreter --\nexit = Close interpreter\nclear = Clear screen");
            while (true)
            {
                Console.Write(">> ");
                string line = Console.ReadLine();

                if (line == "exit")
                {
                    break;
                }
                else if (line == "clear")
                {
                    Console.Clear();
                    continue;
                }

                try
                {
                    this.JSEngine.Run(line);
                }
                catch (Exception ex)
                {
                    string javaScriptErrorMessage = ex.Message.Replace("TOADEngine.JavascriptActions", "TOAD");
                    Console.WriteLine(javaScriptErrorMessage);
                }
                
            }
        }

        private void MainLoop() 
        {
            bool running = true;
            while (running)
            {
                Console.Clear();
                // Printing scenes description
                Console.WriteLine(currentScene.Description);

                string[] userInput = Console.ReadLine().Split(' ');

                if (userInput.Length == 1)
                {
                    switch (userInput[0])
                    {
                        case "exit":
                            Environment.Exit(0);
                            break;
                        case "javascript":
                            if (this.debugMode)
                            {
                                this.JavasriptInterpreter();
                            }
                            break;
                    }
                }

                if (userInput.Length == 2)
                {
                    string command = userInput[0].ToLower();
                    string entity = userInput[1].ToLower();

                    Entity entity_ = EntityExist(entity, this.currentScene.ID);

                    if (entity_ == null)
                    {
                        if (this.entityNotFoundStrings != null && this.entityNotFoundStrings.Length != 0)
                        {
                            Random random = new Random(DateTime.Now.Millisecond);
                            int randomNumber = random.Next(0, this.entityNotFoundStrings.Length);
                            Console.WriteLine(this.entityNotFoundStrings[randomNumber]);
                        }
                        else
                        {
                            Console.WriteLine("Can't find this one.");
                        }
                        
                        Console.ReadKey();
                        continue;

                    }

                    Command command_ = CommandExist(command, entity, this.currentScene.ID);

                    if (command_ != null)
                    {
                        try
                        {
                            this.JSEngine.Run(command_.Script);
                        }
                        catch (Exception ex)
                        {
                            string javaScriptErrorMessage = ex.Message.Replace("TOADEngine.JavascriptActions", "TOAD");
                            Console.WriteLine("There seems to be problem running Javascript. Problem appears in command with id \"{0}\".", command_.ID);
                            Console.WriteLine(javaScriptErrorMessage);
                        }
                        
                    }
                    else
                    {
                        if (this.commandNotFoundStrings != null && this.commandNotFoundStrings.Length != 0)
                        {
                            Random random = new Random(DateTime.Now.Millisecond);
                            int randomNumber = random.Next(0, this.commandNotFoundStrings.Length);
                            Console.WriteLine(this.commandNotFoundStrings[randomNumber]);
                        }
                        else
                        {
                            Console.WriteLine("You can't do that.");
                        }
                    }

                    Console.ReadKey();
                }
            }
        }
    }
}
