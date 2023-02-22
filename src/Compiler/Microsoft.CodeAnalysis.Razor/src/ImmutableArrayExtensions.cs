﻿// Licensed to the .NET Foundation under one or more agreements.
// The .NET Foundation licenses this file to you under the MIT license.

using System.Collections.Generic;
using System.Collections.Immutable;

namespace Microsoft.CodeAnalysis.Razor;

internal static class ImmutableArrayExtensions
{
    public static bool Contains<T, TComparer>(this ImmutableArray<T> array, T item, TComparer comparer)
        where TComparer : IEqualityComparer<T>
    {
        foreach (var actual in array)
        {
            if (comparer.Equals(actual, item))
            {
                return true;
            }
        }

        return false;
    }
}
