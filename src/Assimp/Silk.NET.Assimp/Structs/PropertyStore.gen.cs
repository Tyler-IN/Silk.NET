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

namespace Silk.NET.Assimp
{
    [NativeName("Name", "aiPropertyStore")]
    public unsafe partial struct PropertyStore
    {
        public PropertyStore
        (
            byte sentinel = default
        )
        {
            Sentinel = sentinel;
        }


        [NativeName("Type", "char")]
        [NativeName("Type.Name", "char")]
        [NativeName("Name", "sentinel")]
        public byte Sentinel;
    }
}
