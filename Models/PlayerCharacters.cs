using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel;

namespace BattleAbacus_D20_Modern.Models
{
    public class PlayerCharacters
    {
        [Key]
        public int PlayerCharacterId { get; set; }
        public string PlayerCharacterName { get; set; }
        public int HitPoints { get; set; }
        public int ActionPoints { get; set; }
        public List<CharacterClasses> Classes { get; set; }

    }
}