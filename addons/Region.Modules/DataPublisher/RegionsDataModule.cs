﻿using Mono.Addins;
using OpenSim.Region.Framework.Interfaces;
using System;
using System.Collections.Generic;
using Nini.Config;
using OpenSim.Region.Framework.Scenes;
using log4net;
using System.Reflection;
using OpenSim.Framework.Servers.HttpServer;
using OpenSim.Framework.Servers;

namespace Chris.OS.Additions.Region.Modules.DataPublisher
{
    [Extension(Path = "/OpenSim/RegionModules", NodeName = "RegionModule", Id = "RegionsDataModule")]
    public class RegionsDataModule : ISharedRegionModule
    {
        private static readonly ILog m_log = LogManager.GetLogger(MethodBase.GetCurrentMethod().DeclaringType);
        private IConfigSource m_config = null;

        List<Scene> m_scenes = new List<Scene>();

        public string Name
        {
            get
            {
                return "RegionsDataModule";
            }
        }


        public Type ReplaceableInterface
        {
            get
            {
                return null;
            }
        }


        public void AddRegion(Scene scene)
        {
            
        }

        public void Close()
        {

        }

        public void Initialise(IConfigSource source)
        {
            if (m_config == null)
                m_config = source;
        }

        public void PostInitialise()
        {
            
        }

        public void RegionLoaded(Scene scene)
        {
            if(scene != null)
            {
                m_scenes.Add(scene);

                IHttpServer server = MainServer.GetHttpServer(0);
                server.AddStreamHandler(new RegionsDataHandler(m_config, ref m_scenes));
            }
        }


        public void RemoveRegion(Scene scene)
        {
            m_scenes.Remove(scene);
        }
    }
}
