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
    [NativeName("Name", "VkPhysicalDeviceImageDrmFormatModifierInfoEXT")]
    public unsafe partial struct PhysicalDeviceImageDrmFormatModifierInfoEXT
    {
        public PhysicalDeviceImageDrmFormatModifierInfoEXT
        (
            StructureType sType = StructureType.PhysicalDeviceImageDrmFormatModifierInfoExt,
            void* pNext = default,
            ulong drmFormatModifier = default,
            SharingMode sharingMode = default,
            uint queueFamilyIndexCount = default,
            uint* pQueueFamilyIndices = default
        )
        {
            SType = sType;
            PNext = pNext;
            DrmFormatModifier = drmFormatModifier;
            SharingMode = sharingMode;
            QueueFamilyIndexCount = queueFamilyIndexCount;
            PQueueFamilyIndices = pQueueFamilyIndices;
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
        [NativeName("Type", "uint64_t")]
        [NativeName("Type.Name", "uint64_t")]
        [NativeName("Name", "drmFormatModifier")]
        public ulong DrmFormatModifier;
/// <summary></summary>
        [NativeName("Type", "VkSharingMode")]
        [NativeName("Type.Name", "VkSharingMode")]
        [NativeName("Name", "sharingMode")]
        public SharingMode SharingMode;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "queueFamilyIndexCount")]
        public uint QueueFamilyIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pQueueFamilyIndices")]
        public uint* PQueueFamilyIndices;
    }
}
