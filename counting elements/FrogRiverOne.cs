using System;
using System.Collections.Generic;

class Solution {
    public int solution(int X, int[] A) {
    	var minSeconds = -1;
        var sortedLeaves = new HashSet<int>();
        for (var i = 0; i < A.Length; i++){
        	if(A[i] <= X){
    			sortedLeaves.Add(A[i]);
        	}
        	if(sortedLeaves.Count == X){
        		minSeconds = i;
        		return minSeconds;
        	}
        }
        return minSeconds;
    }
}