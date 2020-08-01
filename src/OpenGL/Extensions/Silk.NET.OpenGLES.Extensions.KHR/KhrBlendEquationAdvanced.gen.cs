// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.OpenGLES;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Silk.NET.Core.InteropServices;

#pragma warning disable 1591

namespace Silk.NET.OpenGLES.Extensions.KHR
{
    [Extension("KHR_blend_equation_advanced")]
    public abstract unsafe partial class KhrBlendEquationAdvanced : NativeExtension<GL>
    {
        public const string ExtensionName = "KHR_blend_equation_advanced";
        [NativeApi(EntryPoint = "glBlendBarrierKHR")]
        public abstract void BlendBarrier();

        public KhrBlendEquationAdvanced(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

