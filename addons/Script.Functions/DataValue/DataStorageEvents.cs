﻿using System;

namespace Chris.OS.Additions.Script.Functions.DataValue
{
    class DataStorageEvents
    {
        #region Events
        public static Action<string, string, string> onSetDataValue;
        public static Action<string, string> onDeleteDataValue;
        public static Action onRateLimit;
        #endregion
    }
}
