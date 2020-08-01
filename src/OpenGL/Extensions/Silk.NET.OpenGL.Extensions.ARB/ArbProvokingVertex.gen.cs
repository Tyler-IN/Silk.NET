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
    [Extension("ARB_provoking_vertex")]
    public abstract unsafe partial class ArbProvokingVertex : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_provoking_vertex";
        [NativeApi(EntryPoint = "glProvokingVertex")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] ARB mode);

        [NativeApi(EntryPoint = "glProvokingVertex")]
        public abstract void ProvokingVertex([Flow(FlowDirection.In)] VertexProvokingMode mode);

        public ArbProvokingVertex(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

