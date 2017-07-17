using System;

namespace UnityUtilityLibrary
{
    public class DataType
    {
        public enum Direction { Left, Right, Up, Down, Forward, Backward, Plus, Minus };
        public enum Axis { X = 0, Y = 1, Z = 2 };
        public enum Sign { Negative = -1, Positive = 1 };
    }
}

