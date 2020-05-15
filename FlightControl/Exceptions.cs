﻿using System;

namespace FlightControl
{
    namespace Exceptions
    {
        public class MapLoadingException : Exception
        {
            public MapLoadingException() { }
            public MapLoadingException(string message) : base(message) { }
        }
        public class TerrainLoadingException : Exception
        {
            public TerrainLoadingException() { }
            public TerrainLoadingException(string message) : base(message) { }
        }
        public class NotEnoughElementsException : Exception
        {
            public NotEnoughElementsException() { }
            public NotEnoughElementsException(string message) : base(message) { }
        }
        public class LinesNotConnectedException : Exception
        {
            public LinesNotConnectedException() { }
            public LinesNotConnectedException(string message) : base(message) { }
        }
    }
}
