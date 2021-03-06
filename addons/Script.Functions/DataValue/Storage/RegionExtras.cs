﻿using log4net;
using Nini.Config;
using OpenSim.Region.Framework.Scenes;
using System;
using System.Reflection;

namespace Chris.OS.Additions.Script.Functions.DataValue.Storage
{
    class RegionExtras : iStorage
    {
        private static readonly ILog m_log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);

        private Scene m_scene = null;

        public RegionExtras(Scene scene, IConfig config)
        {
            m_scene = scene;
        }

        public bool check(String storageID, string key)
        {
            if (m_scene.GetExtraSetting("V:" + key) != "")
                return true;

            return false;
        }

        public string get(String storageID, string key)
        {
            return m_scene.GetExtraSetting("V:" + key);
        }

        public void remove(string storageID, string key)
        {
            throw new NotImplementedException();
        }

        public void save(string key, String storageID, string data)
        {
            m_scene.StoreExtraSetting("V:" + key, data);
        }
    }
}
