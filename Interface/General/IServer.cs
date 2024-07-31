﻿namespace Milimoe.FunGame.Core.Interface
{
    /// <summary>
    /// 服务器需要实现此接口
    /// </summary>
    public interface IServer
    {
        public string[] GameModuleList { get; }
        public string[] GameMapList { get; }
    }
}
