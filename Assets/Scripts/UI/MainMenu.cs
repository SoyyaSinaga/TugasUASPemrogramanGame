using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public GameObject PanelMenu;
    public GameObject PanelSetting;
    public GameObject PanelTentang;
    void Start()
    {
        PanelMenu.SetActive(true);
        PanelSetting.SetActive(false);
        PanelTentang.SetActive(false);
    }
    public void Quit()
    {
        Application.Quit();
    }

    public void  Back()
    {
       PanelMenu.SetActive(true);
       PanelSetting.SetActive(false);
       PanelTentang.SetActive(false);
    }

    public void   Play()
    {
        SceneManager.LoadScene("Game");
    }

    public void   Setting()
    {
      PanelSetting.SetActive(true);
      PanelMenu.SetActive(false);
      PanelTentang.SetActive(false);
    }

    public void Tentang()
    {
      PanelTentang.SetActive(true);
      PanelMenu.SetActive(false);
      PanelSetting.SetActive(false);
    }


}
