using UnityEngine;
using UnityEngine.InputSystem;
public class pickUpStuff : MonoBehaviour
{
    public Transform player;
    
    public Transform thing;
    
    
    
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool isInteracting;
    public InputAction interact;

    
    private void OnEnable()
    {
        interact.Enable();


    }

    private void OnDisable()
    {
        interact.Disable();
    }
    void Start()
    {
        thing.gameObject.GetComponent<Renderer>().enabled = true;
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(player.position, thing.position);
        //Debug.Log(distance);
        isInteracting = interact.triggered;
        if (distance < 20 && isInteracting)
        {
            //TODO: Create system that will remove object from game
               Debug.Log("Object interacted with");
               thing.gameObject.GetComponent<AudioSource>().Play();
               thing.gameObject.GetComponent<Renderer>().enabled = false;
               //Disables mesh of objects making it disappear (YIPPEEEE)
            
        }

        
    
    }
}
