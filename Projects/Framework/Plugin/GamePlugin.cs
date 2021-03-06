﻿using System.Collections.Generic;
using System.Runtime.CompilerServices;
using Framework.Data;
using Framework.Network;

namespace Framework.Plugin
{
    public abstract class GamePlugin
    {
        public string Name { get; set; }

        public virtual bool OnPacket(TcpSession session, Packet packet)
        {
            return false;
        }
        public virtual bool OnCreateRoom(Player plr, Room room)
        {
            return false;
        }

        public virtual bool RoomTick(Room room)
        {
            return false;
        }

        public virtual void OnBuyItem(Player plr, List<Item> itemsToBuy)
        {
        }

        public virtual string OnAdminAction(Player sender, string[] args)
        {
            return "";
        }

        public virtual bool OnBeginRound(Player plr, Room room)
        {
            return false;
        }

        public virtual bool OnReadyRound(Player plr, Room room)
        {
            return false;
        }
    }
}
