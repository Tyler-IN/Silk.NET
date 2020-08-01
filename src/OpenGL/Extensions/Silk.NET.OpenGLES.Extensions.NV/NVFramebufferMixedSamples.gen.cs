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

namespace Silk.NET.OpenGLES.Extensions.NV
{
    [Extension("NV_framebuffer_mixed_samples")]
    public abstract unsafe partial class NVFramebufferMixedSamples : NativeExtension<GL>
    {
        public const string ExtensionName = "NV_framebuffer_mixed_samples";
        [NativeApi(EntryPoint = "glCoverageModulationNV")]
        public abstract void CoverageModulation([Flow(FlowDirection.In)] NV components);

        [NativeApi(EntryPoint = "glCoverageModulationTableNV")]
        public abstract unsafe void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] float* v);

        [NativeApi(EntryPoint = "glCoverageModulationTableNV")]
        public abstract void CoverageModulationTable([Flow(FlowDirection.In)] uint n, [Count(Parameter = "n"), Flow(FlowDirection.In)] Span<float> v);

        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV")]
        public abstract unsafe void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] float* v);

        [NativeApi(EntryPoint = "glGetCoverageModulationTableNV")]
        public abstract void GetCoverageModulationTable([Flow(FlowDirection.In)] uint bufSize, [Flow(FlowDirection.Out)] Span<float> v);

        [NativeApi(EntryPoint = "glRasterSamplesEXT")]
        public abstract void RasterSamples([Flow(FlowDirection.In)] uint samples, [Flow(FlowDirection.In)] bool fixedsamplelocations);

        public unsafe float GetCoverageModulationTable()
        {
            const uint bufSize = 1;
            // ReturnTypeOverloader
            float ret = default;
            GetCoverageModulationTable(bufSize, &ret);
            return ret;
        }

        public NVFramebufferMixedSamples(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

