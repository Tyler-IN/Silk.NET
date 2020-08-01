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

namespace Silk.NET.OpenGLES.Extensions.EXT
{
    [Extension("EXT_primitive_bounding_box")]
    public abstract unsafe partial class ExtPrimitiveBoundingBox : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_primitive_bounding_box";
        [NativeApi(EntryPoint = "glPrimitiveBoundingBoxEXT")]
        public abstract void PrimitiveBoundingBox([Flow(FlowDirection.In)] float minX, [Flow(FlowDirection.In)] float minY, [Flow(FlowDirection.In)] float minZ, [Flow(FlowDirection.In)] float minW, [Flow(FlowDirection.In)] float maxX, [Flow(FlowDirection.In)] float maxY, [Flow(FlowDirection.In)] float maxZ, [Flow(FlowDirection.In)] float maxW);

        public ExtPrimitiveBoundingBox(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

