// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Silk.NET.Core.Attributes;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    [NativeName("Name", "VkPipelineRasterizationDepthClipStateCreateInfoEXT")]
    public unsafe partial struct PipelineRasterizationDepthClipStateCreateInfoEXT
    {
        public PipelineRasterizationDepthClipStateCreateInfoEXT
        (
            StructureType sType = StructureType.PipelineRasterizationDepthClipStateCreateInfoExt,
            void* pNext = default,
            uint flags = default,
            Bool32 depthClipEnable = default
        )
        {
            SType = sType;
            PNext = pNext;
            Flags = flags;
            DepthClipEnable = depthClipEnable;
        }

/// <summary></summary>
        [NativeName("Type", "VkStructureType")]
        [NativeName("Type.Name", "VkStructureType")]
        [NativeName("Name", "sType")]
        public StructureType SType;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "pNext")]
        public void* PNext;
/// <summary></summary>
        [NativeName("Type", "VkPipelineRasterizationDepthClipStateCreateFlagsEXT")]
        [NativeName("Type.Name", "VkPipelineRasterizationDepthClipStateCreateFlagsEXT")]
        [NativeName("Name", "flags")]
        public uint Flags;
/// <summary></summary>
        [NativeName("Type", "VkBool32")]
        [NativeName("Type.Name", "VkBool32")]
        [NativeName("Name", "depthClipEnable")]
        public Bool32 DepthClipEnable;
    }
}
