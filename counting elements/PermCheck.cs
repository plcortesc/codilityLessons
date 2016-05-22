using System;

class Solution {
    public int solution(int[] A) {
        var permutationResult = 1;
        Array.Sort(A);
        for(var i = 0; i < A.Length; i++){
            if(A[i] != i + 1){
                permutationResult = 0;
                return permutationResult;
            }
        }
        return permutationResult;
    }
}