﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using Newtonsoft.Json.Linq;

namespace EzChallBase.Modules
{
    class SpellDBService
    {
        public static void ParseSpellDBData()
        {
            //https://github.com/hyperlegendd/SpellDB_10.25.1json/blob/main/SpellDB_12.25.1.json
            try
            {
                string SpellDBDataString = File.ReadAllText(Directory.GetCurrentDirectory() + @"\SpellDB.json");
                string championName = Game.Objects.LocalPlayer.GetChampionName().Replace(" ", string.Empty);
                
                Game.Spells.SpellBook.SpellDB = JObject.Parse(SpellDBDataString)[championName].ToObject<JObject>();

                LogService.Log("Successfully Parsed SpellDB.");
            }
            catch (Exception Ex)
            {
                LogService.Log(Ex.ToString(), Enums.LogLevel.Error);
                throw new Exception("SpellDBParseExecption");
            }
        }
    }
}
