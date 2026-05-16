using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.Rendering;
public enum trashType 
    { 
        Paper,
        Plastic,
        Compost,
        Trash
    }
public class pickUpStuff : MonoBehaviour
{
    public string itemName;
    public string description;
    [SerializeField]
    public Transform player;
    [SerializeField]
    public Transform thingy;


    public trashType typeOfTrash;
    // Start is called once before the first execution of Update after the MonoBehaviour is created

    public bool isInteracting;
    public InputAction interact;
    public float minX = 100f;
    public float maxX = 160f;
    public float minY = 0f;
    public float maxY = 0f;
    public float minZ = 460f;
    public float maxZ = 600f;

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
        thingy.gameObject.GetComponent<Renderer>().enabled = true;
        float randomX = Random.Range(minX, maxX);
        float randomY = Random.Range(minY, maxY);
        float randomZ = Random.Range(minZ, maxZ);
        Vector3 randomPosition = new Vector3 (randomX, randomY, randomZ);
        // thingy.position = randomPosition;
    }

    // Update is called once per frame
    void Update()
    {
        
        float distance = Vector3.Distance(player.position, thingy.position);
        //Debug.Log(distance);
        isInteracting = interact.triggered;
        if (distance < 20 && isInteracting)
        {
               
               thingy.gameObject.GetComponent<AudioSource>().Play();
               Destroy(thingy.gameObject);
               if(thingy.gameObject.tag == "Paper"){
                    Debug.Log("Paper picked up");
               }
           
            
        }


//        if (isInteracting)
//        {
// Adding comment to try and fix
//            Debug.Log(distance);
//            if (distance < 20)
//            {
//                Debug.Log("flurbshd");
//                thingy.gameObject.GetComponent<AudioSource>().Play();
//                thingy.gameObject.GetComponent<Renderer>().enabled = false;

//            }

//        }
    
   }
}
