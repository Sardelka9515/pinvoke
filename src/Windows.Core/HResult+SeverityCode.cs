// Copyright © .NET Foundation and Contributors. All rights reserved.
// Licensed under the MIT license. See LICENSE file in the project root for full license information.

namespace PInvoke
{
    /// <content>
    /// The <see cref="SeverityCode"/> nested type.
    /// </content>
    public partial struct HResult
    {
        /// <summary>
        /// HRESULT severity codes defined by winerror.h.
        /// </summary>
        public enum SeverityCode : uint
        {
            Success = 0,
            Fail = 1,
        }
    }
}
