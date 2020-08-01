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
    [NativeName("Name", "VkDisplayModeProperties2KHR")]
    public unsafe partial struct DisplayModeProperties2KHR
    {
        public DisplayModeProperties2KHR
        (
            StructureType sType = StructureType.DisplayModeProperties2Khr,
            void* pNext = default,
            DisplayModePropertiesKHR displayModeProperties = default
        )
        {
            SType = sType;
            PNext = pNext;
            DisplayModeProperties = displayModeProperties;
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
        [NativeName("Type", "VkDisplayModePropertiesKHR")]
        [NativeName("Type.Name", "VkDisplayModePropertiesKHR")]
        [NativeName("Name", "displayModeProperties")]
        public DisplayModePropertiesKHR DisplayModeProperties;
    }
}
