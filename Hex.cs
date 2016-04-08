using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace 拾色器
{
    class Hex
    {
        public  int  H_to_D(char a)
        {
            int value;
            switch(a)
            {
                case 'A': value = 10; break;
                case 'a': value = 10; break;
                case 'B': value = 11; break;
                case 'b': value = 11; break;
                case 'C': value = 12; break;
                case 'c': value = 12; break;
                case 'D': value = 13; break;
                case 'd': value = 13; break;
                case 'E': value = 14; break;
                case 'e': value = 14; break;
                case 'F': value = 15; break;
                case 'f': value = 15; break;
                default: value = Convert.ToInt32(a)-48; break;
            }
            return value;
        }

        public string Change_to_alpha(int value)
        {
            switch (value)
            {
                case 10: return "A";
                case 11: return "B";
                case 12: return "C";
                case 13: return "D";
                case 14: return "E";
                case 15: return "F";
                default: return value.ToString();
            }
        }

        public string D_to_H(string value)
        {
            int mid_int = 0;
            int H_bit, L_bit;
            //string mid_string = "";
            if (value == "") mid_int = 0;
            else      mid_int = Convert.ToInt32(value);
            H_bit = mid_int / 16;
            L_bit = mid_int % 16;
            return Change_to_alpha(H_bit) + Change_to_alpha(L_bit);
        }

        public bool Text_string(char value)
        {
            int value_int=Convert.ToInt32(value);
            int a_int=Convert.ToInt32('a');
            int A_int=Convert.ToInt32('A');
            int f_int=Convert.ToInt32('f');
            int F_int=Convert.ToInt32('F');
            if ((value_int - 48 >= 0) && (value_int - 48 <= 9)) return true;
            else if ((value_int - a_int >= 0) && (value_int - f_int <= 0)) return true;
            else if ((value_int - A_int >= 0) && (value_int - F_int <= 0)) return true;
            else 
                return false;                 
        }
    }
}
