using UnityEngine;

public class MenuAnimation : MonoBehaviour
{
    private Animation mainAnimation;

    void Start()
    {
        float screenAspectRatio = 1f * Screen.height / Screen.width;
        if (screenAspectRatio>1)
        {
            FindObjectOfType<Camera>().orthographicSize = 350 * screenAspectRatio;
        }

        mainAnimation = GetComponent<Animation>();
        mainAnimation.Play("StartAnimation");
    }
    
    public void StartAnimation(string animationName)
    {
        mainAnimation.Play(animationName);
    }
}
