// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License. See License.txt in the project root for license information.

// Warning: This code was generated by a tool.
// 
// Changes to this file may cause incorrect behavior and will be lost if the
// code is regenerated.

using System;
using System.Linq;
using Microsoft.Azure.Management.Automation.Models;

namespace Microsoft.Azure.Management.Automation.Models
{
    /// <summary>
    /// Definition of the job stream.
    /// </summary>
    public partial class JobStream
    {
        private JobStreamProperties _properties;
        
        /// <summary>
        /// Optional. Gets or sets the id of the job stream.
        /// </summary>
        public JobStreamProperties Properties
        {
            get { return this._properties; }
            set { this._properties = value; }
        }
        
        /// <summary>
        /// Initializes a new instance of the JobStream class.
        /// </summary>
        public JobStream()
        {
        }
    }
}
