﻿using System.Collections.Generic;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class ChDamageSet : Data
    {
        public List<FoxEntityLink> Rules { get; set; }
        public List<FoxEntityLink> Damages { get; set; }
    }
}
