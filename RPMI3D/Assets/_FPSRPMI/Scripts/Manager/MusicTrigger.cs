using UnityEngine;

public class MusicTrigger : MonoBehaviour
{
    [SerializeField] int musicToPlay;

    private void Start()
    {
        AudioManager.Instance.PlayMusic(musicToPlay);
    }
}
