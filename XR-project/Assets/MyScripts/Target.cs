using UnityEngine;

public class Target : MonoBehaviour
{
    public int points = 10; // Pisteet tästä pallosta

    public void Hit()
    {
        Debug.Log("Hit! +" + points + " points");

        if (ScoreManager.instance != null)
        {
            ScoreManager.instance.AddPoints(points);
        }

        Destroy(gameObject); // Poista pallo osuman jälkeen
    }
}
