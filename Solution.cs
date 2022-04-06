class Solution
        {
            public static int MaxArea(int[] height)
            {
                int max = 0;
                int maxindex = 0;
                int maxTemp = 0;
                int tempindex = 0;
                bool iSwap = true;
                string maxIndexHolder = "";
                int tempVal = 0;
                int maxVal = 0;


                for (int i = 0; i < height.Length; i++)
                {
                    max = height[i];
                    maxindex = i;


                    for (int j = i+1; j < height.Length; j++)
                    {
                        iSwap = true;
                        tempVal = 0;

                        if (maxIndexHolder.Length > 0)
                        {
                            for (int k = 0; k < maxIndexHolder.Length; k++)
                            {
                                if (maxIndexHolder[k] == j)
                                {
                                    iSwap = false;
                                    break;
                                }
                            }
                        }
                        if (iSwap == false)
                            continue;

                        if (j != maxindex && iSwap)
                        {
                            maxTemp = height[j];
                            maxIndexHolder += Convert.ToString(j);
                            tempindex = j;
                        }

                        tempVal = tempindex - maxindex;
                        if (max > maxTemp)
                            tempVal *= maxTemp;
                        else
                            tempVal *= max;

                        if (maxVal < tempVal)
                            maxVal = tempVal;
                    }
                }
                return maxVal;
            }
        }
