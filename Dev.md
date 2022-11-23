## UnityStation

[TOCM]

[TOC]

### Language utilisé

----------
### Lancement du projet pour DEV

 - Cloner unitystation-dev_2022_08_24 (Branche:Tutorial)
 - Lancer le projet unitystation-dev_2022_08_24/UnityProject

----------

### Description du projet

Version du projet 2021.3.12

----------

### Credit , participant, organisation

## Géré par l'équipe de developpement de Unionrolistes Liste des contributeur Credit.md Licence.md

### But du projet / public cible

#### .

----------

### Installation

#### .

----------

### Mise à jour

#### .

----------

### Usage

#### .

----------

### ToDo

Todo.md

----------

Vidéo:

[https://youtu.be/krssJiDJLhY](https://youtu.be/krssJiDJLhY)

Une salle où un objet bloque le passage, Il faut passé par dessus une table (non en verre) tirer une caisse, en poussé une autre, frapper un objet pour le brisé, jeter un objet

le joueur dois se blesser avec un eclat de verre pour utilisé le medkit.

une salle sans electricité pour un exercice incendie. marcher (pour évité de glissé)

si le joueur meur, le scenario reprend a zero, et un message "try again," devrai s'afficher

----------

READ.ME : Thomas.K

This is a tutorial made for Unitystation.

Below is a resume to what I modify / added in development :

-   Added script "GUI_Tutorial" : when button pressed, go to tutorial and start hosting.

~ Modify "SubSceneManager" script : - (32-37) Added bool and map scene variable for tutorial - (51-60) Added if statement : replace normal map by tutorial map if goToTutorial is true

~ Modify "SubSceneManager.SceneList" script : - (93-105) Modify normal random map loading to have tutorial loading option with if-else statement

-   Added script "Tutorial" : manage tutorial zone with trigger enter (exemple : trigger on player spawn that make tutorial bot appear)
    
-   Added script "TutoPlayer" : Make player Rigidbody2D body type on Dynamic instead of Kinematic ONLY WHEN ON TUTORIAL SCENE, if not thte script remove itself
    

----------

Vidéo:

Tutorial Progress 02

[https://cdn.discordapp.com/attachments/967463756181430282/1004527747374260446/Tutorial_Progress_02.mp4](https://cdn.discordapp.com/attachments/967463756181430282/1004527747374260446/Tutorial_Progress_02.mp4)

Vidéo:

Tutorial Progress 03

[https://youtu.be/S36u4GSQ5Gw](https://youtu.be/S36u4GSQ5Gw)

----------

Projet [https://github.com/Unitystation-fork/UnityStation-Tutorial](https://github.com/Unitystation-fork/UnityStation-Tutorial)

moteur [https://github.com/Unitystation-fork/unitystation-dev_2022_08_24](https://github.com/Unitystation-fork/unitystation-dev_2022_08_24) [https://www.youtube.com/watch?v=gPKfnLWkQ8o](https://www.youtube.com/watch?v=gPKfnLWkQ8o)

version de dev 2022.08.24 last bugfix #9164

----------

Build tutoriel

[https://mega.nz/file/ttkRRQya#_KBNU_OqKd7jDkEqPcdYlQT1EixCwMXfpD7_WYjYgSo](https://mega.nz/file/ttkRRQya#_KBNU_OqKd7jDkEqPcdYlQT1EixCwMXfpD7_WYjYgSo)

----------

INFO TEST JEU

-   4Gb Ram (8 recommended)
-   i5 (i7 recommended)
-   ~150-200Mb Hdd
-   1Gio GPU

----------

FAQ

-   What is a machine integration test? It's where you press a button and, the machine does a standard thing such as , control a botanist player To plant some seeds, and measures the parameters at the end To see if it grew the plant or not , And if they got something unexpected that Something has broken

A little bit of coding knowledge , It's hard to explain currently

-   What skills/background does the dev need to have/know? [https://unitystation.github.io/unitystation/contribution-guides/Starting-contribution/](https://unitystation.github.io/unitystation/contribution-guides/Starting-contribution/)
    
-   What is the execution procedure? Get the newestVersion of the github and Open up in the editor and run the integration tests
    
-   What are the expected results? The integration tests should highlight anything that is broken
    
-   Is there a defined report formatting? Don't think so
    

----------

Starting Contribution - UnityStation

[https://unitystation.github.io/unitystation/contribution-guides/Starting-contribution/](https://unitystation.github.io/unitystation/contribution-guides/Starting-contribution/)

----------

GitHub UnityStation-MillstoneSteam

[https://github.com/Unitystation-fork/Unitystation-MillstoneSteam](https://github.com/Unitystation-fork/Unitystation-MillstoneSteam)

----------

Compte rendu:

Semaine 41 par Clémy: Creation du projet

Semaine 42 par Clémy: Petit compte rendu : j'ai mis en place le projet sur github, bataillé avec de la doc pas à jours et initialisé le back pour qu'il soit prêt à recevoir de la data. Courant semaine pro si pas d'impératif particulier je vais commencer le front, faire le petit login et permettre l'ajout de tâches

Semaine 43 par Clémy: Cette semaine j'ai commencé le front, avec une page d'accueil qui pour l'instant ne contient rien, et un header avec le bouton pour se connecter. J'ai aussi créé l'user pour Dae et fait un formulaire de connexion, qui fonctionne (donc seul Dae peut se connecter et modifier la page, à voir par la suite si on prévoit que d'autres personnes doivent pouvoir modifier le contenu, genre ajouter des tâches, en supprimer, et cocher les tâches réalisées)

Semaine 44 par Clémy: Résumé de ma semaine : Back finalisé, c'est à dire que CRUD tâches et users sont opérationnels.

Semaine 45 par @Clémy: Résumé de la semaine : Avec Killian on a fait l'interface admin pour ajouter/créer/supprimer une tâche, reste un peu de css et on pourra merge et delete la branche et fermer le ticket.

----------

GitHub UnityStation READ.ME

[https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/README.md](https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/README.md)

----------

Par DAE

voici le site d'origine qu'on souhaite remettre au propre [https://unitystation.github.io/unitystation-wiki/#Guides/Security%20guides/Space-Law/](https://unitystation.github.io/unitystation-wiki/#Guides/Security%20guides/Space-Law/)

le github [https://github.com/Unitystation-fork/Unitystation-WikiV2](https://github.com/Unitystation-fork/Unitystation-WikiV2)

et ici l'appercu prototype du site [http://31.211.16.159:8202/unitystation-wiki/#3_HowToPlay/Guides/Security%20guides/Space-Law/](http://31.211.16.159:8202/unitystation-wiki/#3_HowToPlay/Guides/Security%20guides/Space-Law/)

mais Gemlnee dois reboot le pc qui le host

------


![TODO](https://github.com/orgs/Unitystation-fork/projects/1/views/4?visibleFields=%5B%22Title%22%2C%22Repository%22%2C%22Assignees%22%2C%22Status%22%5D](https://github.com/orgs/Unitystation-fork/projects/1/views/4?visibleFields=%5B%22Title%22%2C%22Labels%22%2C%22Assignees%22%2C%22Repository%22%2C%22Status%22%5D))


------

Salle obligatoire push-pull  ! [PushPull Video](https://youtu.be/krssJiDJLhY)


Salle exercice incendie ![FireExercice Video](https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/Images/2022-08-30-181759_1920x1080_scrot.png?raw=true)
