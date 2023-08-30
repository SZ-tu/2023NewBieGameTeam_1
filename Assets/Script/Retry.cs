using UnityEngine;
using UnityEngine.SceneManagement;

public class Retry : MonoBehaviour
{
    // �O�̃V�[���ɖ߂邽�߂̊֐�
    public void GoBackToPreviousScene()
    {
        // ���݂̃V�[���̃C���f�b�N�X���擾
        int currentSceneIndex = SceneManager.GetActiveScene().buildIndex;

        // �O�̃V�[���̃C���f�b�N�X���v�Z
        int previousSceneIndex = currentSceneIndex - 1;

        // �C���f�b�N�X��0�����ɂȂ�Ȃ��悤�ɒ���
        if (previousSceneIndex < 0)
        {
            previousSceneIndex = 0;
        }

        // �O�̃V�[���Ɉړ�
        SceneManager.LoadScene(previousSceneIndex);
    }
}
