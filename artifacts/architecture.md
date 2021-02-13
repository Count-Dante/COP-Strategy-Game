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

You should have your UML Class diagram and any other useful UML diagrams in this section. Each diagram should be accompanied by a brief description explaining what the elements are and why they are in the diagram. For your class diagram, you must also include a table that relates each class to one or more user stories. 

See Code Complete, Chapter 3 and https://c4model.com/

# Data Design

The game utilizes the persistentDataPath which allows the player to save the current state of their game to a static directory path. The user will be able to load their saved game from that path and continue right where they left off. Local variables and other objects pertinent to the game will manifest in memory and be destroyed when the game is closed.

# Business Rules

Since we are using pre-existing assets gathered from the internet, and implementing our own game music and sound effects, we must abide by the copyright standards set in place for these elements. Additionally, we shall not attempt to pass off any assets used for this product as our own.

# User Interface Design

![UI-Diagram](https://user-images.githubusercontent.com/73034231/107835586-0736f280-6d68-11eb-955c-57a59b73e863.jpg)

Main Menu: This will be the First Screen the users see when starting the program. The screen displays 2 options, “Start” and “Exit”. The Start button will lead to the next UI.

Start Game: When the user press start game this will be the next screen they see. This screen will also display 2 options, “New Game” and “Load Game”. Both options will lead the user to the Map screen, however, based on the choice the map will differ.

Map: This screen will be the main screen the user interacts with. This screen will have 5 main displays other than the map: “<Name of Settlement>”, “Expand”, “Defend”, “Resources”, and “Pause”. “Pause” is the only other interactable display in which will direct the user to the Pause/Sub Menu. 
 
Pause/Sub Menu: This menu allows the user to pause their game if they need to or if the user wants to save and leave the game. This screen displays 3 options: “Resume Game”, “Save & Exit”, and “Settings”. “Resume Game” will allow the user to go back to Map and resume their game. “Save & Exit” will bring the user back to the Main Menu.

Win: This screen will appear if the user wins the game.

Lost: This screen will appear if the user loses the game.

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

# Security

We are creating a single-player game and will be running locally on the users’ computer, and will not be saving critical or personal data that needs to be protected. So we concluded that security is not a consideration in our system architecture. 

# Performance
The graphics in our game will be 2 Dimensional 8-Bit Style, which will not be graphically intensive. The only intensive part of our software will that the software is computationally intensive. However, the game is designed to be simple so it shouldn’t use a lot of memory and CPU space. So we believe that our game will perform well on any reasonable laptop or desktop.

# Scalability

We want to maintain modularity in our game so that it can be scaled out in future versions. There are a lot of ideas and features we would like to implement, but might not have time for. In this way, we want to establish a core set of features first, and then eventually expand that feature-set over time. Ways in which we plan to scale our game outward in the future include adding more biomes/locations to explore, including new random encounters/events, and introducing more resource types over time to support a variety of play styles.

# Interoperability
Since our game is created using Unity, it is self-contained and does not require any additional files or rely on any software outside of what comes packaged with it. *Manifesting Destiny* does not interact or share data with other software or hardware, and because of this interoperability is not a consideration for this project.

# Internationalization/Localization

This game is being created for a target audience of English-speaking users; this section is not applicable to our game.

# Input/Output

Our game will take input from the mouse in order to move the on-screen cursor and select objects in-game. This can be used to navigate menus or select objects in the game world. In addition, input will be taken from the keyboard for actions such as map navigation (WASD), entering a requested value from the user (0-9), and opening the game menu (ESC). All outputs will come through the screen as the player receives visual feedback from their actions. Any I/O errors will be handled through Unity itself.

# Error Processing

The Unity engine handles error processing for our game and writes any error(s) encountered during runtime to both the console window in Unity and a log file for the Unity editor.

# Fault Tolerance

Bugs are commonplace in gaming and it is expected that at least a few of these will be overlooked during development. For this project we plan to concentrate more on our game’s feature set than some minor bugs. Our focus for detecting faults will be at the priority level of “game breaking” rather than minor. In this way, we can aim to achieve a more dynamic, feature-driven product rather than a linear, yet refined product.

# Architectural Feasibility

Since this game is being made as a simple alternative to other strategy games that incorporate a ton of micromanagement, the core features of this game are relatively simple and thus straightforward for us as the developers to implement. All of the developers working on this project are familiar with C# and have a basic yet solid grasp of Unity development, so we are confident that *Manifest Destiny* will meet its performance targets.


# Overengineering

This game will be robust because we the developers err on the side of simplicity rather than complexity in our code and design. We will start by building a simple main menu that allows the user to start the game and open a simple map. Then, we will create a basic overlay that displays only information that the user needs to play the game and tools to build up their settlement. These elements serve as the basic foundation for our game and after their creation, additional features will be added with simplicity and clean code in mind over the 3 month development period allotted to create our game. If any additional features created add to much complexity or come off as overengineered, they can be very easily rolled back or redesigned within the development period.

# Build-vs-Buy Decisions

We are building our game in the Unity Engine. All software in our final project will be built by us. And, any 8-Bit drawing or music will be either done by hand or will be obtained from open-source materials. Also, we will be using free assets from the Unity asset store, which freely allows us to utilize them. Assets such as TextMesh Pro will be used to write dialogue systems in the game. So all the material and software we are using is free.

# Reuse

This game may use pre-existing visuals or sprites obtained from a third party. Obtaining these resources will be handled with respect and not passed off as our own. We plan to give full credit to the parties that contributed to our software, and follow the legal guidelines necessary for this process.

# Change Strategy

Our game has the flexibility to change at both the higher and lower architecture level. At the low level, we are able to balance and fine-tune certain game mechanics where necessary. For example, if a strategy arises that is shown to over-shadow all other viable strategies, then adjustments can me made to lower to power-level of such a strategy. At the higher level, we're maintaining modularity in our project to keep each feature completely isolated. Additionally, once the core game is designed, we will be able to append as many additional features as we have time for. This will allow us to expand our architecture outward without totally compromising it's integrity.
