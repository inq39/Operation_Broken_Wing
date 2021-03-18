using System;
using Operation_Broken_Wing.Manager;
using UnityEngine;

namespace Operation_Broken_Wing.UI
{
    [RequireComponent(typeof(Canvas))]
    public class Menu : MonoBehaviour
    {
        public void OnBackButton()
        {
            MenuManager.Instance.CloseMenu();
        }

        public void OnPlayButton()
        {
            LevelManager.Instance.LoadNextLevel();
        }

        public void OnOptionsButton()
        {
            Menu settingsMenu = transform.parent.Find("Settings_Menu(Clone)").GetComponent<Menu>();
            if (settingsMenu != null)
            {
                MenuManager.Instance.OpenMenu(settingsMenu);
            }
        }

        public void OnQuitButton()
        {
            LevelManager.Instance.QuitGame();
        }
    }
}
