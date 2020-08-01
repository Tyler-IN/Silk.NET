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
    [NativeName("Name", "VkSparseImageFormatProperties2")]
    public unsafe partial struct SparseImageFormatProperties2
    {
        public SparseImageFormatProperties2
        (
            StructureType sType = StructureType.SparseImageFormatProperties2,
            void* pNext = default,
            SparseImageFormatProperties properties = default
        )
        {
            SType = sType;
            PNext = pNext;
            Properties = properties;
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
        [NativeName("Type", "VkSparseImageFormatProperties")]
        [NativeName("Type.Name", "VkSparseImageFormatProperties")]
        [NativeName("Name", "properties")]
        public SparseImageFormatProperties Properties;
    }
}
