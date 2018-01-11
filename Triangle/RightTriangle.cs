using System;

namespace Triangle
{
    public class RightTriangle
    {
        private void CheckTriangle(int katetA, int katetB, int gepotenuza)
        {
            var actualGepotenuza = katetA + katetB;

            if (gepotenuza != actualGepotenuza)
            {
                throw new Exception("Указанная длинна гипотенузы - ошибочна");
            }

            var actualKatetA = gepotenuza - katetB;

            if (katetA != actualKatetA)
            {
                throw new Exception("Указанная длинна Катета А - ошибочна");
            }

            var actualKatetB = gepotenuza - katetA;

            if (katetB != actualKatetB)
            {
                throw new Exception("Указанная длинна Катета B - ошибочна");
            }
        }
        
        public int CalculationArea(int katetA, int katetB, int gepotenuza)
        {
            CheckTriangle(katetA, katetB, gepotenuza);
            var result = (katetA * katetB) / 2;
            return result;
        }
    }
}
