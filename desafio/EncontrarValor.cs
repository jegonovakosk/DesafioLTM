using System;

namespace desafio
{
    class EncontrarValor
    {
        public int[] Valores { get; }
        public int alvo { get; }

        public EncontrarValor(int[] valores, int alvo)
        {
            Valores = valores;
            this.alvo = alvo;
        }

        public void valorAlvo(int[] valor , int alvo)
        {
            int i = 0;

            do
            {
                for (int k = 0; k < valor.Length; k++)
                {
                    if (valor[i] != valor[k])
                    {
                        int res = valor[i] + valor[k];
                        if (res == alvo)
                        {
                            Console.WriteLine(res);
                        }
                    }
                }

                i++;
            } while (i < valor.Length);
        }
    }
}
