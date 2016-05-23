using System;

class Solution {
    public int solution(int[] A) {
        var minInteger = A.Length + 1;
        var aux = new int[A.Length + 1];

        for (var i = 0; i < A.Length; i++){
            if (A[i] > 0 && A[i] < A.Length + 1){
                aux[A[i]] = A[i];
            }
        } 

        for (var i = 1; i < A.Length + 1; i++){
            if (aux[i] != i){
            	minInteger = i;
                return minInteger;
            }
        }
        return minInteger;
    }
}