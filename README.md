# TerminalHacker

Before continuing, please make sure that you are on desktop to play this game. The game will not work on mobile, tablet, or other apple devices. Mac, Windows or Linux are the only supported platforms for this game trial.

## Play the Game!

Click the following link to play the game and support me. Click for *[Terminal Hacker](https://sharemygame.com/@UmHeyThere/terminal-hacker-1-0?fbclid=IwAR1kJsu6oVLwbqLBEZPC101vzNH_3Qytk2r4c7daWx5KoyNBP2W9QUDbGmk)*. If you feel like providing feedback on my idea's regarding the balancing of the level's then also feel free to leave feedback via this *[feedback](https://docs.google.com/forms/d/1u79wHWWwkceLrxiWsusQMkOJdfi7okWby8RUGGxfBrQ/edit?fbclid=IwAR2eZNSo-2g90EYcAmx1PX52ArfB5GtqyEm_y5KsfcTR5IdG3NXtiAAcLHc)* link.

*If you are having trouble actually playing the game once you have clicked the link, please make sure that you have slected the game-screen with your cursor. The game may not be playable if not selected. You can press `Esc` if you want to get bring cursor back and leave the game.*

***Please note: if you click the link and it does not take you to the game link then please get in contact with me provately and I will be able to make this avaliable for you again (I do not control the servers or the website that it is being hosted on)*** 

## Gameplay Instructions

The idea behind the game is to beat each level from 1 - 3. Each level is selected by hitting the number that represents that level. For each level you need to unscramble the letters provided to you in order to figure out the password of the virtual machine. If you complete the three levels then you have completed the game. 

If at any point you get stuck and would like to go back and try again then please type **'menu'** at any point to be takin back to the start of the game.

## Overview
This was my first ever completed game on unity. While it is nothing major, I wanted to get a project out that was complete and had a minimal gameplay loop.

I did use tutorials from a course on *[Udemy](https://www.udemy.com/)* to help me start and looked over a few lessons from there. While using the lessons to assist me there were tasks in the project that required some prior thought. One main example of this would be the use of gamestates that I was required to figure out. This would enable the same reuse of code depending on the gamestate. Example of this as follows:

> The below code is from the Hacker class within our game.

    enum Screen { MainMenu, Password, Win };
    Screen currentScreen = Screen.MainMenu;

> Above we can see that we have three gamestates using an `enum` and setting the state to either `MainMenu`, `Password`, `Win`. I then use this to set the `Screen` to `MainMenu` by default when the game starts up/the player hits play.

    void OnUserInput(string input)
    {
        if (input.ToLower() == "menu")
        {
            ...do something...
        }
        else if (currentScreen == Screen.MainMenu)
        {
            ...do something else...
        }
        else if (currentScreen == Screen.Password)
        {
            ...do something else...
        }
    }

> I am then able to use the gamestates to allow me to navigate between different screens on the virtual machine depending on the gamestate and without having to write or reuse code over and over.

This is a learning expereince for me and I made this game in 2 days. My aims for future projects is to continue putting out full versions of a game with game states that could in theory work and become fully developed games. Thank you for taking your time to look over my game!