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

namespace Silk.NET.OpenXR
{
    [NativeName("Name", "XrSessionCreateInfoOverlayEXTX")]
    public unsafe partial struct SessionCreateInfoOverlayEXTX
    {
        public SessionCreateInfoOverlayEXTX
        (
            StructureType type = StructureType.TypeSessionCreateInfoOverlayExtx,
            void* next = default,
            OverlaySessionCreateFlagsEXTX createFlags = default,
            uint sessionLayersPlacement = default
        )
        {
            Type = type;
            Next = next;
            CreateFlags = createFlags;
            SessionLayersPlacement = sessionLayersPlacement;
        }

/// <summary></summary>
        [NativeName("Type", "XrStructureType")]
        [NativeName("Type.Name", "XrStructureType")]
        [NativeName("Name", "type")]
        public StructureType Type;
/// <summary></summary>
        [NativeName("Type", "void*")]
        [NativeName("Type.Name", "void")]
        [NativeName("Name", "next")]
        public void* Next;
/// <summary></summary>
        [NativeName("Type", "XrOverlaySessionCreateFlagsEXTX")]
        [NativeName("Type.Name", "XrOverlaySessionCreateFlagsEXTX")]
        [NativeName("Name", "createFlags")]
        public OverlaySessionCreateFlagsEXTX CreateFlags;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "sessionLayersPlacement")]
        public uint SessionLayersPlacement;
    }
}
