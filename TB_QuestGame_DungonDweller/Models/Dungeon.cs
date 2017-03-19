using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// class of the game map
    /// </summary>
    public class Dungeon
    {
        #region ***** define all lists to be maintained by the Universe object *****

        //
        // list of all space-time locations
        //

        private List<DungeonLocation> _dungeonLocations;

        public List<DungeonLocation> SpaceTimeLocations
        {
            get { return _dungeonLocations; }
            set { _dungeonLocations = value; }
        }

        #endregion

        #region ***** constructor *****

        //
        // default Dungeon constructor
        //
        public Dungeon()
        {
            //
            // add all of the universe objects to the game
            // 
            IntializeDungeon();
        }

        #endregion

        #region ***** define methods to initialize all game elements *****

        /// <summary>
        /// initialize the universe with all of the space-time locations
        /// </summary>
        private void IntializeDungeon()
        {
            _dungeonLocations = DungeonObjects.DungeonLocations;
        }

        #endregion

        #region ***** define methods to return game element objects and information *****

        /// <summary>
        /// determine if the Space-Time Location Id is valid
        /// </summary>
        /// <param name="spaceTimeLocationId">true if Space-Time Location exists</param>
        /// <returns></returns>
        public bool IsValidSpaceTimeLocationId(int spaceTimeLocationId)
        {
            List<int> spaceTimeLocationIds = new List<int>();

            //
            // create list of space-time locations ids
            //
            foreach (DungeonLocation stl in _dungeonLocations)
            {
                spaceTimeLocationIds.Add(stl.DungeonLocationID);
            }

            //
            // determine if the space-time location id is a valid id and return the result
            //
            if (spaceTimeLocationIds.Contains(spaceTimeLocationId))
            {
                return true;
            }
            else
            {
                return false;
            }
        }




        /// <summary>
        /// determine if a location is accessible to the player
        /// </summary>
        /// <param name="spaceTimeLocationId"></param>
        /// <returns>accessible</returns>
        public bool IsAccessibleLocation(int spaceTimeLocationId)
        {
            DungeonLocation spaceTimeLocation = GetSpaceTimeLocationById(spaceTimeLocationId);
            if (spaceTimeLocation.Accessable == true)
            {
                return true;
            }
            else
            {
                return false;
            }

        }

        /// <summary>
        /// return the next available ID for a DungeonLocation object
        /// </summary>
        /// <returns>next SpaceTimeLocationObjectID </returns>
        public int GetMaxSpaceTimeLocationId()
        {
            int MaxId = 0;

            foreach (DungeonLocation spaceTimeLocation in SpaceTimeLocations)
            {
                if (spaceTimeLocation.DungeonLocationID > MaxId)
                {
                    MaxId = spaceTimeLocation.DungeonLocationID;
                }
            }

            return MaxId;
        }

        /// <summary>
        /// get a DungeonLocation object using an Id
        /// </summary>
        /// <param name="Id">space-time location ID</param>
        /// <returns>requested space-time location</returns>
        public DungeonLocation GetSpaceTimeLocationById(int Id)
        {
            DungeonLocation spaceTimeLocation = null;

            //
            // run through the space-time location list and grab the correct one
            //
            foreach (DungeonLocation location in _dungeonLocations)
            {
                if (location.DungeonLocationID == Id)
                {
                    spaceTimeLocation = location;
                }
            }

            //
            // the specified ID was not found in the universe
            // throw and exception
            //
            if (spaceTimeLocation == null)
            {
                string feedbackMessage = $"The Space-Time Location ID {Id} does not exist in the current Dungeon.";
                throw new ArgumentException(Id.ToString(), feedbackMessage);
            }

            return spaceTimeLocation;
        }

        #endregion
    }
}
