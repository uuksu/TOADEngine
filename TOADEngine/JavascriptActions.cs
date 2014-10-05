using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace TOADEngine
{
    class JavascriptActions
    {
        private TextAdventureGame game;

        public JavascriptActions(TextAdventureGame game)
        {
            this.game = game;
        }

        public void Print(string text) {
            Console.WriteLine(text);
        }

        public void CurrentScene(string text)
        {
            Scene scene = this.game.SceneExist(text);

            if (scene != null)
            {
                this.game.CurrentScene = scene;
            }
            else
            {
                Console.WriteLine("Script error: Trying to change scene to non-existing scene.");
            }
        }

        public bool HasItem(string itemName)
        {
            if (this.game.PlayerHasItem(itemName))
            {
                return true;
            }
            return false;
        }

        public void AddItem(string itemName)
        {
            this.game.AddItem(itemName);
        }

        public void RemoveItem(string itemName)
        {
            this.game.RemoveItem(itemName);
        }

        public void RemoveEntity(string id)
        {
            this.game.RemoveEntity(id);
        }

        public void RemoveCommand(string id, string owner)
        {
            this.game.RemoveCommand(id, owner);
        }

        public void Exit()
        {
            Environment.Exit(0);
        }
    }
}
