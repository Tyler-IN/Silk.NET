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
    [NativeName("Name", "VkAttachmentReferenceStencilLayoutKHR")]
    public unsafe partial struct AttachmentReferenceStencilLayoutKHR
    {
        public AttachmentReferenceStencilLayoutKHR
        (
            StructureType sType = StructureType.AttachmentReferenceStencilLayout,
            void* pNext = default,
            ImageLayout stencilLayout = default
        )
        {
            SType = sType;
            PNext = pNext;
            StencilLayout = stencilLayout;
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
        [NativeName("Type", "VkImageLayout")]
        [NativeName("Type.Name", "VkImageLayout")]
        [NativeName("Name", "stencilLayout")]
        public ImageLayout StencilLayout;
    }
}
