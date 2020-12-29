using UnityEngine;

public class MainTile : MonoBehaviour {
    [SerializeField] GameObject TileDefault;

    public void OnMouseDown() {
        if (TileDefault.activeSelf) {
            TileDefault.SetActive(false);
        }
    }

    int _id;

    public int id {
        get { return _id; }
    }

    public void ChangeSprite(int id, Sprite image) {
        _id = id;
        GetComponent<SpriteRenderer>().sprite = image;
    }
}