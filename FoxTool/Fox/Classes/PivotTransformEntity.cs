﻿using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    internal class PivotTransformEntity : DataElement
    {
        // Static properties
        public FoxEntityHandle Owner { get; set; }
        // name=pivotTransform_pivot
        public FoxVector3 PivotTransformPivot { get; set; }
        // name=pivotTransform_pivotTranslation
        public FoxVector3 PivotTransformPivotTranslation { get; set; }
    }
}
