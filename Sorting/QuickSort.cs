public static class Quick{
    public static int[] Sort(this int[] array){
        quickSort(array,0,array.Length - 1);
        return array;
    }

    static void quickSort(int[] array, int low, int high){
        if(low <high){
            //partition index
            int pi = partition(array,low,high);
            
            //sort elements before and after partition
            quickSort(array,low,high-1);
            quickSort(array,pi + 1,high);            
        }
    }

    static int partition(int[] array, int low,int high){
        int pivot = array[high];
        int i = low - 1; //index of the smallest element

        int temp;
        for(int j = low; j <= high - 1; j++){
            if(array[j] < pivot){
                i++;
                temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        temp = array[i + 1];
        array[i + 1] = array[high];
        array[high] = temp;
        return (i + 1);
    }
}