using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// static class to hold key/value pairs for menu options
    /// </summary>
    public static class ActionMenu
    {
        public enum CurrentMenu
        {
            QuestInfo,
            InitializeMission,
            MainMenu,
            ObjectMenu,
            NpcMenu,
            AdventurerMenu,
            AdminMenu

        }

        public static CurrentMenu currentMenu = CurrentMenu.MainMenu;

        public static Menu QuestIntro = new Menu()
        {
            MenuName = "QuestIntro",
            MenuTitle = "",
            MenuChoices = new Dictionary<char, AdventurerAction>()
                    {
                        { ' ', AdventurerAction.None }
                    }
        };

        public static Menu InitializeMission = new Menu()
        {
            MenuName = "InitializeMission",
            MenuTitle = "Initialize Mission",
            MenuChoices = new Dictionary<char, AdventurerAction>()
                {
                    { '1', AdventurerAction.Exit }
                }
        };

        public static Menu MainMenu = new Menu()
        {
            MenuName = "MainMenu",
            MenuTitle = "Main Menu",
            MenuChoices = new Dictionary<char, AdventurerAction>()
                {
                    
                    { '1', AdventurerAction.Travel },
                    { '2', AdventurerAction.LookAround },
                    { '3', AdventurerAction.ObjectMenu },
                    { '4', AdventurerAction.NonPlayerCharacterMenu },
                    { '5', AdventurerAction.AdventurerMenu },
                    { '9', AdventurerAction.AdminMenu},
                    { '0', AdventurerAction.Exit }
                }
        };

        public static Menu AdminMenu = new Menu()
        {
            MenuName = "AdminMenu",
            MenuTitle = "Admin Menu",
            MenuChoices = new Dictionary<char, AdventurerAction>()
            {
                { '1', AdventurerAction.ListDungeonLocations },
                { '2', AdventurerAction.ListGameObjects },
                { '3', AdventurerAction.ListNonPlayerCharacters },
                { '4', AdventurerAction.EditAdventurerInfo },
                { '0', AdventurerAction.ReturnToMainMenu }
            }
        };

        public static Menu AdventurerMenu = new Menu()
        {
            MenuName = "AdventurerMenu",
            MenuTitle = "Adventurer Menu",
            MenuChoices = new Dictionary<char, AdventurerAction>()
            {
                { '1', AdventurerAction.AdventurerInfo },
                { '2', AdventurerAction.Inventory },
                { '3', AdventurerAction.AdventurerLocationsVisited },
                { '0', AdventurerAction.ReturnToMainMenu }
            }
        };

        public static Menu ObjectMenu = new Menu()
        {
            MenuName = "ObjectMenu",
            MenuTitle = "Object Menu",
            MenuChoices = new Dictionary<char, AdventurerAction>()
            {
                { '1', AdventurerAction.LookAt },
                { '2', AdventurerAction.PickUp },
                { '3', AdventurerAction.PutDown },
                { '0', AdventurerAction.ReturnToMainMenu }
            }
        };

        public static Menu NpcMenu = new Menu()
        {
            MenuName = "NpcMenu",
            MenuTitle = "NPC Menu",
            MenuChoices = new Dictionary<char, AdventurerAction>()
            {
                { '1', AdventurerAction.TalkTo },
                { '0', AdventurerAction.ReturnToMainMenu }
            }
        };
    }
}
