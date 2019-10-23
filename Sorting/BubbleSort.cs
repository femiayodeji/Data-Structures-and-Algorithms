public static class Bubble{
    public static int[] Sort(this int[] array){
        for(int i = 0; i < array.Length; i++){
            for(int j = 0; j < array.Length; j++)
            {
                if (array[i] >= array[j]) continue;
                //swap
                int temp = array[i];
                array[i] = array[j];
                array[j] = temp;
            }
        }
        return array;
    }
}