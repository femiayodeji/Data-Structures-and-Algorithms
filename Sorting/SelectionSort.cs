public static class Selection{
    public static int[] Sort(this int[] array){
        int minKey;
        for(int i = 0; i < array.Length; i++){
            minKey = i;
            for(int j = i+1; j < array.Length; j++){
                if(array[j] < array[minKey]) minKey = j;
            }
            //swap
            int temp = array[minKey];
            array[minKey] = array[i];
            array[i] = temp;            
        }
        return array;
    }
}