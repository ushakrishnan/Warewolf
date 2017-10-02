﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 15.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace Warewolf.UI.Tests.Merge.MergeConflictsUIMapClasses
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WpfControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public partial class MergeConflictsUIMap
    {
        
        #region Properties
        public MainWindow MainWindow
        {
            get
            {
                if ((this.mMainWindow == null))
                {
                    this.mMainWindow = new MainWindow();
                }
                return this.mMainWindow;
            }
        }
        #endregion
        
        #region Fields
        private MainWindow mMainWindow;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class MainWindow : WpfWindow
    {
        
        public MainWindow()
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.Name, "Warewolf", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MainWindow");
            #endregion
        }
        
        #region Properties
        public DockManager DockManager
        {
            get
            {
                if ((this.mDockManager == null))
                {
                    this.mDockManager = new DockManager(this);
                }
                return this.mDockManager;
            }
        }
        #endregion
        
        #region Fields
        private DockManager mDockManager;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class DockManager : WpfCustom
    {
        
        public DockManager(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.XamDockManager";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "DockManager";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public SplitPaneMiddle SplitPaneMiddle
        {
            get
            {
                if ((this.mSplitPaneMiddle == null))
                {
                    this.mSplitPaneMiddle = new SplitPaneMiddle(this);
                }
                return this.mSplitPaneMiddle;
            }
        }
        #endregion
        
        #region Fields
        private SplitPaneMiddle mSplitPaneMiddle;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class SplitPaneMiddle : WpfCustom
    {
        
        public SplitPaneMiddle(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties[WpfControl.PropertyNames.Instance] = "2";
            this.SearchConfigurations.Add(SearchConfiguration.NextSibling);
            this.SearchConfigurations.Add(SearchConfiguration.DisambiguateChild);
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public TabManSplitPane TabManSplitPane
        {
            get
            {
                if ((this.mTabManSplitPane == null))
                {
                    this.mTabManSplitPane = new TabManSplitPane(this);
                }
                return this.mTabManSplitPane;
            }
        }
        #endregion
        
        #region Fields
        private TabManSplitPane mTabManSplitPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TabManSplitPane : WpfCustom
    {
        
        public TabManSplitPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.ClassName] = "Uia.SplitPane";
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "UI_SplitPane_AutoID";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public TabMan TabMan
        {
            get
            {
                if ((this.mTabMan == null))
                {
                    this.mTabMan = new TabMan(this);
                }
                return this.mTabMan;
            }
        }
        #endregion
        
        #region Fields
        private TabMan mTabMan;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class TabMan : WpfTabList
    {
        
        public TabMan(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabList.PropertyNames.AutomationId] = "UI_TabManager_AutoID";
            this.WindowTitles.Add("Warewolf");
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public MergeTab MergeTab
        {
            get
            {
                if ((this.mMergeTab == null))
                {
                    this.mMergeTab = new MergeTab(this);
                }
                return this.mMergeTab;
            }
        }
        #endregion
        
        #region Fields
        private MergeTab mMergeTab;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class MergeTab : WpfTabPage
    {
        
        public MergeTab(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfTabPage.PropertyNames.Name] = "Dev2.ViewModels.MergeViewModel";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public WpfButton CloseButton
        {
            get
            {
                if ((this.mCloseButton == null))
                {
                    this.mCloseButton = new WpfButton(this);
                    #region Search Criteria
                    this.mCloseButton.SearchProperties[WpfButton.PropertyNames.AutomationId] = "closeBtn";
                    this.mCloseButton.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mCloseButton;
            }
        }
        
        public WpfText TabDescription
        {
            get
            {
                if ((this.mTabDescription == null))
                {
                    this.mTabDescription = new WpfText(this);
                    #region Search Criteria
                    this.mTabDescription.SearchProperties[WpfText.PropertyNames.Name] = "Merge Conflicts";
                    this.mTabDescription.WindowTitles.Add("Warewolf");
                    #endregion
                }
                return this.mTabDescription;
            }
        }
        
        public WorkSurfaceContext WorkSurfaceContext
        {
            get
            {
                if ((this.mWorkSurfaceContext == null))
                {
                    this.mWorkSurfaceContext = new WorkSurfaceContext(this);
                }
                return this.mWorkSurfaceContext;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mCloseButton;
        
        private WpfText mTabDescription;
        
        private WorkSurfaceContext mWorkSurfaceContext;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class WorkSurfaceContext : WpfCustom
    {
        
        public WorkSurfaceContext(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "Dev2.Studio.ViewModels.WorkSurface.WorkSurfaceContextViewModel";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public ContentDockManager ContentDockManager
        {
            get
            {
                if ((this.mContentDockManager == null))
                {
                    this.mContentDockManager = new ContentDockManager(this);
                }
                return this.mContentDockManager;
            }
        }
        #endregion
        
        #region Fields
        private ContentDockManager mContentDockManager;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class ContentDockManager : WpfCustom
    {
        
        public ContentDockManager(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfControl.PropertyNames.AutomationId] = "ContentDockManager";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public MergeWorkflowView MergeWorkflowView
        {
            get
            {
                if ((this.mMergeWorkflowView == null))
                {
                    this.mMergeWorkflowView = new MergeWorkflowView(this);
                }
                return this.mMergeWorkflowView;
            }
        }
        #endregion
        
        #region Fields
        private MergeWorkflowView mMergeWorkflowView;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class MergeWorkflowView : WpfCustom
    {
        
        public MergeWorkflowView(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties.Add(new PropertyExpression(WpfControl.PropertyNames.ClassName, "MergeWorkflowView", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public ScrollViewerPane ScrollViewerPane
        {
            get
            {
                if ((this.mScrollViewerPane == null))
                {
                    this.mScrollViewerPane = new ScrollViewerPane(this);
                }
                return this.mScrollViewerPane;
            }
        }
        #endregion
        
        #region Fields
        private ScrollViewerPane mScrollViewerPane;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class ScrollViewerPane : WpfPane
    {
        
        public ScrollViewerPane(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfPane.PropertyNames.AutomationId] = "MergeGridScrollViewer";
            this.WindowTitles.Add("Warewolf");
            #endregion
        }
        
        #region Properties
        public VariablesExpander VariablesExpander
        {
            get
            {
                if ((this.mVariablesExpander == null))
                {
                    this.mVariablesExpander = new VariablesExpander(this);
                }
                return this.mVariablesExpander;
            }
        }
        
        public WpfRadioButton RightSelectAndApplyWFRadioButton
        {
            get
            {
                if ((this.mRightSelectAndApplyWFRadioButton == null))
                {
                    this.mRightSelectAndApplyWFRadioButton = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mRightSelectAndApplyWFRadioButton.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "UI_DifferenceWorkflowRB_AutoID";
                    this.mRightSelectAndApplyWFRadioButton.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
                    #endregion
                }
                return this.mRightSelectAndApplyWFRadioButton;
            }
        }
        
        public WpfRadioButton LeftSelectAndApplyWFRadioButton
        {
            get
            {
                if ((this.mLeftSelectAndApplyWFRadioButton == null))
                {
                    this.mLeftSelectAndApplyWFRadioButton = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mLeftSelectAndApplyWFRadioButton.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "UI_CurrentWorkflowRB_AutoID";
                    this.mLeftSelectAndApplyWFRadioButton.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
                    #endregion
                }
                return this.mLeftSelectAndApplyWFRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private VariablesExpander mVariablesExpander;
        
        private WpfRadioButton mRightSelectAndApplyWFRadioButton;
        
        private WpfRadioButton mLeftSelectAndApplyWFRadioButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class VariablesExpander : WpfExpander
    {
        
        public VariablesExpander(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfExpander.PropertyNames.AutomationId] = "UI_VariablesExpander_AutoID";
            this.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
            #endregion
        }
        
        #region Properties
        public VariablesHeader VariablesHeader
        {
            get
            {
                if ((this.mVariablesHeader == null))
                {
                    this.mVariablesHeader = new VariablesHeader(this);
                }
                return this.mVariablesHeader;
            }
        }
        #endregion
        
        #region Fields
        private VariablesHeader mVariablesHeader;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "15.0.26208.0")]
    public class VariablesHeader : WpfButton
    {
        
        public VariablesHeader(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WpfButton.PropertyNames.AutomationId] = "HeaderSite";
            this.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
            #endregion
        }
        
        #region Properties
        public WpfRadioButton LeftVariablesRadio
        {
            get
            {
                if ((this.mLeftVariablesRadio == null))
                {
                    this.mLeftVariablesRadio = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mLeftVariablesRadio.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "UI_CurrentVariablesRB_AutoID";
                    this.mLeftVariablesRadio.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
                    #endregion
                }
                return this.mLeftVariablesRadio;
            }
        }
        
        public WpfText LeftVariablesText
        {
            get
            {
                if ((this.mLeftVariablesText == null))
                {
                    this.mLeftVariablesText = new WpfText(this);
                    #region Search Criteria
                    this.mLeftVariablesText.SearchProperties[WpfText.PropertyNames.AutomationId] = "UI_CurrentVariablesText_AutoID";
                    this.mLeftVariablesText.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
                    #endregion
                }
                return this.mLeftVariablesText;
            }
        }
        
        public WpfRadioButton DifferenceVariableRadioButton
        {
            get
            {
                if ((this.mDifferenceVariableRadioButton == null))
                {
                    this.mDifferenceVariableRadioButton = new WpfRadioButton(this);
                    #region Search Criteria
                    this.mDifferenceVariableRadioButton.SearchProperties[WpfRadioButton.PropertyNames.AutomationId] = "UI_DifferenceVariablesRB_AutoID";
                    this.mDifferenceVariableRadioButton.WindowTitles.Add("Warewolf (DEV2\\SANELE.MTHEMBU)");
                    #endregion
                }
                return this.mDifferenceVariableRadioButton;
            }
        }
        #endregion
        
        #region Fields
        private WpfRadioButton mLeftVariablesRadio;
        
        private WpfText mLeftVariablesText;
        
        private WpfRadioButton mDifferenceVariableRadioButton;
        #endregion
    }
}