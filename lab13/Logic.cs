using System;

public class Logic
{
    public static string[] FindWords(string s1, string s2)
    {        
        string[] words1 = s1.Split(' ');
        string[] words2 = s2.Split(' ');

        string[] res = new string[words1.Length];

        int resi = 0;

        for (int i = 0; i < words1.Length; i++)
        {
            for (int j = 0; j < words2.Length; j++)
            {
                if (words1[i] == words2[j])
                {
                    bool f = false;

                    for (int k = 0; k < res.Length; k++)
                    {
                        if (res[k] == words1[i])
                        {
                            f = true;
                            break;
                        }
                    }

                    if (f == false)
                    {
                        res[resi] = words1[i];
                        resi++;
                    }
                }
            }
        }

        string[] finalres = new string[resi];

        for (int i = 0; i < resi; i++)
        {
            finalres[i] = res[i];
        }

        return finalres;
    }
}