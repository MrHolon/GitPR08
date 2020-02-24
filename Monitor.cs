using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ПР0_Проект
{
    class Monitor
    {
        private string firma = new string(' ', 20);
        private string type = new string(' ', 20);
        private float diagonal;
        public Monitor()
        {
            this.firma = "Название";
            this.type = "Шифр";
            this.diagonal = 0;
        }
        public Monitor(string firm, string type, float diagonal)
        {
            this.firma = firm;
            this.type = type;
            this.diagonal = diagonal;

        }
        public string Firm
        {
            set
            {
                firma = value;
            }
        }
        public string Type
        {
            set
            {
                type = value;
            }
        }
        public float Diagonal
        {
            set
            {
                diagonal = Convert.ToSingle(value);
            }
        }
        public void GetInfo()
        {
            Console.WriteLine("Фирма -  {0}; тип - {1}; диагональ - {2}.", firma, type, diagonal);
        }
    }
}
