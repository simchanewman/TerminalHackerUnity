# TerminalHacker

## Overview
This was my first ever completed game on unity. While it is nothing major, I wanted to get a project out that was complete and had a minimal gameplay loop.

I did use tutorials from a course on Udemy to help me start and looked over a few lessons from there. While using the lessons to assist me there were tasks in the project that required some prior thought. One main example of this would be the use of gamestates that I was required to figure out. This would enable the same reuse of code depending on the gamestate. Example of this as follows:

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;


