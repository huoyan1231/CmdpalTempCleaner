// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using System;
using System.Runtime.InteropServices;
using System.Threading;
using Microsoft.CommandPalette.Extensions;

namespace CmdpalTempCleaner;

[Guid("cbed3554-f15c-432e-888c-6b5c3738f9ab")]
public sealed partial class CmdpalTempCleaner : IExtension, IDisposable
{
    private readonly ManualResetEvent _extensionDisposedEvent;

    private readonly CmdpalTempCleanerCommandsProvider _provider = new();

    public CmdpalTempCleaner(ManualResetEvent extensionDisposedEvent)
    {
        this._extensionDisposedEvent = extensionDisposedEvent;
    }

    public object? GetProvider(ProviderType providerType)
    {
        return providerType switch
        {
            ProviderType.Commands => _provider,
            _ => null,
        };
    }

    public void Dispose() => this._extensionDisposedEvent.Set();
}
