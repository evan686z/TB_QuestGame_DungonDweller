using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// class for the game map locations
    /// </summary>
    public class DungeonLocation
    {
        #region FIELDS

        private string _commonName;
        private int _dungeonLocationID; // must be a unique value for each object
        private int _dungeonDate;
        private string _description;
        private string _generalContents;
        private bool _accessable;
        private int _experiencePoints;

        #endregion


        #region PROPERTIES

        public string CommonName
        {
            get { return _commonName; }
            set { _commonName = value; }
        }

        public int DungeonLocationID
        {
            get { return _dungeonLocationID; }
            set { _dungeonLocationID = value; }
        }

        public int DungeonDate
        {
            get { return _dungeonDate; }
            set { _dungeonDate = value; }
        }

        public string Description
        {
            get { return _description; }
            set { _description = value; }
        }

        public string GeneralContents
        {
            get { return _generalContents; }
            set { _generalContents = value; }
        }

        public bool Accessable
        {
            get { return _accessable; }
            set { _accessable = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }

        #endregion


        #region CONSTRUCTORS



        #endregion


        #region METHODS



        #endregion


    }
}
