using System;
using GoldTree.HabboHotel.GameClients;
using GoldTree.Messages;
namespace GoldTree.Communication.Messages.Navigator
{
	internal sealed class GetOfficialRoomsMessageEvent : Interface
	{
		public void Handle(GameClient Session, ClientMessage Event)
		{
			Session.SendMessage(GoldTree.GetGame().GetNavigator().method_5());
		}
	}
}
