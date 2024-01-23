So. I tried doing this in Java, but I bit off WAYYY more than I could chew, so, I'm starting over, now in C#
(Hopefully, I won't get lost this time)

Planned Functions:
-Ability to read data from Dragalia's CharaData, DragonData, TalismanData, and TextLabel + other required files to populate a GUI
-Save changes made in said GUI to the relevant files
-Maybe, hopefully, possibly, automate all this by pulling from a master asset bundle, and save it to the bundle after? This is low priority, because you can just do it yourself, but it'd be nice if I could just pull all the files from a bundle, then put them back after

GUI Plan:
-Ask for bundle/folder path
-Disable UI while loading, show a loading bar somehow (very important, trust me)
-Main Menu:
--Characters:
---List of Characters read from the file, organized by id (ignore variants)
---When character name is clicked on, open side menu with information compiled from CharaData + TextLabel, have a dropdown or something to switch between variants
---Have a separate menu that pulls up all text entries relating to the character
--Dragons
--Wyrmprints