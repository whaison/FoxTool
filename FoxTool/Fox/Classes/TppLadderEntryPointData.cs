using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppLadderEntryPointData
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxEntityHandle Parent { get; set; }
        public FoxEntityPtr Transform { get; set; }
        public FoxEntityPtr ShearTransform { get; set; }
        public FoxEntityPtr PivotTransform { get; set; }
        public FoxEntityHandle Children { get; set; }
        public FoxUInt32 Flags { get; set; }
        public FoxInt32 EntryType { get; set; }
        public FoxUInt32 LocateStep { get; set; }
        public FoxEntityLink LadderHandle { get; set; }
    }
}
