## UnityStation

[TOCM]

[TOC]


----------

```properties
Bonjour, vous etes arriver ici, car vous souhaitez contribuer au developpement du tutoriel. félicitation ! (et merci)
vous trouverez ici les information utile vous fous facilité la vie dans votre tache.
```

**Bonne chance.**

### Lancement du projet pour DEV

! [Markdown](https://docs.github.com/en/get-started/writing-on-github/getting-started-with-writing-and-formatting-on-github/basic-writing-and-formatting-syntax)

 - lisez ceci ! [Starting Contribution - UnityStation](https://unitystation.github.io/unitystation/contribution-guides/Starting-contribution/)

 - Installer unity

 - Cloner unitystation-dev_2022_08_24 (Branche:Tutorial) ![ForkMe](https://github.com/Unitystation-fork/unitystation-dev_2022_08_24)
 
 - Lancer le projet unitystation-dev_2022_08_24/UnityProject


----------

### Credit , participant, organisation

Géré par l'équipe de developpement de Unionrolistes Liste des contributeur ![Credit.md](/Credit.md) & ![Licence.md](/LICENSE)

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

version de dev 2022.08.24 last bugfix #9164
unity Version 2021.1.3

----------

INFO TEST JEU

-   4Gb Ram (8 recommended)
-   i5 (i7 recommended)
-   ~150-200Mb Hdd
-   1Gio GPU

----------


! [TODO](https://github.com/orgs/Unitystation-fork/projects/1/views/4?visibleFields=%5B%22Title%22%2C%22Repository%22%2C%22Assignees%22%2C%22Status%22%5D](https://github.com/orgs/Unitystation-fork/projects/1/views/4?visibleFields=%5B%22Title%22%2C%22Labels%22%2C%22Assignees%22%2C%22Repository%22%2C%22Status%22%5D))


------

Salle obligatoire push-pull  ! [PushPull Video](https://youtu.be/krssJiDJLhY)


Salle exercice incendie ![FireExercice Video](https://github.com/Unitystation-fork/UnityStation-Tutorial/blob/main/Images/2022-08-30-181759_1920x1080_scrot.png?raw=true)
