using UnityEngine;
using TMPro;

public class DialogueController : MonoBehaviour
{
    [Header("Dialogue Data")]
    [SerializeField] private DialogueSet dialogueSet;

    [Header("Dialogue UI")]
    [SerializeField] private TMP_Text dialogueText;
    
    private void Start()
    {
        ShowDialogue("intro");
    }

    // Permite trocar o conjunto de diálogos futuramente.
    public void SetDialogueSet(DialogueSet newDialogueSet)
    {
        if (newDialogueSet == null)
        {
            Debug.LogError("DialogueSet não foi configurado!", this);
            return;
        }

        dialogueSet = newDialogueSet;
    }

    // Procura e apresenta uma fala pelo seu identificador.
    public void ShowDialogue(string dialogueId)
    {
        if (dialogueSet == null)
        {
            Debug.LogError("Nenhum DialogueSet foi atribuído!", this);
            return;
        }

        if (dialogueText == null)
        {
            Debug.LogError("O componente de texto não foi atribuído!", this);
            return;
        }

        if (dialogueSet.entries == null)
        {
            Debug.LogError("A lista de diálogos está vazia ou inválida!", this);
            return;
        }

        DialogueEntry entry = dialogueSet.entries.Find(
            item => item != null && item.id == dialogueId
        );

        if (entry == null)
        {
            Debug.LogWarning(
                "Diálogo não encontrado: " + dialogueId,
                this
            );
            return;
        }

        dialogueText.text = entry.text ?? "";
    }
}