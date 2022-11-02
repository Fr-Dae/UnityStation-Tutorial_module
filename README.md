## Tutoriel Solo - Les bases

[TOCM]

[TOC]

```Markdown
Tutoriel Solo - Les bases
├── Languages utilisés
├── Description du projet
├── Credit , participant, organisation
├── Public cible
├── But du projet
│	└── Détails techniques
│		├── Tutoriel-bot alt text )
│		└── Mode admin
├── Installation
│ 	├── Actuellement
│   └── Projet rendu
├── Mise à jour
├── Usage
└── ToDo
```

-------------

### Languages utilisés

C# Unity

XML

-------------

  

### Description du projet

Ce projet a pour but d'apprendre les bases aux nouveaux joueurs découvrant Unitystation.

-------------

### Credit , participant, organisation

Géré par l'équipe de developpement de Unionrolistes

Liste des contributeurs

[Credit.md]([https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/Credit.md](https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/Credit.md))

[Licence.md]([https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/LICENSE](https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/LICENSE))

-------------

### Public cible

Le projet a pour cible les joueurs débutants

découvrant Unitystaiton.

  

### But du projet

-   Apprendre comment se déplacer
-   Se vêtir
-   Usage d'un ID et d'un PDA, ainsi que de la lumière de navigation
-   Utiliser main gauche et main droite
-   Gestion de l'inventaire
-   Raccourcis clavier usuels
-   Equiper un masque à oxygène et savoir l'activer/désactiver
-   Réparer une brèche dans la coque et y survivre
-   Tirer, pousser
-   Se déplacer par dessus une table
-   (Optionnel) Acheter des objets dans les distributeurs
-   (Optionnel) Utiliser le jukebox
-   (Optionnel) Utiliser et recharger une arme
-   à feu
-   à énergie
-   (Optionnel) Comprendre le système de blessures, et de soins basiques (appliquer au joueurs un dégât)
-   (Optionnel) Savoir planter une graine pour se familiariser avec les mécaniques d'un métier (botanic basics)
-   (Optionnel) Utiliser un extincteur pour éteindre un feu, et forcer une porte sans électricité
-   Reconnaître une navette d'évacuation et s'y diriger
 

#### Détails techniques

Le tutoriel sera composé de plusieurs salles, obligatoires ou facultatives, que le joueur pourra explorer à son rythme.
 
Pour l'accompagner et le guider, sera présent le Tutorial-bot.

C'est un NPC qui a pour fonction de suivre le joueur et de réciter un dialogue dans le tchat du jeu lorsque le joueur est à un endroit spécifique.

##### Tutoriel-bot [alt text]([https://raw.githubusercontent.com/Unitystation-fork/UnityStation-Tutorial/main/Assets/Textures/Bot/Attention-Front/attention-front-1.gif](https://raw.githubusercontent.com/Unitystation-fork/UnityStation-Tutorial/main/Assets/Textures/Bot/Attention-Front/attention-front-1.gif)

La charte graphique est ainsi définie:

Un bot dont l’asset (sprite) fera 32x32, représentant un écran flottant.

L’écran aura deux affichages possibles :

-   un écran « neutre » avec le logo Nanostrasen
-   un écran « interaction » avec un point d’exclamation (pour attirer l’attention)

Il est possible que, plus tard, l’écran aie des fissures ou soit éteint pour afficher son état de santé  (facultatif).

Sa base sera un flotteur antigravité (donc animation de suspension). Il faudra donc une face, un dos, deux profils pour donner l’illusion d’une entité 3D

 
Ses dialogues sont au format XML, facilitant ainsi la localisation dans les langues suivantes :

-   Anglais
-   Français
-   Russe
-   Allemand

##### Mode admin

L'affichage de l'interface en mode admin et de la console sont **désactivées**, mais il est possible qu'elles le soient tout le temps (à verifier).

-------------

### Installation
#### Actuellement

 1. Téléchargez le build test au format .zip
 2. Version Windows ou Linux
 3. Créez un dossier Unitystation dans votre dossier contenant vos jeux.
 4. Collez et décompressez l'archive, vous devriez voir le build à executer

  
#### Projet rendu

(Voir [Installer]([https://github.com/Unitystation-fork/Unitystation-WikiV2/blob/main/docs/1_HowToInstallGame/1_HowInstall.FR.md](https://github.com/Unitystation-fork/Unitystation-WikiV2/blob/main/docs/1_HowToInstallGame/1_HowInstall.FR.md)) Station Hub)

Téléchargez un build ,

Allez dans l'onglet "installation"

Executez celui-ci

  

-------------

### Mise à jour

-------------

### Usage

Une fois le build executé :

Allez dans le menu [Tutoriel] Vert

Sélectionnez la langue

--- Actuellement le russe ne fonctionne pas

Profitez de votre experience de jeu exclusive !

  

Pour quitter le tutoriel, dirigez-vous vers la navette au sud de la station. Sur le côté droit, vous trouverez une console. En marchant dessus, le tutoriel se termine.

  

(idée : menu qui propose d'autres scenarios de tutoriels départements)

---

### ToDo

[TODO]([https://github.com/orgs/Unitystation-fork/projects/1/views/4?visibleFields=%5B%22Title%22%2C%22Repository%22%2C%22Assignees%22%2C%22Status%22%5D](https://github.com/orgs/Unitystation-fork/projects/1/views/4?visibleFields=%5B%22Title%22%2C%22Repository%22%2C%22Assignees%22%2C%22Status%22%5D)]

  

-------------

il existe une video de gameplay pour la version 1.0.5

[https://youtu.be/SM2RSpfiJys](https://youtu.be/SM2RSpfiJys)

 
