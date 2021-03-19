﻿using Operation_Broken_Wing.Manager;
using UnityEngine;

namespace Operation_Broken_Wing.UI
{
    public class MainMenu : Menu<MainMenu>
    {
        public override void OnBackButton()
        {
            AudioManager.Instance.PressButton();
            LevelManager.Instance.QuitGame(); //Quit-Button instead Back-Button
        }

        public void OnPlayButton()
        {
            AudioManager.Instance.PressButton();
            LevelManager.Instance.LoadNextLevel();
        }

        public void OnOptionsButton()
        {
            AudioManager.Instance.PressButton();
            MenuManager.Instance.OpenMenu(SettingsMenu.Instance);
        }
    }
}
