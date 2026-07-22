# WirelessKeycardPlugin

Plugin SCP: Secret Laboratory basé sur LabAPI permettant d’ouvrir certaines portes, casiers et générateurs avec une carte présente dans l’inventaire du joueur.

## Fonctionnalités

- Vérifie les permissions de la carte du joueur.
- Autorise l’ouverture de certaines portes spécifiques.
- Gère les casiers et les générateurs avec la même logique d’accès.

## Prérequis

- .NET Framework 4.8
- Une installation SCP: Secret Laboratory avec les DLLs de référence dans le dossier Managed.
- LabAPI et les dépendances associées.

## Build

1. Ouvrez le projet dans Visual Studio ou exécutez le script PowerShell :
   - `powershell -ExecutionPolicy Bypass -File .\build-plugin.ps1`
2. Vérifiez que les références dans le fichier de projet pointent vers votre installation SCP: Secret Laboratory.
3. Le plugin compilé sera copié dans le dossier `dist/` sous le nom `WirelessKeycardPlugin.dll`.

## Installation

Copiez la DLL compilée dans le dossier de plugins de votre serveur SCP: Secret Laboratory.
