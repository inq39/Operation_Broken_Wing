using Operation_Broken_Wing.Manager;

namespace Operation_Broken_Wing.UI
{
    public class PauseMenu : Menu<PauseMenu>
    {
        public override void OnBackButton()
        {
            base.OnButtonPressRoutine();
            LevelManager.Instance.QuitGame(); //Quit-Button instead Back-Button
        }

        public void OnRestartButton()
        {
            base.OnButtonPressRoutine();
            LevelManager.Instance.ReloadLevel();
        }

        public void OnMainMenuButton()
        {
            base.OnButtonPressRoutine();
            LevelManager.Instance.ReturnToMainMenu();
        }

        public void OnResumeButton()
        {
            base.OnButtonPressRoutine();
            LevelManager.Instance.ResumeLevel();
        }
    }
}
