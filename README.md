# Un jeu vid�o
Cr�er un personnage de jeu vid�o. La classe `Character` contient :
* Un nom en attribut
* Des points de vie en attribut
* Une force d'attaque en attribut
* Une force de d�fense en attribut
* Une m�thode `IsAlive()` qui renvoie un bool�en indiquant si le personnage est vivant (`true`) ou mort (`false`)
* Une m�thode `Attack()` qui prend en param�tre un autre personnage et r�alise l'op�ration suivante : `attaqu�.pv = (attaqu�.pv) - (attaquant.force - attaqu�.d�fense)`

Mets en sc�ne ces deux personnages s'attaquant, jusqu'� ce que l'un des deux meure. Lorsque l'un des deux mourra, affiche un message indiquant qui a gagn�.