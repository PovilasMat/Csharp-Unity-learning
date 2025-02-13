using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

/// <summary>
/// A HUD
/// </summary>
public class HUD : MonoBehaviour
{
    #region Fields

    // scoring support
    [SerializeField]
    TextMeshProUGUI scoreText;
    int score;
    const string ScorePrefix = "Score: ";

    #endregion

    /// <summary>
    /// Start is called before the first frame update
    /// </summary>	
    void Start()
    {
        scoreText.text = ScorePrefix + score.ToString();
    }

    /// <summary>
    /// Adds the given points to the score
    /// </summary>
    /// <param name="points">points</param>
    public void AddPoints(int points)
    {
        score += points;
        scoreText.text = ScorePrefix + score.ToString();
    }
}
