using UnityEngine;

public class pickUpStuff : MonoBehaviour
{
    public Transform player;
    public Transform thing;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        public InputAction interact;
    }

    // Update is called once per frame
    void Update()
    {
        float distance = Vector3.Distance(player.position, thing.position);
        Debug.Log(distance);
        if (distance < 20)
        {
            Debug.Log("hello");
        }
    }
}
