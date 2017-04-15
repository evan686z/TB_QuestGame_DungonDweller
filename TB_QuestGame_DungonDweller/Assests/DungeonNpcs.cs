﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    public static partial class DungeonObjects
    {
        public static List<Npc> Npcs = new List<Npc>()
        {
            new Civilian
            {
                Id = 1,
                Name = "Great Wizard Abanark",
                DungeonLocationID = 5,
                Description = "A slender man wearing a dark robe, and a tall pointed hat.",
                Messages = new List<string>
                {
                    "Greetings adventurer! You don't look to be someone that seeks knowledge from this library.",
                    "You wonder how the books fly? I infused them with some of my magic you see.",
                    "Beware the crypt, something awful lurks in the shadows."
                }
            },

            new Civilian
            {
                Id = 2,
                Name = "Skeleton King",
                DungeonLocationID = 8,
                Description = "An abnormally tall skeleton doned in armor from head to toe, wielding a great sword as tall as he.",
                Messages = new List<string>
                {
                    "Someone comes to claim my crown!",
                    "You will find I am not so easily defeated adventurer!",
                    "Enjoy your last moments on this world! I will be your end!"
                }
            },

            new Civilian
            {
                Id = 3,
                Name = "Spider Queen",
                DungeonLocationID = 6,
                Description = "A huge spider with the torso and face of a woman.",
                Messages = new List<string>
                {
                    "You seek the crown of the skeleton king? You will never escape me!",
                    "Don't think I am so easily defeated! I will enjoy feeding you to my children."
                }
            }
        };
    }
}
