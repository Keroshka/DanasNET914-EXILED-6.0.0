using Exiled.API.Features;
using Exiled.Events.Handlers;
using Exiled.Events.EventArgs.;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Exiled.Events.EventArgs.Scp914;
using MapGeneration.Distributors;
using InventorySystem.Items.Pickups;
using Exiled.API.Features.Items;

namespace DanasNET914
{
    public class EventHandlers
    {
        private Plugin plugin;

        public EventHandlers(Plugin plugin)
        {
            this.plugin = plugin;
        }

        public void OnItemUpgrade(UpgradingInventoryItemEventArgs ev)
        {
            if (ev.Item.Type == ItemType.Radio && ev.KnobSetting == Scp914.Scp914KnobSetting.Coarse && plugin.rng.Next(100) <= 50)
            {
                ev.IsAllowed = false;
                ev.Item.Destroy();
                ev.Player.AddItem(ItemType.SCP1576);
            }
        }

        public void OnPickupUpgrade(UpgradingPickupEventArgs ev)
        {
            if (ev.Pickup.Type == ItemType.Radio && ev.KnobSetting == Scp914.Scp914KnobSetting.Coarse && plugin.rng.Next(100) <= 50)
            {
                ev.IsAllowed = false;
                ev.Pickup.Destroy();
                ev.
            }
        }
    }
}
