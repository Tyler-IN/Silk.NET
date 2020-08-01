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
    [NativeName("Name", "XrInputSourceLocalizedNameGetInfo")]
    public unsafe partial struct InputSourceLocalizedNameGetInfo
    {
        public InputSourceLocalizedNameGetInfo
        (
            StructureType type = StructureType.TypeInputSourceLocalizedNameGetInfo,
            void* next = default,
            ulong sourcePath = default,
            InputSourceLocalizedNameFlags whichComponents = default
        )
        {
            Type = type;
            Next = next;
            SourcePath = sourcePath;
            WhichComponents = whichComponents;
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
        [NativeName("Type", "XrPath")]
        [NativeName("Type.Name", "XrPath")]
        [NativeName("Name", "sourcePath")]
        public ulong SourcePath;
/// <summary></summary>
        [NativeName("Type", "XrInputSourceLocalizedNameFlags")]
        [NativeName("Type.Name", "XrInputSourceLocalizedNameFlags")]
        [NativeName("Name", "whichComponents")]
        public InputSourceLocalizedNameFlags WhichComponents;
    }
}
