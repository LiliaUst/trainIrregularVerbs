using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace TrainIrregularVerbs
{
    sealed class TrainData
    {
        internal string PathTrain { get; set; }
        private IList<VerbData> listTrain;
        internal IList<VerbData> ListTrain
        {
            get { return listTrain; }
        }

        internal TrainData()
        {
            PathTrain = GetInitPath();
            listTrain = null;
        }

        internal string GetInitPath()
        {
            return Path.GetFullPath(@"Data\top50.csv");
        }

        internal void Open()
        {
            if (listTrain == null)
            {
                using (StreamReader reader = new StreamReader(PathTrain))
                {
                    listTrain = new List<VerbData>();
                    string line;
                    while ((line = reader.ReadLine()) != null)
                    {

                        string[] parts = line.Split(';');
                        var verb = new VerbData(parts);
                        listTrain.Add(verb);
                    }
                }
            }
        }
    }

    internal class VerbData
    {
        internal struct Pronoun
        {
            public Pronoun(DeclensionVerb declension, string pronoun)
            {
                this.declension = declension;
                this.pronoun = pronoun;
            }
            public DeclensionVerb declension;
            public string pronoun;
        }
        internal string EnglishVerb { get; set; }
        internal IDictionary<FormVerb, string> EnglishVerbForm { get; set; }
        internal string EnglishPronunciation { get; set; }
        internal string RussianVerbIndefinite { get; set; }
        internal IDictionary<TenseVerb, IDictionary<DeclensionVerb, string>> RussianVerbsDeclension { get; set; }
        internal string EnglishPhrase { get; set; }
        internal string RussianPhrase { get; set; }

        private static IDictionary<string, Pronoun> englishPronoun;

        static VerbData()
        {
            englishPronoun = new Dictionary<string, Pronoun>();
            englishPronoun["I"] = new Pronoun(DeclensionVerb.SingleMan, "Я");
            englishPronoun["You"] = new Pronoun(DeclensionVerb.SingleMan, "Ты");
            englishPronoun["He"] = new Pronoun(DeclensionVerb.SingleMan, "Он");
            englishPronoun["She"] = new Pronoun(DeclensionVerb.SingleWoman, "Она");
            englishPronoun["It"] = new Pronoun(DeclensionVerb.SingleNeuter, "Оно");
            englishPronoun["We"] = new Pronoun(DeclensionVerb.Multi, "Мы");
            englishPronoun["They"] = new Pronoun(DeclensionVerb.Multi, "Они");
        }

        internal VerbData(string[] parts)
        {
            
            if (parts != null && parts.Length > 0)
            {
                EnglishVerb = parts[0];
                string[] verbs = parts[0].Split(',');
                if (verbs != null && verbs.Length > 0)
                {
                    EnglishVerbForm = new Dictionary<FormVerb, string>();
                    EnglishVerbForm[FormVerb.Form1] = verbs[0].Trim();
                    EnglishVerbForm[FormVerb.Form2] = verbs[1].Trim();
                    EnglishVerbForm[FormVerb.Form3] = verbs[2].Trim();
                }

                EnglishPronunciation = parts.Length > 1 ? parts[1] : "";

                RussianVerbIndefinite = parts.Length > 2 ? parts[2] : "";

                if (parts.Length > 3)
                {
                    RussianVerbsDeclension = new Dictionary<TenseVerb, IDictionary<DeclensionVerb, string>>();
                    RussianVerbsDeclension[TenseVerb.Past] = new Dictionary<DeclensionVerb, string>();
                    RussianVerbsDeclension[TenseVerb.Past][DeclensionVerb.SingleMan] = parts[3];
                    RussianVerbsDeclension[TenseVerb.Past][DeclensionVerb.SingleWoman] = parts.Length > 4 ? parts[4] : "";
                    RussianVerbsDeclension[TenseVerb.Past][DeclensionVerb.SingleNeuter] = parts.Length > 5 ? parts[5] : "";
                    RussianVerbsDeclension[TenseVerb.Past][DeclensionVerb.Multi] = parts.Length > 6 ? parts[6] : "";
                }
            }
        }
        internal void PreparingTrainVerb()
        {
            EnglishPhrase = EnglishVerbForm[FormVerb.Form2];
            RussianPhrase = RussianVerbsDeclension[TenseVerb.Past][DeclensionVerb.SingleMan];

            var random = new Random();
            var indexRandom = random.Next(0, VerbData.englishPronoun.Count);
            var keys = (ICollection<string>)VerbData.englishPronoun.Keys;
            if (keys != null)
            {
                var i = 0;
                foreach (var key in keys)
                {
                    if (i++ == indexRandom)
                    {
                        EnglishPhrase = String.Format("{0} {1}", key, EnglishVerbForm[FormVerb.Form2]);
                        RussianPhrase = String.Format("{0} {1}", englishPronoun[key].pronoun, RussianVerbsDeclension[TenseVerb.Past][englishPronoun[key].declension]);
                        break;
                    }
                }
            }
        }


        internal object GetPathAudio()
        {
            return Path.GetFullPath(String.Format(@"Data\Audio\{0}.mp3", EnglishVerbForm[FormVerb.Form1]));
        }
    }

    internal enum TenseVerb {
        Future,
        Present,
        Past,
    }

    internal enum FormVerb
    {
        Indefinite,
        Form1,
        Form2,
        Form3,
        IngForm,
    }

    internal enum DeclensionVerb
    {
        SingleMan,
        SingleWoman,
        SingleNeuter,
        Multi,
    }


}
