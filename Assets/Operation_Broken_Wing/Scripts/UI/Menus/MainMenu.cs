using Operation_Broken_Wing.Manager;
using UnityEngine;

namespace Operation_Broken_Wing.UI
{
    public class MainMenu : Menu<MainMenu>
    {
        public override void OnBackButton()
        {
            base.OnButtonPressRoutine();
            LevelManager.Instance.QuitGame(); //Quit-Button instead Back-Button
        }

        public void OnPlayButton()
        {
            base.OnButtonPressRoutine();
            LevelManager.Instance.LoadNextLevel();
        }

        public void OnOptionsButton()
        {
            AudioManager.Instance.PressButton();
            MenuManager.Instance.OpenMenu(SettingsMenu.Instance);
        }
    }
}
