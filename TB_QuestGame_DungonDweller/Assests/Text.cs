using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// class to store static and to generate dynamic text for the message and input boxes
    /// </summary>
    public static class Text
    {
        public static List<string> HeaderText = new List<string>() { "Dungeon Dweller" };
        public static List<string> FooterText = new List<string>() { "Red Square Productions, 2017" };

        #region INTITIAL GAME SETUP

        public static string QuestIntro()
        {
            string messageBoxText =
            "You have been hired by the local ruler, King Leopold, " +
            "in order to rid the area of a dangerous foe. Your quest is to " +
            "slay the beast known as Krosus, a demon from another dimension " +
            "and only return to the King if you are successful.\n" +
            "Failure is not an option, the lands fate depends on you.\n" +
            " \n" +
            "Your quest begins now.\n" +
            " \n" +
            "Your first task will be to set up the initial details of your quest.\n" +
            " \n" +
            "\tPress any key to begin your journey.\n";

            return messageBoxText;
        }

        public static string CurrrentLocationInfo()
        {
            string messageBoxText =
            "You now stand at the entrance of the dungeon. " +
            "You ready yourself for what might be the battle of your life. " +
            "Many lives depend on your success.\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeQuestIntro()
        {
            string messageBoxText =
                "Before you begin your quest we much gather some information about you.\n" +
                " \n" +
                "You will be prompted for the required information.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeQuestGetAdventurerName()
        {
            string messageBoxText =
                "Enter your name adventurer.\n" +
                " \n" +
                "Please use the name you wish to be referred during your quest.";

            return messageBoxText;
        }

        public static string InitializeQuestGetAdventurerAge(string name)
        {
            string messageBoxText =
                $"Very good then, we will call you {name} on this quest.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n";

            return messageBoxText; ;
        }

        public static string InitializeQuestGetAdventurerClass(Adventurer gameTraveler)
        {
            string messageBoxText =
                $"{gameTraveler.Name}, it will be important for us to know your class on this quest.\n" +
                " \n" +
                "Enter your class below.\n" +
                " \n" +
                "Please use the class specifications below." +
                " \n";

            string classList = null;

            foreach (Character.ClassType @class in Enum.GetValues(typeof(Character.ClassType)))
            {
                if (@class != Character.ClassType.None)
                {
                    classList += $"\t{@class}\n";
                }
            }

            messageBoxText += classList;

            return messageBoxText;
        }

        public static string InitializeMissionGetAdventurerIQ(Adventurer gameAdventurer)
        {
            string messgaeBoxText =
                $"{gameAdventurer.Name}, you will now be given a random IQ.\n" +
                " \n" +
                "Please press enter to get your IQ.\n" +
                " \n";

            return messgaeBoxText;
        }

        public static string InitializeMissionGetAdventurerHealthPotions(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"{gameAdventurer.Name}, you will be given 3 Health Potions to start you adventure.\n" +
                " \n" +
                "Use the carefully, as they are sparse in a dungeon." +
                " \n";

            return messageBoxText;
        }

        public static string InitializeQuestEchoAdventurerInfo(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"Very good then {gameAdventurer.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your quest. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tAdventurer Name: {gameAdventurer.Name}\n" +
                $"\tAdventurer Age: {gameAdventurer.Age}\n" +
                $"\tAdventurer Class: {gameAdventurer.Class}\n" +
                $"\tAdventurer IQ: {gameAdventurer.IQ}\n" +
                $"\tAdventurer Health Potions: {gameAdventurer.HealthPotions}\n" +
                " \n" +
                "Press any key to begin your quest.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string AdventurerInfo(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"\tAdventurer Name: {gameAdventurer.Name}\n" +
                $"\tAdventurer Age: {gameAdventurer.Age}\n" +
                $"\tAdventurer Class: {gameAdventurer.Class}\n" +
                $"\tAdventurer IQ: {gameAdventurer.IQ}\n" +
                $"\tAdventurer Health Potions: {gameAdventurer.HealthPotions}\n" +
                " \n";

            return messageBoxText;
        }

        public static string AdventurerEditInfo(Adventurer gameAdventurer)
        {
            string messageBoxText =
                "If you would like to edit your adventurer, you can do it here.\n" +
                " \n" +
                "Your current Adventurers Name and Age appear below:\n" +
                $"\tAdventurer Name: {gameAdventurer.Name}\n" +
                $"\tAdventurer Age: {gameAdventurer.Age}\n" +
                $"\tAdventurer Class: {gameAdventurer.Class}\n" +
                " \n" +
                "Please enter a new name, age, and class." +
                " \n";

            return messageBoxText;
        }

        public static string ListDungeonLocations(IEnumerable<DungeonLocation> dungeonLocations)
        {
            string messageBoxText =
                "Space-Time Locatoins\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + " \n";

            //
            // display all locations
            //
            string spaceTimeLocationList = null;
            foreach (DungeonLocation spaceTimeLocation in dungeonLocations)
            {
                spaceTimeLocationList +=
                    $"{spaceTimeLocation.DungeonLocationID}".PadRight(10) +
                    $"{spaceTimeLocation.CommonName}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += spaceTimeLocationList;

            return messageBoxText;
        }

        public static string LookAround(DungeonLocation dungeonLocation)
        {
            string messageBoxText =
                $"Current Location: {dungeonLocation.CommonName}\n" +
                " \n" +
                dungeonLocation.GeneralContents;

            return messageBoxText;
        }

        public static string Travel(Adventurer gameDungeon, List<DungeonLocation> dungeonLocations)
        {
            string messageBoxText =
                $"{gameDungeon.Name}, Aion Base will need to know the name of the new location.\n" +
                " \n" +
                "Enter the ID number of your desired location from the table below.\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "Accessible".PadRight(10) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "-------".PadRight(10) + "\n";

            //
            // display all locations except the current location
            //
            string dungeonLocationList = null;
            foreach (DungeonLocation dungeonLocation in dungeonLocations)
            {
                if (dungeonLocation.DungeonLocationID != gameDungeon.DungeonLocationID)
                {
                    dungeonLocationList +=
                        $"{dungeonLocation.DungeonLocationID}".PadRight(10) +
                        $"{dungeonLocation.CommonName}".PadRight(30) +
                        $"{dungeonLocation.Accessable}".PadRight(10) +
                        Environment.NewLine;
                }
            }

            messageBoxText += dungeonLocationList;

            return messageBoxText;
        }

        public static string CurrentLocationInfo(DungeonLocation dungeonLocation)
        {
            string messageBoxText =
                $"Current Location: {dungeonLocation.CommonName}\n" +
                " \n" +
                dungeonLocation.Description;

            return messageBoxText;
        }

        public static string VisitedLocations(IEnumerable<DungeonLocation> dungeonLocations)
        {
            string messageBoxText =
                "Dungeon Locations Visited\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) + "Name".PadRight(30) + "\n" +
                "---".PadRight(10) + "----------------------".PadRight(30) + "\n";

            //
            // display all locations except the current location
            //
            string dungeonLocationList = null;
            foreach (DungeonLocation dungeonLocation in dungeonLocations)
            {
                dungeonLocationList +=
                    $"{dungeonLocation.DungeonLocationID}".PadRight(10) +
                    $"{dungeonLocation.CommonName}".PadRight(30) +
                    $"{dungeonLocation.Accessable}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += dungeonLocationList;

            return messageBoxText;
        }

        public static string ListAllGameObjects(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Dungeon Location Id".PadRight(10) + " \n" +
                "---".PadRight(10) +
                "-------------------".PadRight(30) +
                "-------------------".PadRight(10) + " \n";

            //
            // display all traveler objects
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    $"{gameObject.DungeonLocationId}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        public static string GameObjectsChooseList(IEnumerable<GameObject> gameObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "Game Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) + "\n" +
                "---".PadRight(10) +
                "----------------------".PadRight(30) + "\n";

            //
            // display all traveler objects in rows
            //
            string gameObjectRows = null;
            foreach (GameObject gameObject in gameObjects)
            {
                gameObjectRows +=
                    $"{gameObject.Id}".PadRight(10) +
                    $"{gameObject.Name}".PadRight(30) +
                    Environment.NewLine;
            }

            messageBoxText += gameObjectRows;

            return messageBoxText;
        }

        public static string LookAt(GameObject gameObject)
        {
            string messageBoxText = "";

            messageBoxText =
                $"{gameObject.Name}\n" +
                " \n" +
                gameObject.Description + " \n" +
                " \n";
            if (gameObject is AdventurerObject)
            {
                AdventurerObject adventurerObject = gameObject as AdventurerObject;

                messageBoxText += $"The {adventurerObject.Name} has a value of {adventurerObject.Value} and ";

                if (adventurerObject.CanInventory)
                {
                    messageBoxText += "may be added to your inventory.";
                }
                else
                {
                    messageBoxText += "may not be added to your inventory.";
                }
            }
            else
            {
                messageBoxText += $"The {gameObject.Name} may not be added to your inventory.";
            }

            return messageBoxText;
        }

        public static string CurrentInventory(IEnumerable<AdventurerObject> inventory)
        {
            string messageBoxText = "";

            //
            // display table header
            //
            messageBoxText =
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Type".PadRight(10) +
                "\n" +
                "---".PadRight(10) +
                "-------------------------".PadRight(30) +
                "--------------------".PadRight(10) +
                "\n";

            //
            // display all adventurer objects in rows
            //
            string inventoryObjectRows = null;
            foreach (AdventurerObject inventoryObject in inventory)
            {
                inventoryObjectRows +=
                    $"{inventoryObject.Id}".PadRight(10) +
                    $"{inventoryObject.Name}".PadRight(30) +
                    $"{inventoryObject.Type}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += inventoryObjectRows;

            return messageBoxText;
        }

        public static string ListAllNpcObjects(IEnumerable<Npc> npcObjects)
        {
            //
            // display table name and column headers
            //
            string messageBoxText =
                "NPCs Objects\n" +
                " \n" +

                //
                // display table header
                //
                "ID".PadRight(10) +
                "Name".PadRight(30) +
                "Dungeon Location Id".PadRight(10) + " \n" +
                "---".PadRight(10) +
                "-------------------".PadRight(30) +
                "-------------------".PadRight(10) + " \n";

            //
            // display all traveler objects
            //
            string npcObjectRows = null;
            foreach (Npc npcObject in npcObjects)
            {
                npcObjectRows +=
                    $"{npcObject.Id}".PadRight(10) +
                    $"{npcObject.Name}".PadRight(30) +
                    $"{npcObject.DungeonLocationID}".PadRight(10) +
                    Environment.NewLine;
            }

            messageBoxText += npcObjectRows;

            return messageBoxText;
        }

        #endregion

        public static List<string> StatusBox(Adventurer adventurer)
        {
            List<string> statusBoxText = new List<string>();

            statusBoxText.Add($"Experience Points: {adventurer.ExperiencePoints}\n");
            statusBoxText.Add($"Health: {adventurer.Health}\n");
            statusBoxText.Add($"Lives: {adventurer.Lives}\n");

            return statusBoxText;
        }
    }
}
