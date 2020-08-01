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

namespace Silk.NET.OpenGL.Legacy.Extensions.ARB
{
    [Extension("ARB_sparse_texture")]
    public abstract unsafe partial class ArbSparseTexture : NativeExtension<GL>
    {
        public const string ExtensionName = "ARB_sparse_texture";
        [NativeApi(EntryPoint = "glTexPageCommitmentARB")]
        public abstract void TexPageCommitment([Flow(FlowDirection.In)] ARB target, [Flow(FlowDirection.In)] int level, [Flow(FlowDirection.In)] int xoffset, [Flow(FlowDirection.In)] int yoffset, [Flow(FlowDirection.In)] int zoffset, [Flow(FlowDirection.In)] uint width, [Flow(FlowDirection.In)] uint height, [Flow(FlowDirection.In)] uint depth, [Flow(FlowDirection.In)] bool commit);

        public ArbSparseTexture(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

