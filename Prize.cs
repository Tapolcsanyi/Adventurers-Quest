using System;

namespace Quest
{
    class Prize
    {
        private string _text = "";

        public Prize(string text)
        {
            _text = text;
        }

        public string ShowPrize(Adventurer adventurer)
        {
            if (adventurer.Awesomeness > 0)
            {

                _text = $"You have {adventurer.Awesomeness} Awesomeness.";
                return _text;
            } else {

                _text = "You poor, poor manchild.";
                return _text;
            }
        }
    }
}