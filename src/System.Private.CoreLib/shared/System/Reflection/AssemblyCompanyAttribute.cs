// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

namespace System.Reflection
{
    [AttributeUsage(AttributeTargets.Assembly, Inherited = false)]
    public sealed class AssemblyCompanyAttribute : Attribute
    {
        public AssemblyCompanyAttribute(string company)
        {
            Company = company;
        }

        public string Company { get; }
    }
}

