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
        private DungeonLocation _currentLocation;
        private GameObject _gameDungeonObjects;
        private Sound _gameSound;

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
            _gameSound = new Sound();
            //_gameDungeonObjects = new GameObject();

            //
            // add initial items to the adventurer's inventory
            //
            _gameAdventurer.Inventory.Add(_gameDungeon.GetGameObjectById(5) as AdventurerObject);
            _gameAdventurer.Inventory.Add(_gameDungeon.GetGameObjectById(6) as AdventurerObject);

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
            _currentLocation = _gameDungeon.GetSpaceTimeLocationById(_gameAdventurer.DungeonLocationID);
            _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrrentLocationInfo(), ActionMenu.MainMenu, "");

            //
            // game loop
            //
            while (_playingGame)
            {
                //
                // process all flags, events, and stats
                //
                UpdateGameStatus();

                //
                // get next game action from player
                //
                travelerActionChoice = GetNextAdventurerAction();

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
                        _currentLocation = _gameDungeon.GetSpaceTimeLocationById(_gameAdventurer.DungeonLocationID);

                        //
                        // set the game play screen to the current location info format
                        //
                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");
                        //
                        // play sound when you travel
                        //
                        //_gameSound.PlaySoundTravel();
                        break;

                    case AdventurerAction.AdventurerLocationsVisited:
                        _gameConsoleView.DisplayLocationsVisited();
                        break;

                    case AdventurerAction.ListGameObjects:
                        _gameConsoleView.DisplayListOfAllGameObjects();
                        break;

                    case AdventurerAction.ListNonPlayerCharacters:
                        _gameConsoleView.DisplayListOfAllNpcObjects();
                        break;

                    case AdventurerAction.LookAt:
                        LookAtAction();
                        break;

                    case AdventurerAction.PickUp:
                        PickUpAction();
                        break;

                    case AdventurerAction.PutDown:
                        PutDownAction();
                        break;

                    case AdventurerAction.TalkTo: 
                        TalkToAction();
                        //_gameSound.PlaySoundTalkTo();
                        break;

                    case AdventurerAction.Inventory:
                        _gameConsoleView.DisplayInventory();
                        //_gameSound.PlaySoundInventory();
                        break;

                    case AdventurerAction.EditAdventurerInfo:
                        _gameConsoleView.DisplayEditAdventurerInfo(_gameAdventurer);
                        break;

                    case AdventurerAction.AdminMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.AdminMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Admin Menu", "Select an operation from the menu.", ActionMenu.AdminMenu, "");
                        break;

                    case AdventurerAction.ReturnToMainMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.MainMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Current Location", Text.CurrentLocationInfo(_currentLocation), ActionMenu.MainMenu, "");
                        break;

                    case AdventurerAction.AdventurerMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.AdventurerMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Adventurer Menu", "Select an operation from the menu.", ActionMenu.AdventurerMenu, "");
                        break;

                    case AdventurerAction.ObjectMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.ObjectMenu;
                        _gameConsoleView.DisplayGamePlayScreen("Object Menu", "Select an operation from the menu.", ActionMenu.ObjectMenu, "");
                        break;

                    case AdventurerAction.NonPlayerCharacterMenu:
                        ActionMenu.currentMenu = ActionMenu.CurrentMenu.NpcMenu;
                        _gameConsoleView.DisplayGamePlayScreen("NPC Menu", "Select an operation from the menu.", ActionMenu.NpcMenu, "");
                        break;

                    case AdventurerAction.Exit:
                        //_gameSound.PlaySoundExit();
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

        private AdventurerAction GetNextAdventurerAction()
        {
            AdventurerAction adventurerActionChoice = AdventurerAction.None;

            switch (ActionMenu.currentMenu)
            {
                case ActionMenu.CurrentMenu.MainMenu:
                    adventurerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.MainMenu);
                    break;

                case ActionMenu.CurrentMenu.ObjectMenu:
                    adventurerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.ObjectMenu);
                    break;

                case ActionMenu.CurrentMenu.NpcMenu:
                    adventurerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.NpcMenu);
                    break;

                case ActionMenu.CurrentMenu.AdventurerMenu:
                    adventurerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.AdventurerMenu);
                    break;

                case ActionMenu.CurrentMenu.AdminMenu:
                    adventurerActionChoice = _gameConsoleView.GetActionMenuChoice(ActionMenu.AdminMenu);
                    break;

                default:
                    break;
            }

            return adventurerActionChoice;
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
            if (!_gameAdventurer.HasVisited(_currentLocation.DungeonLocationID))
            {
                //
                // add new location to the list of visited locations if this is a first visit
                //
                _gameAdventurer.DungeonLocationsVisited.Add(_currentLocation.DungeonLocationID);

                //
                // update experience points for visiting locations
                //
                _gameAdventurer.ExperiencePoints += _currentLocation.ExperiencePoints;

                //
                // update experience points for adding items to inventory
                //
                // TODO: only add experience for new objects and not add experience for items already counted
                // if (an item was added, add experience)?
                //if (!_gameAdventurer.Inventory.Contains())
                //{

                //}
                foreach (GameObject gameObject in _gameAdventurer.Inventory)
                {
                    _gameAdventurer.ExperiencePoints += gameObject.ExperiencePoints;
                }

                //
                // Leveling up screen
                //
                LevelUp();

            }



            //_gameConsoleView.UpdateDungeonLocationAccessibility();
        }

        private void LookAtAction()
        {
            //
            // display a list of adventurer objects in a dungeon location and get a player choice
            //
            int gameObjectToLookAtId = _gameConsoleView.DisplayGetGameObjectToLookAt();

            //
            // display game object info
            //
            if (gameObjectToLookAtId != 0)
            {
                //
                // get the ame object from universe
                //
                GameObject gameObject = _gameDungeon.GetGameObjectById(gameObjectToLookAtId);

                //
                // display information for the object chosen
                //
                _gameConsoleView.DisplayGameObjectInfo(gameObject);
            }
        }

        private void PickUpAction()
        {
            //
            // display a list of adventurer object in dungeon location and get a player choice
            //
            int adventurerObjectToPickUpId = _gameConsoleView.DisplayGetAdventurerObjectToPickUp();

            //
            // add the adventurer object to adventurer's inventory
            //
            if (adventurerObjectToPickUpId != 0)
            {
                //
                // get the game object from the dungeon
                //
                AdventurerObject adventurerObject = _gameDungeon.GetGameObjectById(adventurerObjectToPickUpId) as AdventurerObject;

                //
                // note: adventurer object is added to list and the dungeon location of the object is set to 0
                //
                _gameAdventurer.Inventory.Add(adventurerObject);
                adventurerObject.DungeonLocationId = 0;

                //
                // display confirmation message
                //
                _gameConsoleView.DisplayConfirmAdventurerObjectAddedToInventory(adventurerObject);
            }
        }

        private void PutDownAction()
        {
            //
            // display a list of adventurer object in dungeon location and get a player choice
            //
            int inventoryObjectToPutDownId = _gameConsoleView.DisplayGetInventoryObjectToPutDown();

            //
            // get the game object from the dungeon
            //
            AdventurerObject adventurerObject = _gameDungeon.GetGameObjectById(inventoryObjectToPutDownId) as AdventurerObject;

            //
            // remove the object from inventory and set the dungeon location to the current value
            //
            _gameAdventurer.Inventory.Remove(adventurerObject);
            adventurerObject.DungeonLocationId = _gameAdventurer.DungeonLocationID;

            //
            // display confirmation message
            //
            _gameConsoleView.DisplayConfirmAdventurerObjectRemovedFromInventory(adventurerObject);

        }

        private void TalkToAction()
        {
            //
            // display a list of NPCs in dungeon location and get player choice
            //
            int npcToTalkToId = _gameConsoleView.DisplayGetNpcToTalkTo();

            //
            // display NPCs message
            //
            if (npcToTalkToId != 0)
            {
                //
                // get the NPC from the universe
                //
                Npc npc = _gameDungeon.GetNpcById(npcToTalkToId);

                //
                // display information for the object chosen
                //
                _gameConsoleView.DisplayTalkTo(npc);
            }
        }

        private void LevelUp()
        {
            if (_gameAdventurer.ExperiencePoints == 100)
            {
                _gameConsoleView.DisplayGamePlayScreen("Level 2 Reached!", "You have reached level 2! Congradulations!", ActionMenu.MainMenu, "");
            }
            else if (_gameAdventurer.ExperiencePoints == 200)
            {
                _gameConsoleView.DisplayGamePlayScreen("Level 3 Reached!", "You have reached level 3! Congradulations!", ActionMenu.MainMenu, "");
            }
            else if (_gameAdventurer.ExperiencePoints == 300)
            {
                _gameConsoleView.DisplayGamePlayScreen("Level 4 Reached!", "You have reached level 3! Congradulations!", ActionMenu.MainMenu, "");
            }
            else if (_gameAdventurer.ExperiencePoints == 400)
            {
                _gameConsoleView.DisplayGamePlayScreen("Level 5 Reached!", "You have reached level 3! Congradulations!", ActionMenu.MainMenu, "");
            }
            else if (_gameAdventurer.ExperiencePoints == 500)
            {
                _gameConsoleView.DisplayGamePlayScreen("Level 6 Reached!", "You have reached level 3! Congradulations!", ActionMenu.MainMenu, "");
            }
        }
        
        
        //private void DungeonRoomAccess()
        //{
            

        //    if (_gameDungeon.GetGameObjectById(2))
        //    {
                
        //    }
        //}
        #endregion
    }
}
