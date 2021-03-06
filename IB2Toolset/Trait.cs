﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Xml.Serialization;
using System.Windows.Forms;
using System.IO;
using System.Drawing;
using System.ComponentModel;
using Newtonsoft.Json;
//using IceBlink;

namespace IB2Toolset
{
    /*public class Traits
    {
        public List<Trait> traitList = new List<Trait>();

        public Traits()
        {
        }
        public void saveTraitsFile(string filename)
        {
            string json = JsonConvert.SerializeObject(this, Newtonsoft.Json.Formatting.Indented);
            using (StreamWriter sw = new StreamWriter(filename))
            {
                sw.Write(json.ToString());
            }
        }
        public Traits loadTraitsFile(string filename)
        {
            Traits toReturn = null;

            // deserialize JSON directly from a file
            using (StreamReader file = File.OpenText(filename))
            {
                JsonSerializer serializer = new JsonSerializer();
                toReturn = (Traits)serializer.Deserialize(file, typeof(Traits));
            }
            return toReturn;
        }
        public Trait getTraitByTag(string tag)
        {
            foreach (Trait ts in traitList)
            {
                if (ts.tag == tag) return ts;
            }
            return null;
        }
        public Trait getTraitByName(string name)
        {
            foreach (Trait ts in traitList)
            {
                if (ts.name == name) return ts;
            }
            return null;
        }
    }*/

    public class Trait
    {        
        #region Fields        
        private string _name = "newTrait"; //item name
        private string _tag = "newTraitTag"; //item unique tag name
        private string _traitImage = "sp_magebolt";
        private string _description = "";
        private string _prerequisiteTrait = "none";
        private int _skillModifier = 0;
        private string _skillModifierAttribute = "str";
        //private UsableInSituation useableInSituation = UsableInSituation.Always;
        private string _useableInSituation = "Always";
        private string _spriteFilename = "none";
        private string _spriteEndingFilename = "none";
        private int _costSP = 0;
        private string _traitTargetType = "Enemy";
        //private TargetType spellTargetType = TargetType.Enemy;
        private string _traitEffectType = "Damage";
        //private EffectType spellEffectType = EffectType.Damage;
        private int _aoeRadius = 0;
        private int _range = 0;
        //private ScriptSelectEditorReturnObject spellScript = new ScriptSelectEditorReturnObject();
        private string _traitScript = "none";
        #endregion

        #region Properties  
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Name of the Trait")]
        public string name
        {
            get
            {
                return _name;
            }
            set
            {
                _name = value;
            }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Tag of the Trait (Must be unique)")]
        public string tag
        {
            get
            {
                return _tag;
            }
            set
            {
                _tag = value;
            }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Image icon of the Trait")]
        public string traitImage
        {
            get
            {
                return _traitImage;
            }
            set
            {
                _traitImage = value;
            }
        }
        [Editor(typeof(MultilineStringEditor), typeof(System.Drawing.Design.UITypeEditor))]
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Detailed description of trait with some stats and cost as well")]
        public string description
        {
            get
            {
                return _description;
            }
            set
            {
                _description = value;
            }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("tag of the prerequisite trait if there is one, else use 'none'")]
        public string prerequisiteTrait
        {
            get { return _prerequisiteTrait; }
            set { _prerequisiteTrait = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("The modifier value used during skill checks if this trait is a skill type")]
        public int skillModifier
        {
            get { return _skillModifier; }
            set { _skillModifier = value; }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("If the trait is a skill type trait, this is the attribute that is used for additional modifiers to skill check (str, dex, int, cha)")]
        public string skillModifierAttribute
        {
            get { return _skillModifierAttribute; }
            set { _skillModifierAttribute = value; }
        }
        /*[CategoryAttribute("01 - Main"), DescriptionAttribute("When can this be used: Always means that it can be used in combat and on the main maps, Passive means that it is always on and doesn't need to be activated.")]
        public UsableInSituation UseableInSituation
        {
            get { return useableInSituation; }
            set { useableInSituation = value; }
        }*/
        [CategoryAttribute("01 - Main"), DescriptionAttribute("When can this be used: Always means that it can be used in combat and on the main maps, Passive means that it is always on and doesn't need to be activated.")]
        public string useableInSituation
        {
            get { return _useableInSituation; }
            set { _useableInSituation = value; }
        }
        //[Browsable(true), TypeConverter(typeof(SpriteConverter))]
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Sprite to use for the effect (Sprite Filename with extension)")]
        public string spriteFilename
        {
            get
            {
                return _spriteFilename;
            }
            set
            {
                _spriteFilename = value;
            }
        }
        //[Browsable(true), TypeConverter(typeof(SpriteConverter))]
        [CategoryAttribute("01 - Main"), DescriptionAttribute("Sprite to use for the ending effect (Sprite Filename with extension)")]
        public string spriteEndingFilename
        {
            get
            {
                return _spriteEndingFilename;
            }
            set
            {
                _spriteEndingFilename = value;
            }
        }
        [CategoryAttribute("01 - Main"), DescriptionAttribute("How much SP this Trait costs")]
        public int costSP
        {
            get
            {
                return _costSP;
            }
            set
            {
                _costSP = value;
            }
        }
        /*[CategoryAttribute("02 - Target"), DescriptionAttribute("The type of target for this spell")]
        public TargetType SpellTargetType
        {
            get
            {
                return spellTargetType;
            }
            set
            {
                spellTargetType = value;
            }
        }*/
        [CategoryAttribute("02 - Target"), DescriptionAttribute("The type of target for this trait")]
        public string traitTargetType
        {
            get
            {
                return _traitTargetType;
            }
            set
            {
                _traitTargetType = value;
            }
        }
        /*[CategoryAttribute("03 - Effect"), DescriptionAttribute("damage = persistent, negative; heal = persistent, positive; buff = temporary, positive; debuff = temporary, negative")]
        public EffectType SpellEffectType
        {
            get
            {
                return spellEffectType;
            }
            set
            {
                spellEffectType = value;
            }
        }*/
        [CategoryAttribute("03 - Effect"), DescriptionAttribute("damage = persistent, negative; heal = persistent, positive; buff = temporary, positive; debuff = temporary, negative")]
        public string traitEffectType
        {
            get
            {
                return _traitEffectType;
            }
            set
            {
                _traitEffectType = value;
            }
        }
        [CategoryAttribute("02 - Target"), DescriptionAttribute("the radius of the AoE")]
        public int aoeRadius
        {
            get
            {
                return _aoeRadius;
            }
            set
            {
                _aoeRadius = value;
            }
        }
        [CategoryAttribute("02 - Target"), DescriptionAttribute("the range allowed to the center or beginning of the AoE")]
        public int range
        {
            get
            {
                return _range;
            }
            set
            {
                _range = value;
            }
        }
        /*[CategoryAttribute("01 - Main"), DescriptionAttribute("the script to use for this Spell")]
        [Editor(typeof(ScriptSelectEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public ScriptSelectEditorReturnObject SpellScript
        {
            get { return spellScript; }
            set { spellScript = value; }
        }*/
        [CategoryAttribute("01 - Main"), DescriptionAttribute("the script to use for this Spell")]
        //[Editor(typeof(ScriptSelectEditor), typeof(System.Drawing.Design.UITypeEditor))]
        public string traitScript
        {
            get { return _traitScript; }
            set { _traitScript = value; }
        }
        #endregion

        public Trait()
        {            
        }
        public override string ToString()
        {
            return name;
        }
        public Trait ShallowCopy()
        {
            return (Trait)this.MemberwiseClone();
        }
        public Trait DeepCopy()
        {
            Trait other = (Trait)this.MemberwiseClone();
            return other;
        }
    }
}
