using System;
using LabApi.Loader.Features.Plugins;
using LabApi.Events.Handlers;
using LabApi.Events.Arguments.PlayerEvents;
using LabApi.Features.Wrappers;
using UnityEngine.Assertions.Must;
using Interactables.Interobjects.DoorUtils;
using MapGeneration.Distributors;
using LabApi.Events.Arguments.Interfaces;

namespace WirelessKeycardPlugin
{
    public class WirelessKeycardPlugin : Plugin
    {
        public override string Name => "WirelessKeycardPlugin";
        public override string Description => "Permet d'ouvrir les portes avec une carte présente dans l'inventaire.";
        public override string Author => "Gravity73";
        public override Version Version => new Version(1, 0, 0);
        public override Version RequiredApiVersion => new Version(1, 1, 7);

        public override void Enable()
        {
            PlayerEvents.InteractingDoor += OnInteractingDoor;
            PlayerEvents.InteractingLocker += OnInteractingLocker;
            PlayerEvents.UnlockingGenerator += OnUnlockingGenerator;
            ServerConsole.AddLog("=====WirelessKeycardPlugin Enabled.=====", ConsoleColor.Green, false);
            
        }

        public override void Disable()
        {
            PlayerEvents.InteractingDoor -= OnInteractingDoor;
            PlayerEvents.InteractingLocker -= OnInteractingLocker;
            PlayerEvents.UnlockingGenerator -= OnUnlockingGenerator;
            ServerConsole.AddLog("=====WirelessKeycardPlugin Disable.=====", ConsoleColor.Green, false);
        }
      


        private void OnInteractingDoor(PlayerInteractingDoorEventArgs ev)
        {
         
            var player = ev.Player;
          

            if (ev.IsAllowed && ev.CanOpen)
                return;


            if (ev.Door.IsLocked)
                return;


            if (ev.Door.DoorName == LabApi.Features.Enums.DoorName.EzGateB || ev.Door.DoorName ==  LabApi.Features.Enums.DoorName.EzGateA )
            {
               
                foreach (var item in player.Items)
                {       
                    if (item is KeycardItem keycard)
                    {
                        var permissions = keycard.Permissions;
                        if(ev.Door.Base.RequiredPermissions.CheckPermissions(permissions))
                        {
                            ev.IsAllowed = true;
                            ev.CanOpen = true;
                            return;
                        }
                     
                    }
              
                }
            }

            if (ev.Door.DoorName == LabApi.Features.Enums.DoorName.LczCheckpointA ||
                ev.Door.DoorName == LabApi.Features.Enums.DoorName.LczCheckpointB ||
                ev.Door.DoorName == LabApi.Features.Enums.DoorName.HczCheckpoint)
            {
                
                foreach (var item in player.Items)
                {
                    if (item is KeycardItem keycard)
                    {
                        var permission = keycard.Permissions;
                        if (ev.Door.Base.RequiredPermissions.CheckPermissions(permission))
                        {
                            ev.IsAllowed = true;
                            ev.CanOpen = true;
                            return;
                        }
                    }
                }

            }



            if (HasAccessCard(ev.Player, ev.Door.Permissions))
            {
                ev.IsAllowed = true;
                ev.CanOpen = true;
                
            }
            
        }

        private void OnUnlockingGenerator(PlayerUnlockingGeneratorEventArgs ev)
        {
            
          
             if (HasAccessCard(ev.Player, ev.Generator.RequiredPermissions))
            {
                ev.IsAllowed = true;
                ev.CanOpen = true;
                
            }
                
            }  

            
        


        private void OnInteractingLocker(PlayerInteractingLockerEventArgs ev)
        {
            
            if (ev.IsAllowed && ev.CanOpen)
                return;
                
            if (HasAccessCard(ev.Player, ev.Chamber.RequiredPermissions))
            {
                ev.IsAllowed = true;
                ev.CanOpen = true;
            }
            
        }

        


        private bool HasAccessCard(Player player, DoorPermissionFlags requiredPermissions)
        {
            foreach (var item in player.Items)
        {
            if (item is KeycardItem keycard)
            {
                if ((keycard.Permissions & requiredPermissions) == requiredPermissions)
                return true;
                }
    }

    return false;
}
    }
}