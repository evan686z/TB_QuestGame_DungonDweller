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
    public static partial class DungeonObjects
    {
        public static List<DungeonLocation> DungeonLocations = new List<DungeonLocation>()
        {
            // Starting Location
            new DungeonLocation
            {
                CommonName = "Dungeon Entrance",
                DungeonLocationID = 1,
                DungeonDate = 468,
                Description = "The entrance to the dungeon, a huge metal gate, is covered in thick moss " +
                              "that you are barely able to see threw. On the floor surrounding the door, is " +
                              "skattered bones." ,
                GeneralContents = "You push the moss aside to reveal a small room with a single torch " +
                                  "above a doorway. The only way forward is through this doorway.",
                Accessable = true,
                ExperiencePoints = 10
            },
            // Orc warriors
            new DungeonLocation
            {
                CommonName = "Barracks",
                DungeonLocationID = 2,
                DungeonDate = 468,
                Description = "This hall is choked with corpses. The bodies of orcs and ogres lie in tangled heaps where " +
                              "they died, and the floor is sticky with dried blood. It looks like the orcs and ogres were " +
                              "fighting. Some side was the victor but you're not sure which one. The bodies are largely " +
                              "stripped of valuables, but a few broken weapons jut from the " +
                              "slain or lie discarded on the floor." ,
                GeneralContents = "You enter the room and almost instantly are noticed by the several Orc warriors standing " +
                                  "around a cooking fire. The walk towards you, stepping over the corpes of their fellow " +
                                  "warriors. The Orcs let loose a terrifying battle cry and charge at you." ,
                Accessable = true,
                ExperiencePoints = 20
            },
            // Skeletal Warriors
            new DungeonLocation
            {
                CommonName = "Armory",
                DungeonLocationID = 3,
                DungeonDate = 468,
                Description = "This chamber served as an armory for some group of creatures. Armor and weapon racks " +
                              "line the walls and rusty and broken weapons litter the floor. It hasn't been used " +
                              "in a long time, and all the useful weapons have been taken but for a single sword." +
                              "Unlike the other weapons in the room, this one gleams untarnished in the light." ,
                GeneralContents = "As you approach the sword, a group of Skeletal warriors reveal themselves to you." ,
                Accessable = true,
                ExperiencePoints = 20
            },
            // Warden Boss (necromancer, summons skeletons)
            new DungeonLocation
            {
                CommonName = "Prison",
                DungeonLocationID = 4,
                DungeonDate = 468,
                Description = "This chamber is clearly a prison. Small barred cells line the walls, leaving a 15-foot-wide " +
                              "pathway for a guard to walk. Channels run down either side of the path next to the cages, " +
                              "probably to allow the prisoners' waste to flow through the grates on the other side of the " +
                              "room. The cells appear empty but your vantage point doesn't allow " +
                              "you to see the full extent of them all." ,
                GeneralContents = "As you enter the room you hear a loud metal screeching sound. You press foward and from " +
                                  "behind one of the cells appears a ghostly skeleton with a strange aura about him." +
                                  "He holds a giant scythe and entail with him are 2 skeletal minions." ,
                Accessable = true,
                ExperiencePoints = 30
            },
            // Archmage 'insert name here'
            new DungeonLocation
            {
                CommonName = "Library",
                DungeonLocationID = 5,
                DungeonDate = 468,
                Description = "The scent of earthy decay assaults your nose upon peering through the open door to this room." +
                              "Smashed bookcases and their sundered contents litter the floor. Paper rots in mold-spotted " +
                              "heaps, and shattered wood grows white fungus.",
                GeneralContents = "Upon entering the room you can hear the flapping of what sounds like wings. You round the corner " +
                                  "of a tall bookshelf and see what is making the noise. Flying books are everywhere and have a " +
                                  "strange glow about them. In the distance you notice the chanting of arcane magic." +
                                  "The chanting stops and a great wizard appears, as if out of nowhere." ,
                Accessable = true,
                ExperiencePoints = 30
            },
            // Spider Queen Boss
            new DungeonLocation
            {
                CommonName = "Crypt",
                DungeonLocationID = 6,
                DungeonDate = 468,
                Description = "You feel a sense of foreboding upon peering into this cavernous chamber." +
                              "At its center lies a low heap of refuse, rubble, and bones atop which sit several " +
                              "huge broken eggshells. Judging by their shattered remains, the " +
                              "eggs were big enough to hold a crouching man, making you " +
                              "wonder how large -- and where -- the mother is." ,
                GeneralContents = "You stand in the middle of the room, the floor is sticky, but the room is too " +
                                  "dark. You can barely see your hand in front of your face. On either side of the room " +
                                  "you notice something skittering around.",
                Accessable = true,
                ExperiencePoints = 40
            },
            // Obsidian Giant
            new DungeonLocation
            {
                CommonName = "Shrine",
                DungeonLocationID = 7,
                DungeonDate = 468,
                Description = "A 30-foot-tall demonic idol dominates this room of black stone. The potbellied statue " +
                              "is made of obsidian, and its grinning face holds what looks to be two large rubies in " +
                              "place of eyes. A fire burns merrily in a wide brazier the idol holds in its lap.",
                GeneralContents = "As you enter the room the rubies start to glow immensely. The once static statue " +
                                  "now rumbles and shakes. The whole room feels as if it is going to collapse." +
                                  "The statue drops the braizier and marches towards you." ,
                Accessable = true,
                ExperiencePoints = 30
            },
            // Skeleton King
            new DungeonLocation
            {
                CommonName = "Throne Room",
                DungeonLocationID = 8,
                DungeonDate = 468,
                Description = "This room is hung with hundreds of dusty tapestries. All show signs" +
                              "of wear: moth holes, scorch marks, dark stains, and the damage of years " +
                              "of neglect. They hang on all the walls and hang from the ceiling to " +
                              "brush against the floor, blocking your view of the rest of the room.",
                GeneralContents = "Before you stands a great throne made of gold. Though long forgotten, its" +
                                  "luster still shrine through the dust. In the throne sits the great Skeleton King." +
                                  "He rises from his throne and lets out a massive wail.",
                Accessable = false,
                ExperiencePoints = 100
            }
        };
    }
}
