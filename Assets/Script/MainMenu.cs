using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{


    public GameObject PanelSetting;
    public GameObject mainMenuPanel;

    public void MulaiGame()
    {
        SceneManager.LoadScene("FPSGame"); 
    }

    public void BukaSetting()
    {
        mainMenuPanel.SetActive(false);
        PanelSetting.SetActive(true);
    }

    public void TutupSetting()
    {
        PanelSetting.SetActive(false);
        mainMenuPanel.SetActive(true);
    }

    // --- TAMBAHKAN INI UNTUK TOMBOL EXIT ---
    public void KeluarGame()
    {
        Debug.Log("Game Ditutup! (Fungsi ini bakal kelihatan pas game udah di-build jadi .exe)");
        Application.Quit(); // Perintah untuk menutup game
    }
}