﻿/*
 * UnityUtilityLibrary
 * Copyright (C) 2017 Jan Vytrisal
 * 
 * This program is free software: you can redistribute it and/or modify
 * it under the terms of the GNU General Public License as published by
 * the Free Software Foundation, version 3 of the License only.
 * 
 * This program is distributed in the hope that it will be useful,
 * but WITHOUT ANY WARRANTY; without even the implied warranty of
 * MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
 * GNU General Public License for more details.
 * 
 * You should have received a copy of the GNU General Public License
 * along with this program.  If not, see <http://www.gnu.org/licenses/>
 */

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

