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
    [NativeName("Name", "VkSurfaceFullScreenExclusiveWin32InfoEXT")]
    public unsafe partial struct SurfaceFullScreenExclusiveWin32InfoEXT
    {
        public SurfaceFullScreenExclusiveWin32InfoEXT
        (
            StructureType sType = StructureType.SurfaceFullScreenExclusiveWin32InfoExt,
            void* pNext = default,
            IntPtr hmonitor = default
        )
        {
            SType = sType;
            PNext = pNext;
            Hmonitor = hmonitor;
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
        [NativeName("Type", "HMONITOR")]
        [NativeName("Type.Name", "HMONITOR")]
        [NativeName("Name", "hmonitor")]
        public IntPtr Hmonitor;
    }
}
