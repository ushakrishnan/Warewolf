/*
*  Warewolf - The Easy Service Bus
*  Copyright 2016 by Warewolf Ltd <alpha@warewolf.io>
*  Licensed under GNU Affero General Public License 3.0 or later. 
*  Some rights reserved.
*  Visit our website for more information <http://warewolf.io/>
*  AUTHORS <http://warewolf.io/authors.php> , CONTRIBUTORS <http://warewolf.io/contributors.php>
*  @license GNU Affero General Public License <http://www.gnu.org/licenses/agpl-3.0.html>
*/

using System;
using Dev2.Data;

namespace Dev2.Session
{
    public interface IDev2StudioSessionBroker : IDebugSession,IDisposable
    {
        // ReSharper disable InconsistentNaming
        string GetXMLForInputs(IDataListModel dataListModel);
        // ReSharper restore InconsistentNaming

   
    }
}