﻿using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;
using System.Collections;
using System.Text;
using System.IO;
//using IceBlink;
using System.ComponentModel;
using Newtonsoft.Json;

namespace IB2Toolset
{
    public class Area
    {        
        #region Fields
        private string filename = "newArea";
        private string imageFileName = "newArea.jpg";
        private int mapSizeX = 16;
        private int mapSizeY = 16;
        private bool isWorldMap = false;
        private bool useMiniMapFogOfWar = false;
        private bool _areaDark = false;
        private bool useDayNightCycle = false;
        private int timePerSquare = 6;              //currently in minutes
        private string areaMusic = "none";
        private int areaMusicDelay = 0;
        private int areaMusicDelayRandomAdder = 0;
        private string areaSounds = "none";
        private int areaSoundsDelay = 0;
        private int areaSoundsDelayRandomAdder = 0;
        private List<Tile> tiles = new List<Tile>();
        private List<Prop> props = new List<Prop>();
        private List<Trigger> triggers = new List<Trigger>();
        //private string musicFileName = "forest.mp3";
        private int nextIdNumber = 100;
        private string onHeartBeatLogicTree = "none";
        private string onHeartBeatParms = "";
        private List<LocalInt> areaLocalInts = new List<LocalInt>();
        private List<LocalString> areaLocalStrings = new List<LocalString>();
        
        #endregion

        #region Properties
        [CategoryAttribute("01 - Main"), ReadOnly(true)]
        public string Filename
        {
            get { return filename; }
            set { filename = value; }
        }
        [CategoryAttribute("01 - Main"), ReadOnly(true)]
        public bool IsWorldMap
        {
            get { return isWorldMap; }
            set { isWorldMap = value; }
        }
        [CategoryAttribute("01 - Main")]
        public bool UseMiniMapFogOfWar
        {
            get { return useMiniMapFogOfWar; }
            set { useMiniMapFogOfWar = value; }
        }
        [CategoryAttribute("01 - Main")]
        public bool areaDark
        {
            get { return _areaDark; }
            set { _areaDark = value; }
        }
        [CategoryAttribute("01 - Main")]
        public bool UseDayNightCycle
        {
            get { return useDayNightCycle; }
            set { useDayNightCycle = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("How much game world time passes with each square move (in minutes)")]
        public int TimePerSquare
        {
            get { return timePerSquare; }
            set { timePerSquare = value; }
        }
        [CategoryAttribute("01 - Main"), ReadOnly(true)]
        public string ImageFileName
        {
            get { return imageFileName; }
            set { imageFileName = value; }
        }
        [CategoryAttribute("01 - Main"), ReadOnly(true)]
        public int MapSizeX
        {
            get { return mapSizeX; }
            set { mapSizeX = value; }
        }
        [CategoryAttribute("01 - Main"), ReadOnly(true)]
        public int MapSizeY
        {
            get { return mapSizeY; }
            set { mapSizeY = value; }
        }
        [CategoryAttribute("Misc"), ReadOnly(true), Browsable(false)]
        public List<Tile> Tiles
        {
            get { return tiles; }
            set { tiles = value; }
        }
        [CategoryAttribute("Misc"), ReadOnly(true)]
        public List<Prop> Props
        {
            get { return props; }
            set { props = value; }
        }
        [CategoryAttribute("Misc"), ReadOnly(true)]
        public List<Trigger> Triggers
        {
            get { return triggers; }
            set { triggers = value; }
        }
        [Browsable(true), TypeConverter(typeof(MusicConverter))]
        [CategoryAttribute("02 - Music/Sounds"), DescriptionAttribute("Filename of music for the area (include extension)")]
        public string AreaMusic
        {
            get { return areaMusic; }
            set { areaMusic = value; }
        }
        [CategoryAttribute("02 - Music/Sounds"), DescriptionAttribute("Delay between replaying music (in milliseconds)")]
        public int AreaMusicDelay
        {
            get { return areaMusicDelay; }
            set { areaMusicDelay = value; }
        }
        [CategoryAttribute("02 - Music/Sounds"), DescriptionAttribute("Add a random amount of delay (between 0 and this value) to the AreaMusicDelay value (in milliseconds)")]
        public int AreaMusicDelayRandomAdder
        {
            get { return areaMusicDelayRandomAdder; }
            set { areaMusicDelayRandomAdder = value; }
        }
        [Browsable(true), TypeConverter(typeof(MusicConverter))]
        [CategoryAttribute("02 - Music/Sounds"), DescriptionAttribute("Filename of sounds for the area (include extension)")]
        public string AreaSounds
        {
            get { return areaSounds; }
            set { areaSounds = value; }
        }
        [CategoryAttribute("02 - Music/Sounds"), DescriptionAttribute("Delay between replaying area sounds (in milliseconds)")]
        public int AreaSoundsDelay
        {
            get { return areaSoundsDelay; }
            set { areaSoundsDelay = value; }
        }
        [CategoryAttribute("02 - Music/Sounds"), DescriptionAttribute("Add a random amount of delay (between 0 and this value) to the AreaSoundsDelay value (in milliseconds)")]
        public int AreaSoundsDelayRandomAdder
        {
            get { return areaSoundsDelayRandomAdder; }
            set { areaSoundsDelayRandomAdder = value; }
        }
        [CategoryAttribute("Misc"), ReadOnly(true)]
        public int NextIdNumber
        {
            get
            {
                nextIdNumber++;
                return nextIdNumber;
            }
            set { nextIdNumber = value; }
        }

        [Browsable(true), TypeConverter(typeof(LogicTreeConverter))]
        [CategoryAttribute("03 - LogicTree Hooks"), DescriptionAttribute("LogicTree name to be run at the end of each move on this area map (not combat)")]
        public string OnHeartBeatLogicTree
        {
            get { return onHeartBeatLogicTree; }
            set { onHeartBeatLogicTree = value; }
        }
        [CategoryAttribute("03 - LogicTree Hooks"), DescriptionAttribute("Parameters to be used for this LogicTree hook (as many parameters as needed, comma deliminated with no spaces)")]
        public string OnHeartBeatParms
        {
            get { return onHeartBeatParms; }
            set { onHeartBeatParms = value; }
        }
        [CategoryAttribute("04 - Locals"), DescriptionAttribute("These Local Variables will be saved in the save games")]
        public List<LocalInt> AreaLocalInts
        {
            get { return areaLocalInts; }
            set { areaLocalInts = value; }
        }
        [CategoryAttribute("04 - Locals"), DescriptionAttribute("These Local Variables will be saved in the save games")]
        public List<LocalString> AreaLocalStrings
        {
            get { return areaLocalStrings; }
            set { areaLocalStrings = value; }
        }
        #endregion
        
        public Area()
        {
        }

        public void saveAreaFile(string path)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(path))
            {
                sw.Write(json.ToString());
            }
        }
        public Area loadAreaFile(string path)
        {
            Area toReturn = null;

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(path))
            {
                JsonSerializer serializer = new JsonSerializer();
                toReturn = (Area)serializer.Deserialize(file, typeof(Area));
            }
            return toReturn;
        }
        public Trigger getTriggerByTag(string tag)
        {
            foreach (Trigger it in Triggers)
            {
                if (it.TriggerTag == tag) return it;
            }
            return null;
        }
    }    
}
