using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// static class to hold all objects in the game universe; locations, game objects, npc's
    /// </summary>
    public static class DungeonObjects
    {
        public static List<DungeonLocation> DungeonLocations = new List<DungeonLocation>()
        {

            new DungeonLocation
            {
                CommonName = "Dungeon Entrance",
                DungeonLocationID = 1,
                DungeonDate = 468,
                Description = "The entrance to the dungeon is covered in thick moss " +
                    "that you are barely able to see threw.\n",
                GeneralContents = " You push the moss aside to reveal a small room with a single torch " +
                    "above a doorway. The only way forward is through this doorway.\n",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Barracks",
                DungeonLocationID = 2,
                DungeonDate = 468,
                Description = "The Felandrian Plains are a common destination for tourist. " +
                    "Located just north of the equatorial line on the planet of Corlon, they " +
                    "provide excellent habitat for a rich ecosystem of flora and fauna.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Armory",
                DungeonLocationID = 3,
                DungeonDate = 468,
                Description = "The Xantoria market, once controlled by the Thorian elite, is now an " +
                              "open market managed by the Xantorian Commerce Coop. It is a place " +
                              "where many races from various systems trade goods.",
                GeneralContents = "- stuff in the room -",
                Accessable = false,
                ExperiencePoints = 20
            },

            new DungeonLocation
            {
                CommonName = "Storeroom",
                DungeonLocationID = 4,
                DungeonDate = 468,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Kitchen",
                DungeonLocationID = 5,
                DungeonDate = 468,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Eating Hall",
                DungeonLocationID = 6,
                DungeonDate = 468,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Library",
                DungeonLocationID = 7,
                DungeonDate = 468,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Crypt",
                DungeonLocationID = 8,
                DungeonDate = 468,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Shrine",
                DungeonLocationID = 9,
                DungeonDate = 468,
                Description = "The Norlon Corporation Headquarters is located in just outside of Detroit Michigan." +
                              "Norlon, founded in 1985 as a bio-tech company, is now a 36 billion dollar company " +
                              "with huge holdings in defense and space research and development.",
                GeneralContents = "- stuff in the room -",
                Accessable = true,
                ExperiencePoints = 10
            },

            new DungeonLocation
            {
                CommonName = "Throne Room",
                DungeonLocationID = 10,
                DungeonDate = 468,
                Description = "An abandoned space ship looms just out of plaent Velisoid." +
                              "The ship hull is riddled with projectile sized holes and one of " +
                              "the four rear engines is missing. Something terrible happened here.",
                GeneralContents = "As you apporoach the ship, a small pirate ship flys out from behind the freighter." +
                                  "Before you have time to hale them, they open fire on your ship. You flee " +
                                  "as fast as you can, but your ship takes some minor damage.",
                Accessable = true,
                ExperiencePoints = 10
            }
        };
    }
}
