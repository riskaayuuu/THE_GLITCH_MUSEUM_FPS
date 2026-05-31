using UnityEngine;

public class FloatingObject : MonoBehaviour
{
    public float rotasiSpeed = 50f; // Kecepatan putar
    public float tinggiAmplitudo = 0.5f; // Seberapa jauh naik turunnya
    public float frekuensi = 1f; // Seberapa cepat naik turunnya

    Vector3 posisiAwal;

    void Start()
    {
        posisiAwal = transform.position;
    }

    void Update()
    {
        // 1. Logika Berputar
        transform.Rotate(Vector3.up * rotasiSpeed * Time.deltaTime);

        // 2. Logika Naik Turun (Floating)
        float yBaru = posisiAwal.y + Mathf.Sin(Time.time * frekuensi) * tinggiAmplitudo;
        transform.position = new Vector3(transform.position.x, yBaru, transform.position.z);
    }
}