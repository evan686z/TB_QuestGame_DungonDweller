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
                DungeonLocationId = 2,
                Description = "A glass bottle filled with a glowing teal liquid, that will heal all wounds and restore your mana.",
                Type = AdventurerObjectType.Medicine,
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
                Type = AdventurerObjectType.Treasure,
                Value = 45,
                CanInventory = true,
                IsConsumable = false,
                IsVisible = true
            }

        };
    }
}
