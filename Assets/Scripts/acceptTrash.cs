using UnityEngine;

public class acceptTrash : MonoBehaviour
{
    public Transform trash;
    public Transform player;
    public bool isInteracting;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float space = Vector3.Distance(player.position, trash.position);
        if (space < 0 && isInteracting)
        {
            Debug.Log("SHRIYAAAAAAAAAA");
        }
    }
}
