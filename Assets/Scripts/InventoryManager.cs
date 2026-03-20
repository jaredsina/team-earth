using UnityEngine;
using UnityEngine.UIElements;

public class InventoryManager : MonoBehaviour
{
    // varibles that track the intgers for the inventory
    public int plasticsCount = 0;
    public int paperCount = 0;

    private Label plasticsLabel;
    private Label paperLabel;
    // Start is called once before the first execution of Update after the MonoBehaviour is created
    void OnEnable()
    {
        var root = GetComponent<UIDocument>().rootVisualElement;  

        plasticsLabel = root.Q<Label>("Numberofplastics");
        paperLabel = root.Q<Label>("Numberofpaper"); 

        UpdateUI();
            
                   
    }

    public void UpdateUI()
    {
        if (plasticsLabel != null) plasticsLabel.text = plasticsCount.ToString();
        if (paperLabel != null) paperLabel.text = paperCount.ToString();
    }
    
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.P))
        {
            plasticsCount++;
            UpdateUI();
        }
        if (Input.GetKeyDown(KeyCode.O))
        {
            paperCount++;
            UpdateUI();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
            // Only remove if we have more than 0
            if (plasticsCount > 0) 
            {
                plasticsCount--;
                UpdateUI();
            }
        }
        if (Input.GetKeyDown(KeyCode.L))
        {
            if (paperCount > 0) 
            {
                paperCount--;
                UpdateUI();
            }
        }
    }
}
