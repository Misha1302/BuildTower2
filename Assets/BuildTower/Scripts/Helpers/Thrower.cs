namespace BuildTower.Scripts.Helpers
{
    using System;
    using System.Runtime.CompilerServices;

    public static class Thrower
    {
        public static void Throw(
            string ex,
            [CallerFilePath] string path = "",
            [CallerMemberName] string methodName = ""
        )
        {
            throw new InvalidOperationException($"{ex}. \npath: [{path}]. \nmethodName: [{methodName}]");
        }
    }
}