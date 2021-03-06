// Copyright (c) Microsoft and contributors.  All rights reserved.
// 
// Licensed under the Apache License, Version 2.0 (the "License");
// you may not use this file except in compliance with the License.
// You may obtain a copy of the License at
// http://www.apache.org/licenses/LICENSE-2.0
// 
// Unless required by applicable law or agreed to in writing, software
// distributed under the License is distributed on an "AS IS" BASIS,
// WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
// 
// See the License for the specific language governing permissions and
// limitations under the License.
// 
// Code generated by Microsoft (R) AutoRest Code Generator.
// Changes may cause incorrect behavior and will be lost if the code is
// regenerated.

//
// This file was autogenerated by a tool.
// Do not modify it.
//

namespace Microsoft.Azure.Batch
{
    using Models = Microsoft.Azure.Batch.Protocol.Models;
    using System;
    using System.Collections.Generic;
    using System.Linq;

    /// <summary>
    /// Contains information about an application in an Azure Batch account.
    /// </summary>
    public partial class ApplicationSummary : IPropertyMetadata
    {
        private readonly string displayName;
        private readonly string id;
        private readonly IReadOnlyList<string> versions;

        #region Constructors

        internal ApplicationSummary(Models.ApplicationSummary protocolObject)
        {
            this.displayName = protocolObject.DisplayName;
            this.id = protocolObject.Id;
            this.versions = UtilitiesInternal.CreateObjectWithNullCheck(protocolObject.Versions, o => o.ToList().AsReadOnly());
        }

        #endregion Constructors

        #region ApplicationSummary

        /// <summary>
        /// Gets the display name of the application.
        /// </summary>
        public string DisplayName
        {
            get { return this.displayName; }
        }

        /// <summary>
        /// Gets the id of the application.
        /// </summary>
        public string Id
        {
            get { return this.id; }
        }

        /// <summary>
        /// Gets a readonly list of available versions of the application.
        /// </summary>
        public IReadOnlyList<string> Versions
        {
            get { return this.versions; }
        }

        #endregion // ApplicationSummary

        #region IPropertyMetadata

        bool IModifiable.HasBeenModified
        {
            //This class is compile time readonly so it cannot have been modified
            get { return false; }
        }

        bool IReadOnly.IsReadOnly
        {
            get { return true; }
            set
            {
                // This class is compile time readonly already
            }
        }

        #endregion // IPropertyMetadata
    }
}