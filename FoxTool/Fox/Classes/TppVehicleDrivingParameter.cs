using FoxTool.Fox.Types;
using FoxTool.Fox.Types.Structs;

namespace FoxTool.Fox.Classes
{
    public class TppVehicleDrivingParameter
    {
        // Static properties
        public FoxString Name { get; set; }
        public FoxEntityHandle DataSet { get; set; }
        public FoxFloat PidSpeedKp { get; set; }
        public FoxFloat PidSpeedTi { get; set; }
        public FoxFloat PidSpeedTd { get; set; }
        public FoxFloat PidSpeedEta { get; set; }
        public FoxFloat PidSpeedDt { get; set; }
        public FoxFloat PidSteeringKp { get; set; }
        public FoxFloat PidSteeringTi { get; set; }
        public FoxFloat PidSteeringTd { get; set; }
        public FoxFloat PidSteeringEta { get; set; }
        public FoxFloat PidSteeringDt { get; set; }
        public FoxFloat SteeringPredictFutureTime { get; set; }
        public FoxVector3 SteeringControleOffset { get; set; }
        public FoxFloat AdjustOffset { get; set; }
        public FoxFloat SteeringMargin { get; set; }
        public FoxFloat MinimumTurningRadius { get; set; }
    }
}
