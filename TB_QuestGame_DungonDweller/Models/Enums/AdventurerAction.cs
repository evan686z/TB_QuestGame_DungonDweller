using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// enum of all possible player actions
    /// </summary>
    public enum AdventurerAction
    {
        None,
        MissionSetup,
        LookAround,
        Travel,

        AdventurerMenu,
        AdventurerInfo,
        Inventory,
        AdventurerLocationsVisited,

        ObjectMenu,
        LookAt,
        PickUp,
        PutDown,

        NonPlayerCharacterMenu,
        TalkTo,

        AdminMenu,
        ListDungeonLocations,
        ListGameObjects,
        EditAdventurerInfo,
        ListNonPlayerCharacters,

        ReturnToMainMenu,
        Exit

    }
}
