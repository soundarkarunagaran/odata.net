//   OData .NET Libraries
//   Copyright (c) Microsoft Corporation. All rights reserved.  
//   Licensed under the Apache License, Version 2.0 (the "License");
//   you may not use this file except in compliance with the License.
//   You may obtain a copy of the License at

//       http://www.apache.org/licenses/LICENSE-2.0

//   Unless required by applicable law or agreed to in writing, software
//   distributed under the License is distributed on an "AS IS" BASIS,
//   WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//   See the License for the specific language governing permissions and
//   limitations under the License.

using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using Microsoft.OData.Edm.Expressions;

namespace Microsoft.OData.Edm.Library.Expressions
{
    /// <summary>
    /// Represents an EDM enumeration member reference expression.
    /// </summary>
    public class EdmEnumMemberExpression : EdmElement, IEdmEnumMemberExpression
    {
        private readonly List<IEdmEnumMember> enumMembers;

        /// <summary>
        /// Initializes a new instance of the <see cref="EdmEnumMemberExpression"/> class.
        /// </summary>
        /// <param name="enumMembers">Referenced enum member.</param>
        public EdmEnumMemberExpression(params IEdmEnumMember[] enumMembers)
        {
            EdmUtil.CheckArgumentNull(enumMembers, "referencedEnumMember");
            Debug.Assert(enumMembers.Any(), "enumMembers is empty.");
            this.enumMembers = enumMembers.ToList();
        }

        /// <summary>
        /// Gets the referenced enum member.
        /// </summary>
        public IEnumerable<IEdmEnumMember> EnumMembers
        {
            get { return this.enumMembers; }
        }

        /// <summary>
        /// Gets the kind of this expression.
        /// </summary>
        public EdmExpressionKind ExpressionKind
        {
            get { return EdmExpressionKind.EnumMember; }
        }
    }
}