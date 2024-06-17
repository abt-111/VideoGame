# Un jeu vidéo
Créer un personnage de jeu vidéo. La classe `Character` contient :
* Un nom en attribut
* Des points de vie en attribut
* Une force d'attaque en attribut
* Une force de défense en attribut
* Une méthode `IsAlive()` qui renvoie un booléen indiquant si le personnage est vivant (`true`) ou mort (`false`)
* Une méthode `Attack()` qui prend en paramètre un autre personnage et réalise l'opération suivante : `attaqué.pv = (attaqué.pv) - (attaquant.force - attaqué.défense)`

Mets en scène ces deux personnages s'attaquant, jusqu'à ce que l'un des deux meure. Lorsque l'un des deux mourra, affiche un message indiquant qui a gagné.