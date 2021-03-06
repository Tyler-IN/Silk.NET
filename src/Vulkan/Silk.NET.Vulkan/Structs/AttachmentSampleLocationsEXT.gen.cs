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
    public unsafe struct AttachmentSampleLocationsEXT
    {
        public AttachmentSampleLocationsEXT
        (
            uint attachmentIndex = default,
            SampleLocationsInfoEXT sampleLocationsInfo = default
        )
        {
           AttachmentIndex = attachmentIndex;
           SampleLocationsInfo = sampleLocationsInfo;
        }

/// <summary></summary>
        public uint AttachmentIndex;
/// <summary></summary>
        public SampleLocationsInfoEXT SampleLocationsInfo;
    }
}
