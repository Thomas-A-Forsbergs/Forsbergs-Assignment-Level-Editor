using UnityEngine;

public class SceneController : MonoBehaviour {
    public const int gridRows = 5;
    public const int gridCols = 5;
    public const float offsetX = 2f;
    public const float offsetY = 2f;

    [SerializeField] MainTile originalTile;
    [SerializeField] Sprite[] images;

    void Start() {
        Vector3 startPosition = originalTile.transform.position;

        int[] numbers = {0, 0, 0, 0, 0, 1, 1, 1, 1, 1, 2, 2, 2, 2, 2, 3, 3, 3, 3, 3, 4, 4, 4, 4, 4};

        for (int i = 0; i < gridCols; i++) {
            for (int j = 0; j < gridRows; j++) {
                MainTile tile;
                if (i == 0 && j == 0) {
                    tile = originalTile;
                } else {
                    tile = Instantiate(originalTile) as MainTile;
                }

                int index = j * gridCols + i;
                int id = numbers[index];
                tile.ChangeSprite(id, images[id]);

                float posX = (offsetX * i) + startPosition.x;
                float posY = (offsetY * j) + startPosition.y;
                tile.transform.position = new Vector3(posX, posY, startPosition.z);
            }
        }
    }
}