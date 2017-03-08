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
        #endregion

        #region CONSTRUCTORS

        public Adventurer()
        {

        }

        public Adventurer(string name, int age, RaceType race, int iq, int healthPotions, int dungeonLocationID) : base(name, age, race, dungeonLocationID)
        {

        }

        #endregion

        #region METHODS


        #endregion
    }
}
