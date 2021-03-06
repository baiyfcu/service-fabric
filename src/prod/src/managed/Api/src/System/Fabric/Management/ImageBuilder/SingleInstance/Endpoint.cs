// ------------------------------------------------------------
//  Copyright (c) Microsoft Corporation.  All rights reserved.
// ------------------------------------------------------------

namespace System.Fabric.Management.ImageBuilder.SingleInstance
{
    using System.Collections.Generic;
    using System.IO;

    internal class Endpoint
    {
        public Endpoint()
        {
            this.port = 0;
            this.name = null;
        }

        public string name;
        public int port;
    };
}
