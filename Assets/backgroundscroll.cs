using UnityEngine;

public class BackgroundScroll : MonoBehaviour
{
    public float speed = 0.1f;
    private Material mat;
    private Vector2 offset;

    void Start()
    {
        // Quad의 MeshRenderer에서 머티리얼을 가져옵니다.
        mat = GetComponent<MeshRenderer>().material;
    }

    void Update()
    {
        // 1. 시간에 따라 소수점 단위로 좌표값을 계산합니다.
        offset.x += speed * Time.deltaTime;

        // 2. URP 쉐이더의 기본 텍스처 오프셋 속성 이름인 "_BaseMap"을 사용합니다.
        // 만약 이 이름이 안 먹힌다면 "_MainTex"로 바꿔보세요.
        mat.SetTextureOffset("_BaseMap", new Vector2(offset.x, 0));
    }
}