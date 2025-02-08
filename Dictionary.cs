using System.Linq;

namespace My_Protject
{
    public class Dictionary
    {
        private Word[] words;
        public Dictionary()
        {
            words = new Word[]
            {
            new Word("red", "красный"),
            new Word("blue", "синий"),
            new Word("green", "зеленый")
            };
        }
        public string this[string sought]
        {
            get
            {
                foreach (var word in words)
                {
                    if(word.Source == sought)
                    {
                        return word.Target;
                    }
                }
                return null;
            }
            set 
            { 
                foreach (var word in words)
                {
                    if (word.Source == sought)
                    {
                        word.Target = value;
                    }
                }
            }
        }


    }
}
