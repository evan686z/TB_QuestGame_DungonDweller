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
                    { '3', AdventurerAction.LookAt },
                    { '4', AdventurerAction.PickUp },
                    { '5', AdventurerAction.PutDown },
                    { '6', AdventurerAction.Inventory },
                    { '7', AdventurerAction.AdventurerInfo },
                    { '8', AdventurerAction.AdventurerLocationsVisited },
                    //{ '6', AdventurerAction.ListDungeonLocations },
                    //{ '7', AdventurerAction.ListGameObjects },     
                    //{ '6', AdventurerAction.EditAdventurerInfo },
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
                { '3', AdventurerAction.EditAdventurerInfo },
                { '4', AdventurerAction.ReturnToMainMenu }
            }
        };
    }
}
