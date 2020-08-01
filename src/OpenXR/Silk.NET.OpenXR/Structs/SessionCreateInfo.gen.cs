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
    [NativeName("Name", "XrSessionCreateInfo")]
    public unsafe partial struct SessionCreateInfo
    {
        public SessionCreateInfo
        (
            StructureType type = StructureType.TypeSessionCreateInfo,
            void* next = default,
            SessionCreateFlags createFlags = default,
            ulong systemId = default
        )
        {
            Type = type;
            Next = next;
            CreateFlags = createFlags;
            SystemId = systemId;
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
        [NativeName("Type", "XrSessionCreateFlags")]
        [NativeName("Type.Name", "XrSessionCreateFlags")]
        [NativeName("Name", "createFlags")]
        public SessionCreateFlags CreateFlags;
/// <summary></summary>
        [NativeName("Type", "XrSystemId")]
        [NativeName("Type.Name", "XrSystemId")]
        [NativeName("Name", "systemId")]
        public ulong SystemId;
    }
}
