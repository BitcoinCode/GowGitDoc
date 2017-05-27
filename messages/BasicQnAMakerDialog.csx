using System;
using System.Threading.Tasks;

using Microsoft.Bot.Builder.Azure;
using Microsoft.Bot.Builder.Dialogs;
using Microsoft.Bot.Builder.CognitiveServices.QnAMaker;

// For more information about this template visit http://aka.ms/azurebots-csharp-qnamakerhttp://localhost:4040/api/messages
[Serializable]
public class BasicQnAMakerDialog : QnAMakerDialog
{
    // Go to https://qnamaker.ai and feed data, train & publish your QnA Knowledgebase.
    //public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute(Utils.GetAppSetting("QnASubscriptionKey"), Utils.GetAppSetting("QnAKnowledgebaseId"))))
    //{
    //}
    public BasicQnAMakerDialog() : base(new QnAMakerService(new QnAMakerAttribute("71701bf7233846098217e1ed2853070e", "4fe724d5-c4a1-4ed7-a695-c11e7299b398")))
    {
    }
}