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

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace CalculatorWin10._2
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private static object myObj;
        private void ButtonClicked(object sender, RoutedEventArgs e)
        {
            myObj = ((Button)sender).Tag;
            ClickHandler.InformationPassed(myObj.ToString());
            //expressionView.Text = DisplayInfo.currentExpression;
            //screen.Text = DisplayInfo.ErrorOccured ?
            //    "Cannot divide by zero" : DisplayInfo.ExpressionToSuitable(
            //        DisplayInfo.expressionValue);
            //DisplayInfo.ErrorOccured = false;

        }
        // OTHER FUNCTIONS
        private void menu_Click(object sender, RoutedEventArgs e)
        {

        }
        private void history_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
