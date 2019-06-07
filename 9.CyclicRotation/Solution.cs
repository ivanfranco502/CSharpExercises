namespace _9.CyclicRotation
{
    public class Solution
    {
        public int[] solutionNM(int[] A, int K){
            int[] array = new int[A.Length];

            while(K > A.Length){
                K = K - A.Length;
            }

            for(int i = K; i< A.Length; i++){
                array[i-K] = A[i];
            }

            for(int i=0; i< K ; i++){
                array[i+K-1] = A[i];
            }

            return array;
        }

        public int[] solutionN2(int[] A, int K){
            for(int i = 0; i < K; i++){
                int[] array = new int[A.Length]();

                array[0] = A[A.Length -1];

                for(int x = 1; x < array.Length; x++){
                    array[x] = A[x-1];
                }

                if(i == K){
                    return array;
                }else{
                    A = array;
                }
            }
            return array;
        }

        public int[] solutionN(int[] A, int K){
            int[] array = new int[A.Length];

            int indiceNuevo = 0;

            for(int i = 0; i < A.Length; i++){
                indiceNuevo = i + K;
                if(indiceNuevo > A.Length - 1){
                    indiceNuevo = indiceNuevo - A.Length;
                }
                array[i] = A[indiceNuevo];
            }

            return array;
        }

        public int[] solution(int[] A, int K){
            int[] array = new int[A.Length];

            int movimiento = K % A.Length - 1;

            for(int i = 0; i < A.Length; i++){
                int j = movimiento + i;

                if(j > A.Length - 1){
                    j = + j - A.Length;
                }
                array[j] = A[i];
            }

            return array;
        }
    }
}