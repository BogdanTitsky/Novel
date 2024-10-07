using Naninovel;
using TMPro;
using UnityEngine;

namespace CodeBase
{
    public class SetQuestText : MonoBehaviour
    {
        [SerializeField] private TextMeshProUGUI text;
    
        private void OnEnable() => 
            SetQuestFromVariable();

        private void SetQuestFromVariable()
        {
            ICustomVariableManager service = Engine.GetService<ICustomVariableManager>();
            string questLog = service.GetVariableValue("questLog");
            string currentQuestValue = service.GetVariableValue("currentQuest");
            string logText = $"{questLog}\nCurrent task: {currentQuestValue}".Trim();
            text.text = logText;
        }
    }
}
