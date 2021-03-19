using Operation_Broken_Wing.Manager;

namespace Operation_Broken_Wing.UI
{
    public class PauseMenu : Menu<PauseMenu>
    {
        public override void OnBackButton()
        {
            AudioManager.Instance.PressButton();
            LevelManager.Instance.QuitGame(); //Quit-Button instead Back-Button
        }

        public void OnRestartButton()
        {
            AudioManager.Instance.PressButton();
            LevelManager.Instance.ReloadLevel();
        }

        public void OnMainMenuButton()
        {
            AudioManager.Instance.PressButton();
            LevelManager.Instance.ReturnToMainMenu();
        }

        public void OnResumeButton()
        {
            AudioManager.Instance.PressButton();
            LevelManager.Instance.ResumeGame();
        }
    }
}
