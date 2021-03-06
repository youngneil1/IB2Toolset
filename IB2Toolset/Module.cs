﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.IO;
using System.ComponentModel;
using System.Drawing;
using Newtonsoft.Json;
//using IceBlink;

namespace IB2Toolset
{
    public class Module
    {
        #region Fields
        //private string moduleFolderName = "";
        private string _moduleName = "";
        private string _moduleLabelName = "";
        private int _moduleVersion = 1;
        public string saveName = "empty";
        private string _defaultPlayerFilename = "drin.json";
        private bool _mustUsePreMadePC = false;
        private int _numberOfPlayerMadePcsAllowed = 1;
        private int maxPartySize = 6;
        private string _moduleDescription = "";
        private string _moduleCredits = "<big><b>Lanterna - The Exile</b></big><BR><BR>"
						+ "-Story, coding and some art by <b>slowdive_fan</b><BR><BR>"
						+ "-Portrait art by Bree Arts<BR><BR>"
						+ "<i>(an IceBlink Engine conversion to Android)</i><BR><BR>"						
						+ "visit the forums for more info:<BR>"
						+ "www.iceblinkengine.com/forums";
        private int _nextIdNumber = 100;
        private int worldTime = 0;
        public int TimePerRound = 6;
        public bool debugMode = true;
        public List<Item> moduleItemsList = new List<Item>();
        public List<Encounter> moduleEncountersList = new List<Encounter>();
        public List<Container> moduleContainersList = new List<Container>();
        public List<Shop> moduleShopsList = new List<Shop>();
        public List<Creature> moduleCreaturesList = new List<Creature>();
        public List<JournalQuest> moduleJournal = new List<JournalQuest>();
        public List<PlayerClass> modulePlayerClassList = new List<PlayerClass>();
        public List<Race> moduleRacesList = new List<Race>();
        public List<Spell> moduleSpellsList = new List<Spell>();
        public List<Trait> moduleTraitsList = new List<Trait>();
        public List<Effect> moduleEffectsList = new List<Effect>();
        public List<string> moduleAreasList = new List<string>();
        public List<string> moduleConvosList = new List<string>();
        public List<string> moduleLogicTreesList = new List<string>();
        public List<string> moduleIBScriptsList = new List<string>();
        public List<Area> moduleAreasObjects = new List<Area>();
        public List<GlobalInt> moduleGlobalInts = new List<GlobalInt>();
        public List<GlobalString> moduleGlobalStrings = new List<GlobalString>();
        public List<ConvoSavedValues> moduleConvoSavedValuesList = new List<ConvoSavedValues>();
        public List<GlobalListItem> ModuleGlobalListItems = new List<GlobalListItem>();
        public List<LocalListItem> ModuleLocalListItems = new List<LocalListItem>();
        private string _startingArea = "";
        private int _startingPlayerPositionX = 0;
        private int _startingPlayerPositionY = 0;
        public int playerLocationX = 0;
        public int playerLocationY = 0;
        public int playerLastLocationX = 0;
        public int playerLastLocationY = 0;
        private int _partyGold = 0;
        public bool showPartyToken = false;
        private string _partyTokenFilename = "prp_party";
	    public List<Player> playerList = new List<Player>();
		//public List<Item> partyInventoryList = new List<Item>();
	    //public List<string> partyInventoryTagList = new List<string>();
        public List<ItemRefs> partyInventoryRefsList = new List<ItemRefs>();
	    public List<JournalQuest> partyJournalQuests = new List<JournalQuest>();
	    public List<JournalQuest> partyJournalCompleted = new List<JournalQuest>();
	    public string partyJournalNotes = "";
	    public int selectedPartyLeader = 0;
		public bool returnCheck = false;
		public bool addPCScriptFired = false;
		public bool uncheckConvo = false;
		public bool removeCreature = false;
		public bool deleteItemUsedScript = false;
		public int indexOfPCtoLastUseItem = 0;
	    public bool com_showGrid = false;
	    public bool playMusic = false;
	    public bool playButtonSounds = false;
	    public bool playButtonHaptic = false;
	    public bool showTutorialParty = true;
	    public bool showTutorialInventory = true;
	    public bool showTutorialCombat = true;
	    public bool showAutosaveMessage = true;
	    public bool allowAutosave = true;
        public int combatAnimationSpeed = 100;
        private string onHeartBeatLogicTree = "none";
        private string onHeartBeatParms = "";
        #endregion

        #region Properties
        [CategoryAttribute("01 - Main"), DescriptionAttribute("FileName of the Module and the Folder name as well (no spaces allowed)")]
        public string moduleName
        {
            get { return _moduleName; }
            set { _moduleName = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Name of the Module displayed to the player")]
        public string moduleLabelName
        {
            get { return _moduleLabelName; }
            set { _moduleLabelName = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Version of module (must be an integer...1,2,3,4,etc.)")]
        public int moduleVersion
        {
            get { return _moduleVersion; }
            set { _moduleVersion = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Filename of the Player to use as the default starting PC or the forced pre-made PC if that flag (mustUsePreMadePC) is true.")]
        public string defaultPlayerFilename
        {
            get { return _defaultPlayerFilename; }
            set { _defaultPlayerFilename = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Set this flag to true if you only want the player to use the pre-made PC identified in defaultPlayerFilename property. The player will not be given an option to create a character.")]
        public bool mustUsePreMadePC
        {
            get { return _mustUsePreMadePC; }
            set { _mustUsePreMadePC = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("The total number of player made characters allowed in the party (default is 1, max PCs in a party is 6)")]
        public int numberOfPlayerMadePcsAllowed
        {
            get { return _numberOfPlayerMadePcsAllowed; }
            set {
                    if (value > 6)
                    {
                        _numberOfPlayerMadePcsAllowed = 6;
                    }
                    else if (value < 1)
                    {
                        _numberOfPlayerMadePcsAllowed = 1;
                    }
                    else
                    {
                        _numberOfPlayerMadePcsAllowed = value;
                    }
                }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("The maximum total number of players that can be in the party (only values of 1-6 accepted)")]
        public int MaxPartySize
        {
            get { return maxPartySize; }
            set {
                    if (value > 6)
                    {
                        maxPartySize = 6;
                    }
                    else if (value < 1)
                    {
                        maxPartySize = 1;
                    }
                    else
                    {
                        maxPartySize = value;
                    }
                }
        }
        [Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Description of the Module")]
        public string moduleDescription
        {
            get { return _moduleDescription; }
            set { _moduleDescription = value; }
        }

        [Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Text to show up when the 'Credits' button is pressed (use html tags for formatting <b><i><u><br><big><small><tt><h1>…<h6><div><p><font>)")]
        public string moduleCredits
        {
            get { return _moduleCredits; }
            set { _moduleCredits = value; }
        }

        [CategoryAttribute("01 - Main"), DescriptionAttribute("Used for making unique Tags"), ReadOnly(true)]
        public int nextIdNumber
        {
            get
            {
                _nextIdNumber++;
                return _nextIdNumber;
            }
            set { _nextIdNumber = value; }
        }

        [CategoryAttribute("01 - Main"), DescriptionAttribute("Current value for World Time in generic units")]
        public int WorldTime
        {
            get { return worldTime; }
            set { worldTime = value; }
        }

        [CategoryAttribute("01 - Main"), DescriptionAttribute("Filename of starting Area (DO NOT include \".lvl\" extension)")]
        public string startingArea
        {
            get { return _startingArea; }
            set { _startingArea = value; }
        }
        
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Starting X location in starting area")]
        public int startingPlayerPositionX
        {
            get { return _startingPlayerPositionX; }
            set { _startingPlayerPositionX = value; }
        }

        [CategoryAttribute("01 - Main"), DescriptionAttribute("Starting Y location in starting area")]
        public int startingPlayerPositionY
        {
            get { return _startingPlayerPositionY; }
            set { _startingPlayerPositionY = value; }
        }

        [CategoryAttribute("01 - Main"), DescriptionAttribute("Starting party gold")]
        public int partyGold
        {
            get { return _partyGold; }
            set { _partyGold = value; }
        }

        [CategoryAttribute("01 - Main"), DescriptionAttribute("filename of the default party token image (minus the extension)")]
        public string partyTokenFilename
        {
            get { return _partyTokenFilename; }
            set { _partyTokenFilename = value; }
        }

        [Browsable(true), TypeConverter(typeof(LogicTreeConverter))]
        [CategoryAttribute("02 - LogicTree Hooks"), DescriptionAttribute("LogicTree name to be run at the end of each move on any area map (not combat)")]
        public string OnHeartBeatLogicTree
        {
            get { return onHeartBeatLogicTree; }
            set { onHeartBeatLogicTree = value; }
        }
        [CategoryAttribute("02 - LogicTree Hooks"), DescriptionAttribute("Parameters to be used for this LogicTree hook (as many parameters as needed, comma deliminated with no spaces)")]
        public string OnHeartBeatParms
        {
            get { return onHeartBeatParms; }
            set { onHeartBeatParms = value; }
        }

        #endregion

        public Module()
        {
        }
        public void saveModuleFile(string filename)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(json.ToString());
            }
        }
        public Module loadModuleFile(string filename)
        {
            Module toReturn = null;

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                toReturn = (Module)serializer.Deserialize(file, typeof(Module));
            }
            return toReturn;
        }
        public void loadAreas(string path)
        {
            Area newArea = new Area();
            foreach (string areaName in moduleAreasList)
            {
                try
                {
                    newArea = newArea.loadAreaFile(path + areaName + ".level");
                    if (newArea == null)
                    {
                        MessageBox.Show("returned a null area filling areaList");
                    }
                    moduleAreasObjects.Add(newArea);
                    //MessageBox.Show("open file success");
                }
                catch (Exception ex)
                {
                    MessageBox.Show("failed to open all files: " + ex.ToString() + ex.Message);
                }
            }
        }     
    }
}
