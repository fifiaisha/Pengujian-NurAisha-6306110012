﻿// ------------------------------------------------------------------------------
//  <auto-generated>
//      This code was generated by coded UI test builder.
//      Version: 11.0.0.0
//
//      Changes to this file may cause incorrect behavior and will be lost if
//      the code is regenerated.
//  </auto-generated>
// ------------------------------------------------------------------------------

namespace CodedUITestProject2
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
    
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public partial class UIMap
    {
        
        /// <summary>
        /// MethodPlus
        /// </summary>
        public void MethodPlus()
        {
            #region Variable Declarations
            WpfButton uIItem5Button = this.UIMyCalculatorv1Window.UIItem5Button;
            WpfButton uIItemButton = this.UIMyCalculatorv1Window.UIItemButton;
            WpfButton uIItem3Button = this.UIMyCalculatorv1Window.UIItem3Button;
            WpfButton uIItemButton1 = this.UIMyCalculatorv1Window.UIItemButton1;
            #endregion

            // Click '5' button
            Mouse.Click(uIItem5Button, new Point(22, 23));

            // Click '+' button
            Mouse.Click(uIItemButton, new Point(24, 7));

            // Click '3' button
            Mouse.Click(uIItem3Button, new Point(41, 5));

            // Click '=' button
            Mouse.Click(uIItemButton1, new Point(73, 16));
        }
        
        /// <summary>
        /// MethodMinus
        /// </summary>
        public void MethodMinus()
        {
            #region Variable Declarations
            WpfButton uIItem5Button = this.UIMyCalculatorv1Window.UIItem5Button;
            WpfButton uIItemButton2 = this.UIMyCalculatorv1Window.UIItemButton2;
            WpfButton uIItem1Button = this.UIMyCalculatorv1Window.UIItem1Button;
            WpfButton uIItemButton1 = this.UIMyCalculatorv1Window.UIItemButton1;
            #endregion

            // Click '5' button
            Mouse.Click(uIItem5Button, new Point(20, 14));

            // Click '-' button
            Mouse.Click(uIItemButton2, new Point(18, 13));

            // Click '1' button
            Mouse.Click(uIItem1Button, new Point(32, 5));

            // Click '=' button
            Mouse.Click(uIItemButton1, new Point(75, 18));
        }
        
        /// <summary>
        /// MethodMulti
        /// </summary>
        public void MethodMulti()
        {
            #region Variable Declarations
            WpfButton uIItem4Button = this.UIMyCalculatorv1Window.UIItem4Button;
            WpfButton uIItemButton3 = this.UIMyCalculatorv1Window.UIItemButton3;
            WpfButton uIItem2Button = this.UIMyCalculatorv1Window.UIItem2Button;
            WpfButton uIItemButton1 = this.UIMyCalculatorv1Window.UIItemButton1;
            #endregion

            // Click '4' button
            Mouse.Click(uIItem4Button, new Point(32, 12));

            // Click '*' button
            Mouse.Click(uIItemButton3, new Point(16, 11));

            // Click '2' button
            Mouse.Click(uIItem2Button, new Point(17, 8));

            // Click '=' button
            Mouse.Click(uIItemButton1, new Point(70, 4));
        }
        
        /// <summary>
        /// MethodDiv
        /// </summary>
        public void MethodDiv()
        {
            #region Variable Declarations
            WpfButton uIItem9Button = this.UIMyCalculatorv1Window.UIItem9Button;
            WpfButton uIItemButton4 = this.UIMyCalculatorv1Window.UIItemButton4;
            WpfButton uIItem3Button = this.UIMyCalculatorv1Window.UIItem3Button;
            WpfButton uIItemButton1 = this.UIMyCalculatorv1Window.UIItemButton1;
            #endregion

            // Click '9' button
            Mouse.Click(uIItem9Button, new Point(13, 10));

            // Click '/' button
            Mouse.Click(uIItemButton4, new Point(32, 16));

            // Click '3' button
            Mouse.Click(uIItem3Button, new Point(28, 13));

            // Click '=' button
            Mouse.Click(uIItemButton1, new Point(66, 12));
        }
        
        #region Properties
        public UIMyCalculatorv1Window UIMyCalculatorv1Window
        {
            get
            {
                if ((this.mUIMyCalculatorv1Window == null))
                {
                    this.mUIMyCalculatorv1Window = new UIMyCalculatorv1Window();
                }
                return this.mUIMyCalculatorv1Window;
            }
        }
        #endregion
        
        #region Fields
        private UIMyCalculatorv1Window mUIMyCalculatorv1Window;
        #endregion
    }
    
    [GeneratedCode("Coded UITest Builder", "11.0.50727.1")]
    public class UIMyCalculatorv1Window : WpfWindow
    {
        
        public UIMyCalculatorv1Window()
        {
            #region Search Criteria
            this.SearchProperties[WpfWindow.PropertyNames.Name] = "MyCalculator v1";
            this.SearchProperties.Add(new PropertyExpression(WpfWindow.PropertyNames.ClassName, "HwndWrapper", PropertyExpressionOperator.Contains));
            this.WindowTitles.Add("MyCalculator v1");
            #endregion
        }
        
        #region Properties
        public WpfButton UIItem5Button
        {
            get
            {
                if ((this.mUIItem5Button == null))
                {
                    this.mUIItem5Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem5Button.SearchProperties[WpfButton.PropertyNames.Name] = "5";
                    this.mUIItem5Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem5Button;
            }
        }
        
        public WpfButton UIItemButton
        {
            get
            {
                if ((this.mUIItemButton == null))
                {
                    this.mUIItemButton = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton.SearchProperties[WpfButton.PropertyNames.Name] = "+";
                    this.mUIItemButton.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton;
            }
        }
        
        public WpfButton UIItem3Button
        {
            get
            {
                if ((this.mUIItem3Button == null))
                {
                    this.mUIItem3Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem3Button.SearchProperties[WpfButton.PropertyNames.Name] = "3";
                    this.mUIItem3Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem3Button;
            }
        }
        
        public WpfButton UIItemButton1
        {
            get
            {
                if ((this.mUIItemButton1 == null))
                {
                    this.mUIItemButton1 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton1.SearchProperties[WpfButton.PropertyNames.Name] = "=";
                    this.mUIItemButton1.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton1;
            }
        }
        
        public WpfButton UIItemButton2
        {
            get
            {
                if ((this.mUIItemButton2 == null))
                {
                    this.mUIItemButton2 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton2.SearchProperties[WpfButton.PropertyNames.Name] = "-";
                    this.mUIItemButton2.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton2;
            }
        }
        
        public WpfButton UIItem1Button
        {
            get
            {
                if ((this.mUIItem1Button == null))
                {
                    this.mUIItem1Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem1Button.SearchProperties[WpfButton.PropertyNames.Name] = "1";
                    this.mUIItem1Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem1Button;
            }
        }
        
        public WpfButton UIItem4Button
        {
            get
            {
                if ((this.mUIItem4Button == null))
                {
                    this.mUIItem4Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem4Button.SearchProperties[WpfButton.PropertyNames.Name] = "4";
                    this.mUIItem4Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem4Button;
            }
        }
        
        public WpfButton UIItemButton3
        {
            get
            {
                if ((this.mUIItemButton3 == null))
                {
                    this.mUIItemButton3 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton3.SearchProperties[WpfButton.PropertyNames.Name] = "*";
                    this.mUIItemButton3.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton3;
            }
        }
        
        public WpfButton UIItem2Button
        {
            get
            {
                if ((this.mUIItem2Button == null))
                {
                    this.mUIItem2Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem2Button.SearchProperties[WpfButton.PropertyNames.Name] = "2";
                    this.mUIItem2Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem2Button;
            }
        }
        
        public WpfButton UIItem9Button
        {
            get
            {
                if ((this.mUIItem9Button == null))
                {
                    this.mUIItem9Button = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItem9Button.SearchProperties[WpfButton.PropertyNames.Name] = "9";
                    this.mUIItem9Button.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItem9Button;
            }
        }
        
        public WpfButton UIItemButton4
        {
            get
            {
                if ((this.mUIItemButton4 == null))
                {
                    this.mUIItemButton4 = new WpfButton(this);
                    #region Search Criteria
                    this.mUIItemButton4.SearchProperties[WpfButton.PropertyNames.Name] = "/";
                    this.mUIItemButton4.WindowTitles.Add("MyCalculator v1");
                    #endregion
                }
                return this.mUIItemButton4;
            }
        }
        #endregion
        
        #region Fields
        private WpfButton mUIItem5Button;
        
        private WpfButton mUIItemButton;
        
        private WpfButton mUIItem3Button;
        
        private WpfButton mUIItemButton1;
        
        private WpfButton mUIItemButton2;
        
        private WpfButton mUIItem1Button;
        
        private WpfButton mUIItem4Button;
        
        private WpfButton mUIItemButton3;
        
        private WpfButton mUIItem2Button;
        
        private WpfButton mUIItem9Button;
        
        private WpfButton mUIItemButton4;
        #endregion
    }
}