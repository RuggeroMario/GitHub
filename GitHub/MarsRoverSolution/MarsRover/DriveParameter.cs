using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MarsRover
{
    struct DriveCommand
    {
        public const string Forward = "F";
        public const string Back = "B";
        public const string Left = "L";
        public const string Right = "R";
    }

    struct DriveDegrees
    {
        public const double TurnToLeft = -90;
        public const double TurnToRigth = +90;
    }

    struct CardinalPoints
    { 
        public const double Est = 90;
        public const double Sud = 180;
        public const double Ovest = 270;
        public const double Nord = 0;
    }

    struct StraigthDirection
    {
        public const int Forward = 1;
        public const int Back    = -1;
    }

    struct StopLights
    {
        public const int On = 1;
        public const int Off = 0;
    }
}
