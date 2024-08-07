using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodingTest1
{
    //배열 뒤집기
    public class Solution
    {
        public int[] solution(int[] num_list)
        {
            Array.Reverse(num_list);
            return num_list;
        }
    }
    //다른사람 풀이
    /*public class Solution
    {
        public int[] solution(int[] num_list)
        {
            int[] answer = new int[num_list.Length];
            int K = 0;
            for (int i = num_list.Length - 1; i >= 0; i--)
            {
                answer[K] = num_list[i];
                K++;
            }
            return answer;
        }
    }*/
}
