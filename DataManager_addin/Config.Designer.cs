//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.34014
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace DataManager_addin {
    using ESRI.ArcGIS.Desktop.AddIns;
    using ESRI.ArcGIS.CatalogUI;
    using ESRI.ArcGIS.Framework;
    using ESRI.ArcGIS.ArcCatalog;
    using System;
    using System.Collections.Generic;
    
    
    /// <summary>
    /// A class for looking up declarative information in the associated configuration xml file (.esriaddinx).
    /// </summary>
    internal static class ThisAddIn {
        
        internal static string Name {
            get {
                return "Data Manager";
            }
        }
        
        internal static string AddInID {
            get {
                return "{f9506e1c-9c07-4a3f-8516-b8c52c36304f}";
            }
        }
        
        internal static string Company {
            get {
                return "";
            }
        }
        
        internal static string Version {
            get {
                return "1.4";
            }
        }
        
        internal static string Description {
            get {
                return "Type in a description for this Add-in.";
            }
        }
        
        internal static string Author {
            get {
                return "Süleyman";
            }
        }
        
        internal static string Date {
            get {
                return "6/27/2014";
            }
        }
        
        internal static ESRI.ArcGIS.esriSystem.UID ToUID(this System.String id) {
            ESRI.ArcGIS.esriSystem.UID uid = new ESRI.ArcGIS.esriSystem.UIDClass();
            uid.Value = id;
            return uid;
        }
        
        /// <summary>
        /// A class for looking up Add-in id strings declared in the associated configuration xml file (.esriaddinx).
        /// </summary>
        internal class IDs {
            
            /// <summary>
            /// Returns 'DataManager_addin_cmd_DataManager', the id declared for Add-in Button class 'cmd_DataManager'
            /// </summary>
            internal static string cmd_DataManager {
                get {
                    return "DataManager_addin_cmd_DataManager";
                }
            }
            
            /// <summary>
            /// Returns 'DataManager_addin_mnuDataManager', the id declared for Add-in MultiItem class 'mnuDataManager'
            /// </summary>
            internal static string mnuDataManager {
                get {
                    return "DataManager_addin_mnuDataManager";
                }
            }
            
            /// <summary>
            /// Returns 'DataManager_addin_Ext_DataManager', the id declared for Add-in Extension class 'Ext_DataManager'
            /// </summary>
            internal static string Ext_DataManager {
                get {
                    return "DataManager_addin_Ext_DataManager";
                }
            }
            
            /// <summary>
            /// Returns 'DataManager_addin_frm_DataManager', the id declared for Add-in DockableWindow class 'frm_DataManager+AddinImpl'
            /// </summary>
            internal static string frm_DataManager {
                get {
                    return "DataManager_addin_frm_DataManager";
                }
            }
        }
    }
    
internal static class ArcCatalog
{
  private static IApplication s_app;
  private static IGxDocumentEvents_Event s_docEvent;
  public static IApplication Application
  {
    get
    {
      if (s_app == null)
        s_app = Internal.AddInStartupObject.GetHook<IGxApplication>() as IApplication;

      return s_app;
    }
  }

  public static IDocument Document
  {
    get
    {
      if (Application != null)
        return Application.Document;

      return null;
    }
  }

  public static IGxApplication ThisApplication
  {
    get { return Application as IGxApplication; }
  }

  public static IDockableWindowManager DockableWindowManager
  {
    get { return Application as IDockableWindowManager; }
  }

  public static IGxDocumentEvents_Event Events
  {
    get 
    {
      s_docEvent = Document as IGxDocumentEvents_Event;
      return s_docEvent; 
    }
  }
}

namespace Internal
{
  [StartupObjectAttribute()]
  [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
  [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
  public sealed partial class AddInStartupObject : AddInEntryPoint
  {
    private static AddInStartupObject _sAddInHostManager;
    private List<object> m_addinHooks = null;

    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    public AddInStartupObject()
    {
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override bool Initialize(object hook)
    {
      bool createSingleton = _sAddInHostManager == null;
      if (createSingleton)
      {
        _sAddInHostManager = this;
        m_addinHooks = new List<object>();
        m_addinHooks.Add(hook);
      }
      else if (!_sAddInHostManager.m_addinHooks.Contains(hook))
        _sAddInHostManager.m_addinHooks.Add(hook);

      return createSingleton;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    protected override void Shutdown()
    {
      _sAddInHostManager = null;
      m_addinHooks = null;
    }

    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Never)]
    internal static T GetHook<T>() where T : class
    {
      if (_sAddInHostManager != null)
      {
        foreach (object o in _sAddInHostManager.m_addinHooks)
        {
          if (o is T)
            return o as T;
        }
      }

      return null;
    }

    // Expose this instance of Add-in class externally
    public static AddInStartupObject GetThis()
    {
      return _sAddInHostManager;
    }
  }
}
}
