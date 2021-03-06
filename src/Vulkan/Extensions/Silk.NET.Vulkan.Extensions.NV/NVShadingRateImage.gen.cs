// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.
using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Vulkan;
using Silk.NET.Core.Loader;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan.Extensions.NV
{
    [Extension("VK_NV_shading_rate_image")]
    public abstract unsafe partial class NVShadingRateImage : NativeExtension<Vk>
    {
        public const string ExtensionName = "VK_NV_shading_rate_image";
        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdBindShadingRateImageNV")]
        public abstract void CmdBindShadingRateImage([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] ImageView imageView, [Count(Count = 0)] ImageLayout imageLayout);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        public abstract unsafe void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Computed = "customSampleOrderCount"), Flow(FlowDirection.In)] CoarseSampleOrderCustomNV* pCustomSampleOrders);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetCoarseSampleOrderNV")]
        public abstract void CmdSetCoarseSampleOrder([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] CoarseSampleOrderTypeNV sampleOrderType, [Count(Count = 0)] uint customSampleOrderCount, [Count(Computed = "customSampleOrderCount"), Flow(FlowDirection.In)] ref CoarseSampleOrderCustomNV pCustomSampleOrders);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        public abstract unsafe void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ShadingRatePaletteNV* pShadingRatePalettes);

        /// <summary>To be added.</summary>
        [NativeApi(EntryPoint = "vkCmdSetViewportShadingRatePaletteNV")]
        public abstract void CmdSetViewportShadingRatePalette([Count(Count = 0)] CommandBuffer commandBuffer, [Count(Count = 0)] uint firstViewport, [Count(Count = 0)] uint viewportCount, [Count(Computed = "viewportCount"), Flow(FlowDirection.In)] ref ShadingRatePaletteNV pShadingRatePalettes);

        public NVShadingRateImage(ref NativeApiContext ctx)
            : base(ref ctx)
        {
        }
    }
}

