# WirelessKeycardPlugin

Plugin SCP Secret Laboratory basé sur LabAPI permettant d’ouvrir les portes, lockers, generateurs et autre sans avoir besoin de tenir une carte en main.

## Fonctionnalités

- Verifie les cartes présentes dans l'inventaire du joueur.
- Autorise l'ouverture des la porte si l'une des cartes correspond.
- Même logique pour les lockers, generateurs, checkpoints, gates.

## Prérequis

- .NET Framework 4.8
- Une installation SCP: Secret Laboratory avec les DLLs de référence dans le dossier Managed.
- LabAPI et ses dépendances associées.


## Installation

Copiez la DLL générée  dans le dossier de plugins de votre serveur SCP: Secret Laboratory.

## Notes

Ce plugin est destiné à être utilisé avec une version compatible de LabAPI et de SCP: Secret Laboratory.
Toutes les portes, gates, checkpoints, lockers et generateurs sont pris en charge mais pas le boutton de la warhead.
