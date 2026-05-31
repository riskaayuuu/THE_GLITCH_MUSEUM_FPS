using UnityEngine;
using UnityEngine.SceneManagement;

public class DoorSystem : MonoBehaviour
{
    public static bool hasKey = false;

    public enum ObjectType
    {
        Key,
        Door
    }

    public ObjectType objectType;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Player"))
        {
            // KEY
            if (objectType == ObjectType.Key)
            {
                hasKey = true;

                Debug.Log("KEY TAKEN");

                gameObject.SetActive(false);
            }

            // DOOR
            if (objectType == ObjectType.Door)
            {
                if (hasKey)
                {
                    Debug.Log("NEXT LEVEL");

                    SceneManager.LoadScene(
                        SceneManager.GetActiveScene().buildIndex + 1
                    );

                    hasKey = false;
                }
                else
                {
                    Debug.Log("NEED KEY FIRST");
                }
            }
        }
    }
}