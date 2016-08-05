using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BattleAbacus_D20_Modern.Models
{
    public class CharacterClasses
    {
        [Key]
        public int ClassId { get; set; }
        public string ClassName { get; set; }

        //ie d6 is 6, d8 is 8...etc
        public int HitDieNumber { get; set; }

        //save progression, element stores the value, index is the class level -1
        public int[] FortitudeSave { get; set; }
        public int[] ReflexSave { get; set; }
        public int[] WillSave { get; set; }


    }
}