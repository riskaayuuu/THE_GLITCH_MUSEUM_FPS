using UnityEngine;
using UnityEngine.SceneManagement; // Penting biar bisa restart game

public class RanjauSciFi : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        // Cek apakah yang nyenggol ranjau itu si Player
        if (other.CompareTag("Player"))
        {
            Debug.Log("Player kena ranjau! Mengulang level...");
            
            // Cara paling instan: Restart Level 1 dari awal
            SceneManager.LoadScene(SceneManager.GetActiveScene().name);
        }
    }
}