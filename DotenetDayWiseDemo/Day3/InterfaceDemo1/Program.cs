namespace InterfaceDemo1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            SpellCheckFactory spell = new SpellCheckFactory();
            Console.WriteLine("1.English 2.Hindi 3.Jappnese");
            ISpellChecker hindiChecker=spell.GetCheck("Hindi");
            Editor edit = new Editor(hindiChecker);
            edit.DoCheck("abc");
        }
    }
    public interface ISpellChecker
    {
        void SpellCheck(string word);
    }
    public class EnglishSpellChecker : ISpellChecker
    {
        public void SpellCheck(string word)
        {
            Console.WriteLine("English SpecllCheck Done");
        }
    }
    public class HindiSpellChecker : ISpellChecker
    {
        public void SpellCheck(string word)
        {
            Console.WriteLine("Hindi SpecllCheck Done");
        }
    }
    public class JappneseSpellChecker : ISpellChecker
    {
        public void SpellCheck(string word)
        {
            Console.WriteLine("Jappnese SpecllCheck Done");
        }
    }

    public class Editor
    {
        private ISpellChecker _checker;

        public Editor(ISpellChecker checker)
        {
            if (checker == null)
            {
                _checker = new EnglishSpellChecker();
            }
            else
                _checker = checker;

        }

        public void DoCheck(string word)
        {
            _checker.SpellCheck(word);
        }
    }
        public class SpellCheckFactory()
        {
            public ISpellChecker GetCheck(string choice)
            {
                if (choice == "English")
                    return new EnglishSpellChecker();
                if (choice == "Hindi")
                    return new HindiSpellChecker();
                else
                    return new JappneseSpellChecker();
            }
        }



    }

