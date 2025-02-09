using UnityEngine;

/// <summary>
/// A fish
/// </summary>
public class Fish : MonoBehaviour
{
    #region Fields

    [SerializeField] GameObject prefabExplosion;

    int damage = 100;

    #endregion

    #region Properties

    /// <summary>
    /// Gets the damage fish inflicts
    /// </summary>
    public int Damage
    {
        get { return damage; }
    }


    #endregion

    #region Methods

    /// <summary>
    /// Fires the fish
    /// </summary>
    private void OnMouseUpAsButton()
    {
        Rigidbody2D rb2d = GetComponent<Rigidbody2D>();
        rb2d.AddForce(new Vector2(0, 20), ForceMode2D.Impulse);
    }

    /// <summary>
    /// Destroy fish on the collision
    /// </summary>
    /// <param name="collision"></param>
    private void OnCollisionEnter2D(Collision2D collision)
    {
        Instantiate<GameObject>(prefabExplosion, transform.position, Quaternion.identity);
        Destroy(gameObject);
    }

    #endregion
}
