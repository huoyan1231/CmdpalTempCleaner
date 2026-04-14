using Microsoft.CommandPalette.Extensions;
using Microsoft.CommandPalette.Extensions.Toolkit;

namespace CmdpalTempCleaner;

// 继承 InvokableCommand 表示这是一个可以直接执行的动作
public partial class ClearTempCommand : InvokableCommand
{
    public override CommandResult Invoke()
    {
        // 调用我们之前写好的核心清理逻辑
        TempCleaner.ClearTempFolder();

        // 执行完毕后，关闭 CmdPal 搜索框
        return CommandResult.Dismiss();
    }
}