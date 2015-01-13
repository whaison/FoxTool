using System.Collections.Generic;
using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppCautionLocatorSetData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public List<FoxEntityLink> CautionLocators { get; set; }
    }
}
