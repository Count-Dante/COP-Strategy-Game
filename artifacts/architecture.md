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

![Manifesting Destiny Class Diagrams-Main Menu](https://user-images.githubusercontent.com/45442774/109438518-68152a80-79f8-11eb-8658-fa6512b1bbf2.png)

* Start Game Class: This class is where the user will select the mode they want to play in and the difficulty they want to play on.
* Load Game Class: This is where a user can choose to load a saved game.
* Settings Class: This is where a user can adjust the volume of music and sounds.
* Quit Game Class: This allows a user to close the game application.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  1  |    As a player, I want a main menu in order to easily start a new game and load old games.    |   Main Menu   |
|  13  |    As a player, I want to be able to change the volume of the music so I can determine a good volume level for me.    |   Settings   |
|  27  |    As a player, I want to be able to load old games from the main menu so I can easily access previous game states    |   Load Game   |

## Resources
Resources UML Diagram: 

![Manifesting Destiny Class Diagrams-Resources](https://user-images.githubusercontent.com/45442774/110257067-0f9adb80-7f6a-11eb-8ebd-afd23fe8167a.png)

* Resources Class: This class allows other class to update the amount of food, gold, and wood resource. And allows other class to obatin the amount of each resource.
* Food Class: This class holds a "Food" object. This object is 1 of the 3 tiles that will be placed around the map and used to gather the food resource (via harvestFood() method). Uses a "numberOfClicks" field to ensure the player has a limit to the amount of times the food tile can be clicked. Calls on Timer class to ensure resource can be harvested.
* Wood Class: This class holds a "Wood" object. This object is 1 of the 3 tiles that will be placed around the map and used to gather the wood resource (via harvestWood() method). Uses a "numberOfClicks" field to ensure the player has a limit to the amount of times the wood tile can be clicked. Calls on Timer class to ensure resource can be harvested.
* Gold Class: This class holds a "Gold" object. This object is 1 of the 3 tiles that will be placed around the map and used to gather the gold resource (via harvestGold() method). Uses a "numberOfClicks" field to ensure the player has a limit to the amount of times the gold tile can be clicked. Calls on Timer class to ensure resource can be harvested.
* RNG Class: Used to generate a random number for certain events in the game. This class helps in producing random resource amounts as well as random encounters in the game.
* Indicator Class: This class will gather the amount of wood, gold, food from their respected class and print them on screen for the user to see.
* Resource Inventory Class: This class keeps track of a user's input for resource allocation with the sliders. It ensures that users cannot allocate more resources than in their inventory.
* Defense Controller Class: This class updates and removes the number of total resources the user allocated.
* Defense Bar Class: This class updates the Defense Bar UI to show how much defense the user has.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  011  | As a player, I want to be able to see the resources I have so that I can view how many resources I have collected each time. |  Indicator  |
|  019 | As a player, I want there to be a limit to the resources in the map so that I be strategic in how I gather and spend them.  |   Food, Wood, Gold   |
|  025 | As a player I want to be able to collect food from a tile so that I have an alternate way to obtain resources to progress through the game  |   Food  |
|  023 | As a player I want to be able to collect wood from a tile so that I have an alternate way to obtain resources to progress through the game  |   Wood  |
|  024 | As a player I want to be able to collect gold from a tile so that I can have another method of obtaining resources  |   Gold  |
|   010 |     As a player, I want to be able to expand my settlement so that I can continue to progress in the game.   |  Resource Inventory Class    |
|    008|     As a player, I want to be able to defend my settlement from the challenges imposed by the game so that I can save my settlement. | Resource Inventory|
|    008|     As a player, I want to be able to defend my settlement from the challenges imposed by the game so that I can save my settlement. | Defense Controller|
|  030 | As a player, I want a timer while I click on the resources so that I think about what resources to prioritize. |   Food, Wood, Gold   |
|  029 | As a player, I want to be able to see how much defense I need to be able to defend my settlement. |   Defense Bar   |

## Expansion Bar
Expansion Controller UML Diagram: 

![Manifesting Destiny Class Diagrams-Expansion Controller](https://user-images.githubusercontent.com/45442774/110257070-19bcda00-7f6a-11eb-869b-ee152d3f7d95.png)

* Expansion Controller Class: This class holds the resources the user allocates towards expansion each turn. Other classes such as the expansion bar get data from this class. Additionally, this class determines expansion points needed according to level of difficulty (easy, medium, hard, extreme).
* Expansion Bar Class: The Expansion Bar Class changes the bar indicator in the game to help the user visualize how much more expansion points they need before they can expand. The calss gather the amound of wood, gold, and food allocated into the expansion and then calucates the users current expansion point. Which "Update" will update the bar to show the change.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  010  |   As a player, I want to be able to expand my settlement so that I can continue to progress in the game.     |    Expansion Controller  |
|   014 |   As a player, I want an indication of how many resources I need to gather before I am able to expand my settlement.  |   Expansion Bar  |

## Sliders
Sliders UML Diagram: 

![Manifesting Destiny Class Diagrams-Sliders](https://user-images.githubusercontent.com/45442774/109438664-f2f62500-79f8-11eb-841b-0a5ac5dad6a1.png)

* Slider Class: This class updates the text that represents the value the slider is currently at. 
* Wood Slider Class: This is a subclass of the slider class. Determines how the slider should move based on wood collected by the user and saves the final selected value in the expansion controller and defense controller.
* Food Slider Class: This is a subclass of the slider class. Determines how the slider should move based on food collected by the user and saves the final selected value in the expansion controller and defense controller.
* Gold Slider Class: This is a subclass of the slider class. Determines how the slider should move based on gold collected by the user and saves the final selected value in the expansion controller and defense controller.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|   010 |     As a player, I want to be able to expand my settlement so that I can continue to progress in the game.   |  Slider Class    |
|    008|     As a player, I want to be able to defend my settlement from the challenges imposed by the game so that I can save my settlement. | Slider Class |

## Bad RNG
Bad RNG UML Diagram: 

![Manifesting Destiny Class Diagrams-Bad RNG](https://user-images.githubusercontent.com/45442774/109438685-01dcd780-79f9-11eb-9239-f0d1b34de5f6.png)

* Bad RNG Class: This class produces the negative events that the user will have to face as they go through the game.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|   007 |     As a player, I want the game to generate obstacles for me so that I can feel challenged.  |   BadRNG   |

## Volume
Volume UML Diagram: 

![Manifesting Destiny Class Diagrams-Volume](https://user-images.githubusercontent.com/45442774/110257100-4c66d280-7f6a-11eb-8fa0-054748441ca7.png)

* Volume Class: This class updates the music volume or game sounds volume, depnding on which function is used.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  005  |    As a Player, I want music when I play the game to make it more enjoyable.    |   Volume   |
|  013  |    As a player, I want to be able to change the volume of the music so I can determine a good volume level for me.    |   Volume   |

## Save/Load Game
Save/Load Game UML Diagram: 

![Manifesting Destiny Class Diagrams-Save Game](https://user-images.githubusercontent.com/45442774/110257184-9059d780-7f6a-11eb-93ff-98e8871bd8f0.png)

* Save Data Class: This class contains 2 functions: The save function when called stores the current value of each resource and allocation of resources towards either defense or expansion into a "Game Data" object that stores these values into a .data file that is written to Unity's persistent data path. The load function when called accesses the .data file created by the save function and writes the stored values to the current game.
* Game Data Class: This class serves as an object to store the values of each resource and allocation values towards defenese and expansion.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  002  |    As a player, I want to be able to save my game so that I can pick the game up at the last time I played.    |   Save Data   |

## Timer
Timer UML Diagram: 

![Manifesting Destiny Class Diagrams-Timer](https://user-images.githubusercontent.com/45442774/110257157-846e1580-7f6a-11eb-8e35-7a3fdc88ae7f.png)

* Timer Class: Controls how long a round lasts before you are unable to perform any actions. Interfaces with the "TimerBar" game object to show the player that their time is slowly decreasing. Also serves as a support class for the Wood, Food, and Gold classes. (For Timer-Resource interactions, see the Resources class.)

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  030  | As a player, I want a timer while I click on the resources so that I think about what resources to prioritize. |  Timer  |

## Victory Button
Victory Button UML Diagram:

![Untitled Diagram-Page-1](https://user-images.githubusercontent.com/73034231/111244597-9b9bab80-85d9-11eb-898e-dd9656a19fae.jpg)

* Victory Class: This will send the user to the Victory Scene, whenever they are able to expand towards California.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  017  | As a player, I want to be able to beat the game so that I am not playing an endless game. |  Victory  |

## Exit to Main Menu
Exit To Main Menu UML Diagram:

![Untitled Diagram-Page-2](https://user-images.githubusercontent.com/73034231/111245266-c1758000-85da-11eb-97c8-a036f4a925e3.jpg)

* Exit Class: This will sent the user back to the Main Menu Scene.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  017  | As a player, I want to be able to beat the game so that I am not playing an endless game. |  Victory  |

## 
Failed Sound Manager UML Diagram:

![Manifesting Destiny Class Diagrams-Failed Sound Manager](https://user-images.githubusercontent.com/45442774/112058155-9934d680-8b30-11eb-917b-5cc346ecb258.png)

* Failed Sound Manager Class: Plays a sound that signifies losing the game while also stopping the normal background sound of the game.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  005  |  As a Player, I want music when I play the game to make it more enjoyable.   | Failed Sound Manager   |

## 
Events UML Diagram:

![Manifesting Destiny Class Diagrams-Events](https://user-images.githubusercontent.com/45442774/112058197-aa7de300-8b30-11eb-9444-869935513eca.png)

* Plague Class: This class takes a certin amount of food based off of how much the defense bar is filled. And see if the player losses.
* Bandit Class: This class takes a certin amount of gold based off of how much the defense bar is filled. And see if the player losses.
* Tornado Class: This class takes a certin amount of wood based off of how much the defense bar is filled. And see if the player losses.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  032  | As a player, I want different bad events that have different effects so that the game has variety. | Plague, Bandit & Tornado Class |

## 
Play Background Sound UML Diagram:

![Manifesting Destiny Class Diagrams-Play Background Sound](https://user-images.githubusercontent.com/45442774/112058270-bff30d00-8b30-11eb-8ab0-e736d5701d34.png)

* Play Background Sound Class: Plays the background sound through a script that can start and stop the sound of the game.

| **ID** | **User Story**                                                                                              | **Major Classes**       |
| ------ | ----------------------------------------------------------------------------------------------------------- | ----------------------- |
|  005  | As a Player, I want music when I play the game to make it more enjoyable.    |  Play Background Sound  |

# Data Design

The game utilizes the persistentDataPath which allows the player to save the current state of their game to a static directory path. The user will be able to load their saved game from that path and continue right where they left off. Local variables and other objects pertinent to the game will manifest in memory and be destroyed when the game is closed.

| Data Design              | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Game Saved and Load          |  UID 002, 027             |

# Business Rules

Since we are using pre-existing assets gathered from the internet, and implementing our own game music and sound effects, we must abide by the copyright standards set in place for these elements. Additionally, we shall not attempt to pass off any assets used for this product as our own.

| Business Rules             | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Assets        |  UID026 RID001, 002, 003             |

# User Interface Design

![Untitled Diagram (2)](https://user-images.githubusercontent.com/73034231/109447797-82f49880-7a12-11eb-8ae1-862aceab00ce.png)

* Main Menu: This will be the First Screen the users see when starting the program. The screen displays 2 options, “Start” and “Exit”. The Start button will lead to the next UI.

* Start Game: When the user press start game this will be the next screen they see. This screen will also display 2 options, “New Game” and “Load Game”. Both options will lead the user to the Map screen, however, based on the choice the map will differ.

* Map: This screen will be the main screen the user interacts with. This screen will have 5 main displays other than the map: “<Name of Settlement>”, “Expand”, “Defend”, “Resources”, and “Pause”. “Pause” is the only other interactable display in which will direct the user to the Pause/Sub Menu. The is also a "Continue" button that sends the user to Resource Allocation. The "Expand" button will send to a fresh map and closer to California, the last state.
 
* Pause/Sub Menu: This menu allows the user to pause their game if they need to or if the user wants to save and leave the game. This screen displays 3 options: “Resume Game”, “Save & Exit”, and “Settings”. “Resume Game” will allow the user to go back to Map and resume their game. “Save & Exit” will bring the user back to the Main Menu.

* Resouce Allocation: This UI will allow the user to allocate resources into expanding or defending their settlement. This screen will display 3 sliders for each resource and each silder will show the value of the slide at the very right. Their is also a continue button that will allow the user to confirm their allocation and go back to the map.

* Negtaive Event: This screen will only pop up if the user encountures a negative event. This screen will diaply a picture of the event, a discription of what happens in the event, and a "Continue" button that allows the user to be sent back to thge map

* Volume Setting: This screen will allow the user to change the volume of in game sound. This screen will display a slider to increase or decrease the volume of the sound. And an "Exit" button to go back to the Pause/Sub Menu.

* Win: This screen will appear if the user wins the game.

* Lost: This screen will appear if the user loses the game.

| User Interface               | User Story ID                |
|--------------------------|------------------------------|
| Main Menu              |  001, 022               |
| Start Game       |  002                         |
| Map | 009, 010, 011, 014, 015, 021          |
| Pause/Sub Menu             |  002, 006, 013               |
| Resouce Allocation | 008, 010         |
| Negative Event            |  007              |
| Win    |  017                         |
| Lost | 018         |

# Resource Management

Since our game utilizes 8-bit graphics and is relatively simple in terms of mechanics and active objects within the game, approximately 4 gigabytes of ram and any CPU and GPU from 2015+ would be suffiicent to run *Manifesting Destiny*. Object pooling will be used to reduce CPU usage and pre-instatiate any objects (in regard to our game this could be units, resources, or areas to be discovered) needed by a scene instead of dynamically creating them as the game runs.

| Resource Managemnet             | User Story or Requirement ID    |
|--------------------------|------------------------------|
| 8-Bit Graphics        |  UID024 RID001          |

# Security

We are creating a single-player game and will be running locally on the users’ computer, and will not be saving critical or personal data that needs to be protected. So we concluded that security is not a consideration in our system architecture. 

| Security             | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Playing Locally       |  UID028            |

# Performance
The graphics in our game will be 2 Dimensional 8-Bit Style, which will not be graphically intensive. The only intensive part of our software will that the software is computationally intensive. However, the game is designed to be simple so it shouldn’t use a lot of memory and CPU space. So we believe that our game will perform well on any reasonable laptop or desktop.

| Performance           | User Story or Requirement ID    |
|--------------------------|------------------------------|
| 8-Bit Graphics        |  UID024 RID001          |

# Scalability

We want to maintain modularity in our game so that it can be scaled out in future versions. There are a lot of ideas and features we would like to implement, but might not have time for. In this way, we want to establish a core set of features first, and then eventually expand that feature-set over time. Ways in which we plan to scale our game outward in the future include adding more biomes/locations to explore, including new random encounters/events, and introducing more resource types over time to support a variety of play styles.

| Scalability            | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Core Features      |  UID026, 024, 002, 013         |

# Interoperability
Since our game is created using Unity, it is self-contained and does not require any additional files or rely on any software outside of what comes packaged with it. *Manifesting Destiny* does not interact or share data with other software or hardware, and because of this interoperability is not a consideration for this project.

# Internationalization/Localization

This game is being created for a target audience of English-speaking users; this section is not applicable to our game.

# Input/Output

Our game will take input from the mouse in order to move the on-screen cursor and select objects in-game. This can be used to navigate menus or select objects in the game world. In addition, input will be taken from the keyboard for actions such as map navigation (WASD), entering a requested value from the user (0-9), and opening the game menu (ESC). All outputs will come through the screen as the player receives visual feedback from their actions. Any I/O errors will be handled through Unity itself.

| Input/Output           | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Interaction      |  UID026, UID011, UID023 RID001, UID023 RID002, UID023 RID003          |

# Error Processing

The Unity engine handles error processing for our game and writes any error(s) encountered during runtime to both the console window in Unity and a log file for the Unity editor.

# Fault Tolerance

Bugs are commonplace in gaming and it is expected that at least a few of these will be overlooked during development. For this project we plan to concentrate more on our game’s feature set than some minor bugs. Our focus for detecting faults will be at the priority level of “game breaking” rather than minor. In this way, we can aim to achieve a more dynamic, feature-driven product rather than a linear, yet refined product.

| Fault Tolerance           | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Features       |  UID026, 024, 002, 013          |

# Architectural Feasibility

Since this game is being made as a simple alternative to other strategy games that incorporate a ton of micromanagement, the core features of this game are relatively simple and thus straightforward for us as the developers to implement. All of the developers working on this project are familiar with C# and have a basic yet solid grasp of Unity development, so we are confident that *Manifest Destiny* will meet its performance targets.


# Overengineering

This game will be robust because we the developers are on the side of simplicity rather than complexity in our code and design. We will start by building a simple main menu that allows the user to start the game and open a simple map. Then, we will create a basic overlay that displays only information that the user needs to play the game and tools to build up their settlement. These elements serve as the basic foundation for our game and after their creation, additional features will be added with simplicity and clean code in mind over the 3 month development period allotted to create our game. If any additional features created add to much complexity or come off as overengineered, they can be very easily rolled back or redesigned within the development period.

| Overengineering            | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Map     |  UID026          |
| Resources       |  UID023         |

# Build-vs-Buy Decisions

We are building our game in the Unity Engine. All software in our final project will be built by us. And, any 8-Bit drawing or music will be either done by hand or will be obtained from open-source materials. Also, we will be using free assets from the Unity asset store, which freely allows us to utilize them. Assets such as TextMesh Pro will be used to write dialogue systems in the game. So all the material and software we are using is free.

| Business Rules             | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Assets        |  UID026 RID001, 002, 003             |

# Reuse

This game may use pre-existing visuals or sprites obtained from a third party. Obtaining these resources will be handled with respect and not passed off as our own. We plan to give full credit to the parties that contributed to our software, and follow the legal guidelines necessary for this process.

| Business Rules             | User Story or Requirement ID    |
|--------------------------|------------------------------|
| Assets        |  UID026 RID001, 002, 003             |

# Change Strategy

Our game has the flexibility to change at both the higher and lower architecture level. At the low level, we are able to balance and fine-tune certain game mechanics where necessary. For example, if a strategy arises that is shown to over-shadow all other viable strategies, then adjustments can me made to lower to power-level of such a strategy. At the higher level, we're maintaining modularity in our project to keep each feature completely isolated. Additionally, once the core game is designed, we will be able to append as many additional features as we have time for. This will allow us to expand our architecture outward without totally compromising it's integrity.
