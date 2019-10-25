public static class Quick{
    public static int[] Sort(this int[] array){
        QuickSort(array,0,array.Length - 1);
        return array;
    }

    static void QuickSort(int[] array, int left, int right){
        if(left <right){
            //using the median as pivot
            int pivot = array[(left+right)/2];
            //partition index
            int partition = Partition(array,left,right,pivot);            
            //sort elements before and after partition
            QuickSort(array,left,partition-1);
            QuickSort(array,partition,right);            
        }
    }

    static int Partition(int[] array, int leftStart,int rightEnd, int pivot){
        int left = leftStart;
        int right = rightEnd;
        
        while(left <= right){
            //left must be less than pivot
            while(array[left] < pivot){
                left++;
            }
            //right must be greater than pivot
            while(array[right] > pivot){
                right--;
            }
            if(left <= right){
                //swap
                int temp = array[left];
                array[left] = array[right];
                array[right] = temp;
                left++; //moving forward
                right--; //moving backward
            }
        }
        return left;
    }
}