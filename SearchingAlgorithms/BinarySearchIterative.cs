public static class BinarySearchIterativeExtension{
    public static int BinarySearchIterative(this int[] array, int value){
        int start = 0;
        int end  = array.Length - 1;

        while(start <= end){
            int middle = (start + end)/2;
            if(value < array[middle]){
                end = middle - 1;
            }
            else if(value> array[middle]){
                start = middle + 1;
            }
            else{
                return middle;
            }
        }
        return -1;
    }
}