using BackendTiki.Models;
namespace BackendTiki.Access.StaticFunction
{
    public static class Sort
    {
        static public int QuickSortProduct(List<Product> arr, Product productLeft, Product productRight,int left, int right)
        {
            Product pivot;
            pivot = arr[left];
            while (true)
            {
                while (arr[left].Price < pivot.Price)
                {
                    left++;
                }
                while (arr[right].Price > pivot.Price)
                {
                    right--;
                }
                if (productLeft.Price < productRight.Price)
                {
                    (arr[left], arr[right]) = (arr[right], arr[left]);
                }
                else
                {
                    return right;
                }
            }
        }
        static public void quickSort(List<Product> arr, Product productLeft, Product productRight,int left,int right)
        {
            int pivot;
            if (productLeft.Price < productRight.Price)
            {
                pivot = QuickSortProduct(arr, arr[left], arr[right], left,right);
                if (pivot > 1)
                {
                    quickSort(arr, arr[left], arr[pivot - 1], left, pivot - 1);
                }
                if (pivot + 1 < right)
                {
                    quickSort(arr, arr[pivot + 1], arr[right], pivot + 1, right);
                }
            }
        }
    }
}
