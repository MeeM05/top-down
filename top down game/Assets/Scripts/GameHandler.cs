using UnityEngine;

public class GameHandler : MonoBehaviour
{
    // Start is called before the first frame update
    private void Start()
    {
        HealthSystem healthSystem = new HealthSystem(100);

        Debug.Log("Health: " + healthSystem.GetHealth());
        healthSystem.Damage(10);
        Debug.Log("Health: " + healthSystem.GetHealth());
        healthSystem.Heal(10);
        Debug.Log("Health: " + healthSystem.GetHealth());

    }

}