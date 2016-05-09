using System;
//Thanks to the XOR operator it can be solved pretty easily
class Solution {
    public int solution(int[] A) {
        var oddOccurrence = A[0];
        for(var i = 1; i < A.Length; i++){
            oddOccurrence ^= A[i];    
        }
        return oddOccurrence;
    }
}