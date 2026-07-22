# WirelessKeycardPlugin

Plugin SCP: Secret Laboratory basé sur LabAPI permettant d’ouvrir certaines portes, casiers et générateurs lorsqu’une carte avec les permissions adéquates est présente dans l’inventaire du joueur.

## Fonctionnalités

- Vérifie les permissions de la carte du joueur.
- Autorise l’ouverture de portes spécifiques telles que les portes de checkpoint et les portes de zone.
- Gère les casiers et les générateurs avec la même logique d’accès.
- Utilise les événements LabAPI pour intercepter les actions d’ouverture.

## Prérequis

- .NET Framework 4.8
- Une installation SCP: Secret Laboratory avec les DLLs de référence dans le dossier Managed.
- LabAPI et ses dépendances associées.

## Compilation

1. Ouvrez le projet dans Visual Studio ou exécutez la commande suivante dans PowerShell :
   - `dotnet build WirelessKeycardPlugin.csproj -c Release`
2. Vérifiez que les références dans le fichier de projet pointent vers votre installation SCP: Secret Laboratory.
3. La compilation produit la DLL dans le dossier `bin/Release/net481/`.

## Installation

Copiez la DLL générée depuis `bin/Release/net481/WirelessKeycardPlugin.dll` dans le dossier de plugins de votre serveur SCP: Secret Laboratory.

## Notes

Ce plugin est destiné à être utilisé avec une version compatible de LabAPI et de SCP: Secret Laboratory.
