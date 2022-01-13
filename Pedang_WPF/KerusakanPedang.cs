using System;
using System.Collections.Generic;
using System.Text;
using System.Diagnostics;

namespace Pedang_WPF
{
    class KerusakanPedang
    {
        public const int LUKA_DASAR = 3;
        public const int LUKA_BAKAR = 2;

        public int Roll;
        public decimal PengaliAjaib = 1M;
        public int RusakTerbakar = 0;
        public float Kerusakan;

        public void HitungKerusakan()
        {
            Kerusakan = (int)(Roll * PengaliAjaib) + LUKA_DASAR + RusakTerbakar;
            Debug.WriteLine($"CalculateDamage finished: {Kerusakan} (roll: {Roll})");

        }

        public void AturKeajaiban(bool Keajaiban)
        {
            if (Keajaiban)
            {
                PengaliAjaib = 1.75M;
            }
            else
            {
                PengaliAjaib = 1M;
            }
            HitungKerusakan();
            Debug.WriteLine($"SetMagic finished: {Kerusakan} (roll: {Roll})");
        }

        public void AturNyalaApi(bool Nyala)
        {
            HitungKerusakan();
            if (Nyala)
            {
                Kerusakan += LUKA_BAKAR;
            }
            Debug.WriteLine($"SetFlaming finished: {Kerusakan} (roll: {Roll})");
        }


    }
}
