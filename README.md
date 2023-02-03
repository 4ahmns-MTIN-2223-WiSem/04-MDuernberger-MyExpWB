# 04-MDuernberger-MyExpWB

Kurzbeschreibung: Eisstockschießen - Wenn der Spieler sich auf die Holzfläche stellt, kann er den Eisstock nehmen und versuchen so nah wie möglich zur Daube (Würfel) zu schießen. An der Tafel werden Distanz und Punkte angezeigt.

Developmentplatform: Unity 2020.3.18f1, Visual Studio 2022, Windows 10

3 Syntaxelemente:
- Methodendeklaration
- if-Statement
- while-Schleife

Jetzige Interaktion:
Der Eisstock kann mit der Maus geschoßen werden. Wenn der Spieler (Tag "Player") nicht auf der Holzfläche steht, kommt eine Warnung und der Eisstock wird wieder an die Anfangsposition gesetzt, damit schummeln verhindert wird. Der Player ist aktuell noch die Capsule.

- noch nicht eingebunden
- keine third Party Elemente (alles selbst modelliert)

Limitations:
Die Punkte sind teilweise anfangs negativ. Glow-Effect hätte nur mit der Render Pipeline funktioniert (wusste nicht ob diese Umstände machen würde, darum nicht eingebaut)
