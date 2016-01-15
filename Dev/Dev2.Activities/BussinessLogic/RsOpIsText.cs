
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
using System.Collections.Generic;
using System.Linq;
using Dev2.Common.ExtMethods;
// ReSharper disable CheckNamespace
namespace Dev2.DataList
{
    /// <summary>
    /// Class for the "Is Text" recordset search option 
    /// </summary>
    public class RsOpIsText : AbstractRecsetSearchValidation
    {
        public override Func<DataASTMutable.WarewolfAtom, bool> CreateFunc(IEnumerable<DataASTMutable.WarewolfAtom> values, IEnumerable<DataASTMutable.WarewolfAtom> warewolfAtoms, IEnumerable<DataASTMutable.WarewolfAtom> to, bool all)
        {

            return a => values.All(x => a.ToString().IsAlpha());

        }
        public override string HandlesType()
        {
            return "Is Text";
        }

        public override int ArgumentCount
        {
            get
            {
                return 1;
            }
        }
    }
}
