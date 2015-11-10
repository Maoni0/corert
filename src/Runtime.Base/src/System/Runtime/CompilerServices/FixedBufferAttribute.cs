// Copyright (c) Microsoft. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace System.Runtime.CompilerServices
{
    internal unsafe sealed class FixedBufferAttribute : Attribute
    {
        public FixedBufferAttribute(Type elementType, int length)
        {
        }
    }
}