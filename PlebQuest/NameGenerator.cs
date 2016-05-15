using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PlebQuest
{
    //Markov Chain
    class NameGenerator
    {
        //"miniature" would become "-mi", "inia", "iatu", and "ure"
        private char[] v = { 'a', 'e', 'i', 'o', 'u', 'y' };
        private char[] c =
            {'b', 'c', 'd', 'f', 'g', 'h', 'j', 'k', 'l', 'm', 'n', 'p', 'q', 'r', 's', 't', 'v', 'w', 'x', 'z' };

        List<string[]> decomposedWords;

        public NameGenerator()
        {
            decomposedWords = new List<string[]>();

            foreach (string word in words)
            {
                decomposedWords.Add(this.Decompose(word));
            }
        }

        private string[] Decompose(string word)
        {
            //word = "miniature";

            if (word == null)
                return null;

            List<int> cPos = new List<int>();

            for (int i = 0; i < word.Length; i++)
            {
                if (c.Contains(word[i]))
                    cPos.Add(i);
            }

            List<string> parts = new List<string>();

            //badly divised. need to work on double consonant
            parts.Add(word.Substring(0, cPos[1]));
            for (int i = 1; i < cPos.Count - 1; i++)
            {
                int r = cPos[i + 1] - cPos[i - 1] - 1;
                string part = word.Substring(cPos[i - 1] + 1, r);
                //removing single letters 
                if(part.Length >= 1)
                    parts.Add(part);
            }
            parts.Add(word.Substring(cPos[cPos.Count - 2] + 1));
            
            return parts.ToArray();
        }

        public string BuildName()
        {
            Random rng = new Random();
            int nbWords = rng.Next(1, 3);
            string name = string.Empty;

            name += decomposedWords[rng.Next(0, decomposedWords.Count)].First();

            for(int i = 0; i < nbWords; i++)
            {
                int index = rng.Next(0, decomposedWords.Count);

                foreach (string part in decomposedWords[index])
                {
                    if(part.First() == name.Last())
                    {
                        name += part.Substring(1);
                        break;
                    }
                }
            }

            /*int addedParts = 0;
            while(addedParts < nbWords)
            {
                string[] word = decomposedWords[rng.Next(0, decomposedWords.Count)];
                //word generation exemple:

                -mi  miniature
                ino  dinosaurs
                octo doctoral
                ore  more
                    ->minoctore

                - vo  volunteers
                 ofe  professional
                 eti  meticulously
                 ishe established
                ent - student
                    ->vofetishent

                - si  sites
                 inia miniature
                 ude  student
                     ->siniatude

                 - pro professional
                  olo  paleontologists
                on - season
                    ->prolon

                - sta  started
                 aleo  paleontologists
                 eove  moreover
                 entra concentration
                 aci   racing
                 ity   rigidity
                     ->staleoventracity
                     
            }*/

            name += decomposedWords[rng.Next(0, decomposedWords.Count)].Last();

            return name.First().ToString().ToUpper() + name.Substring(1);
        }



        static string[] words = new string[]
        {
            "stadium",
            "great",
            "artist",
            "aviation",
            "grandfather",
            "destruction",
            "tread",
            "privilege",
            "country",
            "colon",
            "decide",
            "conglomerate",
            "toss",
            "mechanical",
            "linear",
            "museum",
            "minor",
            "context",
            "proud",
            "minivan",
            "hope",
            "canvas",
            "plant",
            "translate",
            "count",
            "species",
            "plead",
            "inhabitant",
            "compete",
            "desire",
            "break",
            "resident",
            "corpse",
            "reckless",
            "character",
            "sacrifice",
            "analyst",
            "index",
            "collection",
            "divide"
        };
    }
}
