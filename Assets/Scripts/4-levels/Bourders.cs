using UnityEngine;

public class Bourders : MonoBehaviour
{
    public Transform topBoundary; //parmeters ofr bounderies
    public Transform bottomBoundary;
    private float minY;
    private float maxY;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        maxY = topBoundary.position.y; //update values
        minY = bottomBoundary.position.y;

    }

    // Update is called once per frame
    void Update()
    {
        Vector3 mov = transform.position; //get the actual position
        mov.y = Mathf.Clamp(mov.y, minY, maxY); //lock the val
        transform.position = mov;//updating

    }
}
