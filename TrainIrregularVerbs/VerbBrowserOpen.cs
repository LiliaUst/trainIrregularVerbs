using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Share;

namespace TrainIrregularVerbs
{
    internal class VerbBrowserOpen : BrowserOpen
    {
        string pathTemplate;
        string pathTemplateVerb;
        string descrTrain;
        IList<VerbData> listVerb;

        internal VerbBrowserOpen(string nameTrain, string descrTrain, IList<VerbData> listVerb)
        {
            NameHtml = Path.Combine(Path.GetTempPath(), string.Format("{0}.html", nameTrain));
            pathTemplate = Path.GetFullPath(Path.Combine("Template", "printIrregularVerbs.html"));
            pathTemplateVerb = Path.GetFullPath(Path.Combine("Template", "verb.html"));
            this.listVerb = listVerb;
            this.descrTrain = descrTrain;
        }
        protected override string CreateView()
        {
            using (StreamReader tempFile = new StreamReader(pathTemplate))
            {
                string result = tempFile.ReadToEnd();
                string verbs = "";
                var index = 1;
                var templVerb = "";
                using (StreamReader tempFileVerb = new StreamReader(pathTemplateVerb))
                {
                    templVerb = tempFileVerb.ReadToEnd();
                }
                foreach (var verb in listVerb)
                {
                    verbs += string.Format(templVerb, (index % 2 != 0 ? "odd" : ""), index, verb.EnglishVerb, verb.EnglishPronunciation, verb.RussianVerbIndefinite);
                    index++;
                }
                return String.Format(result, descrTrain, verbs);
            }
        }
    }
}
