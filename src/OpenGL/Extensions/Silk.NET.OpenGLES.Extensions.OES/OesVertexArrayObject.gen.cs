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

namespace Silk.NET.OpenGLES.Extensions.OES
{
    [Extension("OES_vertex_array_object")]
    public abstract unsafe partial class OesVertexArrayObject : NativeExtension<GL>
    {
        public const string ExtensionName = "OES_vertex_array_object";
        [NativeApi(EntryPoint = "glBindVertexArrayOES")]
        public abstract void BindVertexArray([Flow(FlowDirection.In)] uint array);

        [NativeApi(EntryPoint = "glDeleteVertexArraysOES")]
        public abstract unsafe void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] uint* arrays);

        [NativeApi(EntryPoint = "glDeleteVertexArraysOES")]
        public abstract void DeleteVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysOES")]
        public abstract unsafe void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] uint* arrays);

        [NativeApi(EntryPoint = "glGenVertexArraysOES")]
        public abstract void GenVertexArrays([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.Out)] Span<uint> arrays);

        [NativeApi(EntryPoint = "glIsVertexArrayOES")]
        public abstract bool IsVertexArray([Flow(FlowDirection.In)] uint array);

        public unsafe void DeleteVertexArray([Count(Parameter = "n"), Flow(FlowDirection.In)] uint arrays)
        {
            // ArrayParameterOverloader
            DeleteVertexArrays(1, &arrays);
        }

        public unsafe uint GenVertexArray()
        {
            const uint n = 1;
            // ReturnTypeOverloader
            uint ret = default;
            GenVertexArrays(n, &ret);
            return ret;
        }

        public OesVertexArrayObject(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

