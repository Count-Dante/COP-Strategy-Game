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

If you are using a database, you should have a basic Entity Relationship Diagram (ERD) in this section. This diagram should describe the tables in your database and their relationship to one another (especially primary/foreign keys), including the columns within each table. 

See Code Complete, Chapter 3

# Business Rules

Since we are using pre-existing assets gathered from the internet, and implementing our own game music and sound effects, we must abide by the copyright standards set in place for these elements. Additionally, we shall not attempt to pass off any assets used for this product as our own.

# User Interface Design

You should have one or more user interface screens in this section. Each screen should be accompanied by an explaination of the screens purpose and how the user will interact with it. You should relate each screen to one another as the user transitions through the states of your application. You should also have a table that relates each window or component to the support using stories. 

See Code Complete, Chapter 3

# Resource Management

Since our game utilizes 8-bit graphics and is relatively simple in terms of mechanics and active objects within the game, approximately 4 gigabytes of ram and any CPU and GPU from 2015+ would be suffiicent to run *Manifesting Destiny*. Object pooling will be used to reduce CPU usage and pre-instatiate any objects (in regard to our game this could be units, resources, or areas to be discovered) needed by a scene instead of dynamically creating them as the game runs.

# Security

See Code Complete, Chapter 3

# Performance

See Code Complete, Chapter 3

# Scalability

We want to maintain modularity in our game so that it can be scaled out in future versions. There are a lot of ideas and features we would like to implement, but might not have time for. In this way, we want to establish a core set of features first, and then eventually expand that feature-set over time. Ways in which we plan to scale our game outward in the future include adding more biomes/locations to explore, including new random encounters/events, and introducing more resource types over time to support a variety of play styles.

# Interoperability
Since our game is created using Unity, it is self-contained and does not require any additional files or rely on any software outside of what comes packaged with it. *Manifesting Destiny* does not interact or share data with other software or hardware, and because of this interoperability is not a consideration for this project.

# Internationalization/Localization

See Code Complete, Chapter 3

# Input/Output

Our game will take input from the mouse in order to move the on-screen cursor and select objects in-game. This can be used to navigate menus or select objects in the game world. In addition, input will be taken from the keyboard for actions such as map navigation (WASD), entering a requested value from the user (0-9), and opening the game menu (ESC). All outputs will come through the screen as the player receives visual feedback from their actions. Any I/O errors will be handled through Unity itself.

# Error Processing

See Code Complete, Chapter 3

# Fault Tolerance

Bugs are commonplace in gaming and it is expected that at least a few of these will be overlooked during development. For this project we plan to concentrate more on our game’s feature set than some minor bugs. Our focus for detecting faults will be at the priority level of “game breaking” rather than minor. In this way, we can aim to achieve a more dynamic, feature-driven product rather than a linear, yet refined product.

# Architectural Feasibility

See Code Complete, Chapter 3

# Overengineering

See Code Complete, Chapter 3

# Build-vs-Buy Decisions

This section should list the third party libraries your system is using and describe what those libraries are being used for.

See Code Complete, Chapter 3

# Reuse

This game may use pre-existing visuals or sprites obtained from a third party. Obtaining these resources will be handled with respect and not passed off as our own. We plan to give full credit to the parties that contributed to our software, and follow the legal guidelines necessary for this process.

# Change Strategy

Our game has the flexibility to change strategies at both the higher and lower architecture level. At the low level, we are able to balance and fine-tune certain game mechanics where necessary. For example, if a strategy arises that is shown to over-shadow all other viable strategies, then adjustments can me made to lower to power-level of such a strategy. At the higher level, we're maintaining modularity in our project to keep each feature isolated. Additionally, once the core game is designed, we will be able to append as many additional features as we have time for. This will allow us to expand our architecture without totally compromising it's integrity.
