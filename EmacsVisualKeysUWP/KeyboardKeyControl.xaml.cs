using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at https://go.microsoft.com/fwlink/?LinkId=234236

namespace EmacsVisualKeysUWP
{
    public sealed partial class KeyboardKeyControl : UserControl
    {
        public KeyboardKeyControl()
        {
            this.InitializeComponent();
        }

        static KeyboardKeyControl()
        {
            AdditionalContentProperty =
            DependencyProperty.Register("AdditionalContent", typeof(object), typeof(KeyboardKeyControl),
              new PropertyMetadata(null));
        }

        /// <summary>
        /// Gets or sets additional content for the UserControl
        /// </summary>
        public object AdditionalContent
        {
            get { return (object)GetValue(AdditionalContentProperty); }
            set { SetValue(AdditionalContentProperty, value); }
        }
        public static DependencyProperty AdditionalContentProperty;
    }
}
