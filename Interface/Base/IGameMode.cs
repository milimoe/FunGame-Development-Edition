﻿using Milimoe.FunGame.Core.Interface.Base;

namespace Milimoe.FunGame.Core.Interface
{
    public interface IGameMode : IAddon, IAddonController, IGamingConnectEventHandler, IGamingDisconnectEventHandler, IGamingReconnectEventHandler, IGamingBanCharacterEventHandler, IGamingPickCharacterEventHandler,
        IGamingRandomEventHandler, IGamingRoundEventHandler, IGamingLevelUpEventHandler, IGamingMoveEventHandler, IGamingAttackEventHandler, IGamingSkillEventHandler, IGamingItemEventHandler, IGamingMagicEventHandler,
        IGamingBuyEventHandler, IGamingSuperSkillEventHandler, IGamingPauseEventHandler, IGamingUnpauseEventHandler, IGamingSurrenderEventHandler, IGamingUpdateInfoEventHandler, IGamingPunishEventHandler
    {
        public abstract bool StartUI(params object[] args);
    }
}
