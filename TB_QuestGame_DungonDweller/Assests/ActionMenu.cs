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
                    { '1', AdventurerAction.TravelerInfo },
                    { '2', AdventurerAction.LookAround },
                    { '3', AdventurerAction.Travel },
                    { '4', AdventurerAction.TravelerLocationsVisited },
                    { '5', AdventurerAction.ListSpaceTimeLocations },
                    { '0', AdventurerAction.Exit }
                }
        };
    }
}
