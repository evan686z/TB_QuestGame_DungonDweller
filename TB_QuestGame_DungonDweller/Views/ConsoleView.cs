using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace TB_QuestGame_DungonDweller
{
    /// <summary>
    /// view class
    /// </summary>
    public class ConsoleView
    {
        #region ENUMS

        private enum ViewStatus
        {
            TravelerInitialization,
            PlayingGame
        }

        #endregion

        #region FIELDS

        //
        // declare game objects for the ConsoleView object to use
        //
        Adventurer _gameAdventurer;
        Dungeon _gameDungeon;

        ViewStatus _viewStatus;

        #endregion

        #region PROPERTIES

        #endregion

        #region CONSTRUCTORS

        /// <summary>
        /// default constructor to create the console view objects
        /// </summary>
        public ConsoleView(Adventurer gameTraveler, Dungeon gameUniverse)
        {
            _gameAdventurer = gameTraveler;
            _gameDungeon = gameUniverse;

            _viewStatus = ViewStatus.TravelerInitialization;

            InitializeDisplay();
        }

        #endregion

        #region METHODS
        /// <summary>
        /// display all of the elements on the game play screen on the console
        /// </summary>
        /// <param name="messageBoxHeaderText">message box header title</param>
        /// <param name="messageBoxText">message box text</param>
        /// <param name="menu">menu to use</param>
        /// <param name="inputBoxPrompt">input box text</param>
        public void DisplayGamePlayScreen(string messageBoxHeaderText, string messageBoxText, Menu menu, string inputBoxPrompt)
        {
            //
            // reset screen to default window colors
            //
            Console.BackgroundColor = ConsoleTheme.WindowBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.WindowForegroundColor;
            Console.Clear();

            ConsoleWindowHelper.DisplayHeader(Text.HeaderText);
            ConsoleWindowHelper.DisplayFooter(Text.FooterText);

            DisplayMessageBox(messageBoxHeaderText, messageBoxText);
            DisplayMenuBox(menu);
            DisplayInputBox();
            DisplayStatusBox();
        }

        /// <summary>
        /// wait for any keystroke to continue
        /// </summary>
        public void GetContinueKey()
        {
            Console.ReadKey();
        }

        /// <summary>
        /// get a action menu choice from the user
        /// </summary>
        /// <returns>action menu choice</returns>
        public AdventurerAction GetActionMenuChoice(Menu menu)
        {
            AdventurerAction choosenAction = AdventurerAction.None;
            Console.CursorVisible = false;

            //
            // create an array of valid keys from menu dictionary
            //
            char[] validKeys = menu.MenuChoices.Keys.ToArray();

            //
            // validate keys pressed as in MenuChoices dictionary
            //
            char keyPressed;
            do
            {
                ConsoleKeyInfo keyPressedInfo = Console.ReadKey(true);
                keyPressed = keyPressedInfo.KeyChar;
            } while (!validKeys.Contains(keyPressed));

            choosenAction = menu.MenuChoices[keyPressed];
            Console.CursorVisible = true;

            return choosenAction;
        }

        /// <summary>
        /// get a string value from the user
        /// </summary>
        /// <returns>string value</returns>
        public string GetString()
        {
            return Console.ReadLine();
        }

        /// <summary>
        /// get an integer value from the user
        /// </summary>
        /// <returns>integer value</returns>
        public bool GetInteger(string prompt, int minimumValue, int maximumValue, out int integerChoice)
        {
            bool validResponse = false;
            integerChoice = 0;

            DisplayInputBoxPrompt(prompt);
            while (!validResponse)
            {
                if (int.TryParse(Console.ReadLine(), out integerChoice))
                {
                    if (integerChoice >= minimumValue && integerChoice <= maximumValue)
                    {
                        validResponse = true;
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage($"You must enter an integer value between {minimumValue} and {maximumValue}. Please try again.");
                        DisplayInputBoxPrompt(prompt);
                    }
                }
                else
                {
                    ClearInputBox();
                    DisplayInputErrorMessage($"You must enter an integer value between {minimumValue} and {maximumValue}. Please try again.");
                    DisplayInputBoxPrompt(prompt);
                }
            }

            return true;
        }

        /// <summary>
        /// get a character race value from the user
        /// </summary>
        /// <returns>character race value</returns>
        public Character.ClassType GetClass()
        {
            string getClass = Console.ReadLine();

            Character.ClassType classType;
            Enum.TryParse<Character.ClassType>(getClass = Regex.Replace(getClass, @"(^\w)|(\s\w)", m => m.Value.ToUpper()), out classType);

            return classType;
        }
        
        /// <summary>
        /// get a random IQ for the user
        /// </summary>
        /// <returns></returns>
        public int GetIQ()
        {
            Random random = new Random();
            int AdventurerIQ = random.Next(70, 140);

            return AdventurerIQ;
        }

        /// <summary>
        /// display splash screen
        /// </summary>
        /// <returns>player chooses to play</returns>
        public bool DisplaySpashScreen()
        {
            bool playing = true;
            ConsoleKeyInfo keyPressed;

            Console.BackgroundColor = ConsoleTheme.SplashScreenBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.SplashScreenForegroundColor;
            Console.Clear();
            Console.CursorVisible = false;


            Console.SetCursorPosition(0, 10);
            string tabSpace = new String(' ', 35);
            Console.WriteLine(tabSpace + @"      ___                                         ___               _ _           ");
            Console.WriteLine(tabSpace + @"     /   \_   _ _ __   __ _  ___  ___  _ __      /   \__      _____| | | ___ _ __ ");
            Console.WriteLine(tabSpace + @"    / /\ / | | | '_ \ / _` |/ _ \/ _ \| '_ \    / /\ /\ \ /\ / / _ \ | |/ _ \ '__|");
            Console.WriteLine(tabSpace + @"   / /_//| |_| | | | | (_| |  __/ (_) | | | |  / /_//  \ V  V /  __/ | |  __/ |   ");
            Console.WriteLine(tabSpace + @"  /___,'  \__,_|_| |_|\__, |\___|\___/|_| |_| /___,'    \_/\_/ \___|_|_|\___|_|   ");
            Console.WriteLine(tabSpace + @"                      |___/                                                       ");

            Console.SetCursorPosition(80, 25);
            Console.Write("Press any key to continue or Esc to exit.");
            keyPressed = Console.ReadKey();
            if (keyPressed.Key == ConsoleKey.Escape)
            {
                playing = false;
            }

            return playing;
        }

        /// <summary>
        /// initialize the console window settings
        /// </summary>
        private static void InitializeDisplay()
        {
            //
            // control the console window properties
            //
            ConsoleWindowControl.DisableResize();
            ConsoleWindowControl.DisableMaximize();
            ConsoleWindowControl.DisableMinimize();
            Console.Title = "Dungeon Dweller";

            //
            // set the default console window values
            //
            ConsoleWindowHelper.InitializeConsoleWindow();

            Console.CursorVisible = false;
        }

        /// <summary>
        /// display the correct menu in the menu box of the game screen
        /// </summary>
        /// <param name="menu">menu for current game state</param>
        private void DisplayMenuBox(Menu menu)
        {
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuBorderColor;

            //
            // display menu box border
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MenuBoxPositionTop,
                ConsoleLayout.MenuBoxPositionLeft,
                ConsoleLayout.MenuBoxWidth,
                ConsoleLayout.MenuBoxHeight);

            //
            // display menu box header
            //
            Console.BackgroundColor = ConsoleTheme.MenuBorderColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 2, ConsoleLayout.MenuBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center(menu.MenuTitle, ConsoleLayout.MenuBoxWidth - 4));

            //
            // display menu choices
            //
            Console.BackgroundColor = ConsoleTheme.MenuBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MenuForegroundColor;
            int topRow = ConsoleLayout.MenuBoxPositionTop + 3;

            foreach (KeyValuePair<char, AdventurerAction> menuChoice in menu.MenuChoices)
            {
                if (menuChoice.Value != AdventurerAction.None)
                {
                    string formatedMenuChoice = ConsoleWindowHelper.ToLabelFormat(menuChoice.Value.ToString());
                    Console.SetCursorPosition(ConsoleLayout.MenuBoxPositionLeft + 3, topRow++);
                    Console.Write($"{menuChoice.Key}. {formatedMenuChoice}");
                }
            }
        }

        /// <summary>
        /// display the text in the message box of the game screen
        /// </summary>
        /// <param name="headerText"></param>
        /// <param name="messageText"></param>
        private void DisplayMessageBox(string headerText, string messageText)
        {
            //
            // display the outline for the message box
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxBorderColor;
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.MessageBoxPositionTop,
                ConsoleLayout.MessageBoxPositionLeft,
                ConsoleLayout.MessageBoxWidth,
                ConsoleLayout.MessageBoxHeight);

            //
            // display message box header
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBorderColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxForegroundColor;
            Console.SetCursorPosition(ConsoleLayout.MessageBoxPositionLeft + 2, ConsoleLayout.MessageBoxPositionTop + 1);
            Console.Write(ConsoleWindowHelper.Center(headerText, ConsoleLayout.MessageBoxWidth - 4));

            //
            // display the text for the message box
            //
            Console.BackgroundColor = ConsoleTheme.MessageBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.MessageBoxForegroundColor;
            List<string> messageTextLines = new List<string>();
            messageTextLines = ConsoleWindowHelper.MessageBoxWordWrap(messageText, ConsoleLayout.MessageBoxWidth - 4);

            int startingRow = ConsoleLayout.MessageBoxPositionTop + 3;
            int endingRow = startingRow + messageTextLines.Count();
            int row = startingRow;
            foreach (string messageTextLine in messageTextLines)
            {
                Console.SetCursorPosition(ConsoleLayout.MessageBoxPositionLeft + 2, row);
                Console.Write(messageTextLine);
                row++;
            }

        }

        /// <summary>
        /// draw the status box on the game screen
        /// </summary>
        public void DisplayStatusBox()
        {
            Console.BackgroundColor = ConsoleTheme.InputBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.InputBoxBorderColor;

            //
            // display the outline for the status box
            //
            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.StatusBoxPositionTop,
                ConsoleLayout.StatusBoxPositionLeft,
                ConsoleLayout.StatusBoxWidth,
                ConsoleLayout.StatusBoxHeight);

            //
            // display the text for the status box if playing game
            //
            if (_viewStatus == ViewStatus.PlayingGame)
            {
                //
                // display status box header with title
                //
                Console.BackgroundColor = ConsoleTheme.StatusBoxBorderColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
                Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 2, ConsoleLayout.StatusBoxPositionTop + 1);
                Console.Write(ConsoleWindowHelper.Center("Game Stats", ConsoleLayout.StatusBoxWidth - 4));
                Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;

                //
                // display stats
                //
                int startingRow = ConsoleLayout.StatusBoxPositionTop + 3;
                int row = startingRow;
                foreach (string statusTextLine in Text.StatusBox(_gameAdventurer))
                {
                    Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 3, row);
                    Console.Write(statusTextLine);
                    row++;
                }
            }
            else
            {
                //
                // display status box header without header
                //
                Console.BackgroundColor = ConsoleTheme.StatusBoxBorderColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
                Console.SetCursorPosition(ConsoleLayout.StatusBoxPositionLeft + 2, ConsoleLayout.StatusBoxPositionTop + 1);
                Console.Write(ConsoleWindowHelper.Center("", ConsoleLayout.StatusBoxWidth - 4));
                Console.BackgroundColor = ConsoleTheme.StatusBoxBackgroundColor;
                Console.ForegroundColor = ConsoleTheme.StatusBoxForegroundColor;
            }
        }

        /// <summary>
        /// draw the input box on the game screen
        /// </summary>
        public void DisplayInputBox()
        {
            Console.BackgroundColor = ConsoleTheme.InputBoxBackgroundColor;
            Console.ForegroundColor = ConsoleTheme.InputBoxBorderColor;

            ConsoleWindowHelper.DisplayBoxOutline(
                ConsoleLayout.InputBoxPositionTop,
                ConsoleLayout.InputBoxPositionLeft,
                ConsoleLayout.InputBoxWidth,
                ConsoleLayout.InputBoxHeight);
        }

        /// <summary>
        /// display the prompt in the input box of the game screen
        /// </summary>
        /// <param name="prompt"></param>
        public void DisplayInputBoxPrompt(string prompt)
        {
            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 1);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.Write(prompt);
            Console.CursorVisible = true;
        }

        /// <summary>
        /// display the error message in the input box of the game screen
        /// </summary>
        /// <param name="errorMessage">error message text</param>
        public void DisplayInputErrorMessage(string errorMessage)
        {
            Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + 2);
            Console.ForegroundColor = ConsoleTheme.InputBoxErrorMessageForegroundColor;
            Console.Write(errorMessage);
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
            Console.CursorVisible = true;
        }

        /// <summary>
        /// clear the input box
        /// </summary>
        private void ClearInputBox()
        {
            string backgroundColorString = new String(' ', ConsoleLayout.InputBoxWidth - 4);

            Console.ForegroundColor = ConsoleTheme.InputBoxBackgroundColor;
            for (int row = 1; row < ConsoleLayout.InputBoxHeight - 2; row++)
            {
                Console.SetCursorPosition(ConsoleLayout.InputBoxPositionLeft + 4, ConsoleLayout.InputBoxPositionTop + row);
                DisplayInputBoxPrompt(backgroundColorString);
            }
            Console.ForegroundColor = ConsoleTheme.InputBoxForegroundColor;
        }

        /// <summary>
        /// get the player's initial information at the beginning of the game
        /// </summary>
        /// <returns>adventurer object with all properties updated</returns>
        public Adventurer GetInitialAdventurerInfo()
        {
            Adventurer adventurer = new Adventurer();

            //
            // intro
            //
            DisplayGamePlayScreen("Quest Initialization", Text.InitializeQuestIntro(), ActionMenu.QuestIntro, "");
            GetContinueKey();

            //
            // get adventurer's name
            //
            DisplayGamePlayScreen("Quest Initialization - Name", Text.InitializeQuestGetAdventurerName(), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt("Enter your name: ");
            adventurer.Name = Regex.Replace(GetString(), @"(^\w)|(\s\w)", m => m.Value.ToUpper());

            //
            // get adventurer's age
            //
            DisplayGamePlayScreen("Quest Initialization - Age", Text.InitializeQuestGetAdventurerAge(adventurer.Name), ActionMenu.QuestIntro, "");
            int gameTravelerAge;

            GetInteger($"Enter your age {adventurer.Name}: ", 0, 1000000, out gameTravelerAge);
            adventurer.Age = gameTravelerAge;

            //
            // get adventurer's race
            //
            DisplayGamePlayScreen("Quest Initialization - Class", Text.InitializeQuestGetAdventurerClass(adventurer), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt($"Enter your class {adventurer.Name}: ");
            adventurer.Class = GetClass();

            //
            // get adventurer's IQ
            //
            DisplayGamePlayScreen("Quest Beginnings - IQ", Text.InitializeMissionGetAdventurerIQ(adventurer), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt($"Press ENTER to continue.");
            GetContinueKey();
            adventurer.IQ = GetIQ();

            //
            // get adventurer's health potions
            //
            DisplayGamePlayScreen("Quest Beginnings - Health Potions", Text.InitializeMissionGetAdventurerHealthPotions(adventurer), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt($"Press ENTER to continue.");
            GetContinueKey();
            adventurer.HealthPotions = 3;

            //
            // echo the adventurer's info
            //
            DisplayGamePlayScreen("Quest Initialization - Complete", Text.InitializeQuestEchoAdventurerInfo(adventurer), ActionMenu.QuestIntro, "");
            GetContinueKey();

            // 
            // change view status to playing game
            //
            _viewStatus = ViewStatus.PlayingGame;

            return adventurer;
        }

        #region ----- display responses to menu action choices -----

        public void DisplayAdventurerInfo()
        {
            DisplayGamePlayScreen("Adventurer Information", Text.AdventurerInfo(_gameAdventurer), ActionMenu.MainMenu, "");
        }

        public Adventurer DisplayEditAdventurerInfo(Adventurer adventurer)
        {
            string updateAdventurer = "";

            // Update Name
            DisplayGamePlayScreen("Edit Adventurer Information - Name", Text.AdventurerEditInfo(_gameAdventurer), ActionMenu.MainMenu, "");
            DisplayInputBoxPrompt("Enter name: ");
            updateAdventurer = Regex.Replace(GetString(), @"(^\w)|(\s\w)", m => m.Value.ToUpper());
            if (updateAdventurer != "")
            {
                adventurer.Name = updateAdventurer;
            }

            // Update Age
            DisplayGamePlayScreen("Edit Adventurer Information - Age", Text.AdventurerEditInfo(_gameAdventurer), ActionMenu.MainMenu, "");
            DisplayInputBoxPrompt("Enter Age: ");
            int adventurerAge;

            GetInteger($"Enter your age {adventurer.Name}: ", 0, 1000000, out adventurerAge);
            adventurer.Age = adventurerAge;

            // Update Class
            DisplayGamePlayScreen("Edit Adventurer Information - Class", Text.InitializeQuestGetAdventurerClass(adventurer), ActionMenu.QuestIntro, "");
            DisplayInputBoxPrompt($"Enter your race {adventurer.Name}: ");

            adventurer.Class = GetClass();

            // Display new info
            DisplayGamePlayScreen("Adventurer Information", Text.AdventurerInfo(adventurer), ActionMenu.MainMenu, "");

            return adventurer;
        }

        public void DisplayListOfDungeonLocations()
        {
            DisplayGamePlayScreen("List: Dungeon Locations", Text.ListDungeonLocations(_gameDungeon.SpaceTimeLocations),
                ActionMenu.MainMenu, "");
        }

        public void DisplayLookAround()
        {
            DungeonLocation currentSpaceTimeLocation = _gameDungeon.GetSpaceTimeLocationById(_gameAdventurer.DungeonLocationID);
            DisplayGamePlayScreen("Current Location", Text.LookAround(currentSpaceTimeLocation), ActionMenu.MainMenu, "");
        }

        public int DisplayGetNextDungeonLocation()
        {
            int spaceTimeLocationId = 0;
            bool validSpaceTimeLocationID = false;

            DisplayGamePlayScreen("Travel to a new Dungeon Location", Text.Travel(_gameAdventurer, _gameDungeon.SpaceTimeLocations),
                ActionMenu.MainMenu, "");

            while (!validSpaceTimeLocationID)
            {
                //
                // get an integer from the player
                //
                GetInteger($"Enter your new location {_gameAdventurer.Name}: ", 1, _gameDungeon.GetMaxSpaceTimeLocationId(), out spaceTimeLocationId);

                //
                // validate integer as a valid space-time location id and determine accessibility
                //
                if (_gameDungeon.IsValidSpaceTimeLocationId(spaceTimeLocationId))
                {
                    if (_gameDungeon.GetSpaceTimeLocationById(spaceTimeLocationId).Accessable)
                    {
                        validSpaceTimeLocationID = true;
                    }
                    else
                    {
                        ClearInputBox();
                        DisplayInputErrorMessage("It appears you are attempting to travel to an inaccessable location. Please select another location.");
                    }
                }
                else
                {
                    DisplayInputErrorMessage("It appears you entered an invalid space-time location id. Please try again.");
                }
            }
            return spaceTimeLocationId;
        }

        public void DisplayLocationsVisited()
        {
            //
            // generate a list of dungeon locatinos that have been visited
            //
            List<DungeonLocation> visitedSpaceTimeLocations = new List<DungeonLocation>();
            foreach (int spaceTimeLocationID in _gameAdventurer.DungeonLocationsVisited)
            {
                visitedSpaceTimeLocations.Add(_gameDungeon.GetSpaceTimeLocationById(spaceTimeLocationID));
            }

            DisplayGamePlayScreen("Dungeon Locations Visited", Text.VisitedLocations(visitedSpaceTimeLocations), ActionMenu.MainMenu, "");
        }

        #endregion

        #endregion
    }
}
