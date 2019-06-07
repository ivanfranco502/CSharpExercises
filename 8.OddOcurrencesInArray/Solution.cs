namespace _8.OddOcurrencesInArray
{
    public class Solution
    {
        public int solution(int[] A){
            int ocurrencia = 0;
            for(int i1 = 0; i1 < A.Length; i1++){
                ocurrencia = 0;
                for(int i2 = 0; i2 < A.Length; i2++){
                    if(A[i1] == A[i2]){
                        ocurrencia++;
                    }
                    if(i2 == A.Length - 1 && ocurrencia == 1){
                        return A[i1];
                    }
                }
            }
            return -1;
        }
    }
}