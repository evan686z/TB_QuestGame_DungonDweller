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
        LookAt,
        PickUpItem,
        PickUpTreasure,
        PutDownItem,
        PutDownTreasure,
        Travel,
        AdventurerInfo,
        EditAdventurerInfo,
        AdventurerInventory,
        AdventurerTreasure,
        AdventurerLocationsVisited,
        ListDungeonLocations,
        ListItems,
        ListTreasures,
        Exit
    }
}
