// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.InteropServices;

#pragma warning disable 1591

namespace Silk.NET.OpenGL.Extensions.ARB
{
    [Extension("ARB_imaging")]
    public abstract unsafe partial class ArbImaging : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_imaging";
        [NativeApi(EntryPoint = "glBlendColor")]
        public abstract void BlendColor([Flow(FlowDirection.In)] float red, [Flow(FlowDirection.In)] float green, [Flow(FlowDirection.In)] float blue, [Flow(FlowDirection.In)] float alpha);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glBlendEquation")]
        public abstract void BlendEquation([Flow(FlowDirection.In)] BlendEquationModeEXT mode);

        public ArbImaging(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

