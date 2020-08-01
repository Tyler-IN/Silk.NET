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
    [NativeName("Name", "VkBindAccelerationStructureMemoryInfoNV")]
    public unsafe partial struct BindAccelerationStructureMemoryInfoNV
    {
        public BindAccelerationStructureMemoryInfoNV
        (
            StructureType sType = StructureType.BindAccelerationStructureMemoryInfoKhr,
            void* pNext = default,
            AccelerationStructureKHR accelerationStructure = default,
            DeviceMemory memory = default,
            ulong memoryOffset = default,
            uint deviceIndexCount = default,
            uint* pDeviceIndices = default
        )
        {
            SType = sType;
            PNext = pNext;
            AccelerationStructure = accelerationStructure;
            Memory = memory;
            MemoryOffset = memoryOffset;
            DeviceIndexCount = deviceIndexCount;
            PDeviceIndices = pDeviceIndices;
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
        [NativeName("Type", "VkAccelerationStructureKHR")]
        [NativeName("Type.Name", "VkAccelerationStructureKHR")]
        [NativeName("Name", "accelerationStructure")]
        public AccelerationStructureKHR AccelerationStructure;
/// <summary></summary>
        [NativeName("Type", "VkDeviceMemory")]
        [NativeName("Type.Name", "VkDeviceMemory")]
        [NativeName("Name", "memory")]
        public DeviceMemory Memory;
/// <summary></summary>
        [NativeName("Type", "VkDeviceSize")]
        [NativeName("Type.Name", "VkDeviceSize")]
        [NativeName("Name", "memoryOffset")]
        public ulong MemoryOffset;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "deviceIndexCount")]
        public uint DeviceIndexCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t*")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "pDeviceIndices")]
        public uint* PDeviceIndices;
    }
}
