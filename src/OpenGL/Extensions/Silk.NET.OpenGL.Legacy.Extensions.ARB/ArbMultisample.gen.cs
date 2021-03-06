// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL.Legacy;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_multisample")]
    public abstract unsafe partial class ArbMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_multisample";
        /// <summary>
        /// To be added.
        /// </summary>
        /// <param name="value">
        /// To be added.
        /// </param>
        /// <param name="invert">
        /// To be added.
        /// </param>
        [NativeApi(EntryPoint = "glSampleCoverageARB")]
        public abstract void SampleCoverage([Flow(FlowDirection.In)] float value, [Flow(FlowDirection.In)] bool invert);

        public ArbMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

