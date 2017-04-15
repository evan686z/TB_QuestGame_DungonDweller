using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    public static partial class DungeonObjects
    {
        public static List<GameObject> GameObject = new List<GameObject>()
        {
            new AdventurerObject
            {
                Id = 1,
                Name = "Bag of Gold",
                DungeonLocationId = 2,
                Description = "A small leather pouch filled with 8 gold coins.",
                ExperiencePoints = 10,
                Type = AdventurerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 2,
                Name = "Book of Summon Elemental",
                DungeonLocationId = 5,
                Description = "A leather bound book describing how to summon elementals of varrying magic types.",
                ExperiencePoints = 20,
                Type = AdventurerObjectType.Information,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 3,
                Name = "Silver Long Sword",
                DungeonLocationId = 3,
                Description = "An old, but still sharp to the touch, long sword made of silver.",
                ExperiencePoints = 25,
                Type = AdventurerObjectType.Weapon,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 4,
                Name = "Potion of Rejuvenation",
                DungeonLocationId = 4,
                Description = "A glass bottle filled with a glowing teal liquid, that will heal all wounds and restore your mana.",
                ExperiencePoints = 15,
                Type = AdventurerObjectType.Healing,
                Value = 45,
                CanInventory = true,
                IsConsumable = true,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 5,
                Name = "Old Map of dungeon",
                DungeonLocationId = 0,
                Description = "A worn looking map describing the layout of the dungeon given to you by the King.",
                ExperiencePoints = 0,
                Type = AdventurerObjectType.Information,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 6,
                Name = "Lucky Rabbit's Foot",
                DungeonLocationId = 0,
                Description = "Your lucky rabbit's foot. You never leave home without it!",
                ExperiencePoints = 30,
                Type = AdventurerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 7,
                Name = "Crown Of The Skeleton King",
                DungeonLocationId = 8,
                Description = "Although covered in dust and spider webs the crown shimmers with a golden luster.\n" +
                              "You sense a great, but evil, power eminating from the crown." ,
                ExperiencePoints = 1000,
                Type = AdventurerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 8,
                Name = "Vial of Spider Queen Blood",
                DungeonLocationId = 6,
                Description = "A small vial of the poisonous blood of the defeated Spider Queen.\n" +
                              "Someone might find value of this in town." ,
                ExperiencePoints = 20,
                Type = AdventurerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            },

            new AdventurerObject
            {
                Id = 9,
                Name = "Figurine",
                DungeonLocationId = 7,
                Description = "A small figurine that looks worn. It looks as if it an idol that someone used in worship." ,
                ExperiencePoints = 20,
                Type = AdventurerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            }

        };
    }
}
