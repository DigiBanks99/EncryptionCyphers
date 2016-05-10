namespace EncryptionCyphers.Utilities
{
  public class SortingUtils
  {
    public static byte[] DoMerge(byte[] array, int left, int mid, int right)
    {
      byte[] temp = new byte[array.Length];
      int i, leftEnd, count, tempPos;

      leftEnd = mid - 1;
      tempPos = left;
      count = right - left + 1;

      while (left <= leftEnd && mid <= right)
      {
        if (array[left] <= array[mid])
          temp[tempPos++] = array[left++];
        else
          temp[tempPos++] = array[mid++];
      }

      while (left <= leftEnd)
        temp[tempPos++] = array[left++];

      while (mid <= right)
        temp[tempPos++] = array[mid++];

      for (i = 0; i < count; i++)
      {
        array[right] = temp[right];
        right--;
      }

      return array;
    }

    public static byte[] MergeSort(byte[] array, int left, int right)
    {
      int mid;

      if (right > left)
      {
        mid = right + left / 2;
        array = MergeSort(array, left, mid);
        array = MergeSort(array, mid + 1, right);

        array = DoMerge(array, left, mid + 1, right);
      }

      return array;
    }
  }
}
