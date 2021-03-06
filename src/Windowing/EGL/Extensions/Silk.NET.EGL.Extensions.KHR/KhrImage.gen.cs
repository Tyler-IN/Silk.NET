// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.EGL;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.EGL.Extensions.KHR
{
    [Extension("KHR_image")]
    public abstract unsafe partial class KhrImage : NativeExtension<EGL>
    {
        public const string ExtensionName = "KHR_image";
        [NativeApi(EntryPoint = "eglCreateImageKHR")]
        public abstract unsafe IntPtr CreateImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx, [Flow(FlowDirection.In)] KHR target, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] int* attrib_list);

        [NativeApi(EntryPoint = "eglCreateImageKHR")]
        public abstract IntPtr CreateImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr ctx, [Flow(FlowDirection.In)] KHR target, [Flow(FlowDirection.In)] IntPtr buffer, [Flow(FlowDirection.In)] Span<int> attrib_list);

        [NativeApi(EntryPoint = "eglDestroyImageKHR")]
        public abstract bool DestroyImage([Flow(FlowDirection.In)] IntPtr dpy, [Flow(FlowDirection.In)] IntPtr image);

        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx, [Flow(FlowDirection.In)] KHR target, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] int* attrib_list)
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(dpy), new IntPtr(ctx), target, new IntPtr(buffer), attrib_list);
        }

        public unsafe IntPtr CreateImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int ctx, [Flow(FlowDirection.In)] KHR target, [Flow(FlowDirection.In)] int buffer, [Flow(FlowDirection.In)] Span<int> attrib_list)
        {
            // IntPtrOverloader
            return CreateImage(new IntPtr(dpy), new IntPtr(ctx), target, new IntPtr(buffer), attrib_list);
        }

        public unsafe bool DestroyImage([Flow(FlowDirection.In)] int dpy, [Flow(FlowDirection.In)] int image)
        {
            // IntPtrOverloader
            return DestroyImage(new IntPtr(dpy), new IntPtr(image));
        }

        public KhrImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

