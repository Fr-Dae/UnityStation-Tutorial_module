# UnityStation-Tutorial
Un Tutoriel ingame solo pour apprendre les base


Dans la continuité du projet en cours, pour rendre l’expérience utilisateur plus intuitive notamment pour les
nouveau joueurs.
La carte va se doté une entité nommé « Tutorial-Bot » qui donnera des instruction au joueurs et le suivra.


La charte graphique est ainsi défini:

un bot dont l’asset (sprite) fera 32x32, représentant un écran flottant.

L’écran aura deux affichage possible

un écran « neutre » avec le logo Nanostrasen <N>
  
et un écran « interaction » avec un point d’exclamation. (pour attiré l’attention)
  
il est possible que, plus tard l’écran est des fissure ou soit éteint pour affiché sont états de santé.(facultatif)
  
Le dos de l’écran sera composé de divers circuit électronique et cable.
  
(illustration a titre d’exemple)
  
Et sa base sera un flotteur antigravité. (donc animation de suspension)
  
il faudra donc un face, dos, profile pour donné l’illusion d’une entité 3D
  
Le Tutoriel contient :
- plusieurs langages disponible
- un robot qui aide le joueur au cours de son avancé dans le tutoriel ![alt text](https://raw.githubusercontent.com/Unitystation-fork/UnityStation-Tutorial/main/Assets/Textures/Bot/Attention-Front/attention-front-1.gif)
- l'apprentissage de l'indispensable du jeu tel que l'ID, l'équipement, l'inventaire, l'oxygen, etc
- Une session libre pour s'entrainer sur les armes, la botanique ou encore l'infirmerie

<b>Notes :</b>
- l'affichage de l'interface en mode admin et de la console sont <b>désactivées</b>, mais il est possible qu'elles le soient tout le temps (à verifier)

<b>To do :</b>
- Le dialogue "vetement" ne se declanche pas pres avoir bougé
- faire que la porte coupe-feu s'ouvre toute seule si l'O² reviens
- Pouvoir charger le jeu depuis UnityStation Hub (sans le chargement infini)
- S'assuré que le menu Admin existe toujours hors du tutoriel (ou ajouté une commande f5 pour l'affiché)
- Faire ramassé un morceau de verre au joueur, et lui demandé de se soigné en Medbay
- Resoudre le soucis de musique d'ambiance absente.
- Si le tutorial bot est trop loin du joueur, il se teleportera.
- Ajouté une phrase pour expliqué les courrant d'air , changement de pression, absence de gravité, type de blessure.
- Verouillé sur la table le chargeur dans l'armurerie.
- Faire que le bot puisse pointé un element, (vetement, id, pda, sac, casier, medkit, distributeur)
- travaillé la mise en forme du dialogue du bot, ajouté quelques retour a la ligne par exemple
  
  Une salle où un objet bloque le passage,
- Il faut passé par dessus une table (non en verre)  tirer une caisse, en poussé une autre, 
- frapper un objet pour le brisé, 
- jeter un objet 

- le joueur dois se blesser avec un eclat de verre pour utilisé le medkit.


- une salle sans electricité pour un exercice incendie.
- marcher (pour évité de glissé)

- si le joueur meur, le scenario reprend a zero, et un message "try again," devrai s'afficher
  
  
- Prevoir un nouveau tutoriel pour chaque departement. 

Refined English translation, added line breaks for easier readability. 

Job selection screen

If possible ignore or not display the job selection screen, 
(especially since if you select mime, you get its skills in tutorial)


shorter delay on, equipping clothing
Reduce the delay so that the bot invites you to wear clothes with the hanger or with E.
like as soon as you've taken 2 steps.
pointing to the table.


how to open doors
you can open the door by stepping on it if your ID is in the right place or in hand.
or clicked on it.


bot Teleport
If the bot is too far from the player, it will teleport to you.


nees to say box in the bag
You have to say in the dialogue that in the bag, there is a box, which must be opened (for example with the small blue arrow)
and find oxygen and a mask in it.

add the box of the atmo technician which contains a larger oxygen bottle.
to activate the oxygen in your mask you have an icon on the right of your interface.

point to the metal tiles

once in the room, the bot must point to the metal bars and floor tiles.

since they move around
Nice to explain how to equip
(not really useful)


in the next room you need one hole, not two
one rod, and several floor tiles.


manual, normally the door will "open" itself when the pressure is restored.
but you can also force the door open manually with the red panel on the wall.
pointing at the wall



pointing at several things in the "bar" room
to encourage the player to use them.

when leaving the bar, remember to turn off your oxygen supply to avoid asphyxiating yourself
You will find spare bottles in the blue lockers. "O²"


activating stuff in hand
#detecting an empty magazine
you can use Z to interact with the object in hand, or click on it.
for example if your magazine is empty, you can eject it.
If you have an empty magazine, you can throw it away or put it down and pick up another one and insert it into your weapon.
for energy weapons, you have a magazine north of your position.
* lock the battery charger on the table to make it functional


Botanic
pointing at distributor
explaining the, lights on the high tropics
the hydroponics stations have several lights showing their state, water (blue) weed (red), low nutrient (orange) ready for harvest.
you can put a seed or a fruit directly on it.
be careful, if you add a fruit on a plantation you will compost it.

invite the player to take off his gloves, and pick up that shard of glass from the ground.
#detectingabloodstain
"apparently your pain sensor is working, congratulations!
if you don't want to stop emptying your vital fluid on the floor?
you can use the first aid kit on the table,
the health analyser will give you the nature and severity of your injury. 
you can then use the appropriate treatment.
to target a wound carefully, use your number pad or click on the icon at the bottom with the character.


In a room where access is blocked, the player will have to climb over a table, pull a crate, push another one, hit a piece of debris
to free the access.

optional room, firetest.
a room with a door, a red locker.
You have to equip yourself with the fire protection suit, turn on the helmet and equip it.
then another door without energy and with the firelock engaged, it will be necessary to force the two doors with the crowbar.
find the origin of the fire, and use the extinguisher on it.
beware it is recommended to walk "C" not to slip on a puddle of water.


to finish your tutorial, please go to the east of the shuttle.

door ofset and dark

look into space ambience
  
  https://youtu.be/krssJiDJLhY
