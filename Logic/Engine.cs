namespace Logic
{
    public class Engine
    {
        // Retourne l'équivalent romain en chiffre
        public virtual int Evaluate(char roman)
        {
            switch (roman)
            {
                case 'I': return 1;
                case 'V': return 5;
                case 'X': return 10;
                case 'L': return 50;
                case 'C': return 100;
                case 'D': return 500;
                case 'M': return 1000;
                default : return -1;
            }
        }

        // Algo principal
        public virtual int ComputeRomanToDecimal(string roman)
        {
            int res = 0;

            for (int i = 0; i < roman.Length; i++)
            {
                // On prend le nombre en cours
                int s1 = Evaluate(roman[i]);

                // Si nombre suivant
                if (i + 1 < roman.Length)
                {
                    // On prend le suivant
                    int s2 = Evaluate(roman[i + 1]);

                    // On compare
                    if (s1 >= s2)
                    {
                        // le nombre en cours est plus grand 
                        // on ajoute 
                        res += s1;
                    }
                    else
                    {
                        // Sinon, cas spéciaux : IV, XL, XC, ...
                        res = res + s2 - s1;
                        i++; // on incrémente la boucle for
                    }
                }
                else
                {
                    res += s1;
                    i++;
                }
            }

            return res;
        }
    }
}
