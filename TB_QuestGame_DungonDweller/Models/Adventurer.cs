using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// the character class the player uses in the game
    /// </summary>
    public class Adventurer : Character
    {
        #region ENUMERABLES


        #endregion

        #region FIELDS

        private int _iq;
        private int _healthPotions;
        private int _experiencePoints;
        private int _health;
        private int _lives;
        private List<int> _dungeonLocationsVisited;
        private List<AdventurerObject> _inventory;

        #endregion

        #region PROPERTIES

        public int IQ
        {
            get { return _iq; }
            set { _iq = value; }
        }

        public int HealthPotions
        {
            get { return _healthPotions; }
            set { _healthPotions = value; }
        }

        public int ExperiencePoints
        {
            get { return _experiencePoints; }
            set { _experiencePoints = value; }
        }
        public int Health
        {
            get { return _health; }
            set { _health = value; }
        }
        public int Lives
        {
            get { return _lives; }
            set { _lives = value; }
        }
        public List<int> DungeonLocationsVisited
        {
            get { return _dungeonLocationsVisited; }
            set { _dungeonLocationsVisited = value; }
        }

        public List<AdventurerObject> Inventory
        {
            get { return _inventory; }
            set { _inventory = value; }
        }
        #endregion

        #region CONSTRUCTORS

        public Adventurer()
        {
            _dungeonLocationsVisited = new List<int>();
            _inventory = new List<AdventurerObject>();
        }

        public Adventurer(string name, int age, ClassType race, int iq, int healthPotions, int dungeonLocationID) : base(name, age, race, dungeonLocationID)
        {
            _dungeonLocationsVisited = new List<int>();
            _inventory = new List<AdventurerObject>();
        }

        #endregion

        #region METHODS

        public bool HasVisited(int _dungeonLocationID)
        {
            if (DungeonLocationsVisited.Contains(_dungeonLocationID))
            {
                return true;
            }
            else
            {
                return false;
            }
        }

        #endregion
    }
}
