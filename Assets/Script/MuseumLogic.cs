using UnityEngine;
using UnityEngine.SceneManagement;

public class MuseumLogic : MonoBehaviour
{
    public enum ObjectType { Kunci, Pintu, Hazard, Finish }
    public ObjectType tipeObjek;
    
    // Static agar status kunci tersimpan saat pindah scene
    private static bool sudahAmbilKunci = false;
    private bool isProcessing = false;

    private void OnTriggerEnter(Collider other)
    {
        // DEBUG: Baris ini akan kasih tahu siapa yang nabrak di Console
        Debug.Log("Ada tabrakan! Objek: " + other.name + " | Tag: " + other.tag);

        if (other.CompareTag("Player") && !isProcessing)
        {
            if (tipeObjek == ObjectType.Kunci)
            {
                sudahAmbilKunci = true;
                gameObject.SetActive(false); 
                Debug.Log("PATUNG DIAMBIL! Sekarang kamu bisa ke Pintu/Finish.");
            }
            else if (tipeObjek == ObjectType.Pintu)
            {
                if (sudahAmbilKunci)
                {
                    isProcessing = true;
                    Debug.Log("Pindah ke Level berikutnya...");
                    sudahAmbilKunci = false; // Reset kunci untuk level baru
                    SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex + 1);
                }
                else 
                {
                    Debug.Log("Pintu Terkunci! Kamu harus ambil patung dulu.");
                }
            }
            else if (tipeObjek == ObjectType.Hazard)
            {
                isProcessing = true;
                Debug.Log("JATUH! Mengulang level...");
                // Note: sudahAmbilKunci TIDAK direset ke false agar tidak perlu ambil kunci lagi kalau mati
                SceneManager.LoadScene(SceneManager.GetActiveScene().name);
            }
            else if (tipeObjek == ObjectType.Finish)
            {
                Debug.Log("Menyentuh Area FINISH...");
                if (sudahAmbilKunci)
                {
                    isProcessing = true;
                    Debug.Log("SELAMAT! KAMU MENANG!");
                    sudahAmbilKunci = false; // Reset total
                    SceneManager.LoadScene(0); // Balik ke Level 1
                }
                else 
                {
                    Debug.Log("FINISH DITOLAK! Kamu belum bawa patung Level 2.");
                }
            }
        }
    }
}