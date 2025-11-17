using UnityEngine;

public class tunnle : MonoBehaviour
{
    public Transform leftWrapPoint;
    public Transform rightWrapPoint;
    public float offset = 1.5f;
    private void OnTriggerEnter2D(Collider2D other)
    { //function that call when trigger is activate
        if (other.CompareTag("R_tunnel") || other.name == "R_tunnel")
        { //check if R_tunnel triggerd
            Vector3 pos = transform.position; //get position
            pos.x = leftWrapPoint.position.x + offset; //change the position to the left
            transform.position = pos; //update
        }
        else if (other.CompareTag("L_tunnel") || other.name == "L_tunnel")
        {
            Vector3 pos = transform.position;
            pos.x = rightWrapPoint.position.x - offset;
            transform.position = pos;
        }
    }
}
