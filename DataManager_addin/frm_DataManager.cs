using ESRI.ArcGIS.CatalogUI;
using ESRI.ArcGIS.Catalog;
using ESRI.ArcGIS.esriSystem;
using ESRI.ArcGIS.Framework;
using ESRI.ArcGIS.Geoprocessing;
using ESRI.ArcGIS.GeoprocessingUI;
using ESRI.ArcGIS.SystemUI;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

namespace DataManager_addin
{
    /// <summary>
    /// Designer class of the dockable window add-in. It contains user interfaces that
    /// make up the dockable window.
    /// </summary>
    public partial class frm_DataManager : UserControl
    {
        public frm_DataManager(object hook)
        {
            InitializeComponent();
            this.Hook = hook;
            
        }

        /// <summary>
        /// Host object of the dockable window
        /// </summary>
        private object Hook
        {
            get;
            set;
        }

        /// <summary>
        /// Implementation class of the dockable window add-in. It is responsible for 
        /// creating and disposing the user interface class of the dockable window.
        /// </summary>
        public class AddinImpl : ESRI.ArcGIS.Desktop.AddIns.DockableWindow
        {
            private frm_DataManager m_windowUI;

            public AddinImpl()
            {
            }

            protected override IntPtr OnCreateChild()
            {
                m_windowUI = new frm_DataManager(this.Hook);
                return m_windowUI.Handle;
            }

            protected override void Dispose(bool disposing)
            {
                if (m_windowUI != null)
                    m_windowUI.Dispose(disposing);

                base.Dispose(disposing);
            }

        }

        

        public IDockableWindow GetDockableWindow(System.String windowName)
        {
            try
            {
                IDockableWindowManager dockWindowManager = ArcCatalog.Application as IDockableWindowManager;
                UID windowID = new ESRI.ArcGIS.esriSystem.UIDClass();
                windowID.Value = windowName; // example: "esriGeoprocessingUI.GPCommandWindow"
                return dockWindowManager.GetDockableWindow(windowID);
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to load dockable window: " + windowName + Environment.NewLine + ex.Message);
                return null;
            }
        }

        private void setDWVisibility(string dwName, bool visibility)
        {
            //this.Enabled = true;
            //UID dockWinID = new UIDClass();
            //dockWinID.Value = @dwName;
            IDockableWindow s_dockWindow = GetDockableWindow(dwName);
            if (s_dockWindow != null) s_dockWindow.Show(visibility);
        }

        public void FindCommandAndExecute(System.String commandName)
        {
            try
            {
                ICommandBars commandBars = ArcCatalog.Application.Document.CommandBars;
                UID uid = new UIDClass();
                uid.Value = commandName; // Example: "esriFramework.HelpContentsCommand" or "{D74B2F25-AC90-11D2-87F8-0000F8751720}"
                ICommandItem commandItem = commandBars.Find(uid, false, false);

                if (commandItem != null)
                    commandItem.Execute();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to execute command: " + commandName + Environment.NewLine + ex.Message);
            }
        }

        public void iterateToolbars()
        {
            try
            {
                // Set up GUID object for 'ESRI Mx Command Bars' component category
                UID uid_GxCommandBars = new UIDClass();
                uid_GxCommandBars.Value = (System.Object)("{56C205F9-E53A-11D1-9496-080009EEBECB}"); // Explict Cast

                // Set up the category factory.
                ESRI.ArcGIS.esriSystem.ICategoryFactory categoryFactory = new ESRI.ArcGIS.esriSystem.CategoryFactoryClass();
                categoryFactory.CategoryID = uid_GxCommandBars;

                // Go through each member of the category, and if it is a toolbar try to find it in the document
                object object_ComponentCategory = categoryFactory.CreateNext();
                //comboBox1.Items.Clear();
                while (object_ComponentCategory != null)
                {

                    if (object_ComponentCategory is IToolBarDef)
                    {

                        IToolBarDef toolbarDef = (IToolBarDef)object_ComponentCategory; //Explicit Cast
                        ICommandBars commandBars = ArcCatalog.Application.Document.CommandBars;

                        object object_ToolBarDefName = (System.Object)toolbarDef.Name; // Explict Cast
                        ICommandItem commandItem = commandBars.Find(object_ToolBarDefName, false, false);

                        ICommandBar commandBar = (ICommandBar)commandItem; //Explicit Cast

                        if (commandBar != null)
                        {

                        }

                    }

                    object_ComponentCategory = categoryFactory.CreateNext();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Error occured while searching toolbars" + Environment.NewLine + ex.Message);
            }
        }

        public ICommandBar GetToolbarByName(IApplication application, System.String toolbarName)
        {
            try
            {
                ICommandBars commandBars = application.Document.CommandBars;
                UID barID = new UIDClass();
                barID.Value = toolbarName; // Example: "esriArcMapUI.StandardToolBar"
                ICommandItem commandItem = commandBars.Find(barID, false, false);
                if (commandItem != null && commandItem.Type == esriCommandTypes.esriCmdTypeToolbar)
                {
                    return (ESRI.ArcGIS.Framework.ICommandBar)commandItem;
                }
                else
                    return null;
            }
            catch(Exception ex)
            {
                MessageBox.Show("Failed to load toolbar: " + toolbarName + Environment.NewLine + ex.Message);
                return null;
            }
        }

        private void showCommandBar(UID commandbarID)
        {
            try
            {
                ICommandBars commandBars = ArcCatalog.Document.CommandBars;

                ICommandItem commandItem = commandBars.Find(commandbarID, false, false);
                if (commandItem != null && commandItem.Type == esriCommandTypes.esriCmdTypeToolbar)
                {
                    ICommandBar cb = (ICommandBar)commandItem;
                    cb.Dock(esriDockFlags.esriDockShow);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to show commandbar: " + commandbarID + Environment.NewLine + ex.Message);
            }
        }
        
        
        #region Catalog Tree Functions (GxObject)
        private void setRootObjects(bool isFolderConnection, bool isToolboxes, bool isDatabaseServers, bool isDatabaseConnections, bool isGISServers, bool isMyHostedServices, bool isReadyToUseServices)
        {
            try
            {
                IGxApplication gxApp = ArcCatalog.Application as IGxApplication;
                IGxCatalog gxCat = gxApp.Catalog;
                if (gxCat == null)
                {
                    MessageBox.Show("Falied to set catalog object.");
                    return;
                }
                IGxCatalogAdmin gxAdmin = (IGxCatalogAdmin)gxCat;
                if (gxAdmin == null)
                {
                    MessageBox.Show("Falied to set catalog admin object.");
                    return;
                }
                for (int i = 0; i < gxAdmin.RootObjectCount; i++)
                {
                    IGxObject pobj = gxAdmin.get_RootObject(i);
                    //MessageBox.Show(pobj.FullName);
                    if (pobj != null)
                    {
                        //if (pobj is IGxToolbox) gxAdmin.EnableRootObject(i, isToolboxes);
                        //else if (pobj is IGxRemoteDatabaseFolder) gxAdmin.EnableRootObject(i, isDatabaseConnections);
                        //else if (pobj is IGxGISServersFolder) gxAdmin.EnableRootObject(i, isGISServers);
                        //else if (pobj is IGxMyHostedMapsFolder) gxAdmin.EnableRootObject(i, isMyHostedServices);
                        //else if (pobj is IGxTaskServicesRootFolder) gxAdmin.EnableRootObject(i, isReadyToUseServices);
                        //else if (pobj is IGxFolderConnections) gxAdmin.EnableRootObject(i, isFolderConnection);
                        //else if (pobj is IGxc) gxAdmin.EnableRootObject(i, isDatabaseServers);
                        //else gxAdmin.EnableRootObject(i, false);
                        switch (pobj.BaseName)
                        {
                            case "Folder Connections":
                                gxAdmin.EnableRootObject(i, isFolderConnection);
                                break;
                            case "Toolboxes":
                                gxAdmin.EnableRootObject(i, isToolboxes);
                                break;
                            case "Database Servers":
                                gxAdmin.EnableRootObject(i, isDatabaseServers);
                                break;
                            case "Database Connections":
                                gxAdmin.EnableRootObject(i, isDatabaseConnections);
                                break;
                            case "GIS Servers":
                                gxAdmin.EnableRootObject(i, isGISServers);
                                break;
                            case "My Hosted Services":
                                gxAdmin.EnableRootObject(i, isMyHostedServices);
                                break;
                            case "Ready-To-Use Services":
                                gxAdmin.EnableRootObject(i, isReadyToUseServices);
                                break;
                            default:
                                gxAdmin.EnableRootObject(i, false);
                                break;
                        }
                        
                    }
                    else
                    {
                        //MessageBox.Show("Failed to load root object: " + i + " 'th of " + gxAdmin.RootObjectCount);
                    }
                
                }
                gxAdmin.RefreshRootObjects();
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set root objects: " + Environment.NewLine + ex.Message);
            }
        }
        private IGxObject getGxObjects(IGxObject currentobject, System.String objName)
        {
            try
            {
                if (currentobject.BaseName == objName) return currentobject;
                if (currentobject is IGxObjectContainer)
                {
                    IGxObjectContainer gxObjCont = null;
                    IEnumGxObject gxEnum = null;
                    IGxObject gxObject = null;
                    gxObjCont = currentobject as IGxObjectContainer;
                    gxEnum = gxObjCont.Children;
                    if (gxEnum != null)
                    {
                        gxObject = gxEnum.Next();
                        while (gxObject != null)
                        {
                            if (gxObject.BaseName == objName) return gxObject;
                            if (currentobject is IGxObjectContainer)
                            {
                                IGxObject newobj = getGxObjects(gxObject, objName);
                                //if (newobj != null) getGxObjects(newobj, objName);
                            }
                            gxObject = gxEnum.Next();
                        }
                    }
                }
                return null;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to get catalog object: " + objName + Environment.NewLine + ex.Message);
                return null;
            }
        }
        private IGxObject navigateToCatalogObject(System.String objectPath)
        {
            IGxObject gxObj = null;
            IGxSelection gxSel = null;
            try
            {
                IGxApplication gxApp = ArcCatalog.Application as IGxApplication;
                gxApp.Location = objectPath;
                gxSel = gxApp.Selection;
                if (gxSel != null)
                {
                    gxObj = gxSel.Location;
                    if (gxObj != null)
                    {
                        if (gxObj is IGxObjectContainer)
                        {
                            IGxObjectContainer gxObjCont = null;
                            IEnumGxObject gxEnum = null;
                            IGxObject gxObject = null;
                            gxObjCont = gxObj as IGxObjectContainer;
                            gxEnum = gxObjCont.Children;
                            if (gxEnum != null)
                            {
                                gxObject = gxEnum.Next();
                                gxApp.Location = gxObject.FullName;
                                if (gxObject is IGxObjectContainer) gxApp.ExpandSelection();
                                gxApp.Location = gxObj.FullName;
                            }
                        }
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to locate catalog object: " + objectPath + Environment.NewLine + ex.Message);
                return null;
            }
            return gxObj;
        }

        #endregion
 
        #region Toolbox functions

        
        private void toggleToolboxWindow(bool makeVisible)
        {
            //FindCommandAndExecute("esriGeoprocessingUI.ArcToolboxCmd");
            IDockableWindow pdw = GetDockableWindow("esriGeoprocessingUI.ArcToolboxDockWnd");
            if (pdw != null)
            {
                if (makeVisible) pdw.Show(true);
                else pdw.Show(!pdw.IsVisible());
            }
        }
        
        private IGPTool getGPTool(System.String toolName)
        {
            IGPTool pTool = null;
            try
            {
                UID pUID = new UIDClass();
                pUID.Value = "esriGeoprocessingUI.ArcToolboxExtension";
                IArcToolboxExtension pATBExt = (IArcToolboxExtension)ArcCatalog.Application.FindExtensionByCLSID(pUID);

                IArcToolbox pAtb = pATBExt.ArcToolbox;
                pTool = pAtb.GetToolbyNameString(toolName);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            return pTool;

        }

        private void runTool(System.String toolname)
        {
            try
            {
                IGPTool pGpt = getGPTool(toolname); //sample "TableToExcel"
                if (pGpt != null)
                {
                    IGPToolCommandHelper pCommand = new GPToolCommandHelper();
                    pCommand.SetTool(pGpt);
                    pCommand.Invoke(null);
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to run tool: " + toolname + Environment.NewLine + ex.Message);
            }
        }

        private void runTool(IGxObject gxObj)
        {
            try
            {
                if (gxObj == null) return;
                if (gxObj is IGxGPTool)
                {
                    IGxGPTool gxGPTool = (IGxGPTool)gxObj;
                    IGPTool gpTool = gxGPTool.Tool;
                    runTool(gpTool.Name);
                }
                else if (gxObj is GxAddGDSConnection)
                {
                    IGxObjectWizard gxWiz = (IGxObjectWizard)gxObj;
                    gxWiz.Invoke(ArcCatalog.Application.hWnd);
                }
            }
            catch (Exception ex)
            {
            }
        }

        private void runSelectedTool()
        {
            IGxApplication gxApp = ArcCatalog.Application as IGxApplication;
            IGxCatalog gxCat = gxApp.Catalog;
            IGxSelection gxSel = gxApp.Selection;
            if (gxSel != null)
            {
                IGxObject gxObj = gxSel.Location;
                runTool(gxObj);
            }
        }

        #endregion

        private void DeactivateViews()
        {
            IGxViewContainer pGxViewContainer = (IGxViewContainer)ArcCatalog.ThisApplication;

            IEnumGxView pEnumGxView = pGxViewContainer.Views;

            IGxView pGxView = pEnumGxView.Next();
            while (pGxView != null)
            {
                //MessageBox.Show(pGxView.Name);
                pGxView.Deactivate();
                pGxView = pEnumGxView.Next();

            }

        }

        private void ActivateViews()
        {
            IGxViewContainer pGxViewContainer = (IGxViewContainer)ArcCatalog.ThisApplication;
            IGxApplication gxApp = ArcCatalog.Application as IGxApplication;
            IGxCatalog gxCat=gxApp.Catalog;
            IEnumGxView pEnumGxView = pGxViewContainer.Views;


            IGxView pGxView = pEnumGxView.Next();
            while (pGxView != null)
            {
                //MessageBox.Show(pGxView.Name);
                pGxView.Activate(gxApp, gxCat);
                pGxView = pEnumGxView.Next();

            }

        }

        private IGxDocumentationView setActiveView_GxDocumentationView()
        {
            try
            {
                IGxApplication gxApp = ArcCatalog.Application as IGxApplication;
                IGxCatalog gxCat = gxApp.Catalog;
                IGxViewContainer pGxViewContainer = (IGxViewContainer)ArcCatalog.ThisApplication;
                UID windowID = new ESRI.ArcGIS.esriSystem.UIDClass();
                windowID.Value = "esriCatalogUI.GxDocumentationView";

                IGxView docView = pGxViewContainer.FindView(windowID);
                if (docView.Applies(gxApp.SelectedObject)) gxApp.ViewClassID = windowID;
                UID tbID = docView.DefaultToolbarCLSID;
                if (tbID != null) showCommandBar(tbID);
                return (IGxDocumentationView)docView;
            }
            catch (Exception ex)
            {
                MessageBox.Show("Failed to set active view as metadata" + Environment.NewLine + ex.Message);
                return null;
            }
        }


        #region Data Storage & Loading Buttons
        private void btn_ManageData_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, true, true);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Management Tools.tbx");
        }

        private void btn_DataMigration_Click(object sender, EventArgs e)
        {
            setRootObjects(false, true, false, false, false, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx\\To Geodatabase\\CAD to Geodatabase");
            runSelectedTool();
        }

        private void btn_ConnectDatabase_Click(object sender, EventArgs e)
        {
            setRootObjects(false, false, true, true, false, false, false);
            navigateToCatalogObject("Database Connections\\Add Database Connection");
            runSelectedTool();

        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            setRootObjects(false, false, false, false, false, false, false);

            IDockableWindow pdw = GetDockableWindow("{D949DEFF-85E0-47DB-B533-CB2BE6C631CB}"); //"esriCatalogUI.SearchDockableWindow"
            if (pdw != null)
            {
                pdw.Show(!pdw.IsVisible());

            }
        }

        private void btn_ImpExp_Click(object sender, EventArgs e)
        {
            setRootObjects(false, true, false, false, false, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx");
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Interoperability Tools.tbx");
        }

        private void btn_SupportFormats_Click(object sender, EventArgs e)
        {
            setRootObjects(false, true, false, false, false, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Interoperability Tools.tbx");
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx\\To CAD\\Export to CAD");
            runSelectedTool();
        }

        private void btn_Projection_Click(object sender, EventArgs e)
        {
            setRootObjects(false, true, false, false, false, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Management Tools.tbx\\Projections and Transformations\\Convert Coordinate Notation");
            runSelectedTool();
        }

        private void btn_Attachments_Click(object sender, EventArgs e)
        {
            setRootObjects(false, true, false, false, false, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Management Tools.tbx\\Attachments\\Add Attachments");
            runSelectedTool();
        }

        private void btn_MakeFLayer_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, true, true);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Management Tools.tbx\\Layers and Table Views\\Make Feature layer");
            runSelectedTool();
        }

        private void btnCreateFClass_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, true, true);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Data Management Tools.tbx\\Feature Class\\Create Feature Class");
            runSelectedTool();
        }


        #endregion

        #region Metadata Buttons
        private void btn_GenerateMetadata_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx\\Metadata");
            setActiveView_GxDocumentationView();
        }

        private void btn_ImpExpMetadata_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx\\Metadata\\Export Metadata");
            setActiveView_GxDocumentationView();
        }

        private void btn_EnforceMetadataStandards_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx\\Metadata\\ESRI Metadata Translator");
            IGxDocumentationView docView = setActiveView_GxDocumentationView();

            
            
        }

        private void btn_InternetMetadataService_Click(object sender, EventArgs e)
        {
            setRootObjects(false, true, false, false, false, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Conversion Tools.tbx\\Metadata\\Metadata Publisher");
            setActiveView_GxDocumentationView();
        }

        private void btn_DisplayISOMetadata_Click(object sender, EventArgs e)
        {

        }

        private void btn_SupportPolicy_Click(object sender, EventArgs e)
        {

        }

        private void btn_TrackingChanges_Click(object sender, EventArgs e)
        {
            setRootObjects(true, true, true, true, true, false, false);
            navigateToCatalogObject("Toolboxes\\System Toolboxes\\Tracking Analyst Tools.tbx");
            setActiveView_GxDocumentationView();
        }

        #endregion

        private void btn_About_Click(object sender, EventArgs e)
        {
            foreach (System.Windows.Forms.Form f in System.Windows.Forms.Application.OpenForms)
            {
                if (f.GetType().Equals(typeof(AboutBox1)))
                {
                    f.Focus();
                    return;
                }
            }
            //create instance of form
            AboutBox1 frm = new AboutBox1();
            //show form
            frm.ShowDialog();
        }

    }
}
