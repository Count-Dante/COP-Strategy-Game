# Manual Tests

| Test ID | User Story ID | Steps to Reproduce | Expected Result | Actual Result | Pass or Fail |
|----------------|---------------|-------------|---------------------|--------|--------|
|            000 |           029 | Start a game of Manifesting destiny. | Once the game is started, a timer should appear at the bottom of the screen. | At the bottom of the screen, a red bar (timer) slowly decreases. | Pass |
|            000 |           029 | Start a game of Manifesting destiny. | Once the game is started, the timer should decrease at a constant rate. | The red bar (timer) steadily decreases | Pass |
|            000 |           029 | Start a game of Manifesting destiny. | Once 25 seconds passes, text should appear on the screen indicating that time has run out. | After 25 seconds, text appears on the screen to communicate to the player that their time has run out | Pass |
|            000 |           029 | During a game of Mainfesting destiny (before the timer has run out), pause the game. | The timer should stop decreasing. | Once the game is paused, the timer pauses. | Pass |
|            000 |           029 | While the game is paused and the timer has not run out, resume the game. | The timer should resume from where it last left off. | When the game is resumed, the timer resumes. | Pass |
|            000 |           029 | Start a game of Manifesting Destiny and let the timer run out. Then try to pause the game. | The "Time's Out" text should disappear when accessing the pause menu. | Once the game is paused, the "Time's Out" text is no longer visible | Pass |
|            000 |           029 | Save the game while the timer is running, then reload the game. | When the game is reloaded, the timer should resume from where it was last left off. | When loading back into the game, the timer resets. This is a potential exploit for the player. | Fail |
