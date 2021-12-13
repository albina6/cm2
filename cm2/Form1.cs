using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace cm2
{
    public partial class Form1 : Form
    {
        public int t, Na, n, T, countOperators,tA, tP,/* time = 0;// */ time=30;
        public int[] C, serviceCompletion, SS;
        public double lam = 1.2;
        //public double lamY=
       // public double[] J = new double[]{, 3, 2};
        public List<int> Ai, Di, Vi, Qi;
        public int step = 0;

        public Random rnd = new Random(1);
        
       //public bool flagQuery=
       
        public Form1()
        {
            
            InitializeComponent();
        }
        private void InitializeNumber(int countOperators, int T)
        {
            C = new int [countOperators];
            Na = t = n = 0;
            serviceCompletion = new int[countOperators];
            SS = new int[countOperators];
            Ai = new List<int>();//время прибытия в систему
            Di = new List<int>();//время выхода из системы
            Vi = new List<int>();
            Qi = new List<int>();//время в очереди
            tA = GenerationA(t);
            //, tD = 3 * T;
            for (int i = 0; i < countOperators; i++)
            {
                serviceCompletion[i] = 3 * T;
            }

        }
        private double lam_tt(int t)
        {
            if (t < 240)
            {
                return lam/6;
            }
            else if (t < 360)
            {
                return lam/2;
            }
            else
                return lam/6;
        }
        private int GenerationA(int t)
        {
            double x;
            double u1,u2;
            while (true)
            {
                u1 = rnd.NextDouble();
                double j = lam_tt(t),l= Math.Log(u1);
                x = t - ((1 / lam) *l);
                u2 = rnd.NextDouble();
                if (u2 <= j / lam)
                {

                    return (int)(x+1);
                }
            }
            
        }
        private int GenerationY()
        {
            double lam1 = (0.79/10);
            double u = rnd.NextDouble();
            int k = (int)(-(1 / lam1) * Math.Log(u));
            if (k == 0)
                return GenerationY();
            else
                return k;
        }
        private void ArrivalCl()
        {
            t = tA;
            Na += 1;
            tA = GenerationA(t);
            Ai.Add(t);
            int freeOP = FoundFreeOp();
            if (freeOP < 0)
            {
                n++;
            }
            else
            {
                SS[freeOP] = Na;
                int y = GenerationY();
                serviceCompletion[freeOP] = t + y;
                Vi.Add(y);
                n++;
                Di.Add(serviceCompletion[freeOP]);
                int index = Di.Count() - 1;
                Qi.Add(Di[index] - Vi[index] - Ai[index]);
            }

        }
        private int FoundFreeOp()
        {
            for (int i=0; i < countOperators; i++)
            {
                if (SS[i] == 0)
                    return i;
            }
            return -1;
        }
        private int MinTi()
        {
            int min = serviceCompletion[0];
            int minInd=0;
            for (int i=1; i < serviceCompletion.Length; i++)
            {
                if (serviceCompletion[i] < min)
                {
                    min = serviceCompletion[i];
                    minInd = i;
                }
            }
            return minInd;
        }
        private int MaxNum()
        {
            int max =SS[0];
            int maxInd = 0;
            for (int i = 1; i < SS.Length; i++)
            {
                if (SS[i] > max)
                {
                    max = SS[i];
                    maxInd = i;
                }
            }
            return maxInd; ;
        }
        private void LeafCl__T(int minNumb)//завершение обслуживания 
        {
            t = serviceCompletion[minNumb];
            C[minNumb]++; 
            if (n <= countOperators)
            {
                SS[minNumb] = 0;
                serviceCompletion[minNumb] = 3 * T;
            }
            else
            {
                int m=MaxNum();
                SS[minNumb] = SS[m] + 1;
                int y = GenerationY();
                serviceCompletion[minNumb] = t + y ;
                Vi.Add(y);
                Di.Add(serviceCompletion[minNumb]);
                int index = Di.Count() - 1;
                Qi.Add(Di[index] - Vi[index] - Ai[index]);
            }
            n--;
        }
        private void calculate_Click(object sender, EventArgs e)
        {
            try
            {
                T = Int32.Parse(inputT.Text);
                countOperators = Int32.Parse(countOperatorsTB.Text);
            }
            catch
            {
                outputTB.Text= "Enter the correct text";////////// ждать изменения текста и нажатия клавиши

            }
            InitializeNumber(countOperators,T);

            while (tA<T-time||n>0)
            {
                int minTimeNumb = MinTi();
                if ((tA< serviceCompletion[minTimeNumb]) && (tA <T-time))//приход клиента
                {
                    ArrivalCl();
                }
                else
                {
                    LeafCl__T(minTimeNumb);
                }
            }
            tP = Math.Max(t ,T);
            outputTB.Text = "";
            double wMiddle=0,sT=0,viT=0;
            //wMiddle = 0;
            for (int i = 0; i < Na; i++)
            {
                wMiddle += Qi[i];
                sT +=Di[i]-Ai[i];
                viT += Vi[i];
                outputTB.Text+= "№ - " + i + "; Ai - " + Ai[i] +  "; Vi - " + Vi[i] + "; STi - " +( Di[i]-Ai[i]) + "; Di - " + Di[i] + "; Qi - " + Qi[i] + "\r\n";
            }
            wTB.Text =( wMiddle / Na).ToString();
            sTB.Text=(sT / Na).ToString();
            nTB.Text = Na.ToString();
            tPTB.Text = tP.ToString();
            vTB.Text = (viT / Na).ToString();
        }
    }
}
