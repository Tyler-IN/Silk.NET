// This file is part of Silk.NET.
// 
// You may modify and distribute Silk.NET under the terms
// of the MIT license. See the LICENSE file for details.


using System;
using System.Runtime.InteropServices;
using System.Text;
using Silk.NET.Core.Native;
using Ultz.SuperInvoke;

#pragma warning disable 1591

namespace Silk.NET.Vulkan
{
    public unsafe struct DeviceGroupPresentCapabilitiesKHR
    {
        public DeviceGroupPresentCapabilitiesKHR
        (
            StructureType sType = StructureType.DeviceGroupPresentCapabilitiesKhr,
            void* pNext = default,
            DeviceGroupPresentModeFlagsKHR modes = default
        )
        {
           SType = sType;
           PNext = pNext;
           Modes = modes;
        }

/// <summary></summary>
        public StructureType SType;
/// <summary></summary>
        public void* PNext;
        /// <summary></summary>
       public fixed uint PresentMask[32];
/// <summary></summary>
        public DeviceGroupPresentModeFlagsKHR Modes;
    }
}
