using System.Collections;
using UnityEngine;

public class IncorrectButtonHandler : MonoBehaviour
{
    private CanvasGroup canvasGroup;
    public CanvasGroup scrambleScreen;

    private void Start()
    {
        canvasGroup = GetComponent<CanvasGroup>();
    }

    public void DiasbleButton()
    {
        scrambleScreen.interactable = false;
        scrambleScreen.blocksRaycasts = false;
        PermUI.perm.combatTextScoreMinus.SetActive(true);
        PermUI.perm.combatTextScoreMinus.GetComponent<Animator>().SetTrigger("hit");
        StartCoroutine(Reset());
        canvasGroup.alpha = 0;      
        PermUI.perm.falseEmoji.SetActive(true);
        PermUI.perm.answerCanvas.SetActive(true);
        PermUI.perm.backStorImagesCanvas.SetActive(false);
        PermUI.perm.frontStoreImagesCanvas.SetActive(false);
        PermUI.perm.score -= 20;
        SoundManager.PlaySound("Death");      
    }

    private IEnumerator Reset()
    {
        yield return new WaitForSeconds(2f);
        scrambleScreen.interactable = true;
        scrambleScreen.blocksRaycasts = true;
        PermUI.perm.combatTextScoreMinus.SetActive(false);
        PermUI.perm.falseEmoji.SetActive(false);
        PermUI.perm.answerCanvas.SetActive(false);
        PermUI.perm.backStorImagesCanvas.SetActive(true);
        PermUI.perm.frontStoreImagesCanvas.SetActive(true);
        gameObject.SetActive(false);
    }
}