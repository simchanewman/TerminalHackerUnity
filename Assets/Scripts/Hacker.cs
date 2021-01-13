using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    string[] passwordLvl1 = { "kitchen", "family", "garden", "wifi", "car" };
    string[] passwordLvl2 = { "arrest", "convict", "criminal", "weapon", "killer" };
    string[] passwordLvl3 = { "suspicious", "undercover", "investigator", "dezinformatsiya", "enigma" };

    enum Screen { MainMenu, Password, Win };
    int level;
    Screen currentScreen = Screen.MainMenu;
    string password;

    void Start()
    {
        ShowMainMenu("Hi There!!!");
    }

    void ShowMainMenu(string greeting)
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Where would you like to hack into?");
        Terminal.WriteLine("1) My neighbour's secure computer");
        Terminal.WriteLine("2) My local police station");
        Terminal.WriteLine("3) MI6 for secure files");
        Terminal.WriteLine("Please enter your number selection: ");
    }

    void OnUserInput(string input)
    {
        if (input.ToLower() == "menu")
        {
            Start();
            currentScreen = Screen.MainMenu;
        }
        else if (currentScreen == Screen.MainMenu)
        {
            RunMainMenu(input);
        }
        else if (currentScreen == Screen.Password)
        {
            CheckPassword(input);
        }
    }

    void RunMainMenu(string input)
    {
        bool isValidLevelNumber = (input == "1" || input == "2" || input == "3");
        if (isValidLevelNumber)
        {
            level = int.Parse(input);
            AskForPassword();
        }
        else
        {
            Terminal.WriteLine("Please select a valid level number");
            MenuReturn();
        }
    }
   
    void AskForPassword()
    {
        currentScreen = Screen.Password;
        Terminal.ClearScreen();
        RandomisePassword();
        Terminal.WriteLine("Enter the password, hint: " + password.Anagram());
        MenuReturn();
    }

    void RandomisePassword()
    {
        switch (level)
        {
            case 1:
                password = passwordLvl1[Random.Range(0, passwordLvl1.Length)];
                break;
            case 2:
                password = passwordLvl2[Random.Range(0, passwordLvl2.Length)];
                break;
            case 3:
                password = passwordLvl3[Random.Range(0, passwordLvl3.Length)];
                break;
            default:
                Debug.LogError("Invalid Level Number");
                break;
        }
    }

    void CheckPassword(string input)
    {
        if (input.ToLower() == password.ToLower())
        {
            DisplayWinScreen();
        }
        else
        {
            AskForPassword();
        }
    }

    void DisplayWinScreen()
    {
        currentScreen = Screen.Win;
        Terminal.ClearScreen();
        ShowLevelReward();
    }

    void ShowLevelReward()
    {
        switch (level)
        {
            case 1:
                Terminal.WriteLine("You have hacked your neighbour!");
                Terminal.WriteLine(@"
        ___
  ______| |__
 /           \
/_____________\
|      _____  |
|      |   |  |
|      |   |  |
|______|___|__|
");
                MenuReturn();
                break;
            case 2:
                Terminal.WriteLine("You have hacked the police station");
                Terminal.WriteLine(@"
 _____   _____   _____
|     | |     | |     |
|_____| |_____| |_____|
      |       |       |
 _____|  _____|  _____|
");
                MenuReturn();
                break;
            case 3:
                Terminal.WriteLine("You have hacked the government. Watch your back");
                Terminal.WriteLine(@"
   \_____________    __
   /     ________|  |__)
  /  ___/  \
 /  /  
/__/
");
                MenuReturn();
                break;
            default:
                Debug.LogError("Error handling the win screen");
                break;        }
    }

    void MenuReturn()
    {
        Terminal.WriteLine("You many type 'menu' to restart at any point");
    }

}
