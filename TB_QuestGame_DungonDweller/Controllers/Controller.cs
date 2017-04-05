using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// controller for the MVC pattern in the application
    /// </summary>
    public class Controller
    {
        #region FIELDS

        private ConsoleView _gameConsoleView;
        private Adventurer _gameAdventurer;
        private Dungeon _gameDungeon;
        private bool _playingGame;
        private DungeonLocation _dungeonLocation;

        #endregion

        #region PROPERTIES


        #endregion

        #region CONSTRUCTORS

        public Controller()
        {
            //
            // setup all of the objects in the game
            //
            InitializeGame();

            //
            // begins running the application UI
            //
            ManageGameLoop();
        }

        #endregion

        #region METHODS

        /// <summary>
        /// initialize the major game objects
        /// </summary>
        private void InitializeGame()
        {
            _gameAdventurer = new Adventurer();
            _gameDungeon = new Dungeon();
            _gameConsoleView = new ConsoleView(_gameAdventurer, _gameDungeon);
            _playingGame = true;

            Console.CursorVisible = false;
        }

        /// <summary>
        /// method to manage the application setup and game loop
        /// </summary>
        private void ManageGameLoop()
        {
            AdventurerAction travelerActionChoice = AdventurerAction.None;

            //
            // display splash screen
            //
            _playingGame = _gameConsoleView.DisplaySpashScreen();

            //
            // player chooses to quit
            //
            if (!_playingGame)
            {
                Environment.Exit(1);
            }

            //
            // display introductory message
            //
            _gameConsoleView.DisplayGamePlayScreen("Mission Intro", Text.QuestIntro(), ActionMenu.QuestIntro, "");
            _gameConsoleView.GetContinueKey();

            //
            // initialize the mission adventurer
            // 
            InitializeMission();

            //
            // prepare game play screen
            //
            _dungeonLocation = _gameDungeon.GetSpaceTimeLocationById(_gameAdventurer.DungeonLocationID);
            _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrrentLocationInfo(), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {
                //
                // process all flags, events, and stats
                //
                //
                UpdateGameStatus();

                // get next game action from player
                //
                travelerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);

                //
                // choose an action based on the player's menu choice
                //
                switch (travelerActionChoice)
                {
                    case AdventurerAction.None:
                        break;

                    case AdventurerAction.AdventurerInfo:
                        _gameConsoleView.DisplayAdventurerInfo();
                        break;

                    case AdventurerAction.ListDungeonLocations:
                        _gameConsoleView.DisplayListOfDungeonLocations();
                        break;

                    case AdventurerAction.LookAround:
                        _gameConsoleView.DisplayLookAround();
                        break;

                    case AdventurerAction.Travel:
                        //
                        // get new location choice and update the current location property
                        //                        
                        _gameAdventurer.DungeonLocationID = _gameConsoleView.DisplayGetNextDungeonLocation();
                        _dungeonLocation = _gameDungeon.GetSpaceTimeLocationById(_gameAdventurer.DungeonLocationID);

                        //
                        // set the game play screen to the current location info format
                        //
                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_dungeonLocation), ActionMenu.MainMenu, "");
                        break;

                    case AdventurerAction.AdventurerLocationsVisited:
                        _gameConsoleView.DisplayLocationsVisited();
                        break;

                    case AdventurerAction.ListGameObjects:
                        _gameConsoleView.DisplayListOfAllGameObjects();
                        break;

                    case AdventurerAction.EditAdventurerInfo:
                        _gameConsoleView.DisplayEditAdventurerInfo(_gameAdventurer);
                        break;

                    case AdventurerAction.Exit:
                        _playingGame = false;
                        break;

                    default:
                        break;
                }
            }

            //
            // close the application
            //
            Environment.Exit(1);
        }

        /// <summary>
        /// initialize the player info
        /// </summary>
        private void InitializeMission()
        {
            Adventurer adventurer = _gameConsoleView.GetInitialAdventurerInfo();

            _gameAdventurer.Name = adventurer.Name;
            _gameAdventurer.Age = adventurer.Age;
            _gameAdventurer.Class = adventurer.Class;
            _gameAdventurer.IQ = adventurer.IQ;
            _gameAdventurer.HealthPotions = adventurer.HealthPotions;
            _gameAdventurer.DungeonLocationID = 1;

            _gameAdventurer.ExperiencePoints = 0;
            _gameAdventurer.Health = 100;
            _gameAdventurer.Lives = 3;
        }

        private void UpdateGameStatus()
        {
            if (!_gameAdventurer.HasVisited(_dungeonLocation.DungeonLocationID))
            {
                //
                // add new location to the list of visited locations if this is a first visit
                //
                _gameAdventurer.DungeonLocationsVisited.Add(_dungeonLocation.DungeonLocationID);

                //
                // update experience points for visiting locations
                //
                _gameAdventurer.ExperiencePoints += _dungeonLocation.ExperiencePoints;
            }

            //_gameConsoleView.UpdateDungeonLocationAccessibility();
        }

        #endregion
    }
}
