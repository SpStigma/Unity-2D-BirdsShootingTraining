using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxEffect : MonoBehaviour
{
    [SerializeField]
    public float moveSpeed;
    [SerializeField]
    public bool scrollLeft;

    private float singleTexturedWidth;
    // Start is called before the first frame update
    void Start()
    {
        SetupTexture();
        if(scrollLeft)
        {
            moveSpeed = -moveSpeed;
        }
    }

    void SetupTexture()
    {
        Sprite sprite = GetComponent<SpriteRenderer>().sprite;
        singleTexturedWidth = sprite.texture.width / sprite.pixelsPerUnit;
    }

    void Scroll()
    {
        float delta = moveSpeed * Time.deltaTime;
        transform.position += new Vector3(delta, 0f, 0f);
    }

    void CheckReset()
    {
        if( (Mathf.Abs(transform.position.x) - singleTexturedWidth) > 0 )
        {
            transform.position = new Vector3(0f, transform.position.y, transform.position.z);
        }
    }

    // Update is called once per frame
    void Update()
    {
        Scroll();
        CheckReset();
    }
}
