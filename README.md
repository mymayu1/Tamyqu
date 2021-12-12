![Unity: 2021.2](https://img.shields.io/badge/unity-2021.2-ff6964)

# Game: TAMYQU

## Beschreibung

TAMYQU - unser 2D Game
Bei unserem Jump and Run Game geht es darum den Spieler zum Ende des Spiels zu navigieren, während der Player einige Hindernisse ausweichen muss und sich dabei von Platform zu Platform bewegt.


### Genre & Art Style
2D Sidescroller, Platformer

## Features

### Player 
Der Player wird gesteuert mit den WASD Tasten. Mit A und D bewegt er sich nach links und nach rechts bewegt er sich um 6 Einheiten, und dreht sich auch in die gedrückte Richtung. Mit W entered er Türen und mit S croucht der Spieler und kann dennoch sich nach links und rechts bewegen, wenn man S gedrückt hält.

Mit SPACE springt der Player vertikal nach oben um 3 Einheiten, dabei kann der Player auch sich nach links und nach rechts springen, wenn man die Steuerung gleichzeitig drückt. 

Der Player besitzt auch eine Idle wo er alle paar Sekunden blinzelt.

Außerdem kann der Player auch schießen mit der ","-Taste, dabei schießt er von seinem Körper aus einen Bullet-Prefab, womit er seine Enemies abschießen kann.

Der Player kann auch Items einsammeln, wie die Diamanten, Äpfel und Herzen.

Um das Spiel zu pausieren, muss die P Taste gedrückt werden.

### Enemies
Die Enemies sind auch Prefabs, die im Spiel platziert wurden, sie bewegen sich aber minimal um 0.7 Einheiten von der Stelle mit einer Geschwindigkeit von 1.5E. Wenn der Player mit einem Enemy in Berührung kommt wird ein Leben von dem Player abgezogen.
Stirbt sobald er von einem Bullet getroffen wird. Spikes sind Hindernisse im Spiel, welche ausgeweicht werden muss, sonst verliert der Player ein Leben

### Items


<li>Diamanten - Item um das Bonus Level freischalten zu können, spaß bei sammeln.</li>
<li>Äpfel - Beim einsammeln eines Apfels werden 3 bullets garantiert.</li>
<li>Ring - Key um die Tür zum nächsten Level zu öffnen und um das Level zu beenden.</li>
<li>Spikes - Hindernis im Spiel, was ausgeweicht werden muss, sonst verliert der Player ein Leben</li>


## Spiel

### Hauptmenü & Pausenmenü

Bevor das Spiel gestartet wird, erscheint das Hauptmenü.
<li>PLAY - Das Spiel wird gestartet</li>
<li>OPTIONS - Erklärung wie das Spiel gesteuert und gespielt wird, Volumeregler (einstellen der Lautstärke)</li>


![Hauptmenue](https://user-images.githubusercontent.com/65132134/145465544-f6c279b8-0b31-4661-84b1-7a3e775e014a.gif)

##### Das Pausenmenü wird durch die P Taste aufgerufen.

<li>Resume - Das Spiel wird fortgesetzt</li>
<li>Main Menu - Der Spielfortschritt wird beendet und man wird zum Hauptmenü geleitet.</li>
<li>Quit Game - Das Spiel wird beendet und die App wird geschlossen.</li>


![PauseMenue](https://user-images.githubusercontent.com/65132134/145469388-d93450f7-8a2d-429d-bad4-f08b3aed1bfc.gif)


### Player Control

Der Player kann mit der Steuerung sich fortbewegen, von der Platform springen und Items einsammeln.


![PlayerCollecting](https://user-images.githubusercontent.com/65132134/145466022-ddd182fb-ed61-4239-911b-affa6c6c4317.gif)



Der Player schießt seine Enemies ab und begegnet Hindernissen.


![PlayerItems](https://user-images.githubusercontent.com/65132134/145466598-0e033fbc-281a-4053-abf3-a5df7a5afe3d.gif)



Der Player muss den Ring einsammeln um das Level zu beenden und das nächste Level zu betreten.


![PlayerKeyFinish](https://user-images.githubusercontent.com/65132134/145466978-53f718c1-0529-4a32-9653-242c6f56cde7.gif)



Um an manch schwererreichbare Items zu kommen, muss der Player sich ducken.



![PlayerCrouch](https://user-images.githubusercontent.com/65132134/145467149-e82cea2d-51cc-4325-b40e-bff440dc44cd.gif)


### Objekte

Damit es nicht allzu langweilig ist, gibt es schwebene Platforms die sich bewegen können und auch fallende Platforms.



![MovingPlatform](https://user-images.githubusercontent.com/65132134/145467565-f1437adc-e91b-4850-b025-388d0a18b669.gif)




![PlatformMovingFalling](https://user-images.githubusercontent.com/65132134/145467766-8d430f07-4430-4a2c-ba1f-bf360ea8ad62.gif)



Um schwererreichbare Platforms zu erreichen, gibt es Leitern um sie zu erreichen.



![Ladder](https://user-images.githubusercontent.com/65132134/145468040-1c8ddc0a-6415-44d8-8d0f-832c84a37cd9.gif)



### Team
Tanem Basaraner, Tra My Nguyen, Quynh Vi Trinh

### Built With
Software
* Unity Version 2021.2.0f1





