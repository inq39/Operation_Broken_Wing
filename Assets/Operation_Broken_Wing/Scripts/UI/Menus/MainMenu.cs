using Operation_Broken_Wing.Manager;
using UnityEngine;

namespace Operation_Broken_Wing.UI
{
    public class MainMenu : Menu<MainMenu>
    {
        public override void OnBackButton()
        {
            LevelManager.Instance.QuitGame(); //Quit-Button instead Back-Button
        }

        public void OnPlayButton()
        {
            LevelManager.Instance.LoadNextLevel();
        }

        public void OnOptionsButton()
        {
            MenuManager.Instance.OpenMenu(SettingsMenu.Instance);
        }
    }
}
