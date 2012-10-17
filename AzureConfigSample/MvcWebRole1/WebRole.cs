using System;
using System.Collections.Generic;
using System.Linq;
using Microsoft.WindowsAzure;
using Microsoft.WindowsAzure.Diagnostics;
using Microsoft.WindowsAzure.ServiceRuntime;

namespace MvcWebRole1
{
    using System.Diagnostics;

    public class WebRole : RoleEntryPoint
    {
        public override bool OnStart()
        {
            // Initialize the azure specific trace listener
            Trace.Listeners.Add(new DiagnosticMonitorTraceListener());

            return base.OnStart();
        }
    }
}
