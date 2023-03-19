namespace Labs.FirstLab
{

    public class NaturalNumber
    {
        private readonly int _maxNumber = 5000;
        private readonly int _minNumber = 0;

        public int GetMaxNaturalNumber(string text)
        {
            int divider;

            if (TryNumberParse(text, out divider))
            {
                return CalculateMaxNaturalNumber(divider); ;
            }

            return -1;
        }

        private int CalculateMaxNaturalNumber(int divider)
        {
            int result = 0;

            for (int i = _minNumber; i < _maxNumber; i++)
                if (i % divider == 0)
                    result = i;

            return result;
        }

        private bool TryNumberParse(string text, out int result)
        {
            result = 0;

            if (text == null)
                return false;

            if (int.TryParse(text, out result))
                if (result <= _maxNumber && result > _minNumber)
                    return true;

            return false;
        }
    }
}
