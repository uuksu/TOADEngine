using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;

using TOADEngine;

using System.Data.SQLite;

namespace TOADEngineEditor
{
    public partial class MainForm : Form
    {
        private HashSet<Scene> Scenes = new HashSet<Scene>();
        private HashSet<Entity> Entities = new HashSet<Entity>();
        private HashSet<Command> Commands = new HashSet<Command>();
        private Hashtable Settings = new Hashtable();

        private object selectedScene;
        private object selectedEntity;
        private object selectedCommand;

        private string GamePath;

        public MainForm()
        {
            InitializeComponent();
        }

        private void LoadGame(string databasePath)
        {

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


            }
            catch (Exception)
            {
            }
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Environment.Exit(0);
        }

        private void UpdateSceneList()
        {
            sceneBox.Items.Clear();

            foreach (Scene scene in this.Scenes)
            {
                sceneBox.Items.Add(scene.ID);
            }
        }

        private void UpdateEntityList()
        {
            entityBox.Items.Clear();

            foreach (Entity entity in this.Entities)
            {
                entityBox.Items.Add(entity.Location + "-" + entity.ID);
            }
        }

        private void UpdateCommandList()
        {
            commandBox.Items.Clear();

            foreach (Command command in this.Commands)
            {
                commandBox.Items.Add(command.Location + "-" + command.Owner + "-" + command.ID);
            }
        }

        private void openGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            openFileDialog1.Filter = "TOAD Engine Game (*.toadgame) |*.toadgame";
            openFileDialog1.ShowDialog();

            if (openFileDialog1.FileName.Length != 0 && File.Exists(openFileDialog1.FileName))
            {
                this.LoadGame(openFileDialog1.FileName);

                UpdateSceneList();
                UpdateEntityList();
                UpdateCommandList();
                placeSettings();

                this.GamePath = openFileDialog1.FileName;

                saveGameToolStripMenuItem.Enabled = true;
                saveGameAsToolStripMenuItem.Enabled = true;
                exportGameButton.Enabled = true;
                runGameToolStripMenuItem.Enabled = true;
                runGameInDebugModeToolStripMenuItem.Enabled = true;
                tabControl1.Enabled = true;
            }
        }

        private void placeSettings()
        {
            settingFirstSceneBox.Text = Settings["firstScene"].ToString();
            settingEntityNotFoundTextBox.Text = Settings["customEntityNotFoundStrings"].ToString();
            settingCommandNotFoundTextBox.Text = Settings["customCommandNotFoundStrings"].ToString();
        }

        private void sceneBox_SelectedValueChanged(object sender, EventArgs e)
        {
            if (sceneBox.SelectedItem != null)
            {
                string sceneId = sceneBox.SelectedItem.ToString();

                if (sceneId == "newScene")
                {
                    sceneIdBox.Text = "newScene";
                    sceneDescriptionBox.Text = "";
                }
                else
                {
                    foreach (Scene scene in this.Scenes)
                    {
                        if (scene.ID == sceneId)
                        {
                            sceneIdBox.Text = scene.ID;
                            sceneDescriptionBox.Text = scene.Description;
                            break;
                        }
                    }
                }

                this.selectedScene = sceneBox.SelectedItem;
            }
        }

        private void entityBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (entityBox.SelectedItem != null)
            {
                string[] entitySplitted = entityBox.SelectedItem.ToString().Split('-');

                if (entitySplitted[0] == "newEntity")
                {
                    entityIdBox.Text = "newEntity";
                    entityLocationBox.Text = "";
                }
                else
                {
                    foreach (Entity entity in this.Entities)
                    {
                        if (entity.Location == entitySplitted[0] && entity.ID == entitySplitted[1])
                        {
                            entityIdBox.Text = entity.ID;
                            entityLocationBox.Text = entity.Location;
                        }
                    }
                }

                this.selectedEntity = entityBox.SelectedItem;
            }
        }

        private void commandBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            // If nothing has been selected from the list
            if (commandBox.SelectedItem != null)
            {
                // Name of the command from the list splitted
                string[] commandSplitted = commandBox.SelectedItem.ToString().Split('-');

                // If new command is selected from the list
                if (commandSplitted[0] == "newCommand")
                {
                    commandIdBox.Text = "newCommand";
                    commandOwnerBox.Text = "";
                    commandLocationBox.Text = "";
                    commandScriptBox.Text = "";
                }
                else
                {
                    // Finding the right command from the commands list
                    foreach (Command command in this.Commands)
                    {
                        if (command.Location == commandSplitted[0] && command.Owner == commandSplitted[1] && command.ID == commandSplitted[2])
                        {
                            commandIdBox.Text = command.ID;
                            commandOwnerBox.Text = command.Owner;
                            commandLocationBox.Text = command.Location;
                            commandScriptBox.Text = command.Script;
                            break;
                        }
                    }
                }

                this.selectedCommand = commandBox.SelectedItem;
            }
        }

        private void addSceneButton_Click(object sender, EventArgs e)
        {
            bool newSceneExist = false;

            foreach (object item in sceneBox.Items)
            {
                if (item.ToString() == "newScene")
                {
                    newSceneExist = true;
                    break;
                }
            }

            if (!newSceneExist)
            {
                sceneBox.Items.Add("newScene");
                sceneIdBox.Text = "newScene";
                sceneDescriptionBox.Text = "";
                sceneBox.SelectedItem = sceneBox.Items[sceneBox.Items.Count - 1];
            }

        }

        private void removeSceneButton_Click(object sender, EventArgs e)
        {
            foreach (Scene scene in this.Scenes)
            {
                if (scene.ID == sceneBox.SelectedItem.ToString())
                {
                    this.Scenes.Remove(scene);
                    break;
                }
            }
            sceneBox.Items.Remove(sceneBox.SelectedItem);
            
        }

        private void saveSceneButton_Click(object sender, EventArgs e)
        {
            // If nothing has been selected from the listbox
            if (this.selectedScene != null)
            {
                bool newScene = true;

                foreach (Scene scene in this.Scenes)
                {
                    if (scene.ID == this.selectedScene.ToString())
                    {
                        scene.ID = sceneIdBox.Text;
                        scene.Description = sceneDescriptionBox.Text;
                        newScene = false;
                        break;
                    }
                }

                // If scene has not been found, it is new one
                if (newScene)
                {
                    this.Scenes.Add(new Scene(sceneIdBox.Text, sceneDescriptionBox.Text));
                }

                UpdateSceneList();
            }
        }

        private void saveEntityButton_Click(object sender, EventArgs e)
        {
            if (this.selectedEntity != null)
            {
                if (entityLocationBox.Text.Length != 0 && entityIdBox.Text.Length != 0)
                {
                    bool newEntity = true;

                    string entityName = entityLocationBox.Text + "-" + entityIdBox.Text;

                    foreach (Entity entity in this.Entities)
                    {
                        if (entity.Location == entityLocationBox.Text && entity.ID == entityIdBox.Text)
                        {
                            entity.ID = entityIdBox.Text;
                            entity.Location = entityLocationBox.Text;
                            newEntity = false;
                            break;
                        }
                    }

                    if (newEntity)
                    {
                        this.Entities.Add(new Entity(entityIdBox.Text, entityLocationBox.Text));
                    }

                    if (entityLocationBox.Text.Length != 0)
                    {
                        bool sceneExist = false;

                        foreach (Scene scene in this.Scenes)
                        {
                            if (scene.ID == entityLocationBox.Text)
                            {
                                sceneExist = true;
                            }
                        }

                        if (!sceneExist)
                        {
                            DialogResult result = MessageBox.Show("Scene does not exist. Do you want it to be created?", "Scene not found", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                sceneBox.Items.Add(entityLocationBox.Text);
                                this.Scenes.Add(new Scene(entityLocationBox.Text, ""));
                                UpdateSceneList();
                            }
                        }
                    }

                    UpdateEntityList();
                }
                else
                {
                    MessageBox.Show("Id or location missing!");
                }
                
            }
        }

        private void addEntityButton_Click(object sender, EventArgs e)
        {
            bool newEntityExist = false;

            foreach (object item in entityBox.Items)
            {
                if (item.ToString() == "newEntity")
                {
                    newEntityExist = true;
                    break;
                }
            }

            if (!newEntityExist)
            {
                entityBox.Items.Add("newEntity");
                entityIdBox.Text = "newEntity";
                entityLocationBox.Text = "";
                entityBox.SelectedItem = entityBox.Items[entityBox.Items.Count - 1];
            }
        }

        private void removeEntityButton_Click(object sender, EventArgs e)
        {
            foreach (Entity entity in this.Entities)
            {
                if (entity.Location == entityLocationBox.Text && entity.ID == entityIdBox.Text)
                {
                    this.Entities.Remove(entity);
                    break;
                }
            }
            entityBox.Items.Remove(entityBox.SelectedItem);
        }

        private void addCommandButton_Click(object sender, EventArgs e)
        {
            bool newCommandExist = false;

            foreach (object item in commandBox.Items)
            {
                if (item.ToString() == "newCommand")
                {
                    newCommandExist = true;
                    break;
                }
            }

            if (!newCommandExist)
            {
                commandBox.Items.Add("newCommand");
                commandIdBox.Text = "newCommand";
                commandOwnerBox.Text = "";
                commandLocationBox.Text = "";
                commandScriptBox.Text = "";
                commandBox.SelectedItem = commandBox.Items[commandBox.Items.Count - 1];
            }
        }

        private void removeCommandButton_Click(object sender, EventArgs e)
        {
            foreach (Command command in this.Commands)
            {
                if (command.ID == commandIdBox.Text && command.Location == commandLocationBox.Text && command.Owner == commandOwnerBox.Text)
                {
                    this.Commands.Remove(command);
                    break;
                }
            }
            commandBox.Items.Remove(commandBox.SelectedItem);
        }

        private void saveCommandButton_Click(object sender, EventArgs e)
        {
            // If nothing has been selected from the list
            if (this.selectedCommand != null)
            {
                if (commandLocationBox.Text.Length != 0 && commandOwnerBox.Text.Length != 0 && commandIdBox.Text.Length != 0)
                {
                    bool newCommand = true;

                    // Create name of the command
                    string commandBoxName = commandLocationBox.Text + "-" + commandOwnerBox.Text + "-" + commandIdBox.Text;

                    // Finding the command from the list of commands
                    foreach (Command command in this.Commands)
                    {
                        if (command.ID == commandIdBox.Text && command.Location == commandLocationBox.Text && command.Owner == commandOwnerBox.Text)
                        {
                            command.ID = commandIdBox.Text;
                            command.Owner = commandOwnerBox.Text;
                            command.Location = commandLocationBox.Text;
                            command.Script = commandScriptBox.Text;
                            newCommand = false;
                            break;
                        }
                    }

                    if (newCommand)
                    {
                        this.Commands.Add(new Command(commandIdBox.Text, commandOwnerBox.Text, commandLocationBox.Text, commandScriptBox.Text));
                    }

                    if (commandOwnerBox.Text.Length != 0)
                    {
                        bool entityExist = false;

                        foreach (Entity entity in this.Entities)
                        {
                            if (entity.ID == commandOwnerBox.Text)
                            {
                                entityExist = true;
                            }
                        }

                        if (!entityExist)
                        {
                            DialogResult result = MessageBox.Show("Entity does not exist. Do you want it to be created?", "Entity not found", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                entityBox.Items.Add(commandOwnerBox.Text);
                                this.Entities.Add(new Entity(commandOwnerBox.Text, commandLocationBox.Text));
                                UpdateEntityList();
                            }
                        }
                    }

                    if (commandLocationBox.Text.Length != 0)
                    {
                        bool sceneExist = false;

                        foreach (Scene scene in this.Scenes)
                        {
                            if (scene.ID == commandLocationBox.Text)
                            {
                                sceneExist = true;
                            }
                        }

                        if (!sceneExist)
                        {
                            DialogResult result = MessageBox.Show("Scene does not exist. Do you want it to be created?", "Scene not found", MessageBoxButtons.YesNo);
                            if (result == DialogResult.Yes)
                            {
                                sceneBox.Items.Add(commandLocationBox.Text);
                                this.Scenes.Add(new Scene(commandLocationBox.Text, ""));
                                UpdateSceneList();
                            }
                        }
                    }

                    UpdateCommandList();
                }
                else
                {
                    MessageBox.Show("Id, owner or location is missing!");
                }
                
            }
        }

        private void saveGame(string path)
        {
            File.Copy("empty.toadgame", path, true);

            SQLiteConnection connection = new SQLiteConnection(@"Data Source=" + path);
            connection.Open();

            SQLiteCommand command = new SQLiteCommand(connection);

            foreach (Scene scene in this.Scenes)
            {
                command.CommandText = "INSERT INTO scenes (id, description) VALUES (@id, @description)";
                command.Parameters.AddWithValue("@id", scene.ID);
                command.Parameters.AddWithValue("@description", scene.Description);
                command.ExecuteNonQuery();
            }

            foreach (Entity entity in this.Entities)
            {
                command.CommandText = "INSERT INTO entities (id, location) VALUES (@id, @location)";
                command.Parameters.AddWithValue("@id", entity.ID);
                command.Parameters.AddWithValue("@location", entity.Location);
                command.ExecuteNonQuery();
            }

            foreach (Command command_ in this.Commands)
            {
                command.CommandText = "INSERT INTO commands (id, owner, location, script) VALUES (@id, @owner, @location, @script)";
                command.Parameters.AddWithValue("@id", command_.ID);
                command.Parameters.AddWithValue("@owner", command_.Owner);
                command.Parameters.AddWithValue("@location", command_.Location);
                command.Parameters.AddWithValue("@script", command_.Script);
                command.ExecuteNonQuery();
            }

            // Inserting settings
            command.CommandText = "INSERT INTO settings (key, value) VALUES (@key, @value)";
            
            command.Parameters.AddWithValue("@key", "firstScene");
            command.Parameters.AddWithValue("@value", settingFirstSceneBox.Text);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@key", "customCommandNotFoundStrings");
            command.Parameters.AddWithValue("@value", settingCommandNotFoundTextBox.Text);
            command.ExecuteNonQuery();

            command.Parameters.AddWithValue("@key", "customEntityNotFoundStrings");
            command.Parameters.AddWithValue("@value", settingEntityNotFoundTextBox.Text);
            command.ExecuteNonQuery();

            connection.Close();
        }

        private void saveGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TOAD Engine Game (*.toadgame) |*.toadgame";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName.Length != 0)
            {
                this.saveGame(saveFileDialog1.FileName);
                this.GamePath = saveFileDialog1.FileName;
            }
        }

        private void newGameToolStripMenuItem_Click(object sender, EventArgs e)
        {
            saveFileDialog1.Filter = "TOAD Engine Game (*.toadgame) |*.toadgame";
            saveFileDialog1.ShowDialog();

            if (saveFileDialog1.FileName.Length != 0)
            {
                File.Copy("empty.toadgame", saveFileDialog1.FileName, true);
                this.GamePath = saveFileDialog1.FileName;

                saveGameToolStripMenuItem.Enabled = true;
                saveGameAsToolStripMenuItem.Enabled = true;
                exportGameButton.Enabled = true;
                runGameToolStripMenuItem.Enabled = true;
                runGameInDebugModeToolStripMenuItem.Enabled = true;
                tabControl1.Enabled = true;
            }
        }

        private void toolStripMenuItem1_Click(object sender, EventArgs e)
        {
            saveGame(this.GamePath);
        }

        private void runGameToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            this.saveGame(this.GamePath);
            this.runEngine(false);
        }

        private void runGameInDebugModeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.saveGame(this.GamePath);
            this.runEngine(true);
        }

        private void runEngine(bool debug)
        {
            if (settingFirstSceneBox.Text.Length != 0)
            {
                Process engine = new Process();
                engine.StartInfo.FileName = "TOADEngine.exe";
                if (debug)
                {
                    engine.StartInfo.Arguments = "\"" + this.GamePath + "\" -debug";
                }
                else
                {
                    engine.StartInfo.Arguments = "\"" + this.GamePath + "\"";
                }
                engine.Start();
                while (engine.HasExited == false) { }
            }
            else
            {
                MessageBox.Show("First scene setting seems to be missing. Please give id of your wanted first room in settings page.");
            }

        }

        private void exportGameButton_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.ShowDialog();

            if (folderBrowserDialog1.SelectedPath.Length != 0)
            {
                try
                {
                    this.Enabled = false;

                    Directory.CreateDirectory("game");

                    File.Copy(this.GamePath, "game\\game.toadgame", true);
                    File.Copy("launcher.bat", "game\\launcher.bat", true);
                    File.Copy("TOADEngine.exe", "game\\TOADEngine.exe", true);
                    File.Copy("Noesis.Javascript.dll", "game\\Noesis.Javascript.dll", true);
                    File.Copy("System.Data.SQLite.dll", "game\\System.Data.SQLite.dll", true);
                    File.Copy("TOADEngine.exe.config", "game\\TOADEngine.exe.config", true);

                    Process process7zip = new Process();
                    process7zip.StartInfo.FileName = "7za";
                    process7zip.StartInfo.Arguments = "a -tzip -mx9 game.zip game\\";
                    process7zip.StartInfo.CreateNoWindow = true;
                    process7zip.StartInfo.WindowStyle = ProcessWindowStyle.Hidden;
                    process7zip.Start();
                    while (process7zip.HasExited == false) { }

                    File.Copy("game.zip", folderBrowserDialog1.SelectedPath + "\\" + "game.zip", true);

                    Directory.Delete("game", true);
                    File.Delete("game.zip");

                    MessageBox.Show("Game exported succesfully!");
                    this.Enabled = true;
                }
                catch (IOException)
                {
                    MessageBox.Show("Game exporting failed. Please try again with different folder.");
                }

            }
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            saveGameToolStripMenuItem.Enabled = false;
            saveGameAsToolStripMenuItem.Enabled = false;
            exportGameButton.Enabled = false;
            runGameToolStripMenuItem.Enabled = false;
            runGameInDebugModeToolStripMenuItem.Enabled = false;
            tabControl1.Enabled = false;
        }

        private void fileToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }
    }
}