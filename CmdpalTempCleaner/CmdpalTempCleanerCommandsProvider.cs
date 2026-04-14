// Copyright (c) Microsoft Corporation
// The Microsoft Corporation licenses this file to you under the MIT license.
// See the LICENSE file in the project root for more information.

using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace CmdpalTempCleaner;

public partial class CmdpalTempCleanerCommandsProvider : CommandProvider
{
    private readonly ICommandItem[] _commands;

    public CmdpalTempCleanerCommandsProvider()
    {
        DisplayName = "Temp Cleaner";
        Icon = IconHelpers.FromRelativePath("Assets\\StoreLogo.png");
        _commands = [
            new CommandItem(new ClearTempCommand())
    {
        Title = "清理 %temp%",
        Subtitle = "一键清理系统临时文件夹，忽略占用文件",
        Icon = new IconInfo("Assets\\StoreLogo.png") // 如果你有专门的图标也可以在这里换
    }
        ];
    }

    public override ICommandItem[] TopLevelCommands()
    {
        return _commands;
    }

}
