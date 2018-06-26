using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Xml.Serialization;

namespace Lab4{
    public class Fmas { 

        public int[,] FA;
        private int N;
        XmlSerializer xmlSer = new XmlSerializer(typeof(int[]));

        public Fmas(int n, int a, int b){
            if (a > b){
                int c = a;
                a = b;
                b = c;
            }
            N = n;
            Random r = new Random();
            FA = new int[n, n];
            for(int i = 0; i < n; i++) {
                for(int j = 0; j < n; j++) {
                    FA[i,j] = 0;
                }
            }
            for (int i = 0; i < n; i++){
                for (int j = 0; j < n; j++){
                    FA[i,j] = r.Next(a, b + 1);
                }
            }
        }

        public bool CheckIndex(int i, int j) {
            if(i > 0 && i < N && j > 0 && j < N)
                return true;
            return false;
        }

        public int[,] Func1(){
            int [,] res = new int[N,N];
            int [] tmp = new int[N];
            for (int i = 0; i < N; i++){
                for(int j = 0; j < N; j++)
                    tmp[j] = FA[j, i];
                Array.Sort(tmp);
                Array.Reverse(tmp);
                for(int j = 0; j < N; j++)
                    res[j, i] = tmp[j];
            }
            return res;
        }

        public int[,] Func2(int d) {
            int count = 0;
            for(int i = 0; i < N; i++)
                for(int j = 0; j < N; j++)
                    if(FA[i,j] == d)
                        count++;
            int[,] res = new int[count, 2];
            count = 0;
            for(int i = 0; i < N; i++)
                for(int j = 0; j < N; j++)
                    if(FA[i,j] == d) {
                        res[count, 0] = i;
                        res[count, 1] = j;
                        count++;
                    }
            return res;
        }

        public int[,] Func3(int h, int f) {
            int[,] res = new int[N,N];
            for(int i = 0; i < N; i++)
                for(int j = 0; j < N; j++)
                    if(FA[i,j] % 3 == 0)
                        res[i,j] = FA[i,j] * (-1 * h);
                    else
                        res[i,j] = FA[i,j] - f;
            return res;
        }

        public void Serialize(string fileName) {
            int[] arr = new int[N * N];
            int k = 0;
            for(int i = 0; i < N; i++)
                for(int j = 0; j < N; j++, k++)
                    arr[k] = FA[i, j];
            using(FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate)) {
                xmlSer.Serialize(fs, arr);
            }
        }

        public void Deserialize(string fileName) {
            int[] arr = new int[N * N];
            using(FileStream fs = new FileStream(fileName, FileMode.OpenOrCreate)) {
                arr = (int[])xmlSer.Deserialize(fs);
            }
            int k = 0;
            for(int i = 0; i < N; i++)
                for(int j = 0; j < N; j++, k++)
                    FA[i, j] = arr[k];
        }

    }
}
