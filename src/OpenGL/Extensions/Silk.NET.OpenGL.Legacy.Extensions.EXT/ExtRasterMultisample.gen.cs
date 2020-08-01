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
using Silk.NET.Core.InteropServices;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Legacy.Extensions.EXT
{
    [Extension("EXT_raster_multisample")]
    public abstract unsafe partial class ExtRasterMultisample : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_raster_multisample";
        [NativeApi(EntryPoint = "glRasterSamplesEXT")]
        public abstract void RasterSamples([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        public ExtRasterMultisample(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

