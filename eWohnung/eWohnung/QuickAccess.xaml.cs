using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using Xamarin.Forms;

namespace eWohnung
{
    public partial class QuickAccess : ContentView
    {
        public QuickAccess()
        {
            InitializeComponent();
            
        }

        #region QuickCommandProperty
        public static BindableProperty QuickCommandProperty = BindableProperty.Create
            (
                propertyName: "QuickCommand",
                returnType: typeof(ICommand),
                declaringType: typeof(QuickAccess),
                defaultValue: null,
                defaultBindingMode: BindingMode.Default,
                propertyChanged: (b, o, n) =>
                {
                    ((QuickAccess)b).GestureRecognizer.Command = (Command)n;
                    ((QuickAccess)b).GestureRecognizer.CommandParameter = (QuickAccess)b;
                }
            );
        #endregion
        #region QuickCommand
        public ICommand QuickCommand
        {
            get { return (ICommand)GetValue(QuickCommandProperty); }
            set { SetValue(QuickCommandProperty, value); }
        }
        #endregion


        #region QuickIconProperty
        public static BindableProperty QuickIconProperty = BindableProperty.Create
            (
                propertyName: "QuickIcon",
                returnType: typeof(string),
                declaringType: typeof(QuickAccess),
                defaultValue: null,
                defaultBindingMode: BindingMode.Default,
                propertyChanged: (b, o, n) =>
                {
                    ((QuickAccess)b).Icon.Source = (string)n;
                }
            );
        #endregion
        #region QuickIcon
        public string QuickIcon
        {
            get { return (string)GetValue(QuickIconProperty); }
            set { SetValue(QuickIconProperty, value); }
        }
        #endregion

        #region QuickTitleProperty
        public static BindableProperty QuickTitleProperty = BindableProperty.Create
            (
                propertyName: "QuickTitle",
                returnType: typeof(string),
                declaringType: typeof(QuickAccess),
                defaultValue: null,
                defaultBindingMode: BindingMode.Default,
                propertyChanged: (b, o, n) =>
                {
                    ((QuickAccess)b).Title.Text = (string)n;
                }
            );
        #endregion
        #region QuickTitle
        public string QuickTitle
        {
            get { return (string)GetValue(QuickTitleProperty); }
            set { SetValue(QuickTitleProperty, value); }
        }
        #endregion

    }
}
