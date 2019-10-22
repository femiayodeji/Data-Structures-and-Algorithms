public static class BinarySearchExtension{
    public static int BinarySearch(this int[] array, int value){
     return BinarySearch(array, 0, array.Length - 1, value);
    }

    public static int BinarySearch(int[] array, int start, int end, int value){
        if(start > end) return -1;
        int middleElement = (start + end)/2;
        if(value < array[middleElement]){
            return BinarySearch(array, start, middleElement - 1, value);
        }
        else if(value > array[middleElement]){
            return BinarySearch(array, middleElement + 1, end, value);
        }
        else{
            return middleElement;
        }
    }
}