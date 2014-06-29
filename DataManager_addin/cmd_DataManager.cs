using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using ESRI.ArcGIS.esriSystem;


namespace DataManager_addin
{
    public class cmd_DataManager : ESRI.ArcGIS.Desktop.AddIns.Button
    {
        public cmd_DataManager()
        {
        }

        protected override void OnClick()
        {
            this.Enabled = true;
            UID dockWinID = new UIDClass();
            dockWinID.Value = @"DataManager_addin_frm_DataManager";
            ESRI.ArcGIS.Framework.IDockableWindow s_dockWindow = ArcCatalog.DockableWindowManager.GetDockableWindow(dockWinID);
            s_dockWindow.Show(!s_dockWindow.IsVisible());
        }

        protected override void OnUpdate()
        {
            Enabled = ArcCatalog.Application != null;
        }
    }
}
