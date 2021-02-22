# Program Organization

## System Context Diagram: 

![Screen Shot 2021-02-10 at 12 02 12](https://user-images.githubusercontent.com/38693615/107567716-08272300-6bb4-11eb-8670-9e49634eba64.png)

Our single player game will allow players to play Manifesting Destiny, view progress bars to reach the next expansion state, and change game settings to fit their game style. The game is being developed through Unity’s gaming engine. 

| System Context | User Story ID                                                                                 |
|---------|-----------------------------------------------------------------------------------------------|
| Player  | 003, 004, 005, 006, 009, 012, 013,                                                                       |
| Game    | 007, 008, 009, 010, 011, 016, 017, 018, 019, 021 |


## Container Diagram:

![Screen Shot 2021-02-10 at 15 19 22](https://user-images.githubusercontent.com/38693615/107567682-ffcee800-6bb3-11eb-8977-2aa14425b153.png)

* Player: A person who owns the game can access their personal settings set and play the game by controlling user input.
* Game Context: The game context is produced when a player opens the program to launch our game.
* Main Menu Container: Players can access their previous game saves, change their settings, quit the game, and play Manifesting Destiny.
* Game Container: The game container consists of all the settings and controllers necessary to properly advance through the Manifesting Destiny game. 

| Container     | User Story ID                                         |
|---------------|-------------------------------------------------------|
| Main Menu     | 001, 003, 013, 022      |
| Game          | 004, 007, 008, 009, 010, 015, 016, 017 |
| Unity IO      | 002 |

## Component Diagram:

![Component](https://user-images.githubusercontent.com/38693615/107663801-c650b800-6c59-11eb-807f-a86430aa4b2f.png)

Main Menu Container:
* Utilities Component: Functionalities such as start game, load game, quit game, and settings are what compose the utilities component in the Main Menu Container. These functionalities are what give the player access to our game and are dictated by user input.
* persistentDataPath Component: This component is what allows a player to save a current game state or load a new state. The main menu reads from the persistentDataPath to load a game.

Manifesting Destiny (Game) Container:
* persistentDataPath Component: The game uses the persistentDataPath to allow the player to save his current state in the game. Thus, reading and writing to this component will be a frequent action throughout the game. 
* Expansion and Defense Controller Component: As the player plays the game, the progress towards expansion and defense will continue to be recorded. This determines whether the player will be able to expand and gather more resources or lose if the player cannot defend against the bad events. If the player cannot defend against a certain bad event, the player loses the game. Contrastingly, if the player is able to expand towards California, he wins.

| Component                | User Story ID                |
|--------------------------|------------------------------|
| Utilities                |  013, 022, 001               |
| persistentDataPath       |  002                         |
| Expansion & Defense controller | 008, 010, 014          |


# Code Design

## Main Menu
Main Menu UML Diagram: Directly below is the UML for our main menu. The game will start by loading directly into the Main Menu class. The user can then decide whether they want to go to Settings, New Game, or Load Game. In the Settings class, they'll have the option to change the volume settings. In the Load Game class, they'll be able to select one of three saved games and return to playing that game. In the New Game class, they'll choose the settings for their game. That is to say, what mode and difficulty they want.

![Manifesting-Destiny-Class-Diagrams-Main-Menu](https://user-images.githubusercontent.com/45442774/107851886-2ae75080-6ddb-11eb-8f52-28ae6157a2d1.png)

* Main Menu Class: The only purpose of the main menu is to direct the user to either the new game, load game, or settings menus.
* New Game Class: This class is where the user will select the mode they want to play in and the difficulty they want to play on.
* Load Game Class: This is where a user can choose to load a saved game.
* Settings Class: This is where a user can adjust the volume of music and sounds.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  1  |    As a player, I want a main menu in order to easily start a new game and load old games.    |   Main Menu   |
|  13  |    As a player, I want to be able to change the volume of the music so I can determine a good volume level for me.    |   Settings   |

## Overlay
Overlay UML Diagram: The Overlay diagram contains all the various icons and menus that will be on the player's screen as they play the game. The overlay contains an icon to open the buildings menu, an icon to open the units menu, an icon to open the pause menu, and shows you have many resources you have of each type (food, wood, gold). Clicking on any of the icons will direct the user to the associated class. For example, clicking on the buildings menu icon will run the Building Menu class, showing the user a window with all the buildings they can build at that time.

![Manifesting-Destiny-Class-Diagrams-Overlay](https://user-images.githubusercontent.com/45442774/107852007-f1fbab80-6ddb-11eb-8311-df7440104fad.png)

* Overlay Class: A class that allows the user to open any of the necessary overlay menus while playing the game. Basically, it's a bunch of buttons that call the menu classes as needed.
* Pause Menu Class: This is where the user can open the settings menu, save the game, quit the game, or just leave the game paused.
* Unit Menu Class: This is where the user will select the unit they want to build.
* Building Menu Class: This is where the user will select the building they want to build.
* Resource Inventory Class: This allows the user to see the resources they have.
* Popups Class: A parent class governing general popup windows.
* Good Events Class: This subclass shows the user good events.
* Bad Events Class: This subclass shows the user bad events.
* Information Popups Class: This subclass shows the user informational popups.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  2  |    As a player, I want to be able to save my game so that I can pick the game up at the last time I played.    |   Pause Menu   |
|  3  |    As a player, I want a basic tutorial when I first play the game, so that I can easily figure out what I'm supposed to do.    |   Information Popups   |
|  4  |    As a player, I want a text-based narrator, so that the game can communicate certain mechanics and milestones with me.    |   Information Popups   |
|  6  |    As a player, I want to be able to pause the game so I can divert my attention somewhere else while I am playing.    |   Pause Menu   |
|  7  |    As a player, I want the game to generate obstacles for me so that I can feel challenged.    |   Bad Events   |
|  8  |    As a player, I want to be able to defend my settlement from the challenges imposed by the game so that I can save my settlement.    |   Building Menu   |
|  10  |    As a player, I want to be able to expand my settlement so that I can continue to progress in the game.    |   Building Menu   |
|  11  |    As a player, I want to be able to see the resources I have so that I can view how many resources I have collected each time.    |   Resource Inventory   |
|  13  |    As a player, I want to be able to change the volume of the music so I can determine a good volume level for me.    |   Pause Menu   |
|  14  |    As a player, I want an indication of how many resources I need to gather before I am able to expand my settlement.    |   Resource Inventory   |
|  16  |    As a player, I want the game to get harder as I progress so that I am not in a static state.    |   Bad Events   |
|  22  |    As a player, I want to be able to quit the game from the main menu so I can easily exit.    |   Pause Menu   |

## Events
Events UML Diagram: The Events diagram shows the data behind the windows in the "pop-ups" class in the Overlay diagram. That is to say, the "pop-ups" class and its children classes are just the windows that tell the user what is happening. The Events class and its children are what run the calculations and decide what sort of event will occur and why.

![Manifesting-Destiny-Class-Diagrams-Events](https://user-images.githubusercontent.com/45442774/107852014-0344b800-6ddc-11eb-9fa4-f831e7b20501.png)

* Events Class: A parent class governing general events.
* Information Events Class: A subclass that retrieves information on the tutorial, resources, units, or buildings.
* Good Events Class: A subclass that decides when a good event occurs.
* Bad Events Class: A subclass that decides when bad events occur.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  3  |    As a player, I want a basic tutorial when I first play the game, so that I can easily figure out what I'm supposed to do.    |   Information Events   |
|  4  |    As a player, I want a text-based narrator, so that the game can communicate certain mechanics and milestones with me.    |   Information Events   |
|  7  |    As a player, I want the game to generate obstacles for me so that I can feel challenged.    |   Bad Events   |
|  16  |    As a player, I want the game to get harder as I progress so that I am not in a static state.    |   Bad Events   |

## Resources
Resources UML Diagram: The Resources diagram shows the classes that govern the resources within an object. For example, the food inside a farm. There will be a maximum limit to the amount of food in a farm, a semi-random number of "food" resource assigned to the farm, and then a counter that keeps track of the food left in the farm as the user works the farm to gain food from it.

![Manifesting-Destiny-Class-Diagrams-Resources](https://user-images.githubusercontent.com/45442774/107852010-faec7d00-6ddb-11eb-9117-aa2884db493f.png)

* Resources Class: A parent class governing general resources.
* Farms Class: A subclass that dictates how much food is in a farm to begin with and keeps track of how much remains at any given time.
* Forest Class: A subclass that dictates how much wood is in a forest to begin with and keeps track of how much remains at any given time.
* Mines Class: A subclass that dictates how much gold is in a mine to begin with and keeps track of how much remains at any given time.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  9  |    As a player, I want to be able to gather resources to help me progress in the game.    |   Resources   |
|  19  |    As a player, I want there to be a limit to the resources in the map so that I be strategic in how I gather and spend them.    |   Resources Class   |

# Data Design

The game utilizes the persistentDataPath which allows the player to save the current state of their game to a static directory path. The user will be able to load their saved game from that path and continue right where they left off. Local variables and other objects pertinent to the game will manifest in memory and be destroyed when the game is closed.

# Business Rules

Since we are using pre-existing assets gathered from the internet, and implementing our own game music and sound effects, we must abide by the copyright standards set in place for these elements. Additionally, we shall not attempt to pass off any assets used for this product as our own.

# User Interface Design

![UI-Diagram](https://user-images.githubusercontent.com/73034231/107835586-0736f280-6d68-11eb-955c-57a59b73e863.jpg)

* Main Menu: This will be the First Screen the users see when starting the program. The screen displays 2 options, “Start” and “Exit”. The Start button will lead to the next UI.

* Start Game: When the user press start game this will be the next screen they see. This screen will also display 2 options, “New Game” and “Load Game”. Both options will lead the user to the Map screen, however, based on the choice the map will differ.

* Map: This screen will be the main screen the user interacts with. This screen will have 5 main displays other than the map: “<Name of Settlement>”, “Expand”, “Defend”, “Resources”, and “Pause”. “Pause” is the only other interactable display in which will direct the user to the Pause/Sub Menu. 
 
* Pause/Sub Menu: This menu allows the user to pause their game if they need to or if the user wants to save and leave the game. This screen displays 3 options: “Resume Game”, “Save & Exit”, and “Settings”. “Resume Game” will allow the user to go back to Map and resume their game. “Save & Exit” will bring the user back to the Main Menu.

* Win: This screen will appear if the user wins the game.

* Lost: This screen will appear if the user loses the game.

| User Interface               | User Story ID                |
|--------------------------|------------------------------|
| Main Menu              |  001, 022               |
| Start Game       |  002                         |
| Map | 009, 010, 011, 014, 015, 021          |
| Pause/Sub Menu             |  002, 006, 013               |
| Win    |  017                         |
| Lost | 018         |

# Resource Management

Since our game utilizes 8-bit graphics and is relatively simple in terms of mechanics and active objects within the game, approximately 4 gigabytes of ram and any CPU and GPU from 2015+ would be suffiicent to run *Manifesting Destiny*. Object pooling will be used to reduce CPU usage and pre-instatiate any objects (in regard to our game this could be units, resources, or areas to be discovered) needed by a scene instead of dynamically creating them as the game runs.

| Resource Management              | User Story or Requirements ID                |
|--------------------------|------------------------------|
| 8-Bit Graphics              |  RID024              |

# Security

We are creating a single-player game and will be running locally on the users’ computer, and will not be saving critical or personal data that needs to be protected. So we concluded that security is not a consideration in our system architecture. 

| Security              | User Story or Requirements ID                |
|--------------------------|------------------------------|
| Playing Locally             |  UID028              |

# Performance
The graphics in our game will be 2 Dimensional 8-Bit Style, which will not be graphically intensive. The only intensive part of our software will that the software is computationally intensive. However, the game is designed to be simple so it shouldn’t use a lot of memory and CPU space. So we believe that our game will perform well on any reasonable laptop or desktop.

| Performance              | User Story or Requirements ID                |
|--------------------------|------------------------------|
| 8-Bit Graphics              |  RID024              |

# Scalability

We want to maintain modularity in our game so that it can be scaled out in future versions. There are a lot of ideas and features we would like to implement, but might not have time for. In this way, we want to establish a core set of features first, and then eventually expand that feature-set over time. Ways in which we plan to scale our game outward in the future include adding more biomes/locations to explore, including new random encounters/events, and introducing more resource types over time to support a variety of play styles.

| Scalability           | User Story or Requirements ID                |
|--------------------------|------------------------------|
| Core Fetures           |  UID026, 024, 002, 013              |

# Interoperability
Since our game is created using Unity, it is self-contained and does not require any additional files or rely on any software outside of what comes packaged with it. *Manifesting Destiny* does not interact or share data with other software or hardware, and because of this interoperability is not a consideration for this project.

# Internationalization/Localization

This game is being created for a target audience of English-speaking users; this section is not applicable to our game.

# Input/Output

Our game will take input from the mouse in order to move the on-screen cursor and select objects in-game. This can be used to navigate menus or select objects in the game world. In addition, input will be taken from the keyboard for actions such as map navigation (WASD), entering a requested value from the user (0-9), and opening the game menu (ESC). All outputs will come through the screen as the player receives visual feedback from their actions. Any I/O errors will be handled through Unity itself.

| Input/Output          | User Story or Requirements ID                |
|--------------------------|------------------------------|
| Interaction         |  UID026, UID011, UID023 RID001, UID023 RID002 UID023 RID003     |

# Error Processing

The Unity engine handles error processing for our game and writes any error(s) encountered during runtime to both the console window in Unity and a log file for the Unity editor.

# Fault Tolerance

Bugs are commonplace in gaming and it is expected that at least a few of these will be overlooked during development. For this project we plan to concentrate more on our game’s feature set than some minor bugs. Our focus for detecting faults will be at the priority level of “game breaking” rather than minor. In this way, we can aim to achieve a more dynamic, feature-driven product rather than a linear, yet refined product.

# Architectural Feasibility

Since this game is being made as a simple alternative to other strategy games that incorporate a ton of micromanagement, the core features of this game are relatively simple and thus straightforward for us as the developers to implement. All of the developers working on this project are familiar with C# and have a basic yet solid grasp of Unity development, so we are confident that *Manifest Destiny* will meet its performance targets.


# Overengineering

This game will be robust because we the developers are on the side of simplicity rather than complexity in our code and design. We will start by building a simple main menu that allows the user to start the game and open a simple map. Then, we will create a basic overlay that displays only information that the user needs to play the game and tools to build up their settlement. These elements serve as the basic foundation for our game and after their creation, additional features will be added with simplicity and clean code in mind over the 3 month development period allotted to create our game. If any additional features created add to much complexity or come off as overengineered, they can be very easily rolled back or redesigned within the development period.

| Input/Output          | User Story or Requirements ID                |
|--------------------------|------------------------------|
| Map         |  UID026    |
| Resources         |  UID023    |


# Build-vs-Buy Decisions

We are building our game in the Unity Engine. All software in our final project will be built by us. And, any 8-Bit drawing or music will be either done by hand or will be obtained from open-source materials. Also, we will be using free assets from the Unity asset store, which freely allows us to utilize them. Assets such as TextMesh Pro will be used to write dialogue systems in the game. So all the material and software we are using is free.

| Input/Output          | User Story or Requirements ID                |
|--------------------------|------------------------------|
| Assets         |  UID026 RID 001, 002, 003    |

# Reuse

This game may use pre-existing visuals or sprites obtained from a third party. Obtaining these resources will be handled with respect and not passed off as our own. We plan to give full credit to the parties that contributed to our software, and follow the legal guidelines necessary for this process.

| Input/Output          | User Story or Requirements ID                |
|--------------------------|------------------------------|
| Assets         |  UID026 RID 001, 002, 003    |

# Change Strategy

Our game has the flexibility to change at both the higher and lower architecture level. At the low level, we are able to balance and fine-tune certain game mechanics where necessary. For example, if a strategy arises that is shown to over-shadow all other viable strategies, then adjustments can me made to lower to power-level of such a strategy. At the higher level, we're maintaining modularity in our project to keep each feature completely isolated. Additionally, once the core game is designed, we will be able to append as many additional features as we have time for. This will allow us to expand our architecture outward without totally compromising it's integrity.
