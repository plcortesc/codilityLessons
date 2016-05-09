using System;

class Solution {
    public int solution(int X, int Y, int D) {
        var diff = Y - X;
        if(diff == 0) {
            return 0;
        } else if(diff < D) {
            return 1;   
        } else if(diff % D == 0){
            return diff / D;    
        }
        return diff / D + 1;
    }
}