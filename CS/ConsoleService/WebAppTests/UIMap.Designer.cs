﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace WebAppTests
{
    using System;
    using System.CodeDom.Compiler;
    using System.Collections.Generic;
    using System.Drawing;
    using System.Text.RegularExpressions;
    using System.Windows.Input;
    using Microsoft.VisualStudio.TestTools.UITest.Extension;
    using Microsoft.VisualStudio.TestTools.UITesting;
    using Microsoft.VisualStudio.TestTools.UITesting.WinControls;
    using Microsoft.VisualStudio.TestTools.UnitTesting;
    using Keyboard = Microsoft.VisualStudio.TestTools.UITesting.Keyboard;
    using Mouse = Microsoft.VisualStudio.TestTools.UITesting.Mouse;
    using MouseButtons = System.Windows.Forms.MouseButtons;
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// OpenPageRecorded - Use 'OpenPageRecordedParams' to pass parameters into this method.
        /// </summary>
        public void OpenPageRecorded()
        {
            #region Variable Declarations
            WinButton uINowakartaButton = this.UIVerifyingCodebyUsingWindow.UIKartyprzeglądarkiToolBar.UINowakartaButton;
            WinComboBox uIItemComboBox = this.UIVerifyingCodebyUsingWindow.UIPaseknarzędzinawigacToolBar.UIItemComboBox;
            WinEdit uIWprowadźadreslubszukEdit = this.UIVerifyingCodebyUsingWindow.UIItemComboBox.UIWprowadźadreslubszukEdit;
            #endregion

            // Click 'Nowa karta' button
            Mouse.Click(uINowakartaButton, new Point(11, 7));

            // Select 'http://localhost:50669/' in combo box
            uIItemComboBox.EditableItem = this.OpenPageRecordedParams.UIItemComboBoxEditableItem;

            // Type '{Enter}' in 'Wprowadź adres lub szukaj' text box
            Keyboard.SendKeys(uIWprowadźadreslubszukEdit, this.OpenPageRecordedParams.UIWprowadźadreslubszukEditSendKeys, ModifierKeys.None);
        }
        
        /// <summary>
        /// ColumnCounterValueAssert - Use 'ColumnCounterValueAssertExpectedValues' to pass parameters into this method.
        /// </summary>
        public void ColumnCounterValueAssert()
        {
            #region Variable Declarations
            WinEdit uICounterValueEdit = this.UIVerifyingCodebyUsingWindow.UICounterValueColumnHeader.UICounterValueEdit;
            #endregion

            // Verify that the 'Name' property of 'CounterValue' text box contains 'CounterValue'
            StringAssert.Contains(uICounterValueEdit.Name, this.ColumnCounterValueAssertExpectedValues.UICounterValueEditName);
        }
        
        /// <summary>
        /// ClickEditRecorded
        /// </summary>
        public void ClickEditRecorded()
        {
            #region Variable Declarations
            WinEdit uIEditEdit = this.UIVerifyingCodebyUsingWindow.UIEditHyperlink.UIEditEdit;
            #endregion

            // Click 'Edit' text box
            Mouse.Click(uIEditEdit, new Point(14, 9));
        }
        
        /// <summary>
        /// SaveValueRecorded - Use 'SaveValueRecordedParams' to pass parameters into this method.
        /// </summary>
        public void SaveValueRecorded()
        {
            #region Variable Declarations
            WinEdit uICounterValueEdit = this.UIEditMozillaFirefoxWindow.UIValuesGroup.UICounterValueEdit;
            WinButton uISaveButton = this.UIEditMozillaFirefoxWindow.UIValuesGroup.UISaveButton;
            #endregion

            // Type '54.5454545454' in 'CounterValue' text box
            uICounterValueEdit.Text = this.SaveValueRecordedParams.UICounterValueEditText;

            // Click 'Save' button
            Mouse.Click(uISaveButton, new Point(29, 8));
        }
        
        /// <summary>
        /// SavedValueAssert - Use 'SavedValueAssertExpectedValues' to pass parameters into this method.
        /// </summary>
        public void SavedValueAssert()
        {
            #region Variable Declarations
            WinEdit uIItem545454545454Edit = this.UIIndexMozillaFirefoxWindow.UIItemCell.UIItem545454545454Edit;
            #endregion

            // Verify that the 'Name' property of '54.5454545454' text box contains '54.5454545454'
            StringAssert.Contains(uIItem545454545454Edit.Name, this.SavedValueAssertExpectedValues.UIItem545454545454EditName);
        }
        
        /// <summary>
        /// ClosePageRecorded
        /// </summary>
        public void ClosePageRecorded()
        {
            #region Variable Declarations
            WinButton uIItemButton = this.UIIndexMozillaFirefoxWindow1.UIIndexTabPage.UIItemButton;
            #endregion

            // Click button
            Mouse.Click(uIItemButton, new Point(9, 8));
        }
        
        #region Properties
        public virtual OpenPageRecordedParams OpenPageRecordedParams
        {
            get
            {
                if ((this.mOpenPageRecordedParams == null))
                {
                    this.mOpenPageRecordedParams = new OpenPageRecordedParams();
                }
                return this.mOpenPageRecordedParams;
            }
        }
        
        public virtual ColumnCounterValueAssertExpectedValues ColumnCounterValueAssertExpectedValues
        {
            get
            {
                if ((this.mColumnCounterValueAssertExpectedValues == null))
                {
                    this.mColumnCounterValueAssertExpectedValues = new ColumnCounterValueAssertExpectedValues();
                }
                return this.mColumnCounterValueAssertExpectedValues;
            }
        }
        
        public virtual SaveValueRecordedParams SaveValueRecordedParams
        {
            get
            {
                if ((this.mSaveValueRecordedParams == null))
                {
                    this.mSaveValueRecordedParams = new SaveValueRecordedParams();
                }
                return this.mSaveValueRecordedParams;
            }
        }
        
        public virtual SavedValueAssertExpectedValues SavedValueAssertExpectedValues
        {
            get
            {
                if ((this.mSavedValueAssertExpectedValues == null))
                {
                    this.mSavedValueAssertExpectedValues = new SavedValueAssertExpectedValues();
                }
                return this.mSavedValueAssertExpectedValues;
            }
        }
        
        public UIVerifyingCodebyUsingWindow UIVerifyingCodebyUsingWindow
        {
            get
            {
                if ((this.mUIVerifyingCodebyUsingWindow == null))
                {
                    this.mUIVerifyingCodebyUsingWindow = new UIVerifyingCodebyUsingWindow();
                }
                return this.mUIVerifyingCodebyUsingWindow;
            }
        }
        
        public UIEditMozillaFirefoxWindow UIEditMozillaFirefoxWindow
        {
            get
            {
                if ((this.mUIEditMozillaFirefoxWindow == null))
                {
                    this.mUIEditMozillaFirefoxWindow = new UIEditMozillaFirefoxWindow();
                }
                return this.mUIEditMozillaFirefoxWindow;
            }
        }
        
        public UIIndexMozillaFirefoxWindow UIIndexMozillaFirefoxWindow
        {
            get
            {
                if ((this.mUIIndexMozillaFirefoxWindow == null))
                {
                    this.mUIIndexMozillaFirefoxWindow = new UIIndexMozillaFirefoxWindow();
                }
                return this.mUIIndexMozillaFirefoxWindow;
            }
        }
        
        public UIIndexMozillaFirefoxWindow1 UIIndexMozillaFirefoxWindow1
        {
            get
            {
                if ((this.mUIIndexMozillaFirefoxWindow1 == null))
                {
                    this.mUIIndexMozillaFirefoxWindow1 = new UIIndexMozillaFirefoxWindow1();
                }
                return this.mUIIndexMozillaFirefoxWindow1;
            }
        }
        #endregion
        
        #region Fields
        private OpenPageRecordedParams mOpenPageRecordedParams;
        
        private ColumnCounterValueAssertExpectedValues mColumnCounterValueAssertExpectedValues;
        
        private SaveValueRecordedParams mSaveValueRecordedParams;
        
        private SavedValueAssertExpectedValues mSavedValueAssertExpectedValues;
        
        private UIVerifyingCodebyUsingWindow mUIVerifyingCodebyUsingWindow;
        
        private UIEditMozillaFirefoxWindow mUIEditMozillaFirefoxWindow;
        
        private UIIndexMozillaFirefoxWindow mUIIndexMozillaFirefoxWindow;
        
        private UIIndexMozillaFirefoxWindow1 mUIIndexMozillaFirefoxWindow1;
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'OpenPageRecorded'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class OpenPageRecordedParams
    {
        
        #region Fields
        /// <summary>
        /// Select 'http://localhost:50669/' in combo box
        /// </summary>
        public string UIItemComboBoxEditableItem = "http://localhost:50669/";
        
        /// <summary>
        /// Type '{Enter}' in 'Wprowadź adres lub szukaj' text box
        /// </summary>
        public string UIWprowadźadreslubszukEditSendKeys = "{Enter}";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'ColumnCounterValueAssert'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class ColumnCounterValueAssertExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of 'CounterValue' text box contains 'CounterValue'
        /// </summary>
        public string UICounterValueEditName = "CounterValue";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SaveValueRecorded'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class SaveValueRecordedParams
    {
        
        #region Fields
        /// <summary>
        /// Type '54.5454545454' in 'CounterValue' text box
        /// </summary>
        public string UICounterValueEditText = "54.5454545454";
        #endregion
    }
    
    /// <summary>
    /// Parameters to be passed into 'SavedValueAssert'
    /// </summary>
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class SavedValueAssertExpectedValues
    {
        
        #region Fields
        /// <summary>
        /// Verify that the 'Name' property of '54.5454545454' text box contains '54.5454545454'
        /// </summary>
        public string UIItem545454545454EditName = "54.5454545454";
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIVerifyingCodebyUsingWindow : WinWindow
    {
        
        public UIVerifyingCodebyUsingWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Verifying Code by Using UI Automation - Mozilla Firefox";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MozillaWindowClass";
            this.WindowTitles.Add("Verifying Code by Using UI Automation - Mozilla Firefox");
            this.WindowTitles.Add("Nowa karta - Mozilla Firefox");
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public UIKartyprzeglądarkiToolBar UIKartyprzeglądarkiToolBar
        {
            get
            {
                if ((this.mUIKartyprzeglądarkiToolBar == null))
                {
                    this.mUIKartyprzeglądarkiToolBar = new UIKartyprzeglądarkiToolBar(this);
                }
                return this.mUIKartyprzeglądarkiToolBar;
            }
        }
        
        public UIPaseknarzędzinawigacToolBar UIPaseknarzędzinawigacToolBar
        {
            get
            {
                if ((this.mUIPaseknarzędzinawigacToolBar == null))
                {
                    this.mUIPaseknarzędzinawigacToolBar = new UIPaseknarzędzinawigacToolBar(this);
                }
                return this.mUIPaseknarzędzinawigacToolBar;
            }
        }
        
        public UIItemComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new UIItemComboBox(this);
                }
                return this.mUIItemComboBox;
            }
        }
        
        public UICounterValueColumnHeader UICounterValueColumnHeader
        {
            get
            {
                if ((this.mUICounterValueColumnHeader == null))
                {
                    this.mUICounterValueColumnHeader = new UICounterValueColumnHeader(this);
                }
                return this.mUICounterValueColumnHeader;
            }
        }
        
        public UIEditHyperlink UIEditHyperlink
        {
            get
            {
                if ((this.mUIEditHyperlink == null))
                {
                    this.mUIEditHyperlink = new UIEditHyperlink(this);
                }
                return this.mUIEditHyperlink;
            }
        }
        #endregion
        
        #region Fields
        private UIKartyprzeglądarkiToolBar mUIKartyprzeglądarkiToolBar;
        
        private UIPaseknarzędzinawigacToolBar mUIPaseknarzędzinawigacToolBar;
        
        private UIItemComboBox mUIItemComboBox;
        
        private UICounterValueColumnHeader mUICounterValueColumnHeader;
        
        private UIEditHyperlink mUIEditHyperlink;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIKartyprzeglądarkiToolBar : WinToolBar
    {
        
        public UIKartyprzeglądarkiToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinToolBar.PropertyNames.Name] = "Karty przeglądarki";
            this.WindowTitles.Add("Verifying Code by Using UI Automation - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinButton UINowakartaButton
        {
            get
            {
                if ((this.mUINowakartaButton == null))
                {
                    this.mUINowakartaButton = new WinButton(this);
                    #region Search Criteria
                    this.mUINowakartaButton.SearchProperties[WinButton.PropertyNames.Name] = "Nowa karta";
                    this.mUINowakartaButton.WindowTitles.Add("Verifying Code by Using UI Automation - Mozilla Firefox");
                    #endregion
                }
                return this.mUINowakartaButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUINowakartaButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIPaseknarzędzinawigacToolBar : WinToolBar
    {
        
        public UIPaseknarzędzinawigacToolBar(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinToolBar.PropertyNames.Name] = "Pasek narzędzi nawigacyjnych";
            this.WindowTitles.Add("Nowa karta - Mozilla Firefox");
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinComboBox UIItemComboBox
        {
            get
            {
                if ((this.mUIItemComboBox == null))
                {
                    this.mUIItemComboBox = new WinComboBox(this);
                    #region Search Criteria
                    this.mUIItemComboBox.WindowTitles.Add("Nowa karta - Mozilla Firefox");
                    this.mUIItemComboBox.WindowTitles.Add("Index - Mozilla Firefox");
                    #endregion
                }
                return this.mUIItemComboBox;
            }
        }
        #endregion
        
        #region Fields
        private WinComboBox mUIItemComboBox;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemComboBox : WinComboBox
    {
        
        public UIItemComboBox(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Nowa karta - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UIWprowadźadreslubszukEdit
        {
            get
            {
                if ((this.mUIWprowadźadreslubszukEdit == null))
                {
                    this.mUIWprowadźadreslubszukEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIWprowadźadreslubszukEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Wprowadź adres lub szukaj";
                    this.mUIWprowadźadreslubszukEdit.WindowTitles.Add("Nowa karta - Mozilla Firefox");
                    #endregion
                }
                return this.mUIWprowadźadreslubszukEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIWprowadźadreslubszukEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UICounterValueColumnHeader : WinColumnHeader
    {
        
        public UICounterValueColumnHeader(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "CounterValue";
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UICounterValueEdit
        {
            get
            {
                if ((this.mUICounterValueEdit == null))
                {
                    this.mUICounterValueEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUICounterValueEdit.SearchProperties[WinEdit.PropertyNames.Name] = "CounterValue ";
                    this.mUICounterValueEdit.WindowTitles.Add("Index - Mozilla Firefox");
                    #endregion
                }
                return this.mUICounterValueEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUICounterValueEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIEditHyperlink : WinHyperlink
    {
        
        public UIEditHyperlink(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinHyperlink.PropertyNames.Name] = "Edit";
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UIEditEdit
        {
            get
            {
                if ((this.mUIEditEdit == null))
                {
                    this.mUIEditEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIEditEdit.SearchProperties[WinEdit.PropertyNames.Name] = "Edit";
                    this.mUIEditEdit.WindowTitles.Add("Index - Mozilla Firefox");
                    #endregion
                }
                return this.mUIEditEdit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIEditEdit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIEditMozillaFirefoxWindow : WinWindow
    {
        
        public UIEditMozillaFirefoxWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Edit - Mozilla Firefox";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MozillaWindowClass";
            this.WindowTitles.Add("Edit - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public UIValuesGroup UIValuesGroup
        {
            get
            {
                if ((this.mUIValuesGroup == null))
                {
                    this.mUIValuesGroup = new UIValuesGroup(this);
                }
                return this.mUIValuesGroup;
            }
        }
        #endregion
        
        #region Fields
        private UIValuesGroup mUIValuesGroup;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIValuesGroup : WinGroup
    {
        
        public UIValuesGroup(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinControl.PropertyNames.Name] = "Values ";
            this.WindowTitles.Add("Edit - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UICounterValueEdit
        {
            get
            {
                if ((this.mUICounterValueEdit == null))
                {
                    this.mUICounterValueEdit = new WinEdit(this);
                    #region Search Criteria
                    this.mUICounterValueEdit.SearchProperties[WinEdit.PropertyNames.Name] = "CounterValue";
                    this.mUICounterValueEdit.WindowTitles.Add("Edit - Mozilla Firefox");
                    #endregion
                }
                return this.mUICounterValueEdit;
            }
        }
        
        public WinButton UISaveButton
        {
            get
            {
                if ((this.mUISaveButton == null))
                {
                    this.mUISaveButton = new WinButton(this);
                    #region Search Criteria
                    this.mUISaveButton.SearchProperties[WinButton.PropertyNames.Name] = "Save";
                    this.mUISaveButton.WindowTitles.Add("Edit - Mozilla Firefox");
                    #endregion
                }
                return this.mUISaveButton;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUICounterValueEdit;
        
        private WinButton mUISaveButton;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIndexMozillaFirefoxWindow : WinWindow
    {
        
        public UIIndexMozillaFirefoxWindow()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Index - Mozilla Firefox";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MozillaWindowClass";
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public UIItemCell UIItemCell
        {
            get
            {
                if ((this.mUIItemCell == null))
                {
                    this.mUIItemCell = new UIItemCell(this);
                }
                return this.mUIItemCell;
            }
        }
        #endregion
        
        #region Fields
        private UIItemCell mUIItemCell;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIItemCell : WinCell
    {
        
        public UIItemCell(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinEdit UIItem545454545454Edit
        {
            get
            {
                if ((this.mUIItem545454545454Edit == null))
                {
                    this.mUIItem545454545454Edit = new WinEdit(this);
                    #region Search Criteria
                    this.mUIItem545454545454Edit.SearchProperties[WinEdit.PropertyNames.Name] = "54.5454545454 ";
                    this.mUIItem545454545454Edit.WindowTitles.Add("Index - Mozilla Firefox");
                    #endregion
                }
                return this.mUIItem545454545454Edit;
            }
        }
        #endregion
        
        #region Fields
        private WinEdit mUIItem545454545454Edit;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIndexMozillaFirefoxWindow1 : WinWindow
    {
        
        public UIIndexMozillaFirefoxWindow1()
        {
            #region Search Criteria
            this.SearchProperties[WinWindow.PropertyNames.Name] = "Index - Mozilla Firefox";
            this.SearchProperties[WinWindow.PropertyNames.ClassName] = "MozillaWindowClass";
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public UIIndexTabPage UIIndexTabPage
        {
            get
            {
                if ((this.mUIIndexTabPage == null))
                {
                    this.mUIIndexTabPage = new UIIndexTabPage(this);
                }
                return this.mUIIndexTabPage;
            }
        }
        #endregion
        
        #region Fields
        private UIIndexTabPage mUIIndexTabPage;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.60315.1")]
    public class UIIndexTabPage : WinTabPage
    {
        
        public UIIndexTabPage(UITestControl searchLimitContainer) : 
                base(searchLimitContainer)
        {
            #region Search Criteria
            this.SearchProperties[WinTabPage.PropertyNames.Name] = "Index";
            this.WindowTitles.Add("Index - Mozilla Firefox");
            #endregion
        }
        
        #region Properties
        public WinButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WinButton(this);
                    #region Search Criteria
                    this.mUIItemButton.WindowTitles.Add("Index - Mozilla Firefox");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        #endregion
        
        #region Fields
        private WinButton mUIItemButton;
        #endregion
    }
}
