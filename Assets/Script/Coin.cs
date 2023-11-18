using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Coin : MonoBehaviour
{
    private int points = 0;
    public TMP_Text pointsText; 

    private void OnTriggerEnter2D(Collider2D collision)
    {

        if (collision.gameObject.CompareTag("Coin"))
        {
            points += 10;
            Destroy(collision.gameObject);
            UpdatePointsDisplay();
        }
    }

    private void UpdatePointsDisplay()
    {
        if (pointsText != null)
        {
            pointsText.text = "Punkty: " + points;
        }
    }
}
