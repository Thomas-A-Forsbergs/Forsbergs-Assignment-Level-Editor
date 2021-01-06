using UnityEngine;
using Image = UnityEngine.UI.Image;

public class Button : MonoBehaviour {
    public Sprite spriteGreen;
    public Sprite spriteBlue;

    void OnMouseDown() {
        if (true) {
            GetComponent<Image>().sprite = spriteBlue;
            Debug.Log("MouseDown");
        }
    }

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
