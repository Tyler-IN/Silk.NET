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
    [Extension("EXT_external_buffer")]
    public abstract unsafe partial class ExtExternalBuffer : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_external_buffer";
        [NativeApi(EntryPoint = "glBufferStorageExternalEXT")]
        public abstract void BufferStorageExternal([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] IntPtr clientBuffer, [Flow(FlowDirection.In)] uint flags);

        [NativeApi(EntryPoint = "glNamedBufferStorageExternalEXT")]
        public abstract void NamedBufferStorageExternal([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] IntPtr offset, [Flow(FlowDirection.In)] UIntPtr size, [Flow(FlowDirection.In)] IntPtr clientBuffer, [Flow(FlowDirection.In)] uint flags);

        public unsafe void BufferStorageExternal([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] int clientBuffer, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            BufferStorageExternal(target, new IntPtr(offset), new UIntPtr(size), new IntPtr(clientBuffer), flags);
        }

        public unsafe void NamedBufferStorageExternal([Flow(FlowDirection.In)] uint buffer, [Flow(FlowDirection.In)] int offset, [Flow(FlowDirection.In)] uint size, [Flow(FlowDirection.In)] int clientBuffer, [Flow(FlowDirection.In)] uint flags)
        {
            // IntPtrOverloader
            NamedBufferStorageExternal(buffer, new IntPtr(offset), new UIntPtr(size), new IntPtr(clientBuffer), flags);
        }

        public ExtExternalBuffer(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

