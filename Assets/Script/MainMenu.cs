using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public void MulaiGame()
    {
        SceneManager.LoadScene("FPSGame"); // Pastikan ini nama scene asli kamu
    }

    // --- TAMBAHKAN INI UNTUK TOMBOL EXIT ---
    public void KeluarGame()
    {
        Debug.Log("Game Ditutup! (Fungsi ini bakal kelihatan pas game udah di-build jadi .exe)");
        Application.Quit(); // Perintah untuk menutup game
    }
}