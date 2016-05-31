using System;

class Solution {
    public int[] solution(int N, int[] A) {
        var counters = new int[N];
        var maxCounter = 0;
        for(var i = 0; i < A.Length; i++){
            if(1 <= A[i] && A[i] <= N){
                counters[A[i]-1]++;
                if(counters[A[i]-1] > maxCounter){
                    maxCounter++;
                }
            } else if(A[i] == N + 1){
                counters = increaseAllCounters(counters, maxCounter);
            }
        } 
        return counters;
    }
    
    private int[] increaseAllCounters(int[] counters, int maxCounter){
        for(var i = 0; i < counters.Length; i++){
            counters[i] = maxCounter;   
        }
        return counters;
    }
}