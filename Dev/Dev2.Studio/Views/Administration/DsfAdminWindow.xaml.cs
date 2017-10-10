/*
*  Warewolf - Once bitten, there's no going back
*  Copyright 2017 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System.Windows;


namespace Unlimited.Applications.BusinessDesignStudio.Views
{
    /// <summary>
    /// Interaction logic for DsfAdminWindow.xaml
    /// </summary>
    public partial class DsfAdminWindow
    {
        public DsfAdminWindow()
        {
            InitializeComponent();

        }

        private void DocumentContentLoaded(object sender, RoutedEventArgs e)
        {
            dynamic dataContext = DataContext;
            dataContext.Console = TxtConsole;
            dataContext.CommandText = TxtUserCommand;
            TxtUserCommand.Focus();
        }


    }
}
