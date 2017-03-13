﻿using System;
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

        public static string MissionIntro()
        {
            string messageBoxText =
            "You have been hired by the Norlon Corporation to participate " +
            "in its latest endeavor, the Aion Project. Your mission is to " +
            "test the limits of the new Aion Engine and report back to " +
            "the Norlon Corporation.\n" +
            " \n" +
            "Press the Esc key to exit the game at any point.\n" +
            " \n" +
            "Your mission begins now.\n" +
            " \n" +
            "\tYour first task will be to set up the initial parameters of your mission.\n" +
            " \n" +
            "\tPress any key to begin the Mission Initialization Process.\n";

            return messageBoxText;
        }

        public static string CurrrentLocationInfo()
        {
            string messageBoxText =
            "You are now in the Norlon Corporation research facility located in " +
            "the city of Heraklion on the north coast of Crete. You have passed through " +
            "heavy security and descended an unknown number of levels to the top secret " +
            "research lab for the Aion Project.\n" +
            " \n" +
            "\tChoose from the menu options to proceed.\n";

            return messageBoxText;
        }

        #region Initialize Mission Text

        public static string InitializeQuestIntro()
        {
            string messageBoxText =
                "Before you begin your mission we much gather your base data.\n" +
                " \n" +
                "You will be prompted for the required information. Please enter the information below.\n" +
                " \n" +
                "\tPress any key to begin.";

            return messageBoxText;
        }

        public static string InitializeQuestGetAdventurerName()
        {
            string messageBoxText =
                "Enter your name adventurer.\n" +
                " \n" +
                "Please use the name you wish to be referred during your mission.";

            return messageBoxText;
        }

        public static string InitializeQuestGetAdventurerAge(string name)
        {
            string messageBoxText =
                $"Very good then, we will call you {name} on this mission.\n" +
                " \n" +
                "Enter your age below.\n" +
                " \n" +
                "Please use the standard Earth year as your reference.";

            return messageBoxText;
        }

        public static string InitializeQuestGetAdventurerRace(Adventurer gameTraveler)
        {
            string messageBoxText =
                $"{gameTraveler.Name}, it will be important for us to know your race on this mission.\n" +
                " \n" +
                "Enter your race below.\n" +
                " \n" +
                "Please use the universal race classifications below." +
                " \n";

            string raceList = null;

            foreach (Character.RaceType race in Enum.GetValues(typeof(Character.RaceType)))
            {
                if (race != Character.RaceType.None)
                {
                    raceList += $"\t{race}\n";
                }
            }

            messageBoxText += raceList;

            return messageBoxText;
        }

        public static string InitializeQuestEchoAdventurerInfo(Adventurer gameAdventurer)
        {
            string messageBoxText =
                $"Very good then {gameAdventurer.Name}.\n" +
                " \n" +
                "It appears we have all the necessary data to begin your mission. You will find it" +
                " listed below.\n" +
                " \n" +
                $"\tTraveler Name: {gameAdventurer.Name}\n" +
                $"\tTraveler Age: {gameAdventurer.Age}\n" +
                $"\tTraveler Race: {gameAdventurer.Race}\n" +
                " \n" +
                "Press any key to begin your mission.";

            return messageBoxText;
        }

        #endregion

        #endregion

        #region MAIN MENU ACTION SCREENS

        public static string AdventurerInfo(Adventurer gameDungeon)
        {
            string messageBoxText =
                $"\tTraveler Name: {gameDungeon.Name}\n" +
                $"\tTraveler Age: {gameDungeon.Age}\n" +
                $"\tTraveler Race: {gameDungeon.Race}\n" +
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
