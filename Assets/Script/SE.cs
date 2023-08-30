using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class SE : MonoBehaviour
{
    public AudioSource soundEffect; // ���ʉ����Đ����邽�߂̃I�[�f�B�I�\�[�X

    private void Start()
    {
        // �{�^���ɃN���b�N���̏�����ǉ�
        Button backButton = GetComponent<Button>();
        backButton.onClick.AddListener(PlaySoundAndGoBack);
    }

    // ���ʉ����Đ����ăV�[�����ړ�����֐�
    private void PlaySoundAndGoBack()
    {
        // ���ʉ��Đ�
        soundEffect.Play();

        // �����҂��Ă���V�[�����ړ�
        float soundDuration = soundEffect.clip.length;
        Invoke("GoBackToPreviousScene", soundDuration);
    }

    // �O�̃V�[���Ɉړ�����֐�
    private void GoBackToPreviousScene()
    {
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;
        int previousSceneIndex = currentSceneIndex - 1;
        if (previousSceneIndex < 0)
        {
            previousSceneIndex = 0;
        }
        SceneManager.LoadScene(previousSceneIndex);
    }
}
