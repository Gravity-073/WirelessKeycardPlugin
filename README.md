# WirelessKeycardPlugin


An SCP Secret Laboratory plugin based on LabAPI that allows you to open doors, lockers, generators, and other items without having to hold a card in your hand.


## Features


- Checks the cards in the player's inventory.

- Allows the door to be opened if one of the cards matches.

- Same logic applies to lockers, generators, checkpoints, and gates.


## Prerequisites


- .NET Framework 4.8

- An SCP: Secret Laboratory installation with the reference DLLs in the Managed folder.

- LabAPI and its associated dependencies.



## Installation


Copy the generated DLL to the plugins folder on your SCP: Secret Laboratory server.


## Notes


This plugin is intended for use with a compatible version of LabAPI and SCP: Secret Laboratory.

All doors, gates, checkpoints, lockers, and generators are supported, but the warhead button is not.

