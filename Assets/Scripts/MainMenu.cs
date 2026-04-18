// using UnityEngine;
// using UnityEngine.UIElements;


// public class MainMenu : MonoBehaviour
// {
//     public UIDocument grabber;
//     private AudioSource audio;
//     // Start is called once before the first execution of Update after the MonoBehaviour is created
//     void Start()
//     {
    
        
//     }

//     void OnEnable()
//     {
//     grabber = GetComponent<UIDocument>();
//     audio = GetComponent<AudioSource>();
//     var button = grabber.rootVisualElement.Q<Button>("Play");
//     button.RegisterCallback<PointerEnterEvent>(e=>{audio.Play();}); //play sound on hover
//     var button2 = grabber.rootVisualElement.Q<Button>("Exit");
//     button2.RegisterCallback<PointerEnterEvent>(e=>{audio.Play();});
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }
// }
