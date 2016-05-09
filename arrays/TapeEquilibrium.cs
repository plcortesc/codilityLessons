using System;

class Solution {
    public int solution(int[] A) {
        var totalSumLeft = 0;
        var totalSumRight = A[A.Length-1];
        for(var i = 0; i < A.Length-1; i++){
            totalSumLeft += A[i];
        }
        var minDifference = Math.Abs(totalSumLeft - totalSumRight);
        for(var i=A.Length-2; i > 0 ; i--){
           totalSumLeft -= A[i];
           totalSumRight += A[i];
           var difference = Math.Abs(totalSumLeft - totalSumRight);
           if(difference < minDifference){
            minDifference = difference;   
           }
        }
        return minDifference;
    }
}