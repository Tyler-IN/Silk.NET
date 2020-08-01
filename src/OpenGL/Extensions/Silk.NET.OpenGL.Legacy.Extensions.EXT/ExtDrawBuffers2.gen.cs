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
    [Extension("EXT_draw_buffers2")]
    public abstract unsafe partial class ExtDrawBuffers2 : NativeExtension<GL>
    {
        public const string ExtensionName = "EXT_draw_buffers2";
        [NativeApi(EntryPoint = "glColorMaskIndexedEXT")]
        public abstract void ColorMaskIndexed([Flow(FlowDirection.In)] uint index, [Flow(FlowDirection.In)] bool r, [Flow(FlowDirection.In)] bool g, [Flow(FlowDirection.In)] bool b, [Flow(FlowDirection.In)] bool a);

        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        public abstract void DisableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        public abstract void EnableIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract void GetBooleanIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public abstract unsafe void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] int* data);

        [NativeApi(EntryPoint = "glGetIntegerIndexedvEXT")]
        public abstract void GetIntegerIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out int data);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        public abstract bool IsEnabledIndexed([Flow(FlowDirection.In)] EXT target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glDisableIndexedEXT")]
        public abstract void DisableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glEnableIndexedEXT")]
        public abstract void EnableIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract unsafe void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] bool* data);

        [NativeApi(EntryPoint = "glGetBooleanIndexedvEXT")]
        public abstract void GetBooleanIndexed([Flow(FlowDirection.In)] BufferTargetARB target, [Flow(FlowDirection.In)] uint index, [Count(Computed = "target"), Flow(FlowDirection.Out)] out bool data);

        [NativeApi(EntryPoint = "glIsEnabledIndexedEXT")]
        public abstract bool IsEnabledIndexed([Flow(FlowDirection.In)] EnableCap target, [Flow(FlowDirection.In)] uint index);

        public ExtDrawBuffers2(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

