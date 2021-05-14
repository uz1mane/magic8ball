using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace magic8ball
{
    class Engine
    {
        private Form1 form;

        Random rand = new Random();

        public Engine(Form1 form)
        {
            this.form = form;
        }

        public string GetSubject()
        {
            List<double> p = new List<double>();

            p.Add(0.2);
            p.Add(0.3);
            p.Add(0.45);
            p.Add(0.5);
            p.Add(0.63);
            p.Add(0.7);
            p.Add(0.95);
            p.Add(1);

            double answer = rand.NextDouble();

            for (int i = 0; i < p.Count; i++)
            {
                if (answer - p[i] < 0)
                {
                    answer = i + 1;
                    break;
                }
            }

            switch (answer)
            {
                case 1:
                    return "Math";
                case 2:
                    return "Biology";
                case 3:
                    return "Chemistry";
                case 4:
                    return "English";
                case 5:
                    return "History";
                case 6:
                    return "Physics";
                case 7:
                    return "Programming";
                case 8:
                    return "Geography";
            }

            return "...";
        }
    }
}
