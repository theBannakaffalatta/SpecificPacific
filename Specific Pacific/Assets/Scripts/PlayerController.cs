using UnityEngine;

public class PlayerController : MonoBehaviour
{

    public float HorizontalSpeed;
    public float VerticalSpeed;

    void Update()
    {
        var x = Input.GetAxis("Horizontal") * Time.deltaTime * HorizontalSpeed;
        var z = Input.GetAxis("Vertical") * Time.deltaTime * VerticalSpeed;

        transform.Translate(x, 0, z);
    }
}