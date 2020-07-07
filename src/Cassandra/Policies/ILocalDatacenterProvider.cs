﻿// 
//       Copyright (C) DataStax Inc.
// 
//    Licensed under the Apache License, Version 2.0 (the "License");
//    you may not use this file except in compliance with the License.
//    You may obtain a copy of the License at
// 
//       http://www.apache.org/licenses/LICENSE-2.0
// 
//    Unless required by applicable law or agreed to in writing, software
//    distributed under the License is distributed on an "AS IS" BASIS,
//    WITHOUT WARRANTIES OR CONDITIONS OF ANY KIND, either express or implied.
//    See the License for the specific language governing permissions and
//    limitations under the License.

using Cassandra.Connections.Control;
using Cassandra.SessionManagement;

namespace Cassandra
{
    /// <summary>
    /// Obtains or infers the local datacenter.
    /// </summary>
    internal interface ILocalDatacenterProvider
    {
        /// <summary>
        /// Obtains or infers the local datacenter (in case of implicit contact point).
        /// </summary>
        string DiscoverLocalDatacenter(bool inferLocalDc, string policyDatacenter);

        /// <summary>
        /// Should be called after we have an initialized cluster instance.
        /// </summary>
        void Initialize(IInternalCluster cluster, IInternalMetadata internalMetadata);
    }
}