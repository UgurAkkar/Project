using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Mini_Project
{
    class Cards
    {
        string suits, value;
        bool used;
        public Cards(string suits, string value, bool used)
        {
            this.Suits = suits;

            switch (Convert.ToInt32(value))
            {
                case 0:
                    this.value = "Ace";
                    break;    
                case 1:
                    this.value = "Deuce";
                    break;
                case 2:
                    this.value = "Three";
                    break;
                case 3:
                    this.value = "Four";
                    break;
                case 4:
                    this.value = "Five";
                    break;
                case 5:
                    this.value = "Six";
                    break;
                case 6:
                    this.value = "Seven";
                    break;
                case 7:
                    this.value = "Eight";
                    break;
                case 8:
                    this.value = "Nine";
                    break;
                case 9:
                    this.value = "Ten";
                    break;
                case 10:
                    this.value = "Jack";
                    break;
                case 11:
                    this.value = "Queen";
                    break;
                case 12:
                    this.value = "King";
                    break;

            }
            
        }

        public string Suits
        {
            get
            {
                return suits;
            }

            set
            {
                suits = value;
            }
        }

        public bool Used
        {
            get
            {
                return used;
            }

            set
            {
                used = value;
            }
        }

        public string Value
        {
            get
            {
                return value;
            }

            set
            {
                this.value = value;
            }
        }
    }
}
