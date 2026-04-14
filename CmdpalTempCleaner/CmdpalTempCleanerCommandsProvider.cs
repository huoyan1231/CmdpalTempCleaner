// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using CmdpalTempCleaner.Resources; // 在顶部添加资源类的命名空间引用
using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace CmdpalTempCleaner;

public partial class CmdpalTempCleanerCommandsProvider : CommandProvider
{
    private readonly ICommandItem[] _commands;

    public CmdpalTempCleanerCommandsProvider()
    {
        // 替换原本写死的 "Temp Cleaner"
        DisplayName = Strings.ExtensionName;
        Icon = IconHelpers.FromRelativePath("Assets/icon.png");

        _commands = new ICommandItem[]
        {
            new CommandItem(new ClearTempCommand())
            { 
                // 替换原本写死的中文标题和副标题
                Title = Strings.CommandTitle,
                Subtitle = Strings.CommandSubtitle,
                Icon = IconHelpers.FromRelativePath("Assets/icon.png")
            }
        };
    }
    public override ICommandItem[] TopLevelCommands()
    {
        return _commands;
    }

}
