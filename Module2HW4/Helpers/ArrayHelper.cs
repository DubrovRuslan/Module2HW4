using Module2HW4.Models;

namespace Module2HW4.Helpers
{
    public static class ArrayHelper
    {
        public static bool AddElementToArray(ref Animal[] array, Animal newElement)
        {
            if (newElement == null)
            {
                return false;
            }

            var currentSize = (array == null) ? 0 : array.Length;
            var temp = new Animal[currentSize + 1];
            for (var i = 0; i < currentSize; i++)
            {
                temp[i] = array[i];
            }

            temp[currentSize] = newElement;
            array = temp;
            return true;
        }

        public static bool DeleteElemnt(ref object[] array, int indexDeleteElemet)
        {
            if (array == null)
            {
                return false;
            }

            if (indexDeleteElemet < 0 || indexDeleteElemet > array.Length - 1)
            {
                return false;
            }

            if (array.Length == 1 && indexDeleteElemet == 0)
            {
                array = null;
                return true;
            }

            var temp = new object[array.Length - 1];
            for (int i = 0, j = 0; i < array.Length; i++)
            {
                if (i != indexDeleteElemet)
                {
                    temp[j] = array[i];
                    j++;
                }
            }

            array = temp;
            return true;
        }
    }
}
