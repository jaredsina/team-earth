using UnityEngine;
using UnityEngine.UIElements;

public class UIManager : MonoBehaviour
{
    private UIDocument uiDoc;
    private Label Text;
    private Button nextButton;
    private VisualElement root;

    void OnEnable()
    {
        uiDoc = GetComponent<UIDocument>();
        Text = uiDoc.rootVisualElement.Q<Label>("Text");
        root = GetComponent<UIDocument>().rootVisualElement.Q<VisualElement>("QuestContainer");
        AddQuest();
        ColorChange();
    }

    void Update()
    {
        Text.text = ("  - Collect 9 waterbottles");
    }
    public void AddQuest() {

        Label newQuest = new Label(" - New Quest");
        //newQuest.style.color = Color.white;
        //newQuest.style.fontSize = 29;
        //newQuest.style.display = DisplayStyle.Flex;
        newQuest.AddToClassList("incomplete");
        root.Add(newQuest);
      
    }

    public void ColorChange()
    {
    
   
    Text.RemoveFromClassList("incomplete");
    Text.AddToClassList("completed");
    


    }

}

