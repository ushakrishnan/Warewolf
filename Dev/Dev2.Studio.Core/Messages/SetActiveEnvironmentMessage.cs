
/*
*  Warewolf - The Easy Service Bus
*  Copyright 2016 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using Dev2.Studio.Core.Interfaces;

// ReSharper disable CheckNamespace
namespace Dev2.Studio.Core.Messages
{
    public class SetActiveEnvironmentMessage : IMessage
    {
        public IEnvironmentModel EnvironmentModel { get; set; }

        public bool SetFromConnectControl { get; set; }

        public SetActiveEnvironmentMessage(IEnvironmentModel environmentModel, bool setFromConnectControl = false)
        {
            EnvironmentModel = environmentModel;
            SetFromConnectControl = setFromConnectControl;
        }
    }
}
