using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UIElements;

public class SceneLoader : MonoBehaviour
{
    private Button nextButton;

    void Start()
    {

        UIDocument uiDocument = GetComponent<UIDocument>();

        VisualElement root = uiDocument.rootVisualElement;

        nextButton = root.Q<Button>("Play");

        nextButton.clicked += TargetScene;
    }

    void TargetScene()
    {
        SceneManager.LoadScene("Example");
    }
}
