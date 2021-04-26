using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GameController : MonoBehaviour
{
    [SerializeField] private Text finalText;
    [SerializeField] private Text boxesCountText;
    private static GameController thisController;
    private int destroyedBoxesCount = 0;

    private void Start()
    {
        thisController = this;
    }

    internal static void FinishGame(string text)
    {
        thisController.finalText.text = text;
        thisController.finalText.gameObject.SetActive(true);
    }

    private void OnTriggerExit(Collider other)
    {
        if (other.gameObject.GetComponent<BoxController>() != null)
        {
            ++destroyedBoxesCount;
            boxesCountText.text = $"Boxes: {destroyedBoxesCount}";
        }
    }
}
