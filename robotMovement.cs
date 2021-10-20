using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ROBOT
{
    /// <summary>
    /// класс, обеспечивающий передвижение робота
    /// </summary>
    public class robotMovement 
    {
        //свойсвта класса

        int x, y; //кор-ды
        int energy; //энергия

        //методы

        /// <summary>
        /// зарядка робота
        /// </summary>
        public void ChargeHigh()
        {
            energy = 100;
        }
        /// <summary>
        /// разрядка робота
        /// </summary>
        public void ChargeLow()
        {
            energy = 0;
        }
        /// <summary>
        /// движение робота
        /// </summary>
        /// <param name="direct">направление движения</param>
        public void Walking(string direct)
        {
            if (energy > 0) //проверка уровня заряда
            {
                switch(direct) //проверка направления
                {
                    case "left":
                        x--;
                        break;
                    case "right":
                        x++;
                        break;
                    case "down":
                        y--;
                        break;
                    case "up":
                        y++;
                        break;
                }
                energy--; //уменьшение заряда
            }

        }

    }
}
