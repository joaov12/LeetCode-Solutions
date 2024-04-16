// Runtime 339 ms
// Memory 58.3 MB

  public int MaxProfit(int[] prices) {
        int max = 0;
        int min = prices[0];
        
        for(int i=1;i<prices.Length;i++){
            if(prices[i] < min){
                min = prices[i];
            }
            
            if((prices[i] - min) > max )
            {
                max = prices[i] - min;
            }
        }
        return max;
    }
