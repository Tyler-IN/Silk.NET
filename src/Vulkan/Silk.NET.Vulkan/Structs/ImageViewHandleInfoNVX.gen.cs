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
    [NativeName("Name", "VkImageViewHandleInfoNVX")]
    public unsafe partial struct ImageViewHandleInfoNVX
    {
        public ImageViewHandleInfoNVX
        (
            StructureType sType = StructureType.ImageViewHandleInfoNvx,
            void* pNext = default,
            ImageView imageView = default,
            DescriptorType descriptorType = default,
            Sampler sampler = default
        )
        {
            SType = sType;
            PNext = pNext;
            ImageView = imageView;
            DescriptorType = descriptorType;
            Sampler = sampler;
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
        [NativeName("Type", "VkImageView")]
        [NativeName("Type.Name", "VkImageView")]
        [NativeName("Name", "imageView")]
        public ImageView ImageView;
/// <summary></summary>
        [NativeName("Type", "VkDescriptorType")]
        [NativeName("Type.Name", "VkDescriptorType")]
        [NativeName("Name", "descriptorType")]
        public DescriptorType DescriptorType;
/// <summary></summary>
        [NativeName("Type", "VkSampler")]
        [NativeName("Type.Name", "VkSampler")]
        [NativeName("Name", "sampler")]
        public Sampler Sampler;
    }
}
