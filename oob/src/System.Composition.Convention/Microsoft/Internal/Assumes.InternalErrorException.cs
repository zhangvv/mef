// -----------------------------------------------------------------------
// Copyright (c) Microsoft Corporation.  All rights reserved.
// -----------------------------------------------------------------------
using System;
using System.Diagnostics.CodeAnalysis;
using System.Globalization;
using System.Runtime.Serialization;

namespace Microsoft.Internal
{
    partial class Assumes
    {
        // The exception that is thrown when an internal assumption failed.
        [SuppressMessage("Microsoft.Design", "CA1064:ExceptionsShouldBePublic")]
        private class InternalErrorException : Exception
        {
            public InternalErrorException(string message)
                : base(string.Format(CultureInfo.CurrentCulture, Strings.InternalExceptionMessage, message))
            {
            }
        }
    }
}
