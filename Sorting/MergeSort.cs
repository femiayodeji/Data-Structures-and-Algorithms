public static class Merge{
    public static int[] Sort(this int[] array){
        MergeSort(array,0,array.Length - 1);
        return array;
    }

    static void MergeSort(int[] array, int left, int right){
        if(left < right){
            //find the middle point
            int middle = (left + right)/2;

            //sort the first and second halves
            MergeSort(array,left,middle);
            MergeSort(array,middle + 1, right);

            //merge the sorted halves
            MergeHalves(array,left,middle,right);
        }
    }

    static void MergeHalves(int[] array, int left, int middle, int right){
        //find the sizes of the two subarrays to be merged
        int n = middle - left + 1;
        int m = right - middle;

        //create temp arrays
        int[] leftArray = new int[n];
        int[] rightArray = new int[m];

        //copy data to temp arrays
        for(int x = 0; x < n; ++x)
            leftArray[x] = array[left + x];
        for(int y = 0; y < m; ++y)
            rightArray[y] = array[middle + 1 + y];

        //merge the temo arrays
        //initial indexes of first and second subarrays
        int i = 0, j = 0;
        
        //initial indexes of merged subarray arrays
        int k = left;
        while(i < n && j < m){
            if(leftArray[i] <= rightArray[j]){
                array[k] = leftArray[i];
                i++;
            }
            else{
                array[k] = rightArray[j];
                j++;
            }
            k++;
        }
        //copy remaining elements of left array if any
        while(i < n){
            array[k] = leftArray[i];
            i++;
            k++;
        }
        //copy remaining elements of right array if any
        while(j < m){
            array[k] = rightArray[j];
            j++;
            k++;
        }
    }
}