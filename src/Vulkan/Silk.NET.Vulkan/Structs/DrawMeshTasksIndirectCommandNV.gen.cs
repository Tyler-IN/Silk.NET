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
    [NativeName("Name", "VkDrawMeshTasksIndirectCommandNV")]
    public unsafe partial struct DrawMeshTasksIndirectCommandNV
    {
        public DrawMeshTasksIndirectCommandNV
        (
            uint taskCount = default,
            uint firstTask = default
        )
        {
            TaskCount = taskCount;
            FirstTask = firstTask;
        }

/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "taskCount")]
        public uint TaskCount;
/// <summary></summary>
        [NativeName("Type", "uint32_t")]
        [NativeName("Type.Name", "uint32_t")]
        [NativeName("Name", "firstTask")]
        public uint FirstTask;
    }
}
