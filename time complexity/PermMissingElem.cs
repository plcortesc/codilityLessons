using System;

class Solution {
    public int solution(int[] A) {
        var missingValue = 0;
        for(var i = 1; i < A.Length+2; i++){
            missingValue += i == A.Length + 1 ? i : i - A[i-1];                
        }
        return missingValue;
    }
}