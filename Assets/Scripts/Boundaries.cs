using UnityEngine;

public class Boundaries : MonoBehaviour
{
    private Vector2 screenBounds;
    private float objectWidth;
    private float objectHeight;
    private Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();

        // Convert screen pixel size to world space size
        screenBounds = Camera.main.ScreenToWorldPoint(new Vector3(Screen.width, Screen.height, 0));

        // Use Collider2D to get object size
        Collider2D col = GetComponent<Collider2D>();

        if (col != null)
        {
            objectWidth = col.bounds.extents.x;  // Half width
            objectHeight = col.bounds.extents.y; // Half height
        }
        else
        {
            Debug.LogError("No Collider2D found on the Player! Add one for proper boundary clamping.");
        }
    }

    void FixedUpdate()
    {
        if (rb == null) return;

        // Get the player's current position
        Vector2 newPos = rb.position;

        // Clamp the position inside the screen boundaries, accounting for object size
        newPos.x = Mathf.Clamp(newPos.x, -screenBounds.x + objectWidth, screenBounds.x - objectWidth);
        newPos.y = Mathf.Clamp(newPos.y, -screenBounds.y + objectHeight, screenBounds.y - objectHeight);

        // Apply new position with Rigidbody to prevent external forces from pushing it out
        rb.MovePosition(newPos);
    }
}
